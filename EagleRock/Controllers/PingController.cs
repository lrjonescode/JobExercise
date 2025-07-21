
using EagleRock.Repository.Interfaces;
using EagleRock.Repository.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

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
