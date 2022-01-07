using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK.Responses
{
    public class GetResponse
    {
        public string jsonrpc { get; set; }
        public ulong id { get; set; }
        public GetResponseResult result { get; set; }
        public ErrorData error { get; set; }
    }

    public class GetResponseResult
    {
        public string type { get; set; }
        public string mdRoot { get; set; }
        public string sponsor { get; set; }
        public object keyPage { get; set; }
        public GetResponseResultData data { get; set; }
    }

    public class GetResponseResultData
    {
        public string url { get; set; }
        public string tokenUrl { get; set; }
        public string keyBookUrl { get; set; }
        public string balance { get; set; }
        public string creditBalance { get; set; }
        public ulong txCount { get; set; }
        public ulong nonce { get; set; }
    }
}
