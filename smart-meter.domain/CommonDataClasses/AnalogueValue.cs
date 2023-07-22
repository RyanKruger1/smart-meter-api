using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class AnalogueValue
    {
        public float F { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement daTypeElement = documentContext.CreateElement("DAType");
            daTypeElement.SetAttribute("id", "AnalogueValue");

            // Add BDA element
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "f", "FLOAT32"));

            return daTypeElement;
        }

        private static XmlElement CreateBDAElement(XmlDocument documentContext, string name, string bType)
        {
            XmlElement bdaElement = documentContext.CreateElement("BDA");
            bdaElement.SetAttribute("name", name);
            bdaElement.SetAttribute("bType", bType);

            return bdaElement;
        }
    }
}
