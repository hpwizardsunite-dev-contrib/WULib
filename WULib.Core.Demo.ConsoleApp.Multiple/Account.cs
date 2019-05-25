using Newtonsoft.Json;

namespace WULib.Core.Demo.ConsoleApp.Multiple
{
    public class Account
    {
        [JsonProperty("login_provider")]
        public string LoginProvider { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
