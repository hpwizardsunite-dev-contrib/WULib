﻿using System.Threading.Tasks;
using WULib.Core.Exceptions;
using WULib.Core.Extensions;
using WULib.Core.Net.Authentication.Data;
using WULib.Core.Util;

namespace WULib.Core.LoginProviders
{
    /// <summary>
    /// The <see cref="ILoginProvider"/> for Google.
    /// Use this if you want to authenticate to WizardsGo using a Google account.
    /// </summary>
    public class GoogleLoginProvider : ILoginProvider
    {
        private readonly string _username;
        private readonly string _password;

        public GoogleLoginProvider(string username, string password)
        {
            _username = username;
            _password = password;
        }

        /// <summary>
        /// The unique identifier of the <see cref="GoogleLoginProvider"/>.
        /// </summary>
        public string ProviderId => "google";

        /// <summary>
        /// The unique identifier of the user trying to authenticate using the <see cref="GoogleLoginProvider"/>.
        /// </summary>
        public string UserId => _username;

        /// <summary>
        /// Retrieves an <see cref="AccessToken"/> by logging into through the Google Play Services OAuth.
        /// </summary>
        /// <returns>Returns an <see cref="AccessToken"/>.</returns>
        public async Task<AccessToken> GetAccessToken(string useragent, string language)
        {
            var googleClient = new GPSOAuthClient(_username, _password);
            var masterLoginResponse = await googleClient.PerformMasterLogin();

            if (masterLoginResponse.ContainsKey("Error"))
            {
                if (masterLoginResponse["Error"].Equals("NeedsBrowser"))
                    throw new GoogleLoginException($"You have to log into an browser with the email '{_username}'.");

                throw new GoogleLoginException($"Google returned an error message: '{masterLoginResponse["Error"]}'");
            }
            if (!masterLoginResponse.ContainsKey("Token"))
            {
                throw new GoogleLoginException("Token was missing from master login response.");
            }
            var oauthResponse = await googleClient.PerformOAuth(masterLoginResponse["Token"], Constants.GoogleAuthService,
                Constants.GoogleAuthApp, Constants.GoogleAuthClientSig);
            if (!oauthResponse.ContainsKey("Auth"))
            {
                throw new GoogleLoginException("Auth token was missing from oauth login response.");
            }
            return new AccessToken
            {
                Username = _username,
                Token = oauthResponse["Auth"],
                Expiry = TimeUtil.GetDateTimeFromSeconds(int.Parse(oauthResponse["Expiry"])),
                ProviderID = ProviderId
            };
        }
    }
}
