using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK.Responses
{
    public class KeyBookResponse
    {
        public string jsonrpc { get; set; }
        public ulong id { get; set; }
        public KeyBookResponseResult result { get; set; }
        public ErrorData error { get; set; }
    }

    public class KeyBookResponseResult
    {
        public string type { get; set; }
        public string mdRoot { get; set; }
        public string sponsor { get; set; }
        public object txid { get; set; }
        public object keyPage { get; set; }
        public KeyBookResponseResultData data { get; set; }
    }

    public class KeyBookResponseResultData
    {
        public ulong type { get; set; }
        public string url { get; set; }
        public ulong[] sigSpecId { get; set; }
        public string[] sigSpecs { get; set; }
    }
}
