﻿<?xml version="1.0" encoding="UTF-8"?>
<SCL revision="B" version="2007" xmlns="http://www.iec.ch/61850/2003/SCL" schemaLocation="http://www.iec.ch/61850/2003/SCL SCL.xsd" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Header id="SCL_Header" version="SCL_Header" revision="0" toolID="smart-meter-api">
    <History>
      <Hitem version="1" revision="0" when="2023/07/22 13:56:40" who="Ryan Kruger" what="Ryan Kruger" />
    </History>
  </Header>
  <Substation>
    <name>virtual smart meter substation</name>
    <desc>virtual smart meter substation</desc>
  </Substation>
  <IED name="SM1" manufacturer="smart-meter-api" configVersion="1.0" originalSclRevision="B" originalSclVersion="2007">
    <AccessPoint name="AP">
      <Server>
        <LDevice inst="CTRL">
          <LN lnType="LLN0_2007" lnClass="LLN0" inst="" prefix="" />
          <LN lnType="LPHD_TYPE" lnClass="LPHD" inst="1" prefix="" />
          <LN lnType="MMXN_TYPE" lnClass="MMXN" inst="1" prefix="" />
          <LN lnType="CSWI_TYPE" lnClass="CSWI" inst="1" prefix="" />
          <LN lnType="XSWI_TYPE" lnClass="XSWI" inst="1" prefix="" />
        </LDevice>
      </Server>
    </AccessPoint>
    <Services nameLength="64">
      <DynAssociation max="10" />
      <ConfLogControl max="10" />
      <GOOSE max="10" />
      <GetDirectory />
      <GetDataObjectDefinition />
      <DataObjectDirectory />
      <GetDataSetValue />
      <SetDataSetValue />
      <DataSetDirectory />
      <ConfDataSet modify="true" maxAttributes="50" max="50" />
      <DynDataSet max="100" maxAttributes="50" />
      <ReadWrite />
      <ConfReportControl bufConf="true" bufMode="both" max="50" />
      <GetCBValues />
      <ReportSettings rptID="Dyn" trgOps="Dyn" intgPd="Dyn" optFields="Dyn" cbName="Conf" datSet="Dyn" bufTime="Dyn" resvTms="true" owner="true" />
      <LogSettings trgOps="Dyn" intgPd="Dyn" datSet="Dyn" logEna="Dyn" />
      <GSESettings appID="Dyn" dataLabel="Dyn" datSet="Dyn" cbName="Conf" />
      <FileHandling />
      <ConfLNs fixPrefix="true" />
      <ConfLdName />
      <ConfSigRef max="100" />
    </Services>
  </IED>
  <DataTypeTemplates>
    <LNodeType id="LLN0_2007" lnClass="LLN0">
      <DO name="NamPlt" type="LPL_LD2007" />
      <DO name="Beh" type="ENS_Beh" />
      <DO name="Health" type="ENS_Health" />
      <DO name="Mod" type="ENC_Mod_direct" />
      <DO name="LocKey" type="SPS_noSVnoBL" />
      <DO name="Loc" type="SPS_noSVnoBL" />
      <DO name="LocSta" type="SPC_direct" />
      <DO name="Diag" type="SPC_direct" />
      <DO name="LEDRs" type="SPC_direct" />
      <DO name="MltLev" type="SPG_SP" />
    </LNodeType>
    <LNodeType id="LPHD_TYPE" lnClass="LPHD">
      <DO name="PhyNam" type="DPL_Full" />
      <DO name="PhyHealth" type="ENS_Health" />
      <DO name="OutOv" type="SPS_noSVnoBL" />
      <DO name="Proxy" type="SPS_noSVnoBL" />
      <DO name="InOv" type="SPS_noSVnoBL" />
      <DO name="OpTmh" type="INS_noSVnoBL" />
      <DO name="NumPwrUp" type="INS_noSVnoBL" />
      <DO name="WrmStr" type="INS_noSVnoBL" />
      <DO name="WacTrg" type="INS_noSVnoBL" />
      <DO name="PwrUp" type="SPS_noSVnoBL" />
      <DO name="PwrDn" type="SPS_noSVnoBL" />
      <DO name="PwrSupAlm" type="SPS_noSVnoBL" />
      <DO name="RsStat" type="SPC_direct" />
      <DO name="Sim" type="SPC_direct" />
    </LNodeType>
    <LNodeType id="MMXN_TYPE" lnClass="MMXN">
      <DO name="Beh" type="ENS_BehaviourModeKind" />
      <DO name="Amp" type="MV" />
      <DO name="Vol" type="MV" />
      <DO name="Watt" type="MV" />
      <DO name="PwrFact" type="MV" />
      <DO name="Hz" type="MV" />
    </LNodeType>
    <LNodeType id="CSWI_TYPE" lnClass="CSWI">
      <DO name="Beh" type="TMW_Generated_ENS_BehaviourModeKind" />
      <DO name="Pos" type="DPC" />
    </LNodeType>
    <LNodeType id="XSWI_TYPE" lnClass="XSWI">
      <DO name="Beh" type="TMW_Generated_ENS_BehaviourModeKind" />
      <DO name="Loc" type="SPS" />
      <DO name="OpCnt" type="INS" />
      <DO name="SwTyp" type="ENS_SwitchFunctionKind" />
      <DO name="Pos" type="DPC" />
      <DO name="BlkOpn" type="SPC" />
      <DO name="BlkCls" type="SPC" />
    </LNodeType>
    <DAType id="AnalogueValue">
      <BDA name="f" bType="FLOAT32" />
    </DAType>
    <DOType id="DPL_Full" cdc="DPL">
      <DA name="vendor" bType="VisString255" fc="DC">
        <Val>TMW</Val>
      </DA>
      <DA name="hwRev" bType="VisString255" fc="DC" />
      <DA name="swRev" bType="VisString255" fc="DC" />
      <DA name="serNum" bType="VisString255" fc="DC" />
      <DA name="model" bType="VisString255" fc="DC" />
      <DA name="location" bType="VisString255" fc="DC" />
      <DA name="name" bType="VisString64" fc="DC" />
      <DA name="owner" bType="VisString255" fc="DC" />
      <DA name="ePSName" bType="VisString255" fc="DC" />
      <DA name="primeOper" bType="VisString255" fc="DC" />
      <DA name="secondOper" bType="VisString255" fc="DC" />
      <DA name="latitude" bType="FLOAT32" fc="DC" />
      <DA name="longitude" bType="FLOAT32" fc="DC" />
      <DA name="altitude" bType="FLOAT32" fc="DC" />
      <DA name="mRID" bType="VisString255" fc="DC" />
      <DA name="d" bType="VisString255" fc="DC" />
      <DA name="dU" bType="Unicode255" fc="DC" />
    </DOType>
    <DOType id="ENC_Mod_direct" cdc="ENC">
      <DA name="origin" bType="Struct" fc="ST" type="Originator" />
      <DA name="stVal" bType="Enum" fc="ST" type="BehaviourModeKind" dchg="true" />
      <DA name="q" bType="Quality" fc="ST" qchg="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
      <DA name="ctlModel" bType="Enum" fc="CF" type="CtlModelKind" valKind="RO">
        <Val>direct-with-normal-security</Val>
      </DA>
      <DA name="d" bType="VisString255" fc="DC" />
      <DA name="dU" bType="Unicode255" fc="DC" />
      <DA name="Oper" bType="Struct" fc="CO" type="OperBehaviourModeKind" />
    </DOType>
    <DOType id="ENS_Beh" cdc="ENS">
      <DA name="stVal" bType="Enum" fc="ST" type="BehaviourModeKind" dchg="true" dupd="true" />
      <DA name="q" bType="Quality" fc="ST" qchg="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
      <DA name="d" bType="VisString255" fc="DC" />
      <DA name="dU" bType="Unicode255" fc="DC" />
    </DOType>
    <DOType id="ENS_Health" cdc="ENS">
      <DA name="stVal" bType="Enum" type="HealthKind" fc="ST" dchg="true" dupd="true" />
      <DA name="q" bType="Quality" fc="ST" qchg="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
      <DA name="d" bType="VisString255" fc="DC" />
      <DA name="dU" bType="Unicode255" fc="DC" />
    </DOType>
    <DOType id="ENS_BehaviourModeKind" cdc="ENS">
      <DA name="stVal" bType="Enum" type="BehaviourModeKind" fc="ST" dchg="true" dupd="true" />
      <DA name="q" bType="Quality" fc="ST" qcgh="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
    </DOType>
    <DOType id="INS" cdc="INS">
      <DA name="stVal" bType="INT32" fc="ST" dchg="true" dupd="true" />
      <DA name="q" bType="Quality" fc="ST" qchg="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
    </DOType>
    <DOType id="INS_noSVnoBL" cdc="INS">
      <DA name="stVal" bType="INT32" fc="ST" dchg="true" />
      <DA name="q" bType="Quality" fc="ST" qchg="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
      <DA name="d" bType="VisString255" fc="DC" />
      <DA name="dU" bType="Unicode255" fc="DC" />
    </DOType>
    <DOType id="LPL_LD2007" cdc="LPL">
      <DA name="vendor" bType="VisString255" fc="DC">
        <Val>TMW</Val>
      </DA>
      <DA name="swRev" bType="VisString255" fc="DC">
        <Val>1.0</Val>
      </DA>
      <DA name="d" bType="VisString255" fc="DC" />
      <DA name="dU" bType="Unicode255" fc="DC" />
      <DA name="configRev" bType="VisString255" fc="DC">
        <Val>1.0</Val>
      </DA>
      <DA name="paramRev" bType="INT32" fc="ST" dchg="true">
        <Val>0</Val>
      </DA>
      <DA name="valRev" bType="INT32" fc="ST" dchg="true">
        <Val>0</Val>
      </DA>
      <DA name="ldNs" bType="VisString255" fc="EX">
        <Val>IEC 61850-7-4:2007</Val>
      </DA>
    </DOType>
    <DOType id="MV" cdc="MV">
      <DA name="mag" bType="Struct" type="AnalogueValue" fc="MX" dchg="true" dupd="true" />
      <DA name="q" bType="Quality" type="" fc="MX" qchg="true" />
      <DA name="t" bType="Timestamp" type="" fc="MX" />
    </DOType>
    <DAType id="OperBehaviourModeKind">
      <BDA name="ctlVal" bType="Enum" type="BehaviourModeKind" />
      <BDA name="origin" bType="Struct" type="Originator" />
      <BDA name="ctlNum" bType="INT8U" />
      <BDA name="T" bType="Timestamp" />
      <BDA name="Test" bType="BOOLEAN" />
      <BDA name="Check" bType="Check" />
    </DAType>
    <DAType id="OperBool">
      <BDA name="ctlVal" bType="BOOLEAN" />
      <BDA name="origin" bType="Struct" type="Originator" />
      <BDA name="ctlNum" bType="INT8U" />
      <BDA name="T" bType="Timestamp" />
      <BDA name="Test" bType="BOOLEAN" />
      <BDA name="Check" bType="Check" />
    </DAType>
    <DAType id="Originator">
      <BDA name="orCat" bType="Enum" type="OriginatorCategoryKind" />
      <BDA name="orIdent" bType="Octet64" />
    </DAType>
    <DOType id="SPC" cdc="SPC">
      <DA name="ctlModel" bType="Enum" type="CtlModelKind" fc="CF" dchg="true" valKind="RO">
        <Val>status-only</Val>
      </DA>
    </DOType>
    <DOType id="SPC_direct" cdc="SPC">
      <DA name="origin" bType="Struct" fc="ST" type="Originator" />
      <DA name="stVal" bType="BOOLEAN" fc="ST" dchg="true" />
      <DA name="q" bType="Quality" fc="ST" qchg="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
      <DA name="ctlModel" bType="Enum" fc="CF" type="CtlModelKind" valKind="RO">
        <Val>direct-with-normal-security</Val>
      </DA>
      <DA name="d" bType="VisString255" fc="DC" />
      <DA name="dU" bType="Unicode255" fc="DC" />
      <DA name="Oper" bType="Struct" fc="CO" type="OperBool" />
    </DOType>
    <DOType id="SPG_SP" cdc="SPG">
      <DA name="setVal" bType="BOOLEAN" fc="SP" dchg="true" />
      <DA name="d" bType="VisString255" fc="DC" />
      <DA name="dU" bType="Unicode255" fc="DC" />
    </DOType>
    <DOType id="SPS" cdc="SPS">
      <DA name="stVal" bType="BOOLEAN" fc="ST" dchg="true" />
      <DA name="q" bType="Quality" fc="ST" qchg="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
    </DOType>
    <DOType id="SPS_noSVnoBL" cdc="SPS">
      <DA name="stVal" bType="INT32" fc="ST" dchg="true" />
      <DA name="q" bType="Quality" fc="ST" qchg="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
      <DA name="d" bType="VisString255" fc="DC" />
      <DA name="dU" bType="Unicode255" fc="DC" />
    </DOType>
    <DOType id="TMW_Generated_DPC" cdc="DPC">
      <DA name="stVal" bType="Dbpos" fc="ST" dchg="true" />
      <DA name="q" bType="Quality" fc="ST" qchg="true" />
      <DA name="t" bType="Timestamp" fc="ST" />
      <DA name="ctlModel" bType="Enum" type="CtlModelKind" fc="CF" dchg="true" valKind="RO">
        <Val>status-only</Val>
      </DA>
    </DOType>
    <DOType id="TMW_Generated_ENS_BehaviourModeKind" cdc="ENS">
      <DA name="stVal" bType="Enum" fc="ST" type="BehaviourModeKind" dchg="true" dupd="true" />
      <DA name="q" bType="" fc="ST" type="Quality" qchg="true" />
      <DA name="t" bType="" fc="ST" type="Timestamp" />
    </DOType>
    <EnumType id="BehaviourModeKind">
      <EnumVal ord="1">on</EnumVal>
      <EnumVal ord="2">blocked</EnumVal>
      <EnumVal ord="3">test</EnumVal>
      <EnumVal ord="4">test/blocked</EnumVal>
      <EnumVal ord="5">off</EnumVal>
    </EnumType>
    <EnumType id="CtlModelKind">
      <EnumVal ord="0">status-only</EnumVal>
      <EnumVal ord="1">direct-with-normal-security</EnumVal>
      <EnumVal ord="2">sbo-with-normal-security</EnumVal>
      <EnumVal ord="3">direct-with-enhanced-security</EnumVal>
      <EnumVal ord="4">sbo-with-enhanced-security</EnumVal>
    </EnumType>
    <EnumType id="HealthKind">
      <EnumVal ord="1">Ok</EnumVal>
      <EnumVal ord="2">Warning</EnumVal>
      <EnumVal ord="3">Alarm</EnumVal>
    </EnumType>
    <EnumType id="OriginatorCategoryKind">
      <EnumVal ord="0">not-supported</EnumVal>
      <EnumVal ord="1">bay-control</EnumVal>
      <EnumVal ord="2">station-control</EnumVal>
      <EnumVal ord="3">remote-control</EnumVal>
      <EnumVal ord="4">automatic-bay</EnumVal>
      <EnumVal ord="5">automatic-station</EnumVal>
      <EnumVal ord="6">automatic-remote</EnumVal>
      <EnumVal ord="7">maintenance</EnumVal>
      <EnumVal ord="8">process</EnumVal>
    </EnumType>
    <EnumType id="SwitchFunctionKind">
      <EnumVal ord="1">Load Break</EnumVal>
      <EnumVal ord="2">Disconnector</EnumVal>
      <EnumVal ord="3">Earthing Switch</EnumVal>
      <EnumVal ord="4">High Speed Earthing Switch</EnumVal>
    </EnumType>
  </DataTypeTemplates>
</SCL>