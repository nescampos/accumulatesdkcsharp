using AccumulateSDK.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AccumulateSDK
{
    public class AccumulateKeyManagementMethod
    {
        public AccumulateKeyManagementMethod()
        {

        }

        /// <summary>Method <c>KeyPage</c> for executing the "sig-spec" method in Accumulate API</summary>
        /// <param name="id">ID for this request</param>
        /// <param name="url">URL for this request</param>
        /// <returns>Responses.KeyPageResponse instance with all data or error from API</returns>
        public async Task<KeyPageResponse> KeyPage(int id, string url)
        {
            KeyPageResponse keyPageResponse = new KeyPageResponse();
            ValidateClient();
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            var contentJson = JsonConvert.SerializeObject(new { jsonrpc = "2.0", id = id, method = "sig-spec", @params = new { url = url } });

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(AccumulateClient.URL, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    keyPageResponse = JsonConvert.DeserializeObject<KeyPageResponse>(apiResponse);
                }
            }
            return keyPageResponse;
        }

        /// <summary>Method <c>KeyBook</c> for executing the "sig-spec-group" method in Accumulate API</summary>
        /// <param name="id">ID for this request</param>
        /// <param name="url">URL for this request</param>
        /// <returns>Responses.KeyBookResponse instance with all data or error from API</returns>
        public async Task<KeyBookResponse> KeyBook(int id, string url)
        {
            KeyBookResponse keyPageResponse = new KeyBookResponse();
            ValidateClient();
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            var contentJson = JsonConvert.SerializeObject(new { jsonrpc = "2.0", id = id, method = "sig-spec-group", @params = new { url = url } });

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(AccumulateClient.URL, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    keyPageResponse = JsonConvert.DeserializeObject<KeyBookResponse>(apiResponse);
                }
            }
            return keyPageResponse;
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
