using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;

namespace EagleRock.Repository
{
    public class TrafficSegmentRepository : ITrafficSegmentRepository
    {
        private IList<TrafficSegment> trafficBlocks;

        public TrafficSegmentRepository()
        {
            trafficBlocks = new List<TrafficSegment>();
        }

        public bool Create(TrafficSegment trafficSegment)
        {
            trafficBlocks.Add(trafficSegment);
            return true;
        }

        public TrafficSegment Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TrafficSegment> GetAll()
        {
            return trafficBlocks.AsEnumerable();
        }
    }
}
