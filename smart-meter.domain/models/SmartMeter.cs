using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace smart_meter.domain.models
{
    public class SmartMeter
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public Guid? Id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
    }
}
