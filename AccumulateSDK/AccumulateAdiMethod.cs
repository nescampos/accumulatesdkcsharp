using AccumulateSDK.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AccumulateSDK
{
    public class AccumulateAdiMethod
    {
        public AccumulateAdiMethod()
        {

        }

        /// <summary>Method <c>Adi</c> for executing the "adi" method in Accumulate API</summary>
        /// <param name="id">ID for this request</param>
        /// <param name="url">URL for this request</param>
        /// <returns>Responses.AdiResponse instance with all data or error from API</returns>
        public async Task<AdiResponse> Adi(int id, string url)
        {
            AdiResponse adiResponse = new AdiResponse();
            ValidateClient();
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            var contentJson = JsonConvert.SerializeObject(new { jsonrpc = "2.0", id = id, method = "adi", @params = new { url = url } });

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(AccumulateClient.URL, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    adiResponse = JsonConvert.DeserializeObject<AdiResponse>(apiResponse);
                }
            }
            return adiResponse;
        }

        private void ValidateClient()
        {
            if (AccumulateClient.URL == null)
            {
                throw new Exception("The AccumulateClient must be initialized.");
            }
        }
    }
}
