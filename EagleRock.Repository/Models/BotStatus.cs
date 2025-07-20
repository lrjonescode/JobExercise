
namespace EagleRock.Repository.Models
{
    public class BotStatus
    {
        /// <summary>
        /// Bot Identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Bot active status
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Bot Current Location
        /// </summary>
        public GeoLocation? CurrentLocation { get; set; }

        /// <summary>
        /// Bot last data reported
        /// </summary>
        public RoadFlowRate? LastReport { get; set; }
    }
}
