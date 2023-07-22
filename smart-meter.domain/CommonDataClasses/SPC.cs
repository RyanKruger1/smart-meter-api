using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class SPC
    {
        public string CtlModel { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "SPC");
            doTypeElement.SetAttribute("cdc", "SPC");

            // Add DA element
            doTypeElement.AppendChild(CreateDAElement(documentContext, "ctlModel", "Enum", "CtlModelKind", "CF", dchg: "true", valKind: "RO", value: "status-only"));

            return doTypeElement;
        }

        private static XmlElement CreateDAElement(XmlDocument documentContext, string name, string bType, string type, string fc, string dchg = null, string valKind = null, string value = null)
        {
            XmlElement daElement = documentContext.CreateElement("DA");
            daElement.SetAttribute("name", name);
            daElement.SetAttribute("bType", bType);
            daElement.SetAttribute("type", type);
            daElement.SetAttribute("fc", fc);

            if (!string.IsNullOrEmpty(dchg))
            {
                daElement.SetAttribute("dchg", dchg);
            }

            if (!string.IsNullOrEmpty(valKind))
            {
                daElement.SetAttribute("valKind", valKind);
            }

            if (!string.IsNullOrEmpty(value))
            {
                XmlElement valElement = documentContext.CreateElement("Val");
                valElement.InnerText = value;
                daElement.AppendChild(valElement);
            }

            return daElement;
        }
    }
}