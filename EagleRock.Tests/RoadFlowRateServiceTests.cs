using EagleRock.Repository;
using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using EagleRock.Repository.Services;
using NSubstitute;
using System.Runtime.CompilerServices;

namespace EagleRock.Tests
{
    public class RoadFlowRateServiceTests
    {
        private RoadFlowRateService testSubject;


        private GeoLocation Plainlands = new GeoLocation(-27.56467, 152.42374);
        private const string Warrego = "WarregoHwy";

        private GeoLocation Goodna = new GeoLocation(-27.60467, 152.88374);
        private const string IpswichMW = "IpswichMy";

        private const string Ganymede = "Ganymede";
        private const string Io = "Io";
        private const string Triton = "Triton";


        private void GivenAValidUnit()
        {

        }

        private void WhenBotHasReportedTrafficSegment(string botId, GeoLocation location, string roadId, out Guid createdResourceId)
        {

            var trafficSegment = new RoadFlowRate()
            {
                Id = Guid.NewGuid(),
                ReportingUnitId = botId,
                Location = location,
                RoadId = roadId,
                ReportedAt = DateTime.Now,
                VehicleFlowRate = 5,
                VehicleAverageSpeed = 26.0,
                VehicleHeading = 3
            };

            this.testSubject.Create(trafficSegment);
            createdResourceId = trafficSegment.Id;
        }


        private void TheReportedDataIsCorrectlyStored(Guid resourceId,string botId, GeoLocation location, string roadId)
        {
            var resultData = this.testSubject.GetAll().Where(x => x.Id.Equals(resourceId));
            Assert.That(resultData.Count(), Is.EqualTo(1));
            Assert.That(resultData.First().Location.Latitude, Is.EqualTo(location.Latitude));
            Assert.That(resultData.First().Location.Longitude, Is.EqualTo(location.Longitude));
            Assert.That(resultData.First().RoadId, Is.EqualTo(roadId));
            Assert.That(resultData.First().VehicleFlowRate, Is.EqualTo(5));
            Assert.That(resultData.First().VehicleAverageSpeed, Is.EqualTo(26));
            Assert.That(resultData.First().VehicleHeading, Is.EqualTo(3));
        }

        private void TheReportedDataRecordCountIsCorrect(int expectedCount, string? botId = null)
        {
            var resultData = botId != null ? this.testSubject.GetAll().Where(x => x.ReportingUnitId.Equals(botId)) :
                this.testSubject.GetAll();

            Assert.That(resultData.Count(), Is.EqualTo(expectedCount));
        }

        [SetUp]
        public void Setup()
        {
            this.testSubject = new RoadFlowRateService();
        }

        [Test]
        public void AuthorisedBotDataIsStored()
        {
            GivenAValidUnit();
            WhenBotHasReportedTrafficSegment(Io, Plainlands, Warrego, out var newResourceId);
            TheReportedDataIsCorrectlyStored(newResourceId,Io, Plainlands, Warrego);
        }


        [Test]
        public void AuthorisedMultipleBotDataIsStored()
        {
            GivenAValidUnit();

            WhenBotHasReportedTrafficSegment(Io, Plainlands, Warrego, out var newResourceId1);
            WhenBotHasReportedTrafficSegment(Io, Goodna, IpswichMW, out var newResourceId2);
            WhenBotHasReportedTrafficSegment(Ganymede, Goodna, IpswichMW, out var newResourceId3);

            TheReportedDataIsCorrectlyStored(newResourceId1, Io, Plainlands, Warrego);
            TheReportedDataIsCorrectlyStored(newResourceId2,Io, Goodna, IpswichMW);
            TheReportedDataIsCorrectlyStored(newResourceId3,Ganymede, Goodna, IpswichMW);
        }


        [Test]
        public void CorrectNumberOfBotReportRecordsAreCreated()
        {
            GivenAValidUnit();

            WhenBotHasReportedTrafficSegment(Io, Plainlands, Warrego, out var newResourceId1);
            WhenBotHasReportedTrafficSegment(Io, Goodna, IpswichMW, out var newResourceId2);
            WhenBotHasReportedTrafficSegment(Ganymede, Goodna, IpswichMW, out var newResourceId3);
            WhenBotHasReportedTrafficSegment(Ganymede, Goodna, IpswichMW, out var newResourceId4);
            WhenBotHasReportedTrafficSegment(Ganymede, Goodna, IpswichMW, out var newResourceId5);

            WhenBotHasReportedTrafficSegment(Triton, Goodna, IpswichMW, out var newResourceId7);

            TheReportedDataRecordCountIsCorrect(2, Io);
            TheReportedDataRecordCountIsCorrect(3, Ganymede);
            TheReportedDataRecordCountIsCorrect(6);
        }

        [Test]
        public void InvalidBotReportsAreNotStored()
        {
            GivenAValidUnit();

            WhenBotHasReportedTrafficSegment(Io, null, Warrego, out var newResourceId1);
            WhenBotHasReportedTrafficSegment(string.Empty, Plainlands, Warrego, out var newResourceId2);

            TheReportedDataRecordCountIsCorrect(0, Io);
            TheReportedDataRecordCountIsCorrect(0);
        }
    }
}