using EagleRock.DataTypes;
using EagleRock.Repository;
using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EagleRock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrafficController : ControllerBase
    {
 
        private readonly ILogger<TrafficController> _logger;
        private readonly ITrafficSegmentRepository _trafficSegmentCache;
        //private ITrafficSegmentRepository repository;

        public TrafficController(ILogger<TrafficController> logger, ITrafficSegmentRepository trafficSegmentCache)
        {
            _logger = logger;
            _trafficSegmentCache = trafficSegmentCache;
        }
            

       [HttpGet()]
        public IEnumerable<TrafficSegment> Get()
        {
            return _trafficSegmentCache.GetAll();
        }

        [HttpPost]
        public Task<CreatedResult> PostTrafficSegment(TrafficSegmentDto trafficBlockDto)
        {
            var newTrafficSegment = trafficBlockDto.ToModel();

            _trafficSegmentCache.Create(newTrafficSegment);
            //repository.Create(newTrafficSegment);

            return Task.FromResult(Created());

            /*return CreatedAtAction(
                nameof(trafficBlock
                new { id = trafficBlock.ReportingUnitId },
                trafficBlock); */
        }
    }
}
