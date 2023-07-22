using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class TMW_Generated_ENS_BehaviourModeKind
    {
        public string StVal { get; set; }
        public string Q { get; set; }
        public string T { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "TMW_Generated_ENS_BehaviourModeKind");
            doTypeElement.SetAttribute("cdc", "ENS");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElement(documentContext, "stVal", "Enum", "BehaviourModeKind", "ST", dchg: "true", dupd: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "q", "Quality",null, "ST", qchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "t", "Timestamp",null, "ST"));

            return doTypeElement;
        }

        private static XmlElement CreateDAElement(XmlDocument documentContext, string name, string bType, string type, string fc, string dchg = null, string dupd = null, string qchg = null)
        {
            XmlElement daElement = documentContext.CreateElement("DA");
            daElement.SetAttribute("name", name);
            daElement.SetAttribute("bType", bType);
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
