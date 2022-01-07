using AccumulateSDK.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AccumulateSDK
{
    public class AccumulateTokenMethod
    {
        public AccumulateTokenMethod()
        {

        }

        /// <summary>Method <c>Token</c> for executing the "token" method in Accumulate API</summary>
        /// <param name="id">ID for this request</param>
        /// <param name="url">URL for this request</param>
        /// <returns>Responses.TokenResponse instance with all data or error from API</returns>
        public async Task<TokenResponse> Token(int id, string url)
        {
            TokenResponse keyPageResponse = new TokenResponse();
            ValidateClient();
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            var contentJson = JsonConvert.SerializeObject(new { jsonrpc = "2.0", id = id, method = "token", @params = new { url = url } });

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(AccumulateClient.URL, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    keyPageResponse = JsonConvert.DeserializeObject<TokenResponse>(apiResponse);
                }
            }
            return keyPageResponse;
        }


        /// <summary>Method <c>TokenAccount</c> for executing the "token-account" method in Accumulate API</summary>
        /// <param name="id">ID for this request</param>
        /// <param name="url">URL for this request</param>
        /// <returns>Responses.TokenAccountResponse instance with all data or error from API</returns>
        public async Task<TokenAccountResponse> TokenAccount(int id, string url)
        {
            TokenAccountResponse keyPageResponse = new TokenAccountResponse();
            ValidateClient();
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            var contentJson = JsonConvert.SerializeObject(new { jsonrpc = "2.0", id = id, method = "token-account", @params = new { url = url } });

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(AccumulateClient.URL, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    keyPageResponse = JsonConvert.DeserializeObject<TokenAccountResponse>(apiResponse);
                }
            }
            return keyPageResponse;
        }

        /// <summary>Method <c>TokenAccountHistory</c> for executing the "token-account-history" method in Accumulate API</summary>
        /// <param name="id">ID for this request</param>
        /// <param name="url">URL for this request</param>
        /// <returns>Responses.TokenAccountHistoryResponse instance with all data or error from API</returns>
        public async Task<TokenAccountHistoryResponse> TokenAccountHistory(int id, string url)
        {
            TokenAccountHistoryResponse keyPageResponse = new TokenAccountHistoryResponse();
            ValidateClient();
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            var contentJson = JsonConvert.SerializeObject(new { jsonrpc = "2.0", id = id, method = "token-account-history", @params = new { url = url } });

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(AccumulateClient.URL, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    keyPageResponse = JsonConvert.DeserializeObject<TokenAccountHistoryResponse>(apiResponse);
                }
            }
            return keyPageResponse;
        }

        /// <summary>Method <c>TokenTransaction</c> for executing the "token-tx" method in Accumulate API</summary>
        /// <param name="id">ID for this request</param>
        /// <param name="url">URL for this request</param>
        /// <returns>Responses.TokenTransactionResponse instance with all data or error from API</returns>
        public async Task<TokenTransactionResponse> TokenTransaction(int id, string hash)
        {
            TokenTransactionResponse keyPageResponse = new TokenTransactionResponse();
            ValidateClient();
            if (string.IsNullOrWhiteSpace(hash))
            {
                throw new ArgumentNullException("hash");
            }

            var contentJson = JsonConvert.SerializeObject(new { jsonrpc = "2.0", id = id, method = "token-tx", @params = new { hash = hash } });

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(AccumulateClient.URL, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    keyPageResponse = JsonConvert.DeserializeObject<TokenTransactionResponse>(apiResponse);
                }
            }
            return keyPageResponse;
        }

        /// <summary>Method <c>Faucet</c> for executing the "faucet" method in Accumulate API</summary>
        /// <param name="id">ID for this request</param>
        /// <param name="url">URL for this request</param>
        /// <returns>Responses.FaucetResponse instance with all data or error from API</returns>
        public async Task<FaucetResponse> Faucet(int id, string url)
        {
            FaucetResponse keyPageResponse = new FaucetResponse();
            ValidateClient();
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentNullException("url");
            }

            var contentJson = JsonConvert.SerializeObject(new { jsonrpc = "2.0", id = id, method = "faucet", @params = new { url = url } });

            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(contentJson, Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync(AccumulateClient.URL, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    keyPageResponse = JsonConvert.DeserializeObject<FaucetResponse>(apiResponse);
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
