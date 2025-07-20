using EagleRock.Repository.Models;

namespace EagleRock.Repository.Interfaces
{
    public interface IRoadFlowRateService
    {
        /// <summary>
        /// Adds a road flow rate record to the repository
        /// </summary>
        /// <returns>True if data is valid</returns>
        public bool Create(RoadFlowRate roadFlowRate);

        /// <summary>
        /// Gets current road flow rate records stored bi EagleRock
        /// </summary>
        /// <returns>List of RoadFlowRate records</returns>
        public IEnumerable<RoadFlowRate> GetAll();
    }
}
