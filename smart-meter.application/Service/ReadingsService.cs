using smart_meter.domain.Interfaces;
using smart_meter.domain.Interfaces.Services;
using smart_meter.domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.application.Service
{
    public class ReadingsService : IReadingService
    {
        IReadingRepository _readingsRepo;
        public ReadingsService(IReadingRepository readingRepository)
        {
            _readingsRepo = readingRepository;
        }

        public IList<Reading> getMeterReadingBetweenDate(Guid id, DateTime dateFrom, DateTime dateTo)
        {
            return _readingsRepo.getReadings(id).
                Where(x => x.readingTime >= dateFrom && x.readingTime <= dateTo).ToList();
        }

        public IList<Reading> getReadings(Guid id)
        {
            return _readingsRepo.getReadings(id);
        }

        public void saveReading(Reading reading)
        {
            _readingsRepo.recordReading(reading);
        }
    }
}
