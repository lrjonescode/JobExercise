using EagleRock.Repository.Models;

namespace EagleRock.DataTypes
{
    public class BotStatusDto
    {
        public Guid ReportingUnitId {  get; set; }
        public GeoLocation CurrentLocation { get; set; }

        public string Section { get; set; }

        public int FlowRate { get; set; } // vehicles / second

        public double AverageSpeed { get; set; }    // m/s

    }
}
