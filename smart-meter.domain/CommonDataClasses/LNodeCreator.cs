using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class LNodeType
    {
        public string Id { get; set; }
        public string LnClass { get; set; }
        public List<DO> DOs { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement lNodeTypeElement = documentContext.CreateElement("LNodeType");
            lNodeTypeElement.SetAttribute("id", Id);
            lNodeTypeElement.SetAttribute("lnClass", LnClass);

            foreach (var DO in DOs)
            {
                lNodeTypeElement.AppendChild(DO.CreateXmlElement(documentContext));
            }

            return lNodeTypeElement;
        }
    }

    public class DO
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement doElement = documentContext.CreateElement("DO");
            doElement.SetAttribute("name", Name);
            doElement.SetAttribute("type", Type);
            return doElement;
        }
    }
}