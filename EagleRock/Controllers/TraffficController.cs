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
 
        private readonly ILogger<TrafficController> _logger = logger;
        private readonly IRoadFlowRateService roadFlowRateService = roadFlowRateService;

        [HttpGet()]
        public IEnumerable<RoadFlowRate> Get()
        {
            return this.roadFlowRateService.GetAll();
        }

        [HttpPost]
        public CreatedResult PostTrafficSegment(RoadFlowRateDto trafficBlockDto)
        {
            var newTrafficSegment = trafficBlockDto.ToModel();
            roadFlowRateService.Create(newTrafficSegment);

            return Created();
        }
    }
}