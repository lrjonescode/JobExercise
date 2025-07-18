using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using EagleRock.Repository.Services;
using NSubstitute;

namespace EagleRock.Tests
{
    public class BotStausServiceTests
    {
        private ITrafficSegmentRepository trafficSegmentRepository;
        private BotStatusService testSubject;
        private IEnumerable<BotStatus> result;
        
        private void GivenFourUnitsHaveReportedTrafficSegments()
        {
            var trafficSegments = new List<TrafficSegment>();

            trafficSegments.Add(new TrafficSegment()
            { 
                ReportingUnitId = Guid.NewGuid(),

            });

            //this.trafficSegmentRepository.GetAll().Returns();
        }

        private void WhenServiceGetStatusIsCalled()
        {
            this.result= testSubject.GetBotStatuses();
        }
        private void ThenTheLatestStatusRecordsAreReturned()
        {
            Assert.Equals(this.result.Count(), 4);
        }

        [SetUp]
        public void Setup()
        {
            trafficSegmentRepository = Substitute.For<ITrafficSegmentRepository>();
            this.testSubject = new BotStatusService(trafficSegmentRepository);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}