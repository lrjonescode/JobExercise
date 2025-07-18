using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;

namespace EagleRock.Repository
{
    public class RoadFlowRateService : IRoadFlowRateService
    {
        private IList<RoadFlowRate> roadFlowData;

        public RoadFlowRateService()
        {
            roadFlowData = [];
        }

        public bool Create(RoadFlowRate trafficSegment)
        {
            roadFlowData.Add(trafficSegment);
            return true;
        }

        public RoadFlowRate Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoadFlowRate> GetAll()
        {
            return roadFlowData.AsEnumerable();
        }
    }
}
