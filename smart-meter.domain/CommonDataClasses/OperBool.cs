using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class OperBool
    {
        public bool CtlVal { get; set; }
        public Originator Origin { get; set; }
        public byte CtlNum { get; set; }
        public string T { get; set; }
        public bool Test { get; set; }
        public string Check { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement daTypeElement = documentContext.CreateElement("DAType");
            daTypeElement.SetAttribute("id", "OperBool");

            // Add BDA elements
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "ctlVal", "BOOLEAN"));
            daTypeElement.AppendChild(CreateBDAElementWithStruct(documentContext, "origin", "Struct", "Originator"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "ctlNum", "INT8U"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "T", "Timestamp"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "Test", "BOOLEAN"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "Check", "Check", sAddr: ""));

            return daTypeElement;
        }

        private static XmlElement CreateBDAElement(XmlDocument documentContext, string name, string bType, string type = null, string sAddr = null)
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

        private static XmlElement CreateBDAElementWithStruct(XmlDocument documentContext, string name, string bType, string type)
        {
            XmlElement bdaElement = CreateBDAElement(documentContext, name, bType, type);
            return bdaElement;
        }
    }
}
