using Microsoft.Extensions.Options;
using MongoDB.Driver;
using smart_meter.domain.Interfaces;
using smart_meter.domain.models;
using smart_meter.domain.models.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.infrasturcture.Persistence.Repositories
{
    public class ReadingRepository : IReadingRepository
    {
        ReadingsDbContext _context;

        public ReadingRepository(ReadingsDbContext context) { 
               _context = context;
        }

        public void getAllReadings()
        {
            throw new NotImplementedException();
        }

        public IList<Reading> getReadings(Guid environment)
        {
            IList<Reading> readings = _context.readings.Where(r => r.smartMeterId == environment).ToList(); 
            return readings;
        }

        public void recordReading(Reading r)
        {
            _context.readings.Add(r);
            _context.SaveChanges();
        }
    }
}
