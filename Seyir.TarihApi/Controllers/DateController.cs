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
    public class DateController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly DataOperationService _dateOperationService;
        public DateController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _dateOperationService = new DataOperationService();
        }

        // ?date=20220725
        // /getday/20220725

        [HttpGet("GetDay/{date}")]
        public ActionResult Get(string date)
        {
            var day = _dateOperationService.GetDay(date);
            if (day.Status == Status.SUCCESS)
            {
                return Ok(day.Description);
            }
            else
            {
                return BadRequest(day.Description);
            }
        }
    }
}
