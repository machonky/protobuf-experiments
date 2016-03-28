using System;

namespace ProtocolBufferExperiments
{
    public interface ITradeDataService
    {
        void CreatePortfolio(string client, string portfolioName, DateTimeOffset receivedAt);
    }
}