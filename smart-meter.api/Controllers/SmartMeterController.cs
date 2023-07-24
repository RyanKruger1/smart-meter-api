using Microsoft.AspNetCore.Mvc;
using smart_meter.api.RequestModels;
using smart_meter.domain.Interfaces.Services;
using smart_meter.domain.models;

namespace smart_meter.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SmartMeterController : ControllerBase
    {
        ISmartMeterService _smartMeterService;

        public SmartMeterController(ISmartMeterService smartMeterService)
        {
            _smartMeterService = smartMeterService;
        }

        [HttpGet(Name = "getAllSmartMeters")]
        public IList<SmartMeter> GetAllSmartMeters()
        {
            return _smartMeterService.GetAllSmartMeters();
        }

        [HttpGet("{id}")]
        public SmartMeter GetAllSmartMeters(Guid id)
        {
            return _smartMeterService.getSmartMeter(id);
        }

        [HttpPost(Name = "createSmartMeter")]
        public IActionResult CreateSmartMeter(SmartMeterApplicationModel applicationModel)
        {
            Guid guid = Guid.NewGuid();
            SmartMeter smartMeter = new SmartMeter();
            smartMeter.name = applicationModel.name;
            smartMeter.Id = guid;
            smartMeter.location = applicationModel.location;
            smartMeter.zipCode = applicationModel.zipCode;

            _smartMeterService.createSmartMeter(smartMeter);
            return Ok(smartMeter);
        }

        [HttpDelete(Name = "deleteSmartMeter")]
        public IActionResult deleteSmartMeter(Guid id)
        {
            _smartMeterService.deleteSmartMeter(id);
            return NoContent();
        }
    }
}