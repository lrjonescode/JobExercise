using EagleRock.DataTypes;
using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace EagleRock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrafficController(ILogger<TrafficController> logger, IRoadFlowRateService roadFlowRateService) : ControllerBase
    {
 
        private readonly ILogger<TrafficController> logger = logger;
        private readonly IRoadFlowRateService roadFlowRateService = roadFlowRateService;

        [HttpGet()]
        public IEnumerable<RoadFlowRate> Get()
        {
            return this.roadFlowRateService.GetAll();
        }

        [HttpPost]
        public CreatedResult PostTrafficSegment(RoadFlowRateDto trafficBlockDto)
        {
            this.logger.LogInformation(string.Format("POST //Traffic called by {0}",trafficBlockDto.ReportingUnitId));
            var newTrafficSegment = trafficBlockDto.ToModel();
            this.roadFlowRateService.Create(newTrafficSegment);

            return Created();
        }
    }
}