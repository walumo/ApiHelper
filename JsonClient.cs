using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ApiHelper
{
    public class JsonClient
    {
        const string baseUrl = "https://fruityvice.com/api/fruit/"; //Set to your endpoint url
        public async Task<T> GetDataAsync<T>(string urlParams)
        {
            string url = baseUrl + urlParams;

            using (HttpResponseMessage response = await API.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string msg = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<T>(msg);
                }
                else
                {
                    Console.WriteLine("API query failed: (status: {0})",response.StatusCode);
                    return default(T);
                }
            }
        }
        public async Task<List<T>> GetAllDataAsync<T>(string urlParams)
        {
            string url = baseUrl + urlParams;

            using (HttpResponseMessage response = await API.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    string msg = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<List<T>>(msg);
                }
                else
                {
                    Console.WriteLine("API query failed: (status: {0})",response.StatusCode);
                    return default(List<T>);
                }
            }
        }
        public static void Print<T>(T json)
        {
            //Implement printing from Json in object:'data'
        }
    }
}
