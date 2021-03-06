﻿namespace RollbarDotNet.Payloads
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    [JsonObject(MemberSerialization.OptIn)]
    public class Client
    {
        [JsonProperty("keys")]
        private Dictionary<string, object> Keys { get; set; }

        public Client()
        {
            this.Keys = new Dictionary<string, object>();
        }
    }
}