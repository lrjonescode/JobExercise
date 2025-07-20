using EagleRock.Repository.Models;

namespace EagleRock.DataTypes
{
    public class RoadFlowRateDto
    {
        public string ReportingUnitId {  get; set; }
        public GeoLocation Location { get; set; }
        public DateTime ReportedAt { get; set; }
        public string RoadId { get; set; }
        public int VehicleFlowRate { get; set; } // vehicles / second
        public double VehicleAverageSpeed { get; set; }    // m/s
        public double VehicleHeading { get; set; }

        public RoadFlowRateDto()
        {
            ReportingUnitId = string.Empty;
            Location = new GeoLocation(0,0);
            RoadId = string.Empty;
        }

        public RoadFlowRate ToModel()
        {
            return new RoadFlowRate()
            {
                Id = Guid.NewGuid(),
                ReportingUnitId = ReportingUnitId,
                ReportedAt = ReportedAt,
                RoadId = RoadId,
                VehicleFlowRate = VehicleFlowRate,
                VehicleAverageSpeed = VehicleAverageSpeed,
                VehicleHeading = VehicleHeading,
                Location = Location,   
            };
        }
    }
}
