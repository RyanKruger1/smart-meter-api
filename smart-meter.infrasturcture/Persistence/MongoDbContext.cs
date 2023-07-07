using Microsoft.Extensions.Options;
using MongoDB.Driver;
using smart_meter.domain.models;
using smart_meter.domain.models.Settings;

namespace smart_meter.Infrastructure
{
    public class MongoDbContext
    {
        public readonly IMongoCollection<SmartMeter> smartMeterCollection;
        public readonly IMongoCollection<Reading> readingsCollection;


        public MongoDbContext(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            smartMeterCollection = database.GetCollection<SmartMeter>(mongoDBSettings.Value.SmartMeterCollectionName);
            readingsCollection = database.GetCollection<Reading>(mongoDBSettings.Value.ReadingsCollectionName);
        }
    }
}
