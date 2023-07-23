# TronSharp: C# Library for Interacting with Tron Network
TronSharp is a powerful C# library that facilitates seamless interaction with the Tron network (TRX), its protocol, wallet, and smart contracts. Whether you are building decentralized applications (DApps) or integrating Tron functionalities into your existing projects, TronSharp simplifies the process, enabling you to focus on your application logic.

## Features
- **Blockchain Interaction:** TronSharp enables you to interact with the Tron blockchain effortlessly. You can query account information, transaction details, block data, broadcast transactions and more.

- **Wallet Management:** With TronSharp, managing TRX wallets becomes a breeze. It supports various cryptographic algorithms.

- **Smart Contract Integration:** TronSharp provides a comprehensive set of functions to deploy, invoke, and interact with smart contracts on the Tron network. It streamlines the process of integrating DApps with smart contracts.

## Installation

To start using TronSharp in your C# project, you can either:

1. Clone this GitHub repository and include the library in your project.
2. Install the package from NuGet. `TronSharp`

```
PM> Install-Package TronSharp
or
dotnet add package TronSharp
```

### Configuration
First,You need to config `TronSharp` in your `Startup.cs`:
```c#
......
using TronSharp;
......

public void ConfigureServices(IServiceCollection services)
{
    ......

    services.AddTronSharp(x =>
    {
        x.Network = TronNetwork.MainNet;
        x.Channel = new GrpcChannelOption { Host = "grpc.shasta.trongrid.io", Port = 50051 };
        x.SolidityChannel = new GrpcChannelOption { Host = "grpc.shasta.trongrid.io", Port = 50052 };
        x.FreeApiKey = "input your free api key";
        x.ProApiKey = "input your pro api key";
    });

    ......
}

```

Please refer to the documentation for more detailed examples and explanations.

## Donations
If you find TronSharp useful and would like to support its development, you can make a donation to the following TRX wallet address:
### TNDTGoJ3dDvEmNHPCit9UUJVqFswaY7yvC
