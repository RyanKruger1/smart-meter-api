using Microsoft.Extensions.Options;
using MongoDB.Driver;
using smart_meter.domain.Interfaces;
using smart_meter.domain.models;
using smart_meter.domain.models.Settings;

namespace smart_meter.infrasturcture.Persistence.Repositories
{
    
    public class SmartMeterRepository : ISmartMeterRepository
    {

        public readonly IMongoCollection<SmartMeter> _meterStore;

        public SmartMeterRepository(
    IOptions<MongoDBSettings> testDataSettings)
        {
            var mongoClient = new MongoClient(
                testDataSettings.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                testDataSettings.Value.DatabaseName);

            _meterStore = mongoDatabase.GetCollection<SmartMeter>(
                testDataSettings.Value.SmartMeterCollectionName);
        }


        public SmartMeter getSmartMeter(Guid environment) =>
        _meterStore.Find(x => x.Id == environment).FirstOrDefault();

        public IList<SmartMeter> getSmartMeters() =>
         _meterStore.Find(_ => true).ToList();

        public void createSmartMeter(SmartMeter smartMeter) =>
        _meterStore.InsertOneAsync(smartMeter);

        public void updateSmartMeter(SmartMeter smartMeter) =>
        _meterStore.ReplaceOne(x => x.Id == smartMeter.Id, smartMeter);

        public void deleteSmartMeter(Guid id) =>
       _meterStore.DeleteOne(x => x.Id == id);
    }
}