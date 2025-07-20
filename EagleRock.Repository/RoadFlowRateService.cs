using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using EagleRock.Repository.Services;

namespace EagleRock.Repository
{
    public class RoadFlowRateService : IRoadFlowRateService
    {
        // TODO : switch to redis cache once redis server issues are resolved
        // ITrafficCache<RoadFlowRate> roadFlowRateRepository
        private IList<RoadFlowRate> roadFlowRateRepository;

        private IPublisher publisher;

        public RoadFlowRateService()
        {
            roadFlowRateRepository = [];
            this.publisher = new Publisher();
        }

        public bool Create(RoadFlowRate trafficSegment)
        {
            if (IsValid(trafficSegment))
            {
                roadFlowRateRepository.Add(trafficSegment);
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<RoadFlowRate> GetAll()
        {
            return roadFlowRateRepository.AsEnumerable();
        }

        private bool IsValid(RoadFlowRate trafficSegment)
        {

            if (trafficSegment.ReportingUnitId == String.Empty ||
                trafficSegment.Location == null)
            {
                return false;
            }

            return true;
        }
    }
}
