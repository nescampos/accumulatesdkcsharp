using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK.Responses
{
    public class TokenAccountHistoryResponse
    {
        public string jsonrpc { get; set; }
        public ulong id { get; set; }
        public TokenAccountHistoryResponseResult result { get; set; }
    }

    public class TokenAccountHistoryResponseResult
    {
        public string type { get; set; }
        public ulong start { get; set; }
        public ulong limit { get; set; }
        public ulong total { get; set; }
        public TokenAccountHistoryResponseResultData[] data { get; set; }
    }

    public class TokenAccountHistoryResponseResultData
    {
        public string txid { get; set; }
        public string type { get; set; }
        public TokenTransactionResponseResultSigner signer { get; set; }
        public string sig { get; set; }
        public TokenTransactionResponseResultKeyPage keyPage { get; set; }
        public string sponsor { get; set; }
        public TokenTransactionResponseResultStatus status { get; set; }

        public TokenAccountHistoryResponseResultValues data { get; set; }
        public ErrorData error { get; set; }
    }

    public class TokenAccountHistoryResponseResultValues
    {
        public string txid { get; set; }
        public string from { get; set; }
        public object to { get; set; }
        public string amount { get; set; }
        public string tokenURL { get; set; }
    }
}
