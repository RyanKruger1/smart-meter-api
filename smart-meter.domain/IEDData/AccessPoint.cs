using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class AccessPoint
    {
        public string Name { get; set; }
        public Server Server { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement accessPointElement = documentContext.CreateElement("AccessPoint");
            accessPointElement.SetAttribute("name", Name);

            if (Server != null)
                accessPointElement.AppendChild(Server.CreateXmlElement(documentContext));

            return accessPointElement;
        }
    }

    public class Server
    {
        public Authentication Authentication { get; set; }
        public LDevice LDevice { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement serverElement = documentContext.CreateElement("Server");

            if (Authentication != null)
                serverElement.AppendChild(Authentication.CreateXmlElement(documentContext));

            if (LDevice != null)
                serverElement.AppendChild(LDevice.CreateXmlElement(documentContext));

            return serverElement;
        }
    }

    public class Authentication
    {
        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("Authentication");
        }
    }

    public class LDevice
    {
        public string Inst { get; set; }
        public LN LN0 { get; set; }
        public LN LN1 { get; set; }
        public LN LN2 { get; set; }
        public LN LN3 { get; set; }
        public LN LN4 { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement lDeviceElement = documentContext.CreateElement("LDevice");
            lDeviceElement.SetAttribute("inst", Inst);

            if (LN0 != null)
                lDeviceElement.AppendChild(LN0.CreateXmlElement(documentContext));

            if (LN1 != null)
                lDeviceElement.AppendChild(LN1.CreateXmlElement(documentContext));

            if (LN2 != null)
                lDeviceElement.AppendChild(LN2.CreateXmlElement(documentContext));

            if (LN3 != null)
                lDeviceElement.AppendChild(LN3.CreateXmlElement(documentContext));

            if (LN4 != null)
                lDeviceElement.AppendChild(LN4.CreateXmlElement(documentContext));

            return lDeviceElement;
        }
    }

    public class LN
    {
        public string LNType { get; set; }
        public string LNClass { get; set; }
        public string Inst { get; set; }
        public string Prefix { get; set; }

        public XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            XmlElement lnElement = documentContext.CreateElement("LN");
            lnElement.SetAttribute("lnType", LNType);
            lnElement.SetAttribute("lnClass", LNClass);
            lnElement.SetAttribute("inst", Inst);
            lnElement.SetAttribute("prefix", Prefix);
            return lnElement;
        }
    }
}
