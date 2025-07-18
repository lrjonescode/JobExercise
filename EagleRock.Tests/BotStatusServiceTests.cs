using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using EagleRock.Repository.Services;
using NSubstitute;

namespace EagleRock.Tests
{
    public class BotStausServiceTests
    {
        private IRoadFlowRateService roadFlowRateService;
        private BotStatusService testSubject;
        private IEnumerable<BotStatus> result;
        
        private void GivenFourUnitsHaveReportedTrafficSegments()
        {
            var trafficSegments = new List<RoadFlowRate>();

            trafficSegments.Add(new RoadFlowRate()
            {
                ReportingUnitId = ""

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
            roadFlowRateService = Substitute.For<IRoadFlowRateService>();
            this.testSubject = new BotStatusService(roadFlowRateService);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}