using smart_meter.domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.domain.Interfaces.Services
{
    public interface IReadingService
    {
        public void saveReading(Reading reading);
        public IList<Reading> getReadings(Guid id);
        public IList<Reading> getMeterReadingBetweenDate(Guid Guid ,DateTime dateFrom, DateTime dateTo);

    }
}
