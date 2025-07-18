using EagleRock.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EagleRock.Repository.Interfaces
{
    public interface ITrafficSegmentRepository
    {
        public bool Create(TrafficSegment trafficSegment);
        public TrafficSegment Get(Guid Id);

        public IEnumerable<TrafficSegment> GetAll();
    }
}
