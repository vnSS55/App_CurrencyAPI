using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace APPCurrency_API.Services
{
    internal class API_response_currency
    {

        [JsonPropertyName("result")]
        public string result { get; set; }
        [JsonPropertyName("base_code")]
        public string base_code { get; set; }
        [JsonPropertyName("target_code")]
        public string target_code { get; set; }
        [JsonPropertyName("conversion_rate")]
        public double conversion_rate { get; set; }
        [JsonPropertyName("conversion_result")]
        public double conversion_result { get; set; }
    }
}
