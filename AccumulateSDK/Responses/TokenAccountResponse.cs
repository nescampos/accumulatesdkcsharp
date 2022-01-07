using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK.Responses
{
    public class TokenAccountResponse
    {
        public string jsonrpc { get; set; }
        public ulong id { get; set; }
        public TokenAccountResponseResult result { get; set; }
        public ErrorData error { get; set; }
    }

    public class TokenAccountResponseResult
    {
        public string type { get; set; }
        public string mdRoot { get; set; }
        public string sponsor { get; set; }
        public object keyPage { get; set; }
        public TokenAccountResponseResultData data { get; set; }
    }

    public class TokenAccountResponseResultData
    {
        public ulong nonce { get; set; }
        public string url { get; set; }
        public string tokenUrl { get; set; }
        public string keyBookUrl { get; set; }
        public string balance { get; set; }
        public ulong txCount { get; set; }
        public string creditBalance { get; set; }
    }
}
