using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog;
using NLog.Config;
using WULib.Core.Extensions;
using WULib.Core.LoginProviders;
using WULib.Core.Net;
using WULib.Core.Net.Authentication;
using WULib.Core.Net.Authentication.Data;
using WULib.Core.Util.Hash;
using LogLevel = WULib.Core.Logging.LogLevel;

namespace WULib.Core.Demo.ConsoleApp.Multiple
{
    public class Program
    {
        private static readonly CancellationTokenSource CancellationTokenSource = new CancellationTokenSource();

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// This is just a demo application to test out the library and hit all
        /// rate limits. If you want to see basic usage, please look at
        /// the project "WULib.Core.Demo.ConsoleApp".
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            // Configure Logger
            LogManager.Configuration = new XmlLoggingConfiguration(Path.Combine(Directory.GetCurrentDirectory(), "nlog.config"));

            // Initiate console
            Logger.Info("Booting up.");
            Logger.Info("Type 'q', 'quit' or 'exit' to exit.");
            Console.Title = "WU Multiple Demo";

            Configuration.Hasher = new LegacyHasher();

            // Settings
            var accounts = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText("accounts.json"));

            Run(accounts);

            // Handle quit commands.
            HandleCommands();
        }

        private static void Run(IEnumerable<Account> accounts)
        {
            foreach (var account in accounts)
            {
                Task.Run(async () =>
                {
                    try
                    {
                        // Login
                        ILoginProvider loginProvider;

                        switch (account.LoginProvider)
                        {
                            case "google":
                                loginProvider = new GoogleLoginProvider(account.Username, account.Password);
                                break;
                            default:
                                throw new ArgumentException("Login provider must be either \"google\".");
                        }

                        var locRandom = new Random();
                        var latitude = 51.507352 + locRandom.NextDouble(-0.000030, 0.000030); // Somewhere in London
                        var longitude = -0.127758 + locRandom.NextDouble(-0.000030, 0.000030);
                        var session = await GetSession(loginProvider, latitude, longitude, true);
                        session.Logger.RegisterLogOutput((level, message) =>
                        {
                            switch (level)
                            {
                                case LogLevel.Debug:
                                    Logger.Debug(message);
                                    break;
                                case LogLevel.Info:
                                    Logger.Info(message);
                                    break;
                                case LogLevel.Notice:
                                case LogLevel.Warn:
                                    Logger.Warn(message);
                                    break;
                                case LogLevel.Error:
                                    Logger.Error(message);
                                    break;
                                default:
                                    throw new ArgumentOutOfRangeException(nameof(level), level, null);
                            }
                        });
                        SaveAccessToken(session.AccessToken);

                        // Send initial requests and start HeartbeatDispatcher.
                        // This makes sure that the initial heartbeat request finishes and the "session.Map.Cells" contains stuff.
                        if (!await session.StartupAsync())
                        {
                            throw new Exception("Session couldn't start up.");
                        }
                    }
                    catch (Exception e)
                    {
                        Logger.Error($"Username '{account.Username}' had exception: {e.Message}");
                    }
                }, CancellationTokenSource.Token);
            }
        }

        private static void SessionOnAccessTokenUpdated(object sender, EventArgs eventArgs)
        {
            var session = (Session)sender;

            SaveAccessToken(session.AccessToken);

            Logger.Info("Saved access token to file.");
        }

        private static void InventoryOnUpdate(object sender, EventArgs eventArgs)
        {
            Logger.Info("Inventory was updated.");
        }

        private static void MapOnUpdate(object sender, EventArgs eventArgs)
        {
            Logger.Info("Map was updated.");
        }

        private static void SaveAccessToken(AccessToken accessToken)
        {
            var fileName = Path.Combine(Directory.GetCurrentDirectory(), "Cache", $"{accessToken.Uid}.json");

            File.WriteAllText(fileName, JsonConvert.SerializeObject(accessToken, Formatting.Indented));
        }

        private static void HandleCommands()
        {
            var keepRunning = true;

            while (keepRunning)
            {
                var command = Console.ReadLine();

                switch (command)
                {
                    case "q":
                    case "quit":
                    case "exit":
                        CancellationTokenSource.Cancel(false);
                        keepRunning = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Login to UniteGo and return an authenticated <see cref="Session" />.
        /// </summary>
        /// <param name="loginProvider">Provider ID must be 'Google'.</param>
        /// <param name="initLat">The initial latitude.</param>
        /// <param name="initLong">The initial longitude.</param>
        /// <param name="mayCache">Can we cache the <see cref="AccessToken" /> to a local file?</param>
        private static async Task<Session> GetSession(ILoginProvider loginProvider, double initLat, double initLong, bool mayCache = false)
        {
            var cacheDir = Path.Combine(Directory.GetCurrentDirectory(), "Cache");
            var fileName = Path.Combine(cacheDir, $"{loginProvider.UserId}-{loginProvider.ProviderId}.json");

            if (mayCache)
            {
                if (!Directory.Exists(cacheDir))
                    Directory.CreateDirectory(cacheDir);

                if (File.Exists(fileName))
                {
                    var accessToken = JsonConvert.DeserializeObject<AccessToken>(File.ReadAllText(fileName));

                    if (!accessToken.IsExpired)
                        return await Login.GetSession(loginProvider, accessToken, initLat, initLong);
                }
            }

            var session = await Login.GetSession(loginProvider, initLat, initLong);

            if (mayCache)
                SaveAccessToken(session.AccessToken);

            return session;
        }
    }
}
