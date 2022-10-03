using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Seyir.TarihApi.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Seyir.TarihApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamContreoller : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DataOperationTeam _dataOperationTeam ;
        public TeamContreoller(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _dataOperationTeam = new DataOperationTeam();
        }



        [HttpGet("GetTeam/{team}")]

        public ActionResult Get(string team)
        {

            var value1 = _dataOperationTeam.GetTeam(team);
            if (value1.Status == Status.SUCCESS)
            {
                return Ok(value1.Description);
            }
            else
            {
                return BadRequest(value1.Description);
            }

        }

    }
}
