using System;
using ProtocolBufferExperiments.Commands;
using ProtocolBufferExperiments.Common;

namespace ProtocolBufferExperiments
{
    // Command handlers should contain no business logic. 
    // Strictly only to convert from the command object to the service call.
    public class TradeDataCommandHandler:
        IHandleCommand<CreatePortfolio>
    {
        private readonly ITradeDataService _tradeDataService;

        public TradeDataCommandHandler(ITradeDataService tradeDataService)
        {
            _tradeDataService = tradeDataService;
        }

        public void Handle(CreatePortfolio cmd)
        {
            Console.WriteLine("received command:{0}",cmd);
            _tradeDataService.CreatePortfolio(cmd.Client, cmd.PortfolioName, cmd.ReceivedAt.Timestamp.ToDateTimeOffset());
        }

        public void Handle(BogusCommand cmd)
        { } // Just to prove it's not an accident..
    }

    public class BogusCommand : ICommand
    { }
}
