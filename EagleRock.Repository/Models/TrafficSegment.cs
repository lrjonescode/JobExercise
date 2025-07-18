using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleRock.Repository.Models
{
    public class TrafficSegment
    {

        public Guid Id { get; set; }
        public Guid ReportingUnitId { get; set; }
        public GeoLocation Location { get; set; }

        public DateTime ReportedTime { get; set; }

        public string Section { get; set; }

        public int FlowRate { get; set; } // vehicles / second

        public double AverageSpeed { get; set; }    // m/s

    }
}
