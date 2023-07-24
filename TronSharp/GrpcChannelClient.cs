﻿using Grpc.Core;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace TronSharp
{
    class GrpcChannelClient : IGrpcChannelClient
    {
        private readonly ILogger<GrpcChannelClient> _logger;
        private readonly IOptions<TronSharpOptions> _options;

        public GrpcChannelClient(ILogger<GrpcChannelClient> logger, IOptions<TronSharpOptions> options)
        {
            _logger = logger;
            _options = options;
        }

        public Channel GetProtocol()
        {
            return new Channel(_options.Value.Channel.Host, _options.Value.Channel.Port, ChannelCredentials.Insecure);
        }
        public Channel GetSolidityProtocol()
        {
            return new Channel(_options.Value.SolidityChannel.Host, _options.Value.SolidityChannel.Port, ChannelCredentials.Insecure);
        }
    }

}
