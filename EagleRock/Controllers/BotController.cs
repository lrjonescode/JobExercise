
using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace EagleRock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotStatusController(ILogger<BotStatusController> logger, IBotStatusService botStatusService) : ControllerBase
    {
        private readonly ILogger<BotStatusController> logger = logger;
        private readonly IBotStatusService botStatusService = botStatusService;

        [HttpGet()]
        public IEnumerable<BotStatus> Get()
        {
            this.logger.LogInformation(string.Format("BotStatus GET called"));
            return this.botStatusService.GetBotStatus();
        }
    }
}
