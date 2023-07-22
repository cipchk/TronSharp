﻿using Microsoft.Extensions.DependencyInjection;

namespace TronSharp.Contract
{
    class ContractClientFactory : IContractClientFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ContractClientFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IContractClient CreateClient(ContractProtocol protocol)
        {

            IContractClient client = protocol switch
            {
                ContractProtocol.TRC20 => _serviceProvider.GetService<TRC20ContractClient>(),
                _ => throw new NotImplementedException()
            };

            return client;
        }
    }
}
