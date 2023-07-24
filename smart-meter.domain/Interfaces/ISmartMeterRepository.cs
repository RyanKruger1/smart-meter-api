using smart_meter.domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.domain.Interfaces
{
    public interface ISmartMeterRepository
    {
        public SmartMeter getSmartMeter(Guid id);
        public IList<SmartMeter> getSmartMeters();
        public void createSmartMeter(SmartMeter smartMeter);
        public void updateSmartMeter(SmartMeter smartMeter);
        public void deleteSmartMeter(Guid id);

    }
}
