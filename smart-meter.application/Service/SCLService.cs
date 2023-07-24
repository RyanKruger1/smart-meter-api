using smart_meter.domain.Interfaces;
using smart_meter.domain.Interfaces.Services;
using smart_meter.domain.models;
using smart_meter.infrasturcture.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.application.Service
{
    public class SCLService
    {
        ISmartMeterRepository _smartMeterService;
        public SCLService(ISmartMeterRepository smartMeterService)
        {
            _smartMeterService = smartMeterService;
        }

        public void creatsSclFile()
        {

            _smartMeterService.getSmartMeters();
            XMLWriter sclFileCreator = new XMLWriter();
            
            IList<SmartMeter> smartMeters = _smartMeterService.getSmartMeters();
            sclFileCreator.nodes = smartMeters;
            sclFileCreator.CreateSCLFile("test12");
            
        }

    }
}
