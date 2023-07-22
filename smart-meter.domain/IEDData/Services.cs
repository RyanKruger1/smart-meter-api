using System.Xml;

namespace smart_meter.domain.CommonDataClasses
{
    public class Services
    {
        public int NameLength { get; set; }
        public DynAssociation DynAssociation { get; set; }
        public ConfLogControl ConfLogControl { get; set; }
        public GOOSE GOOSE { get; set; }
        public GetDirectory GetDirectory { get; set; }
        public GetDataObjectDefinition GetDataObjectDefinition { get; set; }
        public DataObjectDirectory DataObjectDirectory { get; set; }
        public GetDataSetValue GetDataSetValue { get; set; }
        public SetDataSetValue SetDataSetValue { get; set; }
        public DataSetDirectory DataSetDirectory { get; set; }
        public ConfDataSet ConfDataSet { get; set; }
        public DynDataSet DynDataSet { get; set; }
        public ReadWrite ReadWrite { get; set; }
        public ConfReportControl ConfReportControl { get; set; }
        public GetCBValues GetCBValues { get; set; }
        public ReportSettings ReportSettings { get; set; }
        public LogSettings LogSettings { get; set; }
        public GSESettings GSESettings { get; set; }
        public FileHandling FileHandling { get; set; }
        public ConfLNs ConfLNs { get; set; }
        public ConfLdName ConfLdName { get; set; }
        public ConfSigRef ConfSigRef { get; set; }

        public static XmlElement CreateXmlDataTypes(XmlDocument documentContext)
        {
            XmlElement servicesElement = documentContext.CreateElement("Services");
            servicesElement.SetAttribute("nameLength", "64");

            servicesElement.AppendChild(DynAssociation.CreateXmlElement(documentContext, max: "10"));
            servicesElement.AppendChild(ConfLogControl.CreateXmlElement(documentContext, max: "10"));
            servicesElement.AppendChild(GOOSE.CreateXmlElement(documentContext, max: "10"));
            servicesElement.AppendChild(GetDirectory.CreateXmlElement(documentContext));
            servicesElement.AppendChild(GetDataObjectDefinition.CreateXmlElement(documentContext));
            servicesElement.AppendChild(DataObjectDirectory.CreateXmlElement(documentContext));
            servicesElement.AppendChild(GetDataSetValue.CreateXmlElement(documentContext));
            servicesElement.AppendChild(SetDataSetValue.CreateXmlElement(documentContext));
            servicesElement.AppendChild(DataSetDirectory.CreateXmlElement(documentContext));
            servicesElement.AppendChild(ConfDataSet.CreateXmlElement(documentContext, modify: "true", maxAttributes: "50", max: "50"));
            servicesElement.AppendChild(DynDataSet.CreateXmlElement(documentContext, max: "100", maxAttributes: "50"));
            servicesElement.AppendChild(ReadWrite.CreateXmlElement(documentContext));
            servicesElement.AppendChild(ConfReportControl.CreateXmlElement(documentContext, bufConf: "true", bufMode: "both", max: "50"));
            servicesElement.AppendChild(GetCBValues.CreateXmlElement(documentContext));
            servicesElement.AppendChild(ReportSettings.CreateXmlElement(documentContext, "Dyn", trgOps: "Dyn", intgPd: "Dyn", optFields: "Dyn", cbName: "Conf", "Dyn", bufTime: "Dyn", resvTms: "true", owner: "true"));
            servicesElement.AppendChild(LogSettings.CreateXmlElement(documentContext, trgOps: "Dyn",  "Dyn", "Dyn", "Dyn"));
            servicesElement.AppendChild(GSESettings.CreateXmlElement(documentContext,  "Dyn", dataLabel: "Dyn", "Dyn", cbName: "Conf"));
            servicesElement.AppendChild(FileHandling.CreateXmlElement(documentContext));
            servicesElement.AppendChild(ConfLNs.CreateXmlElement(documentContext, "true"));
            servicesElement.AppendChild(ConfLdName.CreateXmlElement(documentContext));
            servicesElement.AppendChild(ConfSigRef.CreateXmlElement(documentContext, max: "100"));

            return servicesElement;
        }
    }

    // Define classes for each sub-element
    public class DynAssociation
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext, string max)
        {
            XmlElement dynAssociationElement = documentContext.CreateElement("DynAssociation");
            dynAssociationElement.SetAttribute("max", max);
            return dynAssociationElement;
        }
    }

    public class ConfLogControl
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext, string max)
        {
            XmlElement confLogControlElement = documentContext.CreateElement("ConfLogControl");
            confLogControlElement.SetAttribute("max", max);
            return confLogControlElement;
        }
    }

    public class GOOSE
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext, string max)
        {
            XmlElement gooseElement = documentContext.CreateElement("GOOSE");
            gooseElement.SetAttribute("max", max);
            return gooseElement;
        }
    }

    public class GetDirectory
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("GetDirectory");
        }
    }

    public class GetDataObjectDefinition
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("GetDataObjectDefinition");
        }
    }

    public class DataObjectDirectory
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("DataObjectDirectory");
        }
    }

    public class GetDataSetValue
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("GetDataSetValue");
        }
    }

    public class SetDataSetValue
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("SetDataSetValue");
        }
    }

    public class DataSetDirectory
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("DataSetDirectory");
        }
    }

    public class ConfDataSet
    {
 

        public static XmlElement CreateXmlElement(XmlDocument documentContext , String modify , String maxAttributes , String max)
        {
            XmlElement confDataSetElement = documentContext.CreateElement("ConfDataSet");
            confDataSetElement.SetAttribute("modify", modify);
            confDataSetElement.SetAttribute("maxAttributes", maxAttributes);
            confDataSetElement.SetAttribute("max", max);
            return confDataSetElement;
        }
    }

    public class DynDataSet
    {
      

        public static XmlElement CreateXmlElement(XmlDocument documentContext, String max, String maxAttributes)
        {
            XmlElement dynDataSetElement = documentContext.CreateElement("DynDataSet");
            dynDataSetElement.SetAttribute("max", max);
            dynDataSetElement.SetAttribute("maxAttributes", maxAttributes);
            return dynDataSetElement;
        }
    }

    public class ReadWrite
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("ReadWrite");
        }
    }

    public class ConfReportControl
    {
     
        public static XmlElement CreateXmlElement(XmlDocument documentContext ,String bufConf , String bufMode ,String  max)
        {
            XmlElement confReportControlElement = documentContext.CreateElement("ConfReportControl");
            confReportControlElement.SetAttribute("bufConf", bufConf);
            confReportControlElement.SetAttribute("bufMode", bufMode);
            confReportControlElement.SetAttribute("max", max);
            return confReportControlElement;
        }
    }

    public class GetCBValues
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("GetCBValues");
        }
    }

    public class ReportSettings
    {
    
        public static XmlElement CreateXmlElement(XmlDocument documentContext,
            String rptId,
            String trgOps,
            String intgPd,
            String optFields,
            String cbName,
            String dataSet,
            String bufTime,
            String resvTms,
            String owner
            )
        {
            XmlElement reportSettingsElement = documentContext.CreateElement("ReportSettings");
            reportSettingsElement.SetAttribute("rptID", rptId);
            reportSettingsElement.SetAttribute("trgOps", trgOps);
            reportSettingsElement.SetAttribute("intgPd", intgPd);
            reportSettingsElement.SetAttribute("optFields", optFields);
            reportSettingsElement.SetAttribute("cbName", cbName);
            reportSettingsElement.SetAttribute("datSet", dataSet);
            reportSettingsElement.SetAttribute("bufTime", bufTime);
            reportSettingsElement.SetAttribute("resvTms", resvTms);
            reportSettingsElement.SetAttribute("owner", owner);
            return reportSettingsElement;
        }
    }

    public class LogSettings
    {
       
        public static XmlElement CreateXmlElement(XmlDocument documentContext, String trgOps, String intPd, String dataset, String log)
        {
            XmlElement logSettingsElement = documentContext.CreateElement("LogSettings");
            logSettingsElement.SetAttribute("trgOps", trgOps);
            logSettingsElement.SetAttribute("intgPd", intPd);
            logSettingsElement.SetAttribute("datSet", dataset);
            logSettingsElement.SetAttribute("logEna", log);
            return logSettingsElement;
        }
    }

    public class GSESettings
    {
      
        public static XmlElement CreateXmlElement(XmlDocument documentContext, String appId , String dataLabel, String dataSet, String cbName)
        {
            XmlElement gseSettingsElement = documentContext.CreateElement("GSESettings");
            gseSettingsElement.SetAttribute("appID", appId);
            gseSettingsElement.SetAttribute("dataLabel", dataLabel);
            gseSettingsElement.SetAttribute("datSet", dataSet);
            gseSettingsElement.SetAttribute("cbName", cbName);
            return gseSettingsElement;
        }
    }

    public class FileHandling
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("FileHandling");
        }
    }

    public class ConfLNs
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext, String fixPreFix)
        {
            XmlElement confLNsElement = documentContext.CreateElement("ConfLNs");
            confLNsElement.SetAttribute("fixPrefix", fixPreFix);
            return confLNsElement;
        }
    }

    public class ConfLdName
    {
        public static XmlElement CreateXmlElement(XmlDocument documentContext)
        {
            return documentContext.CreateElement("ConfLdName");
        }
    }

    public class ConfSigRef
    {
       
        public static XmlElement CreateXmlElement(XmlDocument documentContext, String max)
        {
            XmlElement confSigRefElement = documentContext.CreateElement("ConfSigRef");
            confSigRefElement.SetAttribute("max", max);
            return confSigRefElement;
        }
    }

   
}

    // Continue defining classes for the rest of the sub-elements..