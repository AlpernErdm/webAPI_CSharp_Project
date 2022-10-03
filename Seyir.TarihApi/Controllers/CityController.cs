using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Seyir.TarihApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seyir.TarihApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CityController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DataOperationsForCity _DataOperationForCity;

        public CityController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _DataOperationForCity = new DataOperationsForCity();
        }


        
        [HttpGet("GetCity/{city}")]
       
        public ActionResult Get(string city)
        {

            var value = _DataOperationForCity.GetCity(city);
            if (value.Status == Status.SUCCESS)
            {
                return Ok(value.Description);
            }
            else
            {
                return BadRequest(value.Description);
            }
            
        }

    }
}

