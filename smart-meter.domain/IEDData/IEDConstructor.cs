using smart_meter.domain.CommonDataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace smart_meter.domain.IEDData
{
    public class IEDConstructor
    {

        public static XmlElement CreateSmartMeterXML(XmlDocument xml , String name)
        {
            XmlElement rootIed = xml.CreateElement("IED");
            rootIed.SetAttribute("name", name);
            rootIed.SetAttribute("manufacturer", "smart-meter-api");
            rootIed.SetAttribute("configVersion", "1.0");
            rootIed.SetAttribute("originalSclRevision", "B");
            rootIed.SetAttribute("originalSclVersion", "2007");

            LN llno = new LN();
            llno.LNClass = "LLN0";
            llno.LNType = "LLN0_2007";
            llno.Inst = "";

            LN lphd = new LN();
            lphd.LNClass = "LPHD";
            lphd.LNType = "LPHD_TYPE";
            lphd.Inst = "1";

            LN mmxn = new LN();
            mmxn.LNClass = "MMXN";
            mmxn.LNType = "MMXN_TYPE";
            mmxn.Inst = "1";
            mmxn.Prefix = "";

            LN xswi = new LN();
            xswi.LNClass = "XSWI";
            xswi.LNType = "XSWI_TYPE";
            xswi.Inst = "1";
            xswi.Prefix = "";

            LN cswi = new LN();
            cswi.LNClass = "CSWI";
            cswi.LNType = "CSWI_TYPE";
            cswi.Inst = "1";
            cswi.Prefix = "";

            LDevice device1 = new LDevice();
            device1.LN0 = llno;
            device1.LN1 = lphd;
            device1.LN2 = mmxn;
            device1.LN3 = cswi;
            device1.LN4 = xswi;
            device1.Inst= "CTRL";

            Server s = new Server();
            s.LDevice = device1;

            AccessPoint ap = new AccessPoint();
            ap.Server = s;
            ap.Name = "AP";

            rootIed.AppendChild(ap.CreateXmlElement(xml));
            rootIed.AppendChild(Services.CreateXmlDataTypes(xml));
            

            return rootIed;
        }

    }
}
