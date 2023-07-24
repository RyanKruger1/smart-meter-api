using Microsoft.AspNetCore.Mvc;
using smart_meter.api.RequestModels;
using smart_meter.application.Service;
using smart_meter.domain.Interfaces;
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
        SCLService service;

        public SCLController(ISmartMeterRepository _smRepo)
        {
            service = new SCLService(_smRepo);
        }

        [HttpGet]
        public ActionResult GetAllSmartMeters()
        {
            service.creatsSclFile();
            return Ok();
        }
    }
}