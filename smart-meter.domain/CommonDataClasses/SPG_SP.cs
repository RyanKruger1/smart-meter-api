using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class SPG_SP
    {
        public bool SetVal { get; set; }
        public string D { get; set; }
        public string DU { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "SPG_SP");
            doTypeElement.SetAttribute("cdc", "SPG");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElement(documentContext, "setVal", "BOOLEAN", "SP", dchg: "true"));

            // The remaining elements don't have a value attribute, so they won't have <Val> elements.
            doTypeElement.AppendChild(CreateDAElement(documentContext, "d", "VisString255", "DC"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "dU", "Unicode255", "DC"));

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
    }
}