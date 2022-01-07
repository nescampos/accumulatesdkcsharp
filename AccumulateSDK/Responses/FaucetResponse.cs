using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK.Responses
{
    public class FaucetResponse
    {
        public string jsonrpc { get; set; }
        public ulong id { get; set; }
        public FaucetResponseResult result { get; set; }
        public ErrorData error { get; set; }
    }

    public class FaucetResponseResult
    {
        public string type { get; set; }
        public string sponsor { get; set; }
        public object txid { get; set; }
        public object keyPage { get; set; }
        public FaucetResponseResultData data { get; set; }
    }

    public class FaucetResponseResultData
    {
        public string txid { get; set; }
        public string hash { get; set; }
        public string codespace { get; set; }
    }
}
