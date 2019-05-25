namespace WULib.Core
{
    public static class Constants
    {
        // API stuff

        public const string ApiUrl = "https://uniterelease.nianticlabs.com/plfe/rpc";
        public const string ApiUserAgent = "Niantic App";

        public const string VersionUrl = "https://uniterelease.nianticlabs.com/plfe/version";

        // Login stuff

        public const string LoginOauthUrl = "https://sso.unite.com/sso/oauth2.0/accessToken";

        public const string GoogleAuthService = "audience:server:client_id:848232511240-7so421jotr2609rmqakceuu1luuq0ptb.apps.googleusercontent.com";
        public const string GoogleAuthApp = "com.nianticlabs.unite";
        public const string GoogleAuthClientSig = "321187995bc7cdc2b5fc91b11a96e2baa8602c62";
    }
}