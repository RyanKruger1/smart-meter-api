using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class MV
    {

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "MV");
            doTypeElement.SetAttribute("cdc", "MV");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElement(documentContext, "mag", "Struct", "AnalogueValue", "MX", dchg: "true", dupd: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "q", "Quality",null, "MX", qchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "t", "Timestamp",null, "MX"));

            return doTypeElement;
        }

        private static XmlElement CreateDAElement(XmlDocument documentContext, string name, string bType, string type, string fc, string dchg = null, string dupd = null, string qchg = null)
        {
            XmlElement daElement = documentContext.CreateElement("DA");
            daElement.SetAttribute("name", name);
            daElement.SetAttribute("bType", bType);
            daElement.SetAttribute("type", type);
            daElement.SetAttribute("fc", fc);

            if (!string.IsNullOrEmpty(type))
            {
                daElement.SetAttribute("type", type);
            }

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