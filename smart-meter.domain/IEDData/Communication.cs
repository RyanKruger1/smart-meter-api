using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class Communication
    {
        public SubNetwork SubNetwork { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement communicationElement = documentContext.CreateElement("Communication");

            if (SubNetwork != null)
                communicationElement.AppendChild(SubNetwork.CreateXmlElement(documentContext));

            return communicationElement;
        }
    }

    public class SubNetwork
    {
        public string Name { get; set; }
        public ConnectedAP ConnectedAP { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement subNetworkElement = documentContext.CreateElement("SubNetwork");
            subNetworkElement.SetAttribute("name", Name);

            if (ConnectedAP != null)
                subNetworkElement.AppendChild(ConnectedAP.CreateXmlElement(documentContext));

            return subNetworkElement;
        }
    }

    public class ConnectedAP
    {
        public string ApName { get; set; }
        public string IedName { get; set; }
        public Address Address { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement connectedAPElement = documentContext.CreateElement("ConnectedAP");
            connectedAPElement.SetAttribute("apName", ApName);
            connectedAPElement.SetAttribute("iedName", IedName);

            if (Address != null)
                connectedAPElement.AppendChild(Address.CreateXmlElement(documentContext));

            return connectedAPElement;
        }
    }

    public class Address
    {
        public string PTypeOSIAPTitle { get; set; }
        public string PTypeOSIAEQualifier { get; set; }
        public string PTypeOSIPSEL { get; set; }
        public string PTypeOSISSEL { get; set; }
        public string PTypeOSITSEL { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement addressElement = documentContext.CreateElement("Address");

            addressElement.AppendChild(CreatePElement(documentContext, "OSI-AP-Title", PTypeOSIAPTitle));
            addressElement.AppendChild(CreatePElement(documentContext, "OSI-AE-Qualifier", PTypeOSIAEQualifier));
            addressElement.AppendChild(CreatePElement(documentContext, "OSI-PSEL", PTypeOSIPSEL));
            addressElement.AppendChild(CreatePElement(documentContext, "OSI-SSEL", PTypeOSISSEL));
            addressElement.AppendChild(CreatePElement(documentContext, "OSI-TSEL", PTypeOSITSEL));

            return addressElement;
        }

        private static XmlElement CreatePElement(XmlDocument documentContext, string type, string value)
        {
            XmlElement pElement = documentContext.CreateElement("P");
            pElement.SetAttribute("type", type);
            pElement.InnerText = value;
            return pElement;
        }
    }
}
