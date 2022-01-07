using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK.Responses
{
    public class TokenResponse
    {
        public string jsonrpc { get; set; }
        public ulong id { get; set; }
        public TokenResponseResult result { get; set; }
        public ErrorData error { get; set; }
    }

    public class TokenResponseResult
    {
        public string type { get; set; }
        public string mdRoot { get; set; }
        public string sponsor { get; set; }
        public object txid { get; set; }
        public object keyPage { get; set; }
        public TokenResponseResultData data { get; set; }
    }

    public class TokenResponseResultData
    {
        public ulong precision { get; set; }
        public string url { get; set; }
        public string symbol { get; set; }
        public string propertiesUrl { get; set; }
    }
}
