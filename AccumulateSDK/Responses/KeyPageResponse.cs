using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK.Responses
{
    public class KeyPageResponse
    {
        public string jsonrpc { get; set; }
        public ulong id { get; set; }
        public KeyPageResponseResult result { get; set; }
        public ErrorData error { get; set; }
    }

    public class KeyPageResponseResult
    {
        public string type { get; set; }
        public string mdRoot { get; set; }
        public string sponsor { get; set; }
        public object txid { get; set; }
        public object keyPage { get; set; }
        public KeyPageResponseResultData data { get; set; }
    }

    public class KeyPageResponseResultData
    {
        public ulong type { get; set; }
        public string url { get; set; }
        public string sigSpecId { get; set; }
        public ulong creditBalance { get; set; }
        public KeyPageResponseResultDataKey[] keys { get; set; }

    }
    public class KeyPageResponseResultDataKey
    {
        public string publicKey { get; set; }
        public ulong nonce { get; set; }
    }
}
