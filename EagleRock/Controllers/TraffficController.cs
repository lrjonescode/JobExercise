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
        public IActionResult Post([FromBody] RoadFlowRateDto trafficSegment)
        {
            this.logger.LogInformation(string.Format("POST //Traffic called by {0}", trafficSegment.ReportingUnitId));
            var newTrafficSegment = trafficSegment.ToModel();
            if (this.roadFlowRateService.Create(newTrafficSegment))
            {
                // At this stage no requirement for single created resource uri
                return Created(string.Empty,newTrafficSegment);
            }
            else
            {
                return BadRequest("Field reportingUnitId is required");
            }   
        }
    }
}