using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class OperBehaviourModeKind
    {

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement daTypeElement = documentContext.CreateElement("DAType");
            daTypeElement.SetAttribute("id", "OperBehaviourModeKind");

            // Add BDA elements
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "ctlVal", "Enum", "BehaviourModeKind"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "origin", "Struct", "Originator"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "ctlNum", "INT8U"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "T", "Timestamp"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "Test", "BOOLEAN"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "Check", "Check", sAddr: ""));

            return daTypeElement;
        }

        private static XmlElement CreateBDAElement(XmlDocument documentContext, string name, string bType, string type = "", string sAddr = "")
        {
            XmlElement bdaElement = documentContext.CreateElement("BDA");
            bdaElement.SetAttribute("name", name);
            bdaElement.SetAttribute("bType", bType);

            if (!string.IsNullOrEmpty(type))
            {
                bdaElement.SetAttribute("type", type);
            }

            if (!string.IsNullOrEmpty(sAddr))
            {
                bdaElement.SetAttribute("sAddr", sAddr);
            }

            return bdaElement;
        }
    }
}
