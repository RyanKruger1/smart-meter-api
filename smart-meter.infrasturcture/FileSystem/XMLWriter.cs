using smart_meter.domain.CommonDataClasses;
using smart_meter.domain.IEDData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace smart_meter.infrasturcture.FileSystem
{
    public class XMLWriter
    {

        XmlDocument xml = new XmlDocument();

        public XMLWriter()
        {
         
        }

        public void saveDocument()
        {
           
            XmlNamespaceManager nsManager = new XmlNamespaceManager(xml.NameTable);
            nsManager.AddNamespace("scl", "http://www.iec.ch/61850/2003/SCL");

            // Create the XML declaration
            XmlDeclaration xmlDeclaration = xml.CreateXmlDeclaration("1.0", "UTF-8", null);
            xml.AppendChild(xmlDeclaration);

            // Create the root element
            XmlElement rootElement = xml.CreateElement("SCL");
            rootElement.SetAttribute("revision", "B");
            rootElement.SetAttribute("version", "2007");
            rootElement.SetAttribute("xmlns", "http://www.iec.ch/61850/2003/SCL");
            rootElement.SetAttribute("xsi:schemaLocation", "http://www.iec.ch/61850/2003/SCL SCL.xsd");
            rootElement.SetAttribute("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance");
            rootElement.SetAttribute("xmlns:xsd", "http://www.w3.org/2001/XMLSchema");
            
            xml.AppendChild(rootElement);

            // Create child elements and add them to the root element
            XmlElement header = xml.CreateElement("Header");
            header.SetAttribute("id", "SCL_Header");
            header.SetAttribute("version", "SCL_Header");
            header.SetAttribute("revision", "0");
            header.SetAttribute("toolID", "smart-meter-api");
            header.AppendChild(generateHistory());
            rootElement.AppendChild(header);

            XmlElement substationElement = xml.CreateElement("Substation");
            XmlElement sName = xml.CreateElement("name");
            sName.InnerText = "virtual smart meter substation";

            XmlElement sDesc = xml.CreateElement("desc");
            sDesc.InnerText = "virtual smart meter substation";

            substationElement.AppendChild(sName);
            substationElement.AppendChild(sDesc);
            rootElement.AppendChild(substationElement);

            rootElement.AppendChild(IEDConstructor.CreateSmartMeterXML(xml,"SM1"));
            rootElement.AppendChild(DataTypesConstructor.CreateDataTypesXML(xml));

           
            xml.Save("../virtual-substation.scd");
        }

        public XmlElement createSmartMeter(String name)
        {


            return null;
        }

        public XmlElement generateHistory()
        {
            XmlElement historyElement = xml.CreateElement("History");
            XmlElement hiItem = xml.CreateElement("Hitem");
            hiItem.SetAttribute("version","1");
            hiItem.SetAttribute("revision", "0");
            hiItem.SetAttribute("when", DateTime.Now.ToString());
            hiItem.SetAttribute("who", "Ryan Kruger");
            hiItem.SetAttribute("what", "Ryan Kruger");
            historyElement.AppendChild(hiItem);

            return historyElement;
        }

    }
}
