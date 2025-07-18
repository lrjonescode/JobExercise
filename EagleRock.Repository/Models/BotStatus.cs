
namespace EagleRock.Repository.Models
{
    public class BotStatus
    {
        public string Id { get; set; }
        public bool IsActive { get; set; }
        public GeoLocation? CurrentLocation { get; set; }
        public RoadFlowRate? LastReport { get; set; }
    }
}
