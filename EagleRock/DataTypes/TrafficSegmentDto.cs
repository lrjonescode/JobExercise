using EagleRock.Repository.Models;

namespace EagleRock.DataTypes
{
    public class TrafficSegmentDto
    {
        public Guid ReportingUnitId {  get; set; }
        public GeoLocation Location { get; set; }

        public DateTime ReportedTime { get; set; }

        public string Section { get; set; }

        public int FlowRate { get; set; } // vehicles / second

        public double AverageSpeed { get; set; }    // m/s

        public TrafficSegment ToModel()
        {
            return new TrafficSegment()
            {
                Id = Guid.NewGuid(),
                ReportingUnitId = ReportingUnitId,
                ReportedTime = ReportedTime,
                Section = Section,
                FlowRate = FlowRate,
                AverageSpeed = AverageSpeed,
                Location = Location,
                
                    
            };
        }
    }
}
