using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using WULib.Core.Util;
using WULib.Core.Extensions;
using WULib.Core.Exceptions;
using WUProtos.Networking.Requests;
using WUProtos.Networking.Envelopes;
using WUProtos.Networking.Platform;
using static WUProtos.Networking.Requests.Messages.CreateOrUpdatePlayerMessage.Types;
using WUProtos.Networking.Responses;
using WUProtos.Networking.Requests.Messages;

namespace WULib.Core.Net
{
    public class RpcClient : IDisposable
    {
        /// <summary>
        ///     The authenticated <see cref="Session" />.
        /// </summary>
        private readonly Session _session;

        /// <summary>
        ///     The class responsible for all encryption / signing regarding <see cref="RpcClient"/>.
        /// </summary>
        private readonly RpcEncryption _rpcEncryption;

        /// <summary>
        ///     The current request count we are at.
        /// </summary>
        private ulong _requestCount;

        /// <summary>
        ///     The rpc url we have to call.
        /// </summary>
        private string _requestUrl;

        private readonly RandomIdGenerator idGenerator = new RandomIdGenerator();

        private readonly List<RequestType> _defaultRequests = new List<RequestType>
        {
            RequestType.DownloadSettings,
        };

        private readonly ConcurrentQueue<RequestEnvelope> _rpcQueue = new ConcurrentQueue<RequestEnvelope>();

        private readonly ConcurrentDictionary<RequestEnvelope, ByteString> _rpcResponses = new ConcurrentDictionary<RequestEnvelope, ByteString>();

        private readonly Semaphore _rpcQueueMutex = new Semaphore(1, 1);

        internal RpcClient(Session session)
        {
            _session = session;
            _rpcEncryption = new RpcEncryption(session);
        }

        internal DateTime LastRpcRequest { get; private set; }

        internal DateTime LastRpcMapObjectsRequest { get; private set; }

        internal GeoCoordinate LastGeoCoordinateMapObjectsRequest { get; private set; } = new GeoCoordinate();

        internal DeviceOS GetPlatform()
        {
            return _session.Device.DeviceInfo.DeviceType == "Apple" ? DeviceOS.Ios : DeviceOS.Android;
        }

        private long PositiveRandom()
        {
            long ret = _session.Random.Next() | (_session.Random.Next() << 32);
            // lrand48 ensures it's never < 0
            // So do the same
            if (ret < 0)
                ret = -ret;
            return ret;
        }

        private void IncrementRequestCount()
        {
            // Request counts on android jump more than 1 at a time according to logs
            // They are fully sequential on iOS though
            // So mimic that same behavior here.
            switch (GetPlatform())
            {
                case DeviceOS.Android:
                    _requestCount += (uint)_session.Random.Next(2, 15);
                    break;
                case DeviceOS.Ios:
                    _requestCount++;
                    break;
            }
        }

        /// <summary>
        /// Sends all requests which the (ios-)client sends on startup
        /// </summary>
        // NOTE: this is the new login process in the real app, after of 0.45 API
        internal async Task<bool> StartupAsync()
        {
            // Empty request. To change the _requestUrl variable.
            await SendRemoteProcedurePlatformCallAsync();

            CreateOrUpdatePlayerResponse playerResponse;
            int loop = 0;

            do
            {
                var response = await SendRemoteProcedureCallAsync(new Request
                {
                    RequestType = RequestType.CreateOrUpdatePlayer,
                    RequestMessage = new CreateOrUpdatePlayerMessage
                    {
                        DeviceInfo = new ClientDeviceInfo
                        {
                            //ClientVersion = "",
                            //DeviceOs = DeviceOS.Ios,
                            //DeviceType = "",
                            //OsVersion = ""
                        },

                        Locale = _session.Player.PlayerLocale,
                    }.ToByteString()
                });

                if (response == null)
                {
                    _session.Logger.Warn("Wizards Go service as maybe issues, Please try later");
                    //return false;
                }

                playerResponse = CreateOrUpdatePlayerResponse.Parser.ParseFrom(response);

                if (!playerResponse.Success)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(1000));
                }
                loop++;
            } while (!playerResponse.Success && loop < 5);

            return true;
        }

        /// <summary>
        ///     It is not recommended to call this. Map objects will update automatically and fire the map update event.
        /// </summary>
        public async Task RefreshMapObjectsAsync()
        {
            var cellIds = MapUtil.GetCellIdsForLatLong(_session.Player.Coordinate.Latitude, _session.Player.Coordinate.Longitude);
            var sinceTimeMs = cellIds.Select(x => (long)0).ToArray();

            var response = await SendRemoteProcedureCallAsync(new Request
            {
            });

            if (response != null)
            {
            }
            else if (_session.State != SessionState.Paused)
            {
            }

            //_session.Map.Cells = new RepeatedField<MapCell>();
            throw new SessionStateException("We received 0 map cells or status is empty.");
        }
        /// <summary>
        ///     Gets the next request id for the <see cref="RequestEnvelope" />.
        /// </summary>
        /// <returns></returns>
        private ulong GetNextRequestId()
        {
            //Change to random requestId https://github.com/pogodevorg/pgoapi/pull/217

            return idGenerator.Next();
        }

        /// <summary>
        ///     Gets a collection of requests that should be sent in every request to UniteGo along with your own
        ///     <see cref="Request" />.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Request> GetDefaultRequests()
        {
            var request = new List<Request>
            {
            };

            if (string.IsNullOrEmpty(_session.GlobalSettingsHash))
            {
                request.Add(new Request
                {
                    RequestType = RequestType.DownloadSettings
                });
            }
            else
            {
            }
            return request;
        }

        /// <summary>
        ///     Gets a <see cref="RequestEnvelope" /> with authentication data.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="addDefaultRequests"></param>
        /// <param name = "nobuddy"></param>
        /// <param name = "noinbox"></param>
        /// <returns></returns>
        public async Task<RequestEnvelope> GetRequestEnvelopeAsync(IEnumerable<Request> request, bool addDefaultRequests)
        {
            var requestEnvelope = new RequestEnvelope
            {
                StatusCode = 2,
                RequestId = GetNextRequestId(),
                Latitude = _session.Player.Coordinate.Latitude,
                Longitude = _session.Player.Coordinate.Longitude
            };

            if (request != null && request.FirstOrDefault().RequestType != RequestType.MethodUnset)
            {
                requestEnvelope.Requests.AddRange(request);

                if (addDefaultRequests)
                    requestEnvelope.Requests.AddRange(GetDefaultRequests());
            }

            if (_session.AccessToken.AuthTicket != null && _session.AccessToken.AuthTicket.ExpireTimestampMs < ((ulong)TimeUtil.GetCurrentTimestampInMilliseconds() - (60000 * 2)))
            {
                // Check for almost expired AuthTicket (2 minute buffer). Null out the AuthTicket so that AccessToken is used.
                _session.AccessToken.AuthTicket = null;
            }

            if (_session.AccessToken.AuthTicket == null || _session.AccessToken.IsExpired || string.IsNullOrEmpty(_session.AccessToken.Token))
            {
                if (_session.AccessToken.IsExpired || string.IsNullOrEmpty(_session.AccessToken.Token))
                {
                    await _session.GetValidAccessToken(true);
                }

                requestEnvelope.AuthInfo = new RequestEnvelope.Types.AuthInfo
                {
                    Provider = _session.AccessToken.ProviderID,
                    Token = new RequestEnvelope.Types.AuthInfo.Types.JWT
                    {
                        Contents = _session.AccessToken.Token,
                        Unknown2 = 59
                    }
                };
            }
            else
            {
                requestEnvelope.AuthTicket = _session.AccessToken.AuthTicket;
            }

            return requestEnvelope;
        }

        public async Task<ByteString> SendRemoteProcedureCallAsync(RequestType requestType)
        {
            return await SendRemoteProcedureCallAsync(new Request
            {
                RequestType = requestType
            });
        }

        public async Task<ByteString> SendRemoteProcedurePlatformCallAsync(PlatformRequestType type = PlatformRequestType.UnknownPlatformClientAction)
        {
            var requestEnvelope = await GetRequestEnvelopeAsync(null, false);

            switch (type)
            {
                case PlatformRequestType.AddLoginAction:
                    break;
                case PlatformRequestType.AddNewPoi:
                    break;
                case PlatformRequestType.GetSignedUrlForPhotoUpload:
                    break;
                case PlatformRequestType.ListLoginAction:
                    break;
                case PlatformRequestType.RedeemPasscode:
                    break;
                case PlatformRequestType.RegisterPushNotification:
                    break;
                case PlatformRequestType.RemoveLoginAction:
                    break;
                case PlatformRequestType.UnregisterPushNotification:
                    break;
                case PlatformRequestType.UpdateNotificationStatus:
                    break;
            }

            return await SendRemoteProcedureCall(requestEnvelope);
        }

        public async Task<ByteString> SendRemoteProcedureCallAsync(Request request, bool addDefaultRequests = true)
        {
            return await SendRemoteProcedureCall(await GetRequestEnvelopeAsync(new[] { request }, addDefaultRequests));
        }

        public async Task<ByteString> SendRemoteProcedureCallAsync(Request[] request, bool addDefaultRequests = false, bool nobuddy = false, bool noinbox = false)
        {
            return await SendRemoteProcedureCall(await GetRequestEnvelopeAsync(request, addDefaultRequests));
        }

        private async Task<ByteString> SendRemoteProcedureCall(RequestEnvelope requestEnvelope)
        {
            return await Task.Run(async () =>
            {
                _rpcQueue.Enqueue(requestEnvelope);

                try
                {
                    if (!Configuration.IgnoreRPCSemafore)
                        _rpcQueueMutex.WaitOne();

                    RequestEnvelope processRequestEnvelope;

                    while (_rpcQueue.TryDequeue(out processRequestEnvelope))
                    {
                        if (Configuration.ThrottleDifference > 0)
                        {
                            //var diff = Math.Max(0, DateTime.Now.Millisecond - LastRpcRequest.Millisecond);
                            var diff = (int)Math.Min((DateTime.UtcNow - LastRpcRequest.ToUniversalTime()).TotalMilliseconds, Configuration.ThrottleDifference);
                            if (diff < Configuration.ThrottleDifference)
                            {
                                var delay = Configuration.ThrottleDifference - diff + (int)(_session.Random.NextDouble() * 0);

                                await Task.Delay(delay);
                            }
                        }

                        _rpcResponses.GetOrAdd(processRequestEnvelope, await PerformRemoteProcedureCallAsync(processRequestEnvelope));
                    }

                    ByteString ret;
                    _rpcResponses.TryRemove(requestEnvelope, out ret);

                    return ret;

                }
                catch (ArgumentOutOfRangeException)
                {
                    return null;
                }
                finally
                {
                    if (!Configuration.IgnoreRPCSemafore)
                        _rpcQueueMutex.Release();
                }
            });
        }

        private async Task<ByteString> PerformRemoteProcedureCallAsync(RequestEnvelope requestEnvelope)
        {
            if (requestEnvelope == null)
            {
                return null;
            }

            try
            {
                switch (_session.State)
                {
                    case SessionState.Stopped:
                        _session.Logger.Error("We tried to send a request while the session was stopped.");
                        return null;

                    case SessionState.Banned:
                        _session.Logger.Error("We tried to send a request while the session was temporal banned.");
                        return null;

                    case SessionState.Paused:
                        break;
                }

                using (var requestData = new ByteArrayContent(requestEnvelope.ToByteArray()))
                {
                    if (requestData == null)
                    {
                        await Task.Delay(10000); //wait 10 secs on grave bug
                        throw new SessionStateException($"RequestData is null");
                    }

                    using (var response = await _session.HttpClient.PostAsync(_requestUrl ?? Constants.ApiUrl, requestData))
                    {
                        if (response == null)
                        {
                            await Task.Delay(10000); //wait 10 secs on grave bug
                            throw new SessionStateException($"RequestData response is null");
                        }

                        _session.Logger.Debug("Sending RPC Request: '" + string.Join(", ", requestEnvelope.Requests.Select(x => x.RequestType)) + "'");
                        _session.Logger.Debug("=> Platform Request: '" + string.Join(", ", requestEnvelope.PlatformRequests.Select(x => x.Type)) + "'");

                        if (!response.IsSuccessStatusCode)
                        {
                            _session.Logger.Warn(await response.Content.ReadAsStringAsync());
                            await Task.Delay(10000); //wait 10 secs on grave bug
                            throw new Exception("Received a non-success HTTP status code from the RPC server, see the console for the response.");
                        }

                        var responseBytes = await response.Content.ReadAsByteArrayAsync();
                        var responseEnvelope = ResponseEnvelope.Parser.ParseFrom(responseBytes);

                        switch (responseEnvelope.StatusCode)
                        {
                            // Valid response.
                            case ResponseEnvelope.Types.StatusCode.Ok:
                                // Success!?                                
                                break;

                            // Valid response and new rpc url.
                            case ResponseEnvelope.Types.StatusCode.OkRpcUrlInResponse:
                                if (Regex.IsMatch(responseEnvelope.ApiUrl, "pgorelease\\.nianticlabs\\.com\\/plfe\\/\\d+"))
                                {
                                    _requestUrl = $"https://{responseEnvelope.ApiUrl}/rpc";
                                }
                                else
                                {
                                    await Task.Delay(10000); //wait 10 secs on grave bug
                                    throw new Exception($"Received an incorrect API url: '{responseEnvelope.ApiUrl}', status code was: '{responseEnvelope.StatusCode}'.");
                                }
                                break;

                            // A new rpc endpoint is available.
                            case ResponseEnvelope.Types.StatusCode.Redirect:
                                if (Regex.IsMatch(responseEnvelope.ApiUrl, "pgorelease\\.nianticlabs\\.com\\/plfe\\/\\d+"))
                                {
                                    _requestUrl = $"https://{responseEnvelope.ApiUrl}/rpc";
                                    return await PerformRemoteProcedureCallAsync(requestEnvelope);
                                }
                                await Task.Delay(10000); //wait 10 secs on grave bug
                                throw new Exception($"Received an incorrect API url: '{responseEnvelope.ApiUrl}', status code was: '{responseEnvelope.StatusCode}'.");

                            // The login token is invalid.
                            // TODO: Make cleaner to reduce duplicate code with the GetRequestEnvelopeAsync method.
                            case ResponseEnvelope.Types.StatusCode.InvalidAuthToken:
                                _session.Logger.Debug("Received StatusCode 102, reauthenticating.");

                                await _session.GetValidAccessToken(true);

                                // Apply new token.
                                requestEnvelope.AuthInfo = new RequestEnvelope.Types.AuthInfo
                                {
                                    Provider = _session.AccessToken.ProviderID,
                                    Token = new RequestEnvelope.Types.AuthInfo.Types.JWT
                                    {
                                        Contents = _session.AccessToken.Token,
                                        Unknown2 = 59
                                    }
                                };

                                // Clear all PlatformRequests.
                                requestEnvelope.PlatformRequests.Clear();

                                // Re-send envelope.
                                ByteString resend = null;
                                resend = await PerformRemoteProcedureCallAsync(requestEnvelope);

                                if (resend == null)
                                    throw new SessionStateException("INVALID AUTH TOKEN");
                                else
                                    return resend;
                                throw new SessionStateException("INVALID AUTH TOKEN");
                            case ResponseEnvelope.Types.StatusCode.BadRequest:
                                await Task.Delay(10000); //wait 10 secs on grave bug
                                throw new APIBadRequestException("BAD REQUEST");
                            case ResponseEnvelope.Types.StatusCode.SessionInvalidated:
                                await Task.Delay(10000); //wait 10 secs on grave bug
                                throw new SessionInvalidatedException("SESSION INVALIDATED");
                            case ResponseEnvelope.Types.StatusCode.Unknown:
                                await Task.Delay(10000); //wait 10 secs on grave bug
                                throw new SessionUnknowException("UNKNOWN");
                            case ResponseEnvelope.Types.StatusCode.InvalidPlatformRequest:
                                await Task.Delay(10000); //wait 10 secs on grave bug
                                throw new InvalidPlatformException("INVALID PLATFORM REQUEST");
                            case ResponseEnvelope.Types.StatusCode.InvalidRequest:
                                await Task.Delay(10000); //wait 10 secs on grave bug
                                throw new InvalidPlatformException("INVALID REQUEST");
                            default:
                                await Task.Delay(10000); //wait 10 secs on grave bug
                                throw new Exception($"Unknown status code: {responseEnvelope.StatusCode}");
                        }

                        LastRpcRequest = DateTime.UtcNow;

                        if (requestEnvelope.Requests[0].RequestType == RequestType.CreateOrUpdatePlayer)
                        {
                            LastRpcMapObjectsRequest = LastRpcRequest;
                            LastGeoCoordinateMapObjectsRequest = _session.Player.Coordinate;
                        }

                        if (responseEnvelope.AuthTicket != null)
                        {
                            _session.AccessToken.AuthTicket = responseEnvelope.AuthTicket;
                            _session.Logger.Debug("Received a new AuthTicket from Wizards!");
                        }

                        return HandleResponseEnvelope(requestEnvelope, responseEnvelope);
                    }
                }
            }
            catch (SessionInvalidatedException ex)
            {
                throw ex;
            }
            catch (InvalidPlatformException ex)
            {
                throw ex;
            }
            catch (APIBadRequestException ex)
            {
                throw new APIBadRequestException(ex.Message);
            }
            catch (Exception ex)
            {
                throw new SessionStateException($"Your account may be temporary banned! please try from the official client." + ex);
            }
        }

        /// <summary>
        /// Responsible for handling the received <see cref="ResponseEnvelope" />.
        /// </summary>
        /// <param name="requestEnvelope">The <see cref="RequestEnvelope"/> prepared by <see cref="PerformRemoteProcedureCallAsync"/>.</param>
        /// <param name="responseEnvelope">The <see cref="ResponseEnvelope"/> received from <see cref="SendRemoteProcedureCallAsync(POGOProtos.Networking.Requests.Request)" />.</param>
        /// <returns>Returns the <see cref="ByteString" />response of the <see cref="Request"/>.</returns>
        private ByteString HandleResponseEnvelope(RequestEnvelope requestEnvelope, ResponseEnvelope responseEnvelope)
        {
            //if (responseEnvelope.Returns.Count == 0)
            //{
            //    throw new Exception("There were 0 responses.");
            //}

            // Take requested response and remove from returns.
            var requestResponse = responseEnvelope.Returns[0];

            // Handle the default responses.
            HandleDefaultResponses(requestEnvelope, responseEnvelope.Returns);

            // Handle responses which affect the inventory
            HandleInventoryResponses(requestEnvelope.Requests[0], requestResponse);

            return requestResponse;
        }

        private void HandleInventoryResponses(Request request, ByteString requestResponse)
        {
            switch (request.RequestType)
            {

                case RequestType.CreateOrUpdatePlayer:
                    var releaseResponse = CreateOrUpdatePlayerResponse.Parser.ParseFrom(requestResponse);
                    if (releaseResponse.Success)
                    {
                        var releaseMessage = CreateOrUpdatePlayerResponse.Parser.ParseFrom(request.RequestMessage);
                    }
                    break;

            }
        }

        /// <summary>
        ///     Handles the default heartbeat responses.
        /// </summary>
        /// <param name="requestEnvelope"></param>
        /// <param name="returns">The payload of the <see cref="ResponseEnvelope" />.</param>
        private void HandleDefaultResponses(RequestEnvelope requestEnvelope, IList<ByteString> returns)
        {
            var responseIndexes = new Dictionary<int, RequestType>();

            for (var i = 0; i < requestEnvelope.Requests.Count; i++)
            {
                var request = requestEnvelope.Requests[i];
                if (_defaultRequests.Contains(request.RequestType))
                    responseIndexes.Add(i, request.RequestType);
            }

            foreach (var responseIndex in responseIndexes)
            {
                var bytes = returns[responseIndex.Key];

                switch (responseIndex.Value)
                {
                    case RequestType.DownloadSettings: // Download_Settings
                        DownloadSettingsResponse downloadSettings = null;
                        try
                        {
                            downloadSettings = DownloadSettingsResponse.Parser.ParseFrom(bytes);
                        }
                        catch (Exception)
                        {
                            downloadSettings = new DownloadSettingsResponse() { Error = "Could not parse downloadSettings" };
                            continue;
                        }
                        if (string.IsNullOrEmpty(downloadSettings.Error))
                        {
                            if (downloadSettings.Values == null)
                            {
                                continue;
                            }
                            if (_session.GlobalSettings == null || _session.GlobalSettingsHash != downloadSettings.Sha1)
                            {
                                _session.GlobalSettingsHash = downloadSettings.Sha1;
                                _session.GlobalSettings = downloadSettings.Values;
                            }
                            else
                            {
                                _session.GlobalSettings = downloadSettings.Values;
                            }
                        }
                        else
                        {
                            _session.Logger.Debug($"DownloadSettingsResponse.Error: '{downloadSettings.Error}'");
                            continue;
                        }
                        break;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        internal void Dispose(bool disposing)
        {
            if (!disposing) return;
            _rpcQueueMutex?.Dispose();
        }

        private void HandleEventHandler(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs errorArgs)
        {
            var currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }
    }
}
