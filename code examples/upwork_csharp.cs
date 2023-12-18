using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace OxyApi
{
    class Program
    {
        static async Task Main()
        {
            const string Username = "YOUR_USERNAME";
            const string Password = "YOUR_PASSWORD";

            var parameters = new Dictionary<string, string>()
            {
                { "source", "universal" },
                { "url", "https://www.upwork.com/hire/landing/?utm_campaign=sembrand_google_intl_marketplace_core&utm_medium=paidsearch&utm_content=150606034558&utm_term=upwork&campaignid=20227594544&matchtype=e&device=c&partnerid=cj0kcqiayewrbhddarisagp1mwsp9zzkgwn_rdxwtubn7hqlmxlog0gmb0tscajaqy6fxziirl2vbyuaak0mealw_wcb&utm_source=google&cq_cmp=20227594544&cq_plac&cq_net=g&ad_id=660518288337&gad_source=1"},
            }


            var client = new HttpClient();

            Uri baseUri = new Uri("https://realtime.oxylabs.io");
            client.BaseAddress = baseUri;

            var requestMessage = new HttpRequestMessage(HttpMethod.Post, "/v1/queries");
            requestMessage.Content = JsonContent.Create(parameters);

            var authenticationString = $"{Username}:{Password}";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.UTF8.GetBytes(authenticationString));
            requestMessage.Headers.Add("Authorization", "Basic " + base64EncodedAuthenticationString);

            var response = await client.SendAsync(requestMessage);
            var contents = await response.Content.ReadAsStringAsync();

            Console.WriteLine(contents);
        }
    }
}