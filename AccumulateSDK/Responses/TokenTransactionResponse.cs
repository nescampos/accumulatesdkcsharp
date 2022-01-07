using System;
using System.Collections.Generic;
using System.Text;

namespace AccumulateSDK.Responses
{
    public class TokenTransactionResponse
    {
        public string jsonrpc { get; set; }
        public ulong id { get; set; }
        public TokenTransactionResponseResult result { get; set; }
        public ErrorData error { get; set; }
    }

    public class TokenTransactionResponseResult
    {
        public string type { get; set; }
        public string sponsor { get; set; }
        public string txid { get; set; }

        public string sig { get; set; }

        
        public TokenTransactionResponseResultSigner signer { get; set; }
        public TokenTransactionResponseResultStatus status { get; set; }

        public TokenTransactionResponseResultKeyPage keyPage { get; set; }
        public TokenTransactionResponseResultData data { get; set; }
    }

    public class TokenTransactionResponseResultData
    {
        public string txid { get; set; }
        public string from { get; set; }
        public TokenTransactionResponseResultDataTo[] to { get; set; }
    }

    public class TokenTransactionResponseResultDataTo
    {
        public string txid { get; set; }
        public string url { get; set; }
        public ulong amount { get; set; }
    }

    public class TokenTransactionResponseResultKeyPage
    {
        public ulong height { get; set; }
        public ulong index { get; set; }
    }

    public class TokenTransactionResponseResultStatus
    {
        public string code { get; set; }
    }

    public class TokenTransactionResponseResultSigner
    {
        public string publicKey { get; set; }
        public ulong nonce { get; set; }
    }
}
