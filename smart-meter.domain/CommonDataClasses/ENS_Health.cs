using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class ENS_Health
    {
        public string StVal { get; set; }
        public string Q { get; set; }
        public string T { get; set; }
        public string D { get; set; }
        public string DU { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "ENS_Health");
            doTypeElement.SetAttribute("cdc", "ENS");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElement(documentContext, "stVal", "Enum", "HealthKind", "ST", dchg: "true", dupd: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "q", "Quality", null, "ST", qchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "t", "Timestamp", null, "ST"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "d", "VisString255", null, "DC"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "dU", "Unicode255", null, "DC"));

            return doTypeElement;
        }

        private static XmlElement CreateDAElement(XmlDocument documentContext, string name, string bType, string type, string fc, string dchg = null, string dupd = null, string qchg = null)
        {
            XmlElement daElement = documentContext.CreateElement("DA");
            daElement.SetAttribute("name", name);
            daElement.SetAttribute("bType", bType);

            if (!string.IsNullOrEmpty(type))
            {
                daElement.SetAttribute("type", type);
            }

            daElement.SetAttribute("fc", fc);

            if (!string.IsNullOrEmpty(dchg))
            {
                daElement.SetAttribute("dchg", dchg);
            }

            if (!string.IsNullOrEmpty(dupd))
            {
                daElement.SetAttribute("dupd", dupd);
            }

            if (!string.IsNullOrEmpty(qchg))
            {
                daElement.SetAttribute("qchg", qchg);
            }

            return daElement;
        }
    }
}
