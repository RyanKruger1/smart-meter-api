using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.domain.models
{
    public class Reading
    {
        public int Id { get; set; }
        public Guid smartMeterId { get; set; }
        public DateTime readingTime { get; set; }
        public double voltage { get; set; }
        public double current { get; set; }
        public double power { get; set; }
        public double powerFactor { get; set; }
    }
}
