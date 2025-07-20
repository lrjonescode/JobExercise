using EagleRock.Repository.Models;

namespace EagleRock.Repository.Interfaces
{
    public interface IRoadFlowRateService
    {
        public bool Create(RoadFlowRate roadFlowRate);
        public IEnumerable<RoadFlowRate> GetAll();
    }
}
