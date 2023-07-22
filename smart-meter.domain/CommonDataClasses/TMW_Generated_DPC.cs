using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class TMW_Generated_DPC
    {
        public string StVal { get; set; }
        public string Q { get; set; }
        public string T { get; set; }
        public string CtlModel { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement doTypeElement = documentContext.CreateElement("DOType");
            doTypeElement.SetAttribute("id", "TMW_Generated_DPC");
            doTypeElement.SetAttribute("cdc", "DPC");

            // Add DA elements
            doTypeElement.AppendChild(CreateDAElement(documentContext, "stVal", "Dbpos", "ST", dchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "q", "Quality", "ST", qchg: "true"));
            doTypeElement.AppendChild(CreateDAElement(documentContext, "t", "Timestamp", "ST"));

            XmlElement ctlModelElement = documentContext.CreateElement("DA");
            ctlModelElement.SetAttribute("name", "ctlModel");
            ctlModelElement.SetAttribute("bType", "Enum");
            ctlModelElement.SetAttribute("type", "CtlModelKind");
            ctlModelElement.SetAttribute("fc", "CF");
            ctlModelElement.SetAttribute("dchg", "true");
            ctlModelElement.SetAttribute("valKind", "RO");

            XmlElement valElement = documentContext.CreateElement("Val");
            valElement.InnerText = "status-only";
            ctlModelElement.AppendChild(valElement);

            doTypeElement.AppendChild(ctlModelElement);

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
