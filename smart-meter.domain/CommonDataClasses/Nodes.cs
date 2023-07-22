using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class MMXN
    {
        public static XmlElement CreateXMLLogicalNodes(XmlDocument xmlDocument)
        {
            //MMXU
            LNodeType mmxn = new LNodeType();
            mmxn.LnClass = "MMXN";
            mmxn.Id = "MMXN_TYPE";
            mmxn.DOs = new List<DO>(){
                new DO{ Name= "Beh", Type = "ENS_BehaviourModeKind"},
                new DO{ Name= "Amp", Type = "MV"},
                new DO{ Name= "Vol", Type = "MV"},
                new DO{ Name= "Watt", Type = "MV"},
                new DO{ Name= "PwrFact", Type = "MV"},
                new DO{ Name= "Hz", Type = "MV"}
            };

            return mmxn.CreateXmlElement(xmlDocument);
        }
    }

    public class XSWI
    {
        public static XmlElement CreateXMLLogicalNodes(XmlDocument xmlDocument)
        {
            //MMXU
            LNodeType xswi = new LNodeType();
            xswi.LnClass = "XSWI";
            xswi.Id = "XSWI_TYPE";
            xswi.DOs = new List<DO>(){
                new DO{ Name= "Beh", Type = "TMW_Generated_ENS_BehaviourModeKind"},
                new DO{ Name= "Loc", Type = "SPS"},
                new DO{ Name= "OpCnt", Type = "INS"},
                new DO{ Name= "SwTyp", Type = "ENS_SwitchFunctionKind"},
                new DO{ Name= "Pos", Type = "DPC"},
                new DO{ Name= "BlkOpn", Type = "SPC"},
                new DO{ Name= "BlkCls", Type = "SPC"}

            };

            return xswi.CreateXmlElement(xmlDocument);
        }
    }

    public class CSWI
    {
        public static XmlElement CreateXMLLogicalNodes(XmlDocument xmlDocument)
        {
            //MMXU
            LNodeType cswi = new LNodeType();
            cswi.LnClass = "CSWI";
            cswi.Id = "CSWI_TYPE";
            cswi.DOs = new List<DO>(){
                new DO{ Name= "Beh", Type = "TMW_Generated_ENS_BehaviourModeKind"},
                new DO{ Name= "Pos", Type = "DPC"},
            };

            return cswi.CreateXmlElement(xmlDocument);
        }
    }

    public class LLN0
    {
        public static XmlElement CreateXMLLogicalNodes(XmlDocument xmlDocument)
        {
            
            LNodeType llno = new LNodeType();
            llno.LnClass = "LLN0";
            llno.Id = "LLN0_2007";
            llno.DOs = new List<DO>(){
                new DO{ Name= "NamPlt", Type = "LPL_LD2007"},
                new DO{ Name= "Beh", Type = "ENS_Beh"},
                new DO{ Name= "Health", Type = "ENS_Health"},
                new DO{ Name= "Mod", Type = "ENC_Mod_direct"},
                new DO{ Name= "LocKey", Type = "SPS_noSVnoBL"},
                new DO{ Name= "Loc", Type = "SPS_noSVnoBL"},
                new DO{ Name= "LocSta", Type = "SPC_direct"},
                new DO{ Name= "Diag", Type = "SPC_direct"},
                new DO{ Name= "LEDRs", Type = "SPC_direct"},
                new DO{ Name= "MltLev", Type = "SPG_SP"},
            };

            return llno.CreateXmlElement(xmlDocument);
        }
    }

    public class LPHD
    {
        public static XmlElement CreateXMLLogicalNodes(XmlDocument xmlDocument)
        {
            
            LNodeType lphd = new LNodeType();
            lphd.LnClass = "LPHD";
            lphd.Id = "LPHD_TYPE";
            lphd.DOs = new List<DO>(){
                new DO{ Name= "PhyNam", Type = "DPL_Full"},
                new DO{ Name= "PhyHealth", Type = "ENS_Health"},
                new DO{ Name= "OutOv", Type = "SPS_noSVnoBL"},
                new DO{ Name= "Proxy", Type = "SPS_noSVnoBL"},
                new DO{ Name= "InOv", Type = "SPS_noSVnoBL"},
                new DO{ Name= "OpTmh", Type = "INS_noSVnoBL"},
                new DO{ Name= "NumPwrUp", Type = "INS_noSVnoBL"},
                new DO{ Name= "WrmStr", Type = "INS_noSVnoBL"},
                new DO{ Name= "WacTrg", Type = "INS_noSVnoBL"},
                new DO{ Name= "PwrUp", Type = "SPS_noSVnoBL"},
                new DO{ Name= "PwrDn", Type = "SPS_noSVnoBL"},
                new DO{ Name= "PwrSupAlm", Type = "SPS_noSVnoBL"},
                new DO{ Name= "RsStat", Type = "SPC_direct"},
                new DO{ Name= "Sim", Type = "SPC_direct"}
            };

            return lphd.CreateXmlElement(xmlDocument);
        }
    }
}
