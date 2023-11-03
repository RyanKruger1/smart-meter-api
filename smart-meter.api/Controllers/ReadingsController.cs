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

        [HttpPost("{id}")]
        public IActionResult CreateSmartMeter(ReadingRequestModel reading, Guid id)
        {
            Reading applicationReading = new Reading();

            applicationReading.smartMeterId = id;
            applicationReading.readingTime = DateTime.Now;
            applicationReading.current = reading.current;
            applicationReading.voltage = reading.voltage;
            applicationReading.power = reading.power;
            applicationReading.powerFactor = reading.powerFactor;

            _readingService.saveReading(applicationReading);
            return Ok(applicationReading);
        }

        [HttpGet("{id}")]
        public IActionResult CreateSmartMeter(Guid id)
        {
            return Ok(_readingService.getReadings(id));
        }
    }
}