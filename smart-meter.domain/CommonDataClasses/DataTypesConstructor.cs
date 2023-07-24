using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class DataTypesConstructor
    {
        public static XmlElement CreateDataTypesXML(XmlDocument doc)
        {
            XmlElement xmlDocument = doc.CreateElement("DataTypeTemplates");
            xmlDocument.AppendChild(LLN0.CreateXMLLogicalNodes(doc));
            xmlDocument.AppendChild(LPHD.CreateXMLLogicalNodes(doc));
            xmlDocument.AppendChild(MMXN.CreateXMLLogicalNodes(doc));
            xmlDocument.AppendChild(CSWI.CreateXMLLogicalNodes(doc));
            xmlDocument.AppendChild(XSWI.CreateXMLLogicalNodes(doc));

            xmlDocument.AppendChild(AnalogueValue.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(DPL_Full.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(DPC.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(ENC_Mod_direct.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(ENS_Beh.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(ENS_Health.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(ENS_BehaviourModeKind.CreateXMlDataTypes(doc));
            xmlDocument.AppendChild(ENS_SwitchFunctionKind.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(INS.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(INS_noSVnoBL.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(LPL_LD2007.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(MV.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(OperBehaviourModeKind.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(OperBool.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(Originator.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(SPC.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(SPC_direct.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(SPG_SP.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(SPS.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(SPS_noSVnoBL.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(TMW_Generated_DPC.CreateXmlDataTypes(doc));
            xmlDocument.AppendChild(TMW_Generated_ENS_BehaviourModeKind.CreateXmlDataTypes(doc));

            xmlDocument.AppendChild(CreateEnumTypeElement(doc, "BehaviourModeKind",
             ("on", 1), ("blocked", 2), ("test", 3), ("test/blocked", 4), ("off", 5)));
            xmlDocument.AppendChild(CreateEnumTypeElement(doc, "CtlModelKind",
                ("status-only", 0), ("direct-with-normal-security", 1), ("sbo-with-normal-security", 2),
                ("direct-with-enhanced-security", 3), ("sbo-with-enhanced-security", 4)));
            xmlDocument.AppendChild(CreateEnumTypeElement(doc, "HealthKind",
                ("Ok", 1), ("Warning", 2), ("Alarm", 3)));
            xmlDocument.AppendChild(CreateEnumTypeElement(doc, "OriginatorCategoryKind",
                ("not-supported", 0), ("bay-control", 1), ("station-control", 2), ("remote-control", 3),
                ("automatic-bay", 4), ("automatic-station", 5), ("automatic-remote", 6),
                ("maintenance", 7), ("process", 8)));
            xmlDocument.AppendChild(CreateEnumTypeElement(doc, "SwitchFunctionKind",
                ("Load Break", 1), ("Disconnector", 2), ("Earthing Switch", 3), ("High Speed Earthing Switch", 4)));

            return xmlDocument;
        }


        private static XmlElement CreateEnumTypeElement(XmlDocument documentContext, string id, params (string value, int ord)[] enumValues)
        {
            XmlElement enumTypeElement = documentContext.CreateElement("EnumType");
            enumTypeElement.SetAttribute("id", id);

            // Create and add EnumVal elements
            foreach (var enumValue in enumValues)
            {
                XmlElement enumValElement = documentContext.CreateElement("EnumVal");
                enumValElement.SetAttribute("ord", enumValue.ord.ToString());
                enumValElement.InnerText = enumValue.value;
                enumTypeElement.AppendChild(enumValElement);
            }

            return enumTypeElement;
        }
    }
}
