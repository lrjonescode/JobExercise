namespace EagleRock.Repository.Models
{
    public class RoadFlowRate
    {
        public Guid Id { get; set; }
        public string ReportingUnitId { get; set; }
        public GeoLocation Location { get; set; } = new GeoLocation();
        public DateTime ReportedAt { get; set; }
        public string RoadId { get; set; }
        public int VehicleFlowRate { get; set; } // vehicles / second
        public double VehicleAverageSpeed { get; set; }    // m/s
    }
}
