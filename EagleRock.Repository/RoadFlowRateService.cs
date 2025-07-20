using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;

namespace EagleRock.Repository
{
    public class RoadFlowRateService : IRoadFlowRateService
    {
        // TODO : switch to readi cache once redis server issues are resolved
        // ITrafficCache<RoadFlowRate> roadFlowRateRepository
        private IList<RoadFlowRate> roadFlowRateRepository;

        public RoadFlowRateService()
        {
            roadFlowRateRepository = [];
        }

        public bool Create(RoadFlowRate trafficSegment)
        {
            roadFlowRateRepository.Add(trafficSegment);
            return true;
        }

        public IEnumerable<RoadFlowRate> GetAll()
        {
            return roadFlowRateRepository.AsEnumerable();
        }
    }
}
