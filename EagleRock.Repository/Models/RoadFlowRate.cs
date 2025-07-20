namespace EagleRock.Repository.Models
{
    public class RoadFlowRate
    {
        public Guid Id { get; set; }

        /// <summary>
        /// Reporting unit's unique identifier
        /// </summary>
        public string ReportingUnitId { get; set; }

        /// <summary>
        /// data reporting location
        /// </summary>
        public GeoLocation Location { get; set; }

        /// <summary>
        /// data reporting time (UTC)
        /// </summary>     
        public DateTime ReportedAt { get; set; }

        /// <summary>
        /// Road identifier/name
        /// </summary>
        public string RoadId { get; set; }

        /// <summary>
        /// Road flow rate (vehicle/s)
        /// </summary>
        public int VehicleFlowRate { get; set; }

        /// <summary>
        /// Average vehicle speed (m/s)
        /// </summary>
        public double VehicleAverageSpeed { get; set; }

        /// <summary>
        /// vehicle direction (heading) (degrees)
        /// </summary>
        public double VehicleHeading { get; set; }

        public RoadFlowRate()
        {
            ReportingUnitId = string.Empty;
            Location = new GeoLocation(0, 0);
            RoadId = string.Empty;
        }
    }
}
