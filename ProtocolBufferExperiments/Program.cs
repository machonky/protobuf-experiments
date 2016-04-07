using System;
using System.Collections.Generic;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using ProtocolBufferExperiments.Commands;
using ProtocolBufferExperiments.Common;

namespace ProtocolBufferExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Our server will have to bootstrap a few things...
            var fullyQualifiedName = "ProtocolBufferExperiments.Commands.CreatePortfolio";
            var factory = new Dictionary<string, Func<ByteString, IMessage>>
            {
                {fullyQualifiedName, IMessageFactory.Create<CreatePortfolio>},
            };

            var tradeService = new TradeDataService();
            var tradeCmdHandler = new TradeDataCommandHandler(tradeService);

            // A command is created in another context/clientApp/different language/whatever
            var cmd = new CreatePortfolio
            {
                Client = "Universal Exports",
                PortfolioName = "Questionable Investments",
                ReceivedAt = new TimezoneTimestamp
                {
                    Timestamp = DateTime.Now.ToUniversalTime().ToTimestamp(),
                    TimezoneOffset = new TimeSpan(8,0,0).ToDuration(),
                },
                Value = -12345m
            };

            // ...encoded into binary and shoved in a language neutral container so it can be restored later.
            // Then the frame is put into a message bus.
            var frame = new MessageFrame
            {
                MessageTypeName = ((IMessage)cmd).Descriptor.FullName,
                EncodedMessage = cmd.ToByteString(),
            };

            // When received it needs to be converted back into the original message type
            IMessage inboundMsg = null;
            Func<ByteString, IMessage> cmdFactory;
            if (factory.TryGetValue(frame.MessageTypeName, out cmdFactory))
            {
                inboundMsg = cmdFactory(frame.EncodedMessage);
            }

            if (inboundMsg != null)
            {
                // Some sorcery routes the command to the proper handler, then...
                tradeCmdHandler.Handle((dynamic)cmd);
            }

            Console.ReadKey();
        }
    }
}
