using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class SPS
    {
        public bool StVal { get; set; }
        public string Q { get; set; }
        public string T { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "SPS");
            doTypeElement.SetAttribute("cdc", "SPS");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElement(documentContext, "stVal", "BOOLEAN", "ST", dchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "q", "Quality", "ST", qchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "t", "Timestamp", "ST"));

            return doTypeElement;
        }

        private static XmlElement CreateDAElement(XmlDocument documentContext, string name, string bType, string fc, string dchg = null, string qchg = null)
        {
            XmlElement daElement = documentContext.CreateElement("DA");
            daElement.SetAttribute("name", name);
            daElement.SetAttribute("bType", bType);
            daElement.SetAttribute("fc", fc);

            if (!string.IsNullOrEmpty(dchg))
            {
                daElement.SetAttribute("dchg", dchg);
            }

            if (!string.IsNullOrEmpty(qchg))
            {
                daElement.SetAttribute("qchg", qchg);
            }

            return daElement;
        }
    }
}
