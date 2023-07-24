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
    public class SmartMeterService : ISmartMeterService
    {
        ISmartMeterRepository _smRepo;
        XMLWriter xml;

        public SmartMeterService(ISmartMeterRepository smRepo)
        {
            _smRepo = smRepo;
            xml = new XMLWriter();
        }

        public void createSmartMeter(SmartMeter meter)
        {
            _smRepo.createSmartMeter(meter);
            xml.nodes = _smRepo.getSmartMeters();
            xml.CreateSCLFile("virtual-substation");
        }

        public IList<SmartMeter> GetAllSmartMeters()
        {
            return _smRepo.getSmartMeters();
        }

        public SmartMeter getSmartMeter(Guid id)
        {
            return _smRepo.getSmartMeter(id);
        }

        public void updateSmartMeter(Guid id, SmartMeter smartMeter)
        {
            throw new NotImplementedException();
        }

        public void deleteSmartMeter(Guid id)
        {
            _smRepo.deleteSmartMeter(id);
            xml.nodes = _smRepo.getSmartMeters();
            xml.CreateSCLFile("virtual-substation");
        }
    }
}
