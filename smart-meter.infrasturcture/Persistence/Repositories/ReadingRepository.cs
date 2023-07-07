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
        public readonly IMongoCollection<Reading> _readingStore;
        public ReadingRepository(
  IOptions<MongoDBSettings> testDataSettings)
        {
            var mongoClient = new MongoClient(
                testDataSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                testDataSettings.Value.DatabaseName);

            _readingStore = mongoDatabase.GetCollection<Reading>(
                testDataSettings.Value.ReadingsCollectionName);
        }

        public IList<Reading> getReadings(Guid smartMeterId) =>
        _readingStore.Find(x => x.smartMeterId == smartMeterId).ToList();
        

        public void recordReading(Reading r) =>
        _readingStore.InsertOne(r);

        public void getAllReadings() =>
        _readingStore.Find(_ => true).ToList();

    }
}
