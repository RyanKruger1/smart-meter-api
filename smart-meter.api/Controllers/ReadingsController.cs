using Microsoft.AspNetCore.Mvc;
using smart_meter.api.RequestModels;
using smart_meter.domain.Interfaces.Services;
using smart_meter.domain.models;

namespace smart_meter.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReadingsController : ControllerBase
    {
        IReadingService _readingService;

        public ReadingsController(IReadingService readingService)
        {
            _readingService = readingService;
        }

        [HttpPost(Name = "recordReading")]
        public IActionResult CreateSmartMeter(Reading r)
        {
            _readingService.saveReading(r);
            return Ok(r);
        }

        [HttpGet("{id}")]
        public IActionResult CreateSmartMeter(Guid id)
        {
            return Ok(_readingService.getReadings(id));
        }
    }
}