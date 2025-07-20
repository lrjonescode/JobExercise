using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using EagleRock.Repository.Services;
using NSubstitute;

namespace EagleRock.Tests
{
    public class BotStatusServiceTests
    {
        private IRoadFlowRateService roadFlowRateService;
        private ICollection<RoadFlowRate> eagleRockData;
        private BotStatusService testSubject;
        private IEnumerable<BotStatus> result;
        private const string Ganymede = "Ganymede";
        private const string Io = "Io";
        private const string Triton = "Triton";

        private const string RoadA = "RoadA";
        private const string RoadB = "RoadB";
        private const string RoadC = "RoadC";
        private const string RoadD = "RoadD";
        private const string RoadE = "RoadE";

        private static GeoLocation locationA = new GeoLocation(20, 120);
        private static GeoLocation locationB = new GeoLocation(21, 121);
        private static GeoLocation locationC = new GeoLocation(22, 122);
        private static GeoLocation locationD = new GeoLocation(123, 123);
        private static GeoLocation locationE = new GeoLocation(24, 124);

        private void GivenBotReportsTrafficSegment(string botId, GeoLocation currentPosition, string roadId)
        {
            var trafficSegment = new RoadFlowRate()
            {
                ReportingUnitId = botId,
                Location = currentPosition,
                RoadId = roadId,
                ReportedAt = DateTime.UtcNow,
                VehicleFlowRate = 10
            };
            eagleRockData.Add(trafficSegment);  
        }

        private void WhenServiceGetStatusIsCalled()
        {
            this.result= testSubject.GetBotStatus();
        }
        private void ThenTheBotLatestPositionReportedIsReturned(string botId,GeoLocation location)
        {
            var botStatusData = this.result.Where(x => x.Id == botId);
            Assert.That(botStatusData.Count(), Is.EqualTo(1));
            Assert.That(this.result.Where(x => x.Id == botId).Single().CurrentLocation, Is.EqualTo(location));
        }

        [SetUp]
        public void Setup()
        {
            roadFlowRateService = Substitute.For<IRoadFlowRateService>();
            this.testSubject = new BotStatusService(roadFlowRateService);
            this.eagleRockData = new List<RoadFlowRate>();
            roadFlowRateService.GetAll().Returns(eagleRockData);
        }
            
        [Test]
        public void ReportingBotsCurrentPositionIsReturned()
        {
            GivenBotReportsTrafficSegment(Io , locationA, RoadA);
            GivenBotReportsTrafficSegment(Io, locationB, RoadB);
            GivenBotReportsTrafficSegment(Ganymede, locationB, RoadB);
            GivenBotReportsTrafficSegment(Triton, locationB, RoadB);
            GivenBotReportsTrafficSegment(Triton, locationA, RoadA);
            GivenBotReportsTrafficSegment(Triton, locationC, RoadC);
            GivenBotReportsTrafficSegment(Io, locationD, RoadD);

            WhenServiceGetStatusIsCalled();

            ThenTheBotLatestPositionReportedIsReturned(Io,locationD);
            ThenTheBotLatestPositionReportedIsReturned(Ganymede, locationB);
            ThenTheBotLatestPositionReportedIsReturned(Io, locationD);
        }
    }
}