# Accumulate SDK for .NET Core
.NET Core Library for Accumulate Network (https://accumulatenetwork.io/), built with C#

## License
----
Apache

## Contributors
----

- [Néstor Nicolás Campos Rojas](https://www.linkedin.com/in/nescampos/)

## Use the library

To consume this library, just add with NuGet or DotNet CLI in your project.

**Full version**

```sh
    Install-Package AccumulateSDK -Version 1.0.0
```

```sh
    dotnet add package AccumulateSDK --version 1.0.0
```

## Configuration

You need to initialized the service with **AccumulateClient** class, with the endpoint URL.

```csharp
    AccumulateClient.Init(<<endpoint_url>>);
```

```csharp
    AccumulateClient.Init(<<endpoint_url>>);
```

You can use the **Constant** class with some endpoint url:
- TESTNET_ENDPOINT_V1
- LOCALHOST_ENDPOINT_V1


### Dependencies

The only dependency is [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)

## AccumulateGetMethod

You can use *get* service (**AccumulateGetMethod**) for getting data.

```csharp
    using AccumulateSDK
    AccumulateGetMethod accumulateGetMethod = new AccumulateGetMethod();
    Responses.GetResponse responseGet = accumulateGetMethod.Get(1, "acc://d4c8d9ab07daeecf50a7c78ff03c6524d941299e5601e578/ACME").Result;
```

**Available Methods**:
- Get()



## AccumulateAdiMethod

You can use *adi* service (**AccumulateAdiMethod**) for getting data.

```csharp
    using AccumulateSDK
    AccumulateAdiMethod accumulateAdiMethod = new AccumulateAdiMethod();
    Responses.AdiResponse adiResponse = accumulateAdiMethod.Adi(1, "redwagon").Result;
```

**Available Methods**:
- Adi()

## AccumulateTokenMethod

You can use **AccumulateTokenMethod** for getting data from "token", "token-account", "token-account-history", "token-tx" and "faucet" services.

```csharp
    using AccumulateSDK
    AccumulateTokenMethod accumulateTokenMethod = new AccumulateTokenMethod();
    Responses.TokenResponse tokenResponse = accumulateTokenMethod.Token(3, "acc://ACME").Result;

    Responses.TokenAccountResponse tokenAccountResponse = accumulateTokenMethod.TokenAccount(3, "acc://d4c8d9ab07daeecf50a7c78ff03c6524d941299e5601e578/ACME").Result;

    Responses.TokenAccountHistoryResponse tokenAccountHistoryResponse = accumulateTokenMethod.TokenAccountHistory(3, "acc://d4c8d9ab07daeecf50a7c78ff03c6524d941299e5601e578/ACME").Result;

    Responses.TokenTransactionResponse tokenTransactionResponse = accumulateTokenMethod.TokenTransaction(3, "9bf76e3fc19efd158b13b426c29dd07b37aeb6de23da4e1642fbf6a23059512b").Result;

    Responses.FaucetResponse faucetResponse = accumulateTokenMethod.Faucet(3, "acc://d4c8d9ab07daeecf50a7c78ff03c6524d941299e5601e578/ACME").Result;
```

**Available Methods**:
- Token()
- TokenAccount()
- TokenAccountHistory()
- TokenTransaction()
- Faucet()


## AccumulateKeyManagementMethod

You can use **AccumulateKeyManagementMethod** for getting data from "sig-spec" and "sig-spec-group" services.

```csharp
    using AccumulateSDK
    AccumulateKeyManagementMethod accumulateKeyManagementMethod = new AccumulateKeyManagementMethod();
    Responses.KeyPageResponse keyPageResponse = accumulateKeyManagementMethod.KeyPage(1, "acc://testadi1/keypage1").Result;

    Responses.KeyBookResponse keyBookResponse = accumulateKeyManagementMethod.KeyBook(1, "acc://testadi1/keybook1").Result;
```

**Available Methods**:
- KeyPage()
- KeyBook()


## Contributions

If you want to colaborate, just fork this repository and build new things. Thanks!!
