using EagleRock.Repository.Models;

namespace EagleRock.Repository.Interfaces
{
    public interface IRoadFlowRateService
    {
        public bool Create(RoadFlowRate roadFlowRate);
        public RoadFlowRate Get(Guid Id);
        public IEnumerable<RoadFlowRate> GetAll();
    }
}
