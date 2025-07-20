using EagleRock.Repository.Models;

namespace EagleRock.Repository.Interfaces
{
    public interface IPublisher
    {
        /// <summary>
        /// Publishes the road flow rate to exterbal subscribers
        /// </summary>
        void Publish(RoadFlowRate rate);
    }
}
