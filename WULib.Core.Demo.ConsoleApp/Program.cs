using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog;
using NLog.Config;
using WULib.Core.LoginProviders;
using WULib.Core.Net;
using WULib.Core.Net.Authentication;
using WULib.Core.Net.Authentication.Data;
using WULib.Core.Util.Hash;
using LogLevel = WULib.Core.Logging.LogLevel;
using WULib.Core.Extensions;

namespace WULib.Core.Demo.ConsoleApp
{
    public class Program
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// This is just a demo application to test out the library / show a bit how it works.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Run(args).GetAwaiter().GetResult();
        }

        private static async Task Run(string[] args)
        {
            // Configure Logger
            LogManager.Configuration = new XmlLoggingConfiguration(Path.Combine(Directory.GetCurrentDirectory(), "nlog.config"));


            // Initiate console
            Logger.Info("Booting up.");
            Logger.Info("Type 'q', 'quit' or 'exit' to exit.");
            Console.Title = "WU Demo";

            Configuration.Hasher = new LegacyHasher();
            // Configuration.IgnoreHashVersion = true;

            // Settings
            var loginProviderStr = "google";
            var usernameStr = Environment.GetEnvironmentVariable("UNITE_USERNAME") ?? ""; // Your UNITE username
            var passwordStr = Environment.GetEnvironmentVariable("UNITE_PASSWORD") ?? ""; // Your UNITE password

            // Login
            ILoginProvider loginProvider;

            switch (loginProviderStr)
            {
                case "google":
                    loginProvider = new GoogleLoginProvider(usernameStr, passwordStr);
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

            // Handle quit commands.
            HandleCommands();
        }

        private static void SessionOnAccessTokenUpdated(object sender, EventArgs e)
        {
            var session = (Session)sender;

            SaveAccessToken(session.AccessToken);

            Logger.Info("Saved access token to file.");
        }

        private static void InventoryOnUpdate(object sender, EventArgs e)
        {
            Logger.Info("Inventory was updated.");
        }

        private static void MapOnUpdate(object sender, EventArgs e)
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
                        keepRunning = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Login to UniteGo and return an authenticated <see cref="Session" />.
        /// </summary>
        /// <param name="loginProvider">Provider must be Google.</param>
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
