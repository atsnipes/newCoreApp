using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backend.Services;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get(string cmd)
        {
            cmd = $"./Scripts/iicDriver.sh {cmd}";
            var result = new ScriptService().Bash(cmd);
            return Ok(result);
        }

        [HttpGet(Route("hi"))]
        public ActionResult Gets(string cmd)
        {
            cmd = $"./Scripts/iicDriver.sh {cmd}";
            var result = new ScriptService().Bash(cmd);
            return Ok(result);
        }
    }
}
