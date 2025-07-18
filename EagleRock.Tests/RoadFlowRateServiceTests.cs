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

        private void WhenOneUnitHasReportedTrafficSegments()
        {

            var trafficSegment = new RoadFlowRate()
            {
                ReportingUnitId = Ganymede,
                Location = Plainlands,
                RoadId = Warrego,
                ReportedAt = DateTime.Now,
                VehicleFlowRate = 5,
                VehicleAverageSpeed = 26.0
            };

            this.testSubject.Create(trafficSegment);
        }

        
        private void TheReportedDataIstored()
        {
            Assert.That(this.testSubject.GetAll().Count(), Is.EqualTo(1));

            var records = this.testSubject.GetAll();    
            Assert.That(records.First().Location == Plainlands);
            Assert.That(records.First().RoadId == Warrego);
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
            WhenOneUnitHasReportedTrafficSegments();
            TheReportedDataIstored();
        }
    }
}