using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleRock.Repository.Models
{
    public class BotStatus
    {
        public Guid ReportingUnitId { get; set; }
        public GeoLocation CurrentLocation { get; set; }

        public string Section { get; set; }

        public int FlowRate { get; set; } // vehicles / second

        public double AverageSpeed { get; set; }    // m/s

    }
}
