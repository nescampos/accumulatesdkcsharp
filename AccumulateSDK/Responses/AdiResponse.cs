using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK.Responses
{
    public class AdiResponse
    {
        public string jsonrpc { get; set; }
        public ulong id { get; set; }
        public AdiResponse result { get; set; }
        public ErrorData error { get; set; }
    }

    public class AdiResponseResult
    {
        public string type { get; set; }
        public string mdRoot { get; set; }
        public string sponsor { get; set; }
        public object txid { get; set; }
        public object keyPage { get; set; }
        public AdiResponseResultData data { get; set; }
    }

    public class AdiResponseResultData
    {
        public string url { get; set; }
        public string publicKey { get; set; }
        public string keyBookName { get; set; }
        public string keyPageName { get; set; }
    }
}
