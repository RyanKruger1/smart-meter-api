using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class LPL_LD2007
    {
        public string Vendor { get; set; }
        public string SwRev { get; set; }
        public string D { get; set; }
        public string DU { get; set; }
        public string ConfigRev { get; set; }
        public int ParamRev { get; set; }
        public int ValRev { get; set; }
        public string LdNs { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "LPL_LD2007");
            doTypeElement.SetAttribute("cdc", "LPL");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElementWithVal(documentContext, "vendor", "VisString255", "DC", "TMW"));
            doTypeElement.AppendChild(CreateDAElementWithVal(documentContext, "swRev", "VisString255", "DC", "1.0"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "d", "VisString255", "DC"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "dU", "Unicode255", "DC"));
            doTypeElement.AppendChild(CreateDAElementWithVal(documentContext, "configRev", "VisString255", "DC", "1.0"));
            doTypeElement.AppendChild(CreateDAElementWithVal(documentContext, "paramRev", "INT32", "ST", "0", dchg: "true"));
            doTypeElement.AppendChild(CreateDAElementWithVal(documentContext, "valRev", "INT32", "ST", "0", dchg: "true"));
            doTypeElement.AppendChild(CreateDAElementWithVal(documentContext, "ldNs", "VisString255", "EX", "IEC 61850-7-4:2007"));

            return doTypeElement;
        }

        private static XmlElement CreateDAElement(XmlDocument documentContext, string name, string bType, string fc, string dchg = null)
        {
            XmlElement daElement = documentContext.CreateElement("DA");
            daElement.SetAttribute("name", name);
            daElement.SetAttribute("bType", bType);
            daElement.SetAttribute("fc", fc);

            if (!string.IsNullOrEmpty(dchg))
            {
                daElement.SetAttribute("dchg", dchg);
            }

            return daElement;
        }

        private static XmlElement CreateDAElementWithVal(XmlDocument documentContext, string name, string bType, string fc, string value, string dchg = null)
        {
            XmlElement daElement = CreateDAElement(documentContext, name, bType, fc, dchg);

            XmlElement valElement = documentContext.CreateElement("Val");
            valElement.InnerText = value;

            daElement.AppendChild(valElement);

            return daElement;
        }
    }
}
