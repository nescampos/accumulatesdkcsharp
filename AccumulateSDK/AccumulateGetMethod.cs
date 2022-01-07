using AccumulateSDK.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace AccumulateSDK
{
    public class AccumulateGetMethod
    {

        public AccumulateGetMethod()
        {

        }

        /// <summary>Method <c>Get</c> for executing the "get" method in Accumulate API</summary>
        /// <param name="id">ID for this request</param>
        /// <param name="url">URL for this request</param>
        /// <returns>Responses.GetResponse instance with all data or error from API</returns>
        public async Task<GetResponse> Get(int id, string url)
        {
            GetResponse getResponse = new GetResponse();
            ValidateClient();
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            var contentJson = JsonConvert.SerializeObject(new { jsonrpc = "2.0", id = id, method = "get", @params = new { url = url } });

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(AccumulateClient.URL, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    getResponse = JsonConvert.DeserializeObject<GetResponse>(apiResponse);
                }
            }
            return getResponse;
        }

        private void ValidateClient()
        {
            if(AccumulateClient.URL == null)
            {
                throw new Exception("The AccumulateClient must be initialized.");
            }
        }
    }
}
