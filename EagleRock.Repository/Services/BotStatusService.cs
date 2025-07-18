using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleRock.Repository.Services
{
    public class BotStatusService : IBotStatusService
    {
        private readonly ITrafficSegmentRepository _trafficSegmentCache;
        public BotStatusService(ITrafficSegmentRepository trafficSegmentCache) 
        {
            _trafficSegmentCache = trafficSegmentCache;
        }
        public IEnumerable<BotStatus> GetBotStatuses()
        {
            var botGrouping = _trafficSegmentCache.GetAll().OrderBy(x => x.ReportedTime).GroupBy(x => x.ReportingUnitId).Select(x => x.Last());

            var botStatuses = new List<BotStatus>();
            foreach (var bot in botGrouping)
            {
                botStatuses.Add(new BotStatus()
                {
                    ReportingUnitId = bot.ReportingUnitId,
                    CurrentLocation = bot.Location,
                    AverageSpeed = bot.AverageSpeed,
                    FlowRate = bot.FlowRate,
                    Section = bot.Section,
                });
            }
            return botStatuses;

        }
    }
}
