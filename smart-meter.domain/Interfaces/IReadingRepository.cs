using smart_meter.domain.models;

namespace smart_meter.domain.Interfaces
{
    public interface IReadingRepository
    {
        public IList<Reading> getReadings(Guid environment);
        public void recordReading(Reading r);
        public void getAllReadings();
    }
}
