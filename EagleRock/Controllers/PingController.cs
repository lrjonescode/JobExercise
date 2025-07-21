
using Microsoft.AspNetCore.Mvc;

namespace EagleRock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController() : ControllerBase
    {
        private const string PingMessage = "EagleRock is online";
        [HttpGet()]
        public string Get()
        {
            return PingMessage;
        }
    }
}
