using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class SPC_direct
    {
        // Add properties for the Originator struct
        public string OriginatorProperty1 { get; set; }
        public string OriginatorProperty2 { get; set; }
        // ...

        public bool StVal { get; set; }
        public string Q { get; set; }
        public string T { get; set; }
        public string CtlModel { get; set; }
        public string D { get; set; }
        public string DU { get; set; }

        // Add properties for the OperBool struct
        public bool OperBoolProperty1 { get; set; }
        public bool OperBoolProperty2 { get; set; }
        // ...

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "SPC_direct");
            doTypeElement.SetAttribute("cdc", "SPC");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElement(documentContext, "origin", "Struct", "Originator", "ST"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "stVal", "BOOLEAN",null, "ST", dchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "q", "Quality", null,"ST", qchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "t", "Timestamp",null, "ST"));

            XmlElement ctlModelElement = CreateDAElement(documentContext, "ctlModel", "Enum", "CtlModelKind", "CF", valKind: "RO");
            ctlModelElement.AppendChild(CreateValueElement(documentContext, "direct-with-normal-security"));
            doTypeElement.AppendChild(ctlModelElement);

            doTypeElement.AppendChild(CreateDAElement(documentContext, "d", "VisString255", null, "DC"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "dU", "Unicode255", null, "DC"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "Oper", "Struct", "OperBool", "CO"));

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
