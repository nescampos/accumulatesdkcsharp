using System;
using AccumulateSDK;

namespace AccumulateSDK.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AccumulateClient.Init(Constant.TESTNET_ENDPOINT_V1);
            Console.WriteLine("AccumulateClient initialized.");

            AccumulateGetMethod accumulateGetMethod = new AccumulateGetMethod();
            Responses.GetResponse responseGet = accumulateGetMethod.Get(1, "acc://d4c8d9ab07daeecf50a7c78ff03c6524d941299e5601e578/ACME").Result;

            AccumulateAdiMethod accumulateAdiMethod = new AccumulateAdiMethod();
            Responses.AdiResponse adiResponse = accumulateAdiMethod.Adi(1, "redwagon").Result;

            AccumulateTokenMethod accumulateTokenMethod = new AccumulateTokenMethod();
            Responses.TokenResponse tokenResponse = accumulateTokenMethod.Token(3, "acc://ACME").Result;

            Responses.TokenAccountResponse tokenAccountResponse = accumulateTokenMethod.TokenAccount(3, "acc://d4c8d9ab07daeecf50a7c78ff03c6524d941299e5601e578/ACME").Result;

            Responses.TokenAccountHistoryResponse tokenAccountHistoryResponse = accumulateTokenMethod.TokenAccountHistory(3, "acc://d4c8d9ab07daeecf50a7c78ff03c6524d941299e5601e578/ACME").Result;

            Responses.TokenTransactionResponse tokenTransactionResponse = accumulateTokenMethod.TokenTransaction(3, "9bf76e3fc19efd158b13b426c29dd07b37aeb6de23da4e1642fbf6a23059512b").Result;

            Responses.FaucetResponse faucetResponse = accumulateTokenMethod.Faucet(3, "acc://d4c8d9ab07daeecf50a7c78ff03c6524d941299e5601e578/ACME").Result;

            AccumulateKeyManagementMethod accumulateKeyManagementMethod = new AccumulateKeyManagementMethod();
            Responses.KeyPageResponse keyPageResponse = accumulateKeyManagementMethod.KeyPage(1, "acc://testadi1/keypage1").Result;

            Responses.KeyBookResponse keyBookResponse = accumulateKeyManagementMethod.KeyBook(1, "acc://testadi1/keybook1").Result;
        }
    }
}
