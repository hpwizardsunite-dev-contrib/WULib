using System.Threading.Tasks;
using WULib.Core.Exceptions;
using WULib.Core.Extensions;
using WULib.Core.LoginProviders;
using WULib.Core.Net.Authentication.Data;
using WULib.Core.Util.Device;
using WUProtos.Networking.Requests.Messages;

namespace WULib.Core.Net.Authentication
{
    /// <summary>
    /// Responsible for Authenticating and Re-authenticating the user.
    /// </summary>
    public static class Login
    {
        /// <summary>
        /// Login with a stored <see cref="AccessToken" />.
        /// </summary>
        /// <param name="loginProvider"></param>
        /// <param name="accessToken"></param>
        /// <param name="initialLatitude">The initial latitude you will spawn at after logging into UniteGo.</param>
        /// <param name="initialLongitude">The initial longitude you will spawn at after logging into UniteGo.</param>
        /// <param name="deviceWrapper">The <see cref="DeviceWrapper"/> used by the <see cref="Session"/>, keep null if you want a randomly generated <see cref="DeviceWrapper"/>.</param>
        /// <param name = "playerLocale"></param>
        /// <returns></returns>
        public static async Task<Session> GetSession(ILoginProvider loginProvider, AccessToken accessToken, double initialLatitude, double initialLongitude, DeviceWrapper deviceWrapper = null, CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale playerLocale = null)
        {
            DeviceWrapper device = deviceWrapper ?? DeviceInfoUtil.GetRandomDevice();
            CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale locale = playerLocale ?? new CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale { Country = "US", Language = "en", Timezone = "America/New_York" };
            string language = locale.Language + "-" + locale.Country;

            if (accessToken == null || string.IsNullOrEmpty(accessToken.Token) || accessToken.IsExpired)
            {
                accessToken = await loginProvider.GetAccessToken(device.UserAgent, language);
                if (accessToken == null || string.IsNullOrEmpty(accessToken.Token) || accessToken.IsExpired)
                    throw new SessionStateException($"{nameof(accessToken)} is expired.");
            }

            var session = new Session(loginProvider, accessToken, new GeoCoordinate(initialLatitude, initialLongitude), device, locale);
            session.Logger.Debug("Authenticated from cache.");
            return session;
        }

        /// <summary>
        /// Login through OAuth with Google.
        /// </summary>
        /// <param name="loginProvider">The OAuth provider you use to authenticate.</param>
        /// <param name="initialLatitude">The initial latitude you will spawn at after logging into UniteGo.</param>
        /// <param name="initialLongitude">The initial longitude you will spawn at after logging into UniteGo.</param>
        /// <param name="deviceWrapper">The <see cref="DeviceWrapper"/> used by the <see cref="Session"/>, keep null if you want a randomly generated <see cref="DeviceWrapper"/>.</param>
        /// <param name = "playerLocale"></param>
        /// <returns></returns>
        public static async Task<Session> GetSession(ILoginProvider loginProvider, double initialLatitude, double initialLongitude, DeviceWrapper deviceWrapper = null, CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale playerLocale = null)
        {
            DeviceWrapper device = deviceWrapper ?? DeviceInfoUtil.GetRandomDevice();
            CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale locale = playerLocale ?? new CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale { Country = "US", Language = "en", Timezone = "America/New_York" };
            string language = locale.Language + "-" + locale.Country;
            var session = new Session(loginProvider, await loginProvider.GetAccessToken(device.UserAgent, language), new GeoCoordinate(initialLatitude, initialLongitude), device, locale);
            session.Logger.Debug("Authenticated through Google.");
            return session;
        }

        /// <summary>
        /// Login with a stored <see cref="AccessToken" />.
        /// </summary>
        /// <param name="loginProvider">The OAuth provider you use to authenticate.</param>
        /// <param name="accessToken">The <see cref="AccessToken"/> you want to re-use.</param>
        /// <param name="coordinate">The initial coordinate you will spawn at after logging into UniteGo.</param>
        /// <param name="deviceWrapper">The <see cref="DeviceWrapper"/> used by the <see cref="Session"/>, keep null if you want a randomly generated <see cref="DeviceWrapper"/>.</param>
        /// <param name = "playerLocale"></param>
        /// <returns></returns>
        public static async Task<Session> GetSession(ILoginProvider loginProvider, AccessToken accessToken, GeoCoordinate coordinate, DeviceWrapper deviceWrapper = null, CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale playerLocale = null)
        {
            DeviceWrapper device = deviceWrapper ?? DeviceInfoUtil.GetRandomDevice();
            CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale locale = playerLocale ?? new CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale { Country = "US", Language = "en", Timezone = "America/New_York" };
            string language = locale.Language + "-" + locale.Country;

            if (accessToken == null || string.IsNullOrEmpty(accessToken.Token) || accessToken.IsExpired)
            {
                accessToken = await loginProvider.GetAccessToken(device.UserAgent, language);
                if (accessToken == null || string.IsNullOrEmpty(accessToken.Token) || accessToken.IsExpired)
                    throw new SessionStateException($"{nameof(accessToken)} is expired.");
            }

            var session = new Session(loginProvider, accessToken, coordinate, device, locale);
            session.Logger.Debug("Authenticated from cache.");
            session.Logger.Debug("Authenticated through Google.");
            return session;
        }

        /// <summary>
        /// Login through OAuth with Google.
        /// </summary>
        /// <param name="loginProvider">The OAuth provider you use to authenticate.</param>
        /// <param name="coordinate">The initial coordinate you will spawn at after logging into UniteGo.</param>
        /// <param name="deviceWrapper">The <see cref="DeviceWrapper"/> used by the <see cref="Session"/>, keep null if you want a randomly generated <see cref="DeviceWrapper"/>.</param>
        /// <param name = "playerLocale"></param>
        /// <returns></returns>
        public static async Task<Session> GetSession(ILoginProvider loginProvider, GeoCoordinate coordinate, DeviceWrapper deviceWrapper = null, CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale playerLocale = null)
        {
            DeviceWrapper device = deviceWrapper ?? DeviceInfoUtil.GetRandomDevice();
            CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale locale = playerLocale ?? new CreateOrUpdatePlayerMessage.Types.ClientPlayerLocale { Country = "US", Language = "en", Timezone = "America/New_York" };
            string language = locale.Language + "-" + locale.Country;
            var session = new Session(loginProvider, await loginProvider.GetAccessToken(device.UserAgent, language), coordinate, device, locale);
            session.Logger.Debug("Authenticated through Google.");
            return session;
        }
    }
}
