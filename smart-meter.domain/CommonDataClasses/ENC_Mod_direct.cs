using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class ENC_Mod_direct
    {
        // Add properties for the Originator struct
        public string OriginatorProperty1 { get; set; }
        public string OriginatorProperty2 { get; set; }
        // ...

        public string StVal { get; set; }
        public string Q { get; set; }
        public string T { get; set; }
        public string CtlModel { get; set; }
        public string D { get; set; }
        public string DU { get; set; }

        // Add properties for the OperBehaviourModeKind struct
        public string OperBehaviourModeKindProperty1 { get; set; }
        public string OperBehaviourModeKindProperty2 { get; set; }
        // ...

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "ENC_Mod_direct");
            doTypeElement.SetAttribute("cdc", "ENC");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElement(documentContext, "origin", "Struct", "Originator", "ST"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "stVal", "Enum", "BehaviourModeKind", "ST", dchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "q", "Quality",null, "ST", qchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "t", "Timestamp", null,"ST"));

            XmlElement ctlModelElement = CreateDAElement(documentContext, "ctlModel", "Enum", "CtlModelKind", "CF", valKind: "RO");
            ctlModelElement.AppendChild(CreateValueElement(documentContext, "direct-with-normal-security"));
            doTypeElement.AppendChild(ctlModelElement);

            doTypeElement.AppendChild(CreateDAElement(documentContext, "d", "VisString255",null, "DC"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "dU", "Unicode255",null, "DC"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "Oper", "Struct", "OperBehaviourModeKind", "CO"));

            return doTypeElement;
        }

        private static XmlElement CreateDAElement(XmlDocument documentContext, string name, string bType, string type, string fc, string dchg = null, string qchg = null, string valKind = null)
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

            if (!string.IsNullOrEmpty(qchg))
            {
                daElement.SetAttribute("qchg", qchg);
            }

            if (!string.IsNullOrEmpty(valKind))
            {
                daElement.SetAttribute("valKind", valKind);
            }

            return daElement;
        }

        private static XmlElement CreateValueElement(XmlDocument documentContext, string value)
        {
            XmlElement valElement = documentContext.CreateElement("Val");
            valElement.InnerText = value;
            return valElement;
        }
    }
}
