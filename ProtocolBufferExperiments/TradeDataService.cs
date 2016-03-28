using System;
using Google.Protobuf.WellKnownTypes;
using ProtocolBufferExperiments.Common;
using ProtocolBufferExperiments.Events;

namespace ProtocolBufferExperiments
{
    public class TradeDataService : ITradeDataService
    {
        public void CreatePortfolio(string client, string portfolioName, DateTimeOffset receivedAt)
        {
            // This invocation might fail... due to some validation failure.

            // After successful validation update our in-memory database and add an event to our aggregate-root.
            var @event = new PortfolioCreated
            {
                ObjectUuid = Guid.NewGuid().ToString(),
                Client = client,
                PortfolioName = portfolioName,
                CreatedAt = new TimezoneTimestamp
                {
                    Timestamp = DateTime.UtcNow.ToTimestamp(),
                    TimezoneOffset = new TimeSpan(8, 0, 0).ToDuration(),
                },
                ReceivedAt = new TimezoneTimestamp
                {
                    Timestamp = receivedAt.ToTimestamp(),
                    TimezoneOffset = new TimeSpan(8, 0, 0).ToDuration(),
                },
            };
            // Event assignment must always succeed. This is our record of work.
            // Broadcast the event...
            // Events can have multiple listeners, so another event-handler may use the information to 
            // update a relational database
        }
    }
}