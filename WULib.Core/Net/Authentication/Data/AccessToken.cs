﻿using System;
using Newtonsoft.Json;
using WUProtos.Networking.Envelopes;

namespace WULib.Core.Net.Authentication.Data
{
    public class AccessToken
    {
        [JsonIgnore]
        public string Uid => $"{Username}-{ProviderID}";

        [JsonProperty("username", Required = Required.Always)]
        public string Username { get; set; }

        [JsonProperty("token", Required = Required.Always)]
        public string Token { get; set; }

        [JsonProperty("expiry", Required = Required.Always)]
        public DateTime Expiry { get; set; }

        [JsonProperty("provider_id", Required = Required.Always)]
        public string ProviderID { get; set; }

        [JsonIgnore]
        public bool IsExpired => DateTime.UtcNow > Expiry;

        [JsonIgnore]
        public AuthTicket AuthTicket { get; set; }

        public void Expire()
        {
            Expiry = DateTime.MinValue;
            AuthTicket = null;
            Token = null;
        }
    }
}
