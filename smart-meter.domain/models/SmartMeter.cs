using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace smart_meter.domain.models
{
    public class SmartMeter
    {
        public Guid? Id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string zipCode { get; set; }
    }
}
