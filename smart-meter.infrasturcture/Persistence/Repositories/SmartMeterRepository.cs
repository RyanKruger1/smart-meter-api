using Microsoft.Extensions.Options;
using MongoDB.Driver;
using smart_meter.domain.Interfaces;
using smart_meter.domain.models;
using smart_meter.domain.models.Settings;
using System;

namespace smart_meter.infrasturcture.Persistence.Repositories
{
    
    public class SmartMeterRepository : ISmartMeterRepository
    {

        public readonly IMongoCollection<SmartMeter> _meterStore;

        SmartMeterDbContext _context;

        public SmartMeterRepository(SmartMeterDbContext context)
        {
            _context = context;
        }

        public void createSmartMeter(SmartMeter smartMeter)
        {
            _context.Add(smartMeter);
            _context.SaveChanges();
        }

        public void deleteSmartMeter(Guid id)
        {
            _context.Remove(getSmartMeter(id));
            _context.SaveChanges();
        }

        public SmartMeter getSmartMeter(Guid id)
        {
            SmartMeter sm = _context.meters.Where(r => r.Id == id).SingleOrDefault();
            return sm;
        }

        public IList<SmartMeter> getSmartMeters()
        {
            IList<SmartMeter> sms = _context.meters.ToList();
            return sms;
        }

        public void updateSmartMeter(SmartMeter smartMeter)
        {
            throw new NotImplementedException();
        }
    }
}