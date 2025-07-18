using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;

namespace EagleRock.Repository.Services
{
    public class BotStatusService : IBotStatusService
    {
        private readonly IRoadFlowRateService roadFlowRateService;
        public BotStatusService(IRoadFlowRateService roadFlowRateService) 
        {
            this.roadFlowRateService = roadFlowRateService;
        }
        public IEnumerable<BotStatus> GetBotStatus()
        {
            var reportedBotData = this.roadFlowRateService.GetAll().OrderBy(x => x.ReportedAt).GroupBy(x => x.ReportingUnitId).Select(x => x.Last());

            var botStatuses = new List<BotStatus>();
            foreach (var botData in reportedBotData)
            {
                botStatuses.Add(new BotStatus()
                {
                    Id = botData.ReportingUnitId,
                    CurrentLocation = botData.Location,
                    IsActive = true,
                    LastReport = botData,
                });
            }
            return botStatuses;

        }
    }
}
