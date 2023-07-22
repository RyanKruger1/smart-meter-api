using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace smart_meter.infrasturcture.FileSystem
{
    public class XMLReader
    {
        XmlDocument xml = new XmlDocument();
        public XMLReader()
        {
            xml.Load("smart-meter-xml.xml");
        }
    }
}
