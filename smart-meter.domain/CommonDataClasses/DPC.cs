using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class DPC
    {
       
        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "DPC");
            doTypeElement.SetAttribute("cdc", "DPC");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElement(documentContext, "stVal", "Dbpos", "ST", dchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "q", "Quality", "ST", qchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "t", "Timestamp", "ST"));
            doTypeElement.AppendChild(CreateEnumDAElement(documentContext, "ctlModel", "Enum", "CtlModelKind", "CF", dchg: "true", valKind: "RO", enumValue: "status-only"));

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

        private static XmlElement CreateEnumDAElement(XmlDocument documentContext, string name, string bType, string type, string fc, string dchg = null, string valKind = null, string enumValue = null)
        {
            XmlElement daElement = CreateDAElement(documentContext, name, bType, fc, dchg, qchg: null);

            if (!string.IsNullOrEmpty(type))
            {
                daElement.SetAttribute("type", type);
            }

            if (!string.IsNullOrEmpty(dchg))
            {
                daElement.SetAttribute("dchg", dchg);
            }

            if (!string.IsNullOrEmpty(valKind))
            {
                daElement.SetAttribute("valKind", valKind);
            }

            if (!string.IsNullOrEmpty(enumValue))
            {
                XmlElement valElement = documentContext.CreateElement("Val");
                valElement.InnerText = enumValue;
                daElement.AppendChild(valElement);
            }

            return daElement;
        }
    }
}
