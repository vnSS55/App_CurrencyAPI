using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace APPCurrency_API.Services
{
    internal class API_supportedcodes
    {

        [JsonPropertyName("result")]
        public string result { get; set; }
        [JsonPropertyName("supported_codes")]
        public List<List<string>> supported_codes { get; set; }
    }
}
