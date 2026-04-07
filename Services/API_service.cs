using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text;
using App_CurrencyAPI;
using Microsoft.Extensions.Configuration;

namespace APPCurrency_API.Services
{
    internal class API_services
    {

        // a HTTP client that doesn't innitialize again
        private readonly HttpClient client = new HttpClient();

        // base url of the API
        private const string base_url = "https://v6.exchangerate-api.com/v6";
        
        // api key configuration, secret
        private readonly IConfiguration config;
        private readonly string api_keyy;
        
        
        // get the api_key value from user-secrets, gets hidden in github
        public API_services()
        {
            config = new ConfigurationBuilder()
                .AddUserSecrets<API_services>()
                .Build();

            api_keyy = config["ApiSetting:ApiKey"];
        }
        

        public async Task<API_response_currency> Currency_Conversion(string base_currency, string target_currency, double amount)
        {
            string url = $"{base_url}/{api_keyy}/pair/{base_currency}/{target_currency}/{amount}"; // pre made HTTPS request

            API_response_currency response = await client.GetFromJsonAsync<API_response_currency>(url);

            return response;
        }
        // Method to give a list of the 
        public async Task<API_supportedcodes> Currency_Data()
        {
            string url = $"{base_url}/{api_keyy}/codes"; // pre made HTTPS request

            API_supportedcodes response = await client.GetFromJsonAsync<API_supportedcodes>(url);

            return response;
        }
    }
}

