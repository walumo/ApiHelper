using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiHelper
{
    public class ApiLoader
    {
        const string baseUrl = "https://fruityvice.com/api/fruit/"; //Set to your endpoint url
        public async Task<T> GetDataAsync<T>(string urlParams) //urlParams are your query parameters
        {
            string url = baseUrl + urlParams;

            using (HttpResponseMessage response = await API.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    var msg = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<T>(msg);
                }
                else
                {
                    Console.WriteLine("Something went wrong: (status: {0})", response.StatusCode);
                    return default(T);
                }
            }
        }
        public static void Print<T>(T json)
        {
            //Implement printing from Json in object:'data'
        }
    }
}
