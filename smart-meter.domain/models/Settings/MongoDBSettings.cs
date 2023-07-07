using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smart_meter.domain.models.Settings
{
    public class MongoDBSettings
    {

        public String ConnectionString {get ;set;}

        public String DatabaseName {get ;set;}

        public String SmartMeterCollectionName { get; set; }

        public String ReadingsCollectionName { get; set; }
    }
}
