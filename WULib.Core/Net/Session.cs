using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WULib.Core.Exceptions;
using WULib.Core.Logging;
using WULib.Core.LoginProviders;
using WULib.Core.Net.Authentication.Data;
using WULib.Core.Wizards;
using WULib.Core.Util.Device;
using WULib.Core.Extensions;
using WUProtos.Networking.Requests.Messages;
using Google.Protobuf;

namespace WULib.Core.Net
{
    /// <summary>
    /// This is an authenticated <see cref="Session" /> with UniteGo that handles everything between the developer and UniteGo.
    /// </summary>
    public class Session : IDisposable
    {
        private SessionState _state;

        /// <summary>
        /// This is the <see cref="HeartbeatDispatcher" /> which is responsible for retrieving events and updating gps location.
        /// </summary>
        private readonly HeartbeatDispatcher Heartbeat;

        /// <summary>
        /// This is the <see cref="RpcClient" /> which is responsible for all communication between us and UniteGo.
        /// Only use this if you know what you are doing.
        /// </summary>
        public readonly RpcClient RpcClient;

        public readonly Logger Logger;

        private static readonly string[] ValidLoginProviders = { "google" };

        /// <summary>
        /// Stores data like assets and item templates. Defaults to an in-memory cache, but can be implemented as writing to disk by the platform
        /// </summary>
        // public IDataCache DataCache { get; set; } = new MemoryDataCache();
        // public Templates Templates { get; private set; }

        internal Session(ILoginProvider loginProvider, AccessToken accessToken, GeoCoordinate geoCoordinate, DeviceWrapper deviceWrapper, CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale playerLocale)
        {
            if (!ValidLoginProviders.Contains(loginProvider.ProviderId))
            {
                throw new ArgumentException("LoginProvider ID must be one of the following: " + string.Join(", ", ValidLoginProviders));
            }
            Logger = new Logger();

            State = SessionState.Stopped;

            Device = deviceWrapper;

            var handler = new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                UseProxy = Device.Proxy != null,
                Proxy = Device.Proxy
            };

            HttpClient = new HttpClient(handler);
            HttpClient.DefaultRequestHeaders.UserAgent.TryParseAdd(Constants.ApiUserAgent);
            HttpClient.DefaultRequestHeaders.ExpectContinue = false;

            AccessToken = accessToken;

            if (IsValidAccessToken())
            {
                //OnAccessTokenUpdated();
            }
            else
                throw new SessionStateException("INVALID AUTH TOKEN");

            LoginProvider = loginProvider;
            Player = new Player(this, geoCoordinate, playerLocale);
            Map = new Map(this);
            Templates = new Templates(this);
            RpcClient = new RpcClient(this);

            if (Configuration.EnableHeartbeat)
                Heartbeat = new HeartbeatDispatcher(this);
        }

        /// <summary>
        /// Gets the <see cref="SessionState"/> of the <see cref="Session"/>.
        /// </summary>
        public SessionState State
        {
            get { return _state; }
            private set
            {
                _state = value;

                Logger.Debug($"Session state was set to {_state}.");
            }
        }

        internal void SetTemporalBan()
        {
            State = SessionState.Banned;
            //OnTemporalBanReceived();
            if (State != SessionState.Stopped)
                Shutdown();
        }

        /// <summary>
        /// Gets the <see cref="Random"/> of the <see cref="Session"/>.
        /// </summary>
        internal Random Random { get; private set; } = new Random();

        /// <summary>
        /// Gets the <see cref="DeviceWrapper"/> used by <see cref="RpcEncryption"/>.
        /// </summary>
        public DeviceWrapper Device { get; private set; }

        /// <summary>
        /// Gets the <see cref="HttpClient"/> of the <see cref="Session"/>.
        /// </summary>
        internal HttpClient HttpClient { get; }

        /// <summary>
        /// Gets the <see cref="ILoginProvider"/> used to obtain an <see cref="AccessToken"/>.
        /// </summary>
        private ILoginProvider LoginProvider { get; }

        /// <summary>
        ///  Gets the <see cref="AccessToken"/> of the <see cref="Session" />.
        /// </summary>
        public AccessToken AccessToken { get; private set; }

        /// <summary>
        /// Gets the <see cref="Player"/> of the <see cref="Session" />.
        /// </summary>
        public Player Player { get; private set; }

        /// <summary>
        /// Gets the <see cref="Map"/> of the <see cref="Session" />.
        /// </summary>
        public Map Map { get; }

        /// <summary>
        /// Gets the <see cref="GlobalSettings"/> of the <see cref="Session" />.
        /// </summary>
        public ByteString GlobalSettings { get; internal set; }

        /// <summary>
        /// Gets the hash of the <see cref="GlobalSettings"/>.
        /// </summary>
        internal string GlobalSettingsHash { get; set; } = string.Empty;

        private Semaphore ReauthenticateMutex { get; } = new Semaphore(1, 1);

        public Templates Templates { get; private set; }

        public async Task<bool> StartupAsync()
        {
            if (State != SessionState.Stopped)
            {
                throw new SessionStateException("The session has already been started.");
            }

            if (!Configuration.IgnoreHashVersion)
            {
                await CheckHasherVersion();
            }

            State = SessionState.Started;

            if (!await RpcClient.StartupAsync())
            {
                return false;
            }

            if (Configuration.EnableHeartbeat)
                await Heartbeat.StartDispatcherAsync();

            return true;
        }

        public void Pause()
        {
            if (State != SessionState.Started &&
                State != SessionState.Resumed && State != SessionState.Banned)
            {
                throw new SessionStateException("The session is not running.");
            }

            State = SessionState.Paused;

            if (Configuration.EnableHeartbeat)
                Heartbeat.StopDispatcher();
        }

        public async Task ResumeAsync()
        {
            if (State != SessionState.Paused)
            {
                throw new SessionStateException("The session is not paused.");
            }

            State = SessionState.Resumed;

            if (Configuration.EnableHeartbeat)
                await Heartbeat.StartDispatcherAsync();
        }

        public void Shutdown()
        {
            if (State == SessionState.Stopped)
            {
                throw new SessionStateException("The session has already been stopped.");
            }

            if (State != SessionState.Banned)
                State = SessionState.Stopped;

            if (Configuration.EnableHeartbeat)
                Heartbeat.StopDispatcher();
        }

        /// <summary>
        /// Checks if the current minimal version of WizardsGo matches the version of the <see cref="Configuration.Hasher"/>.
        /// Throws an exception if there is a version mismatch.
        /// </summary>
        /// <returns></returns>
        public async Task CheckHasherVersion()
        {
            //remove warn
            await Task.Delay(0);
        }

        /// <summary>
        /// Ensures the <see cref="Session" /> check if is valid access token.
        /// </summary>
        private bool IsValidAccessToken()
        {
            if (AccessToken == null || string.IsNullOrEmpty(AccessToken.Token) || AccessToken.IsExpired)
                return false;

            return true;
        }

        /// <summary>
        /// Ensures the <see cref="Session" /> gets valid access token.
        /// </summary>
        internal async Task<AccessToken> GetValidAccessToken(bool forceRefresh = false)
        {
            try
            {
                ReauthenticateMutex.WaitOne();

                if (forceRefresh)
                {
                    AccessToken.Expire();
                }

                if (IsValidAccessToken())
                    return AccessToken;

                await Reauthenticate();
                return AccessToken;
            }
            finally
            {
                ReauthenticateMutex.Release();
            }
        }

        /// <summary>
        /// Ensures the <see cref="Session" /> gets reauthenticated, no matter how long it takes.
        /// </summary>
        private async Task Reauthenticate()
        {
            var tries = 0;

            while (!IsValidAccessToken())
            {
                try
                {
                    string language = this.Player.PlayerLocale.Language + "-" + this.Player.PlayerLocale.Country;
                    AccessToken = await LoginProvider.GetAccessToken(this.Device.UserAgent, language);
                        Logger.Debug("Authenticated through Google.");
                }
                catch (GoogleLoginException ex)
                {
                    if (ex.Message.Contains("You have to log into a browser")) throw new GoogleLoginException(ex.Message);
                    throw new GoogleLoginException($"Reauthenticate exception was catched: {ex}");
                }
                catch (Exception ex)
                {
                    throw new Exception($"Reauthenticate exception was catched: {ex}");
                }
                finally
                {
                    if (tries == 5)
                    {
                        throw new SessionStateException("Error refreshing access token.");
                    }

                    ++tries;

                    if (!IsValidAccessToken())
                    {
                        var sleepSeconds = Math.Min(60, tries * 5);
                        Logger.Error($"Reauthentication failed, trying again in {sleepSeconds} seconds.");
                        await Task.Delay(TimeSpan.FromMilliseconds(sleepSeconds * 1000));
                    }
                    else
                    {
                        //OnAccessTokenUpdated();
                    }
                }
            }

            if (!IsValidAccessToken())
            {
                throw new SessionStateException("Error refreshing access token.");
            }
        }

        #region Events
        /// <summary>
        /// may be you can resume WULib.Core by using <see cref="ResumeAsync"/>.
        /// </summary>
        //public event EventHandler<EventArgs> events;
        #endregion

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;

            ReauthenticateMutex?.Dispose();
            RpcClient?.Dispose();
            HttpClient?.Dispose();
        }
    }
}
