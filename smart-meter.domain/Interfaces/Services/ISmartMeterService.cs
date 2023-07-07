using smart_meter.domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.domain.Interfaces.Services
{
    public interface ISmartMeterService
    {
        public void createSmartMeter(SmartMeter meter);
        public SmartMeter getSmartMeter(Guid id);
        public IList<SmartMeter> GetAllSmartMeters();
        public void updateSmartMeter(Guid id, SmartMeter smartMeter);
    }
}
