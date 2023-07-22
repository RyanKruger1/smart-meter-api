using Microsoft.AspNetCore.Mvc;
using smart_meter.api.RequestModels;
using smart_meter.domain.Interfaces.Services;
using smart_meter.domain.models;
using smart_meter.infrasturcture.FileSystem;
using System.Xml;

namespace smart_meter.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SCLController : ControllerBase
    {
        IReadingService _readingService;

        public SCLController(IReadingService readingService)
        {
            _readingService = readingService;
        }

        [HttpGet]
        public ActionResult GetAllSmartMeters()
        {
            XMLWriter xml = new XMLWriter();
            xml.saveDocument();
            return Ok();
        }
    }
}