using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace smart_meter.domain.CommonDataClasses

    {
        public class DPL_Full
        {
            public string Vendor { get; set; }
            public string HwRev { get; set; }
            public string SwRev { get; set; }
            public string SerNum { get; set; }
            public string Model { get; set; }
            public string Location { get; set; }
            public string Name { get; set; }
            public string Owner { get; set; }
            public string EPSName { get; set; }
            public string PrimeOper { get; set; }
            public string SecondOper { get; set; }
            public float Latitude { get; set; }
            public float Longitude { get; set; }
            public float Altitude { get; set; }
            public string MRID { get; set; }
            public string D { get; set; }
            public string DU { get; set; }

            public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
            {
                XmlElement doTypeElement = documentContext.CreateElement("DOType");
                doTypeElement.SetAttribute("id", "DPL_Full");
                doTypeElement.SetAttribute("cdc", "DPL");

                // Add DA elements
                doTypeElement.AppendChild(CreateDAElement(documentContext, "vendor", "VisString255", "DC", "TMW"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "hwRev", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "swRev", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "serNum", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "model", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "location", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "name", "VisString64", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "owner", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "ePSName", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "primeOper", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "secondOper", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "latitude", "FLOAT32", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "longitude", "FLOAT32", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "altitude", "FLOAT32", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "mRID", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "d", "VisString255", "DC"));
                doTypeElement.AppendChild(CreateDAElement(documentContext, "dU", "Unicode255", "DC"));

                return doTypeElement;
            }

            public static XmlElement CreateDAElement(XmlDocument documentContext, string name, string bType, string fc, string val = null)
            {
                XmlElement daElement = documentContext.CreateElement("DA");
                daElement.SetAttribute("name", name);
                daElement.SetAttribute("bType", bType);
                daElement.SetAttribute("fc", fc);

                if (!string.IsNullOrEmpty(val))
                {
                    XmlElement valElement = documentContext.CreateElement("Val");
                    valElement.InnerText = val;
                    daElement.AppendChild(valElement);
                }

                return daElement;
            }
        }
    }