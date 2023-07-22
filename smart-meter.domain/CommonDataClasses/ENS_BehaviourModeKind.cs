using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class ENS_BehaviourModeKind
    {

        public static XmlElement CreateXMlDataTypes(XmlDocument documentContext)
        {
            XmlElement behElement = documentContext.CreateElement("DOType");
            behElement.SetAttribute("id", "ENS_BehaviourModeKind");
            behElement.SetAttribute("cdc", "ENS");

            XmlElement beh = documentContext.CreateElement("DA");
            beh.SetAttribute("name", "stVal");
            beh.SetAttribute("bType", "Enum");
            beh.SetAttribute("type", "BehaviourModeKind");
            beh.SetAttribute("fc", "ST");
            beh.SetAttribute("dchg", "true");
            beh.SetAttribute("dupd", "true");

            XmlElement q = documentContext.CreateElement("DA");
            q.SetAttribute("name", "q");
            q.SetAttribute("bType", "Quality");
            q.SetAttribute("fc", "ST");
            q.SetAttribute("qcgh", "true");

            XmlElement t = documentContext.CreateElement("DA");
            t.SetAttribute("name", "t");
            t.SetAttribute("bType", "Timestamp");
            t.SetAttribute("fc", "ST");

            behElement.AppendChild(beh);
            behElement.AppendChild(q);
            behElement.AppendChild(t);

            return behElement;
        }

    }
}