using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace milo
{
    internal class HttpService
    {
        public async Task<string> OpenAIImageRequest(string prompt)
        {
            var apiUrl = "https://api.openai.com/v1/images/generations";
            var token = "<your_key>";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var payload = new
                {
                    prompt = prompt,
                    n = 1,
                    size = "512x512"
                };

                var jsonPayload = JsonConvert.SerializeObject(payload);

                var httpContent = new StringContent(jsonPayload);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync(apiUrl, httpContent);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }

        }

        public async Task<string> OpenAICompletionRequest(string prompt)
        {
            var apiUrl = "https://api.openai.com/v1/completions";
            var token = "<your_key>";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var payload = new
                {
                    model = "text-davinci-003",
                    prompt = prompt,
                    temperature = 0.3,
                    max_tokens = 2000,
                    top_p = 1.0,
                    frequency_penalty = 0.0,
                    presence_penalty = 0.0
                };

                var jsonPayload = JsonConvert.SerializeObject(payload);

                var httpContent = new StringContent(jsonPayload);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync(apiUrl, httpContent);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}
