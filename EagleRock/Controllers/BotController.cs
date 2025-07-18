using EagleRock.DataTypes;
using EagleRock.Repository;
using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace EagleRock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotStatusController : ControllerBase
    {
 
        private readonly ILogger<BotStatusController> _logger;
        private readonly IBotStatusService botStatusService;

        public BotStatusController(ILogger<BotStatusController> logger, IBotStatusService botStatusService)
        {
            _logger = logger;
            this.botStatusService = botStatusService;
        }
            

       [HttpGet()]
        public IEnumerable<BotStatus> Get()
        {
            return this.botStatusService.GetBotStatuses();
        }
    }
}
