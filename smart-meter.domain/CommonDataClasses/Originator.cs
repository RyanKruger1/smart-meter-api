using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class Originator
    {
        public string OrCat { get; set; }
        public string OrIdent { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement daTypeElement = documentContext.CreateElement("DAType");
            daTypeElement.SetAttribute("id", "Originator");

            // Add BDA elements
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "orCat", "Enum", "OriginatorCategoryKind"));
            daTypeElement.AppendChild(CreateBDAElement(documentContext, "orIdent", "Octet64"));

            return daTypeElement;
        }

        private static XmlElement CreateBDAElement(XmlDocument documentContext, string name, string bType, string type = null)
        {
            XmlElement bdaElement = documentContext.CreateElement("BDA");
            bdaElement.SetAttribute("name", name);
            bdaElement.SetAttribute("bType", bType);

            if (!string.IsNullOrEmpty(type))
            {
                bdaElement.SetAttribute("type", type);
            }

            return bdaElement;
        }
    }
}
