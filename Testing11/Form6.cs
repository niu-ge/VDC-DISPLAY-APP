using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Testing11
{
    public partial class Form6 : Form
    {
        public static string sValues = "";
        string[] toDbNameArray;
        public Form6(string[] sValue)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.backButton.Visible = false;
            this.Refresh();
            dateLabel.Text = "Date:" + System.DateTime.Now.ToString();
            DataSet panelDS = Form1.panelDS;
            projectLabel.Text = Form8.projectName;
            iTextSharp.text.Image[] imageArray = new iTextSharp.text.Image[sValue.Length];
           Document doc = new Document(PageSize.A3);
               PdfWriter.GetInstance(doc, new FileStream(Form4.sLocation, FileMode.Create));
             doc.Open();
                for (int i2 = 0; i2 < sValue.Length; i2++)
                {
                int rows;
                    int column;
                    string mainSwitchBoard = "";
                    string circuitID = "";
                    string toDbName = "";
                    string destinatedLocation = "";
                    string from = "";
                    string connectedLoad = "";
                    string maxDemandKVA = "";
                    string maxDemandKW = "";
                    string load = "";
                    string breakerSetting = "";
                    string breakerAF = "";
                    string breakerAT = "";
                    string phase = "";
                    string voltage = "";
                    string cableType = "";
                    string cableNo = "";
                    string cableSize = "";
                    string cableEarth = "";
                    string cableEarth2 = "";
                    string cableMethod = "";
                    string cableLength = "";
                    string cableRating = "";
                    string current = "";
                    string cableSet = "";
                    string core = "";
                    string armour = "";
                    string ca = "";
                    string cg = "";
                    string ci = "";
                    string deratingFactors = "";
                    string zValues = "";
                    string deratedCurrent = "";
                    string voltageDrop = "";
                    string voltageDropPercentage = "";
                    string allowVDPercentage = "";
                string circuitBreakerType = "";


                string voltageDropText="";
        string voltageDropPercentageText = "";
        string allowVDPercentageText = "";

        string cableSetText = "";
        string cableTypeText = "";
        string cableMethodText = "";
                string cableSizeText = "";
                string coreArrayText = "";
                string cableEarth2ArrayText = "";
        Double n;
        sValues = sValue[i2];
                projectLabel.Text = Form8.projectName;
                selectedLabel.Text = "SELECTED PANEL: " + sValue[i2];
                    /*//mainSwitchBoard = getData("Main Switchboard");
                    //circuitID = getData("Circuit ID");
                    toDbName = getData("To: DB Name");
                    destinatedLocation = getData("Destination Location");
                    from = getData("From");
                    //connectedLoad = getData("Connected Load, CL (KVA)");
                    //maxDemandKVA = getData("Maximum Demand, MD (KVA)");
                    //maxDemandKW = getData("Maximum Demand, MD  (KW)");
                    //load = getData("Load (A)");
                    //breakerSetting = getData("Breaker Setting (AF/AT)");
                    //breakerAF = getData("Breaker Setting (AF)");
                    //breakerAT = getData("Breaker Setting (AT)");
                    //phase = getData("No of Phase(3/1)");
                    //voltage = getData("Voltage (V)");
                    cableType = getData("Cable Type");
                    cableNo = getData("Cable No");
                    cableSize = getData("Cable Size");
                    cableEarth = getData("Cable #Earth");
                    cableEarth2 = getData("Cable Earth");
                    cableMethod = getData("Method of Installation of Cables");
                    cableLength = getData("Length (m)");
                    cableRating = getData("Rating");
                    //current = getData("Current Capacity (A)");
                    cableSet = getData("Cable Set");
                    //core = getData("Core");
                    //armour = getData("Armour (A/NA)");
                    ca = getData("Ca");
                    cg = getData("Cg");
                    ci = getData("Ci");
                    deratingFactors = getData("Derating Factors");
                    //zValues = getData("Z Values (mV/A/m)");
                    deratedCurrent = getData("Current Capacity' (A)");
                    voltageDrop = getData("VD (V)");
                    voltageDropPercentage = getData("VD (%)");
                    allowVDPercentage = getData("Allowable Voltage Drop");*/
                    startDbLabel.Text = sValues;
                    string rowAtList = "";
                    for (int k = 0; k < Form1.panelDS.Tables[0].Columns.Count; k++)
                    {
                        if (Form1.panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "From")
                        {
                            for (int o = 1; o < Form1.panelDS.Tables[0].Rows.Count; o++)
                            {
                                if (Form1.panelDS.Tables[0].Rows[o].ItemArray[k].ToString() == sValue[i2])
                                {
                                    rowAtList += o.ToString() + ",";
                                }
                            }
                            rowAtList = rowAtList.TrimEnd(',');
                        }
                    }
                    string[] rowAt = rowAtList.Split(',');
                    for (int g = 0; g < rowAt.Length; g++)
                    {
                        for (int k = 0; k < panelDS.Tables[0].Columns.Count; k++)
                        {
                            if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Main Switchboard")
                            {
                                mainSwitchBoard = mainSwitchBoard + panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Circuit ID")
                            {
                                circuitID += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "To: DB Name")
                            {
                                toDbName += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Destination Location")
                            {
                                destinatedLocation += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "From")
                            {
                                from += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Connected Load, CL (KVA)")
                            {
                                connectedLoad += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Maximum Demand, MD (KVA)")
                            {
                                maxDemandKVA += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Maximum Demand, MD  (KW)")
                            {
                                maxDemandKW += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Load (A)")
                            {
                                load += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Breaker Setting (AF/AT)")
                            {

                                breakerSetting += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Breaker Setting (AF)")
                            {

                                breakerAF += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Breaker Setting (AT)")
                            {

                                breakerAT += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "No of Phase(3/1)")
                            {

                                phase += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Voltage (V)")
                            {

                                voltage += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable Type")
                            {

                                cableType += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable No")
                            {

                                cableNo += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable Size")
                            {

                                cableSize += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable #Earth")
                            {

                                cableEarth += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable Earth")
                            {

                                cableEarth2 += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Method of Installation of Cables")
                            {

                                cableMethod += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Length (m)")
                            {

                                cableLength += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Rating")
                            {

                                cableRating += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Current Capacity (A)")
                            {

                                current += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable Set")
                            {

                                cableSet += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Core")
                            {

                                core += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Armour (A/NA)")
                            {

                                armour += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Ca")
                            {

                                ca += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cg")
                            {
                                cg += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Ci")
                            {

                                ci += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Derating Factors")
                            {
                                deratingFactors += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Z Values (mV/A/m)")
                            {

                                zValues += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Current Capacity' (A)")
                            {

                                deratedCurrent += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "VD (V)")
                            {

                                voltageDrop += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "VD (%)")
                            {
                                voltageDropPercentage += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                            else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Allowable Voltage Drop")
                            {

                                allowVDPercentage += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                            }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Circuit Breaker Type (ACB/RCCB/MSB/MCCB)")
                        {

                            circuitBreakerType += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";

                        }
                        else
                            {

                            }
                        }
                    }
                if (circuitID != "")
                {
                    circuitID = circuitID.Remove(circuitID.Length - 1);
                }
                if (toDbName != "")
                {
                    toDbName = toDbName.Remove(toDbName.Length - 1);
                }
                if (destinatedLocation != "")
                {
                    destinatedLocation = destinatedLocation.Remove(destinatedLocation.Length - 1);
                }
                if (from != "")
                {
                    from = from.Remove(from.Length - 1);
                }
                if (connectedLoad != "")
                {
                    connectedLoad = connectedLoad.Remove(connectedLoad.Length - 1);
                }
                if (maxDemandKVA != "")
                {
                    maxDemandKVA = maxDemandKVA.Remove(maxDemandKVA.Length - 1);
                }
                if (maxDemandKW != "")
                {
                    maxDemandKW = maxDemandKW.Remove(maxDemandKW.Length - 1);
                }
                if (load != "")
                {
                    load = load.Remove(load.Length - 1);
                }
                if (breakerSetting != "")
                {
                    breakerSetting = breakerSetting.Remove(breakerSetting.Length - 1);
                }
                if (breakerAF != "")
                {
                    breakerAF = breakerAF.Remove(breakerAF.Length - 1);
                }
                if (breakerAT != "")
                {
                    breakerAT = breakerAT.Remove(breakerAT.Length - 1);
                }
                if (phase != "")
                {
                    phase = phase.Remove(phase.Length - 1);
                }
                if (voltage != "")
                {
                    voltage = voltage.Remove(voltage.Length - 1);
                }
                if (cableType != "")
                {
                    cableType = cableType.Remove(cableType.Length - 1);
                }
                if (cableNo != "") { cableNo = cableNo.Remove(cableNo.Length - 1); }
                if (cableSize != "") { cableSize = cableSize.Remove(cableSize.Length - 1); }
                if (cableEarth != "") cableEarth = cableEarth.Remove(cableEarth.Length - 1);
                if (cableEarth2 != "") cableEarth2 = cableEarth2.Remove(cableEarth2.Length - 1);
                if (cableMethod != "") cableMethod = cableMethod.Remove(cableMethod.Length - 1);
                if (cableLength != "") cableLength = cableLength.Remove(cableLength.Length - 1);
                if (cableRating != "") cableRating = cableRating.Remove(cableRating.Length - 1);
                if (current != "") current = current.Remove(current.Length - 1);
                if (cableSet != "") cableSet = cableSet.Remove(cableSet.Length - 1);
                if (core != "") core = core.Remove(core.Length - 1);
                if (armour != "") armour = armour.Remove(armour.Length - 1);
                if (ca != "") ca = ca.Remove(ca.Length - 1);
                if (cg != "") cg = cg.Remove(cg.Length - 1);
                if (ci != "") ci = ci.Remove(ci.Length - 1);
                if (deratingFactors != "") deratingFactors = deratingFactors.Remove(deratingFactors.Length - 1);
                if (zValues != "") zValues = zValues.Remove(zValues.Length - 1);
                if (deratedCurrent != "") deratedCurrent = deratedCurrent.Remove(deratedCurrent.Length - 1);
                if (voltageDrop != "") voltageDrop = voltageDrop.Remove(voltageDrop.Length - 1);
                if (voltageDropPercentage != "") voltageDropPercentage = voltageDropPercentage.Remove(voltageDropPercentage.Length - 1);
                if (allowVDPercentage != "") allowVDPercentage = allowVDPercentage.Remove(allowVDPercentage.Length - 1);
                if (circuitBreakerType != "") circuitBreakerType = circuitBreakerType.Remove(circuitBreakerType.Length - 1);

                String all = mainSwitchBoard + "|" + circuitID + "|" + toDbName + "|" + destinatedLocation + "|" + from + "|" + connectedLoad + "|" +
            maxDemandKVA + "|" + maxDemandKW + "|" + load + "|" + breakerSetting + "|" + breakerAF + "|" + breakerAT + "|" + maxDemandKW +
        phase + "|" + voltage + "|" + cableType + "|" + cableNo + "|" + cableSize + "|" + cableEarth + "|" + cableEarth2 + "|" + cableMethod
            + "|" + cableLength + "|" + cableRating + "|" + current + "|" + cableSet + "|" + core + "|" + armour + "|" + ca + "|" + cg + "|" + ci + "|" +
            deratingFactors + "|" + zValues + "|" + deratedCurrent + "|" + voltageDrop + "|" + voltageDropPercentage + "|" + allowVDPercentage;
                    //MessageBox.Show(all);

                    //   string[] mainSwitchBoardArray = mainSwitchBoard.Split('|');
                    //  string[] circuitIDArray = circuitID.Split('|');
                    toDbNameArray = toDbName.Split('|');
                    string[] destinatedLocationArray = destinatedLocation.Split('|');
                    string[] fromArray = from.Split('|');
                    //  string[] connectedLoadArray = connectedLoad.Split('|');
                    // string[] maxDemandKVAArray = maxDemandKVA.Split('|');
                    // string[] maxDemandKWArray = maxDemandKW.Split('|');
                    // string[] loadArray = load.Split('|');
                    // string[] breakerSettingArray = breakerSetting.Split('|');
                    // string[] breakerAFArray = breakerAF.Split('|');
                     string[] breakerATArray = breakerAT.Split('|');
                    //string[] phaseArray = phase.Split('|');
                    //string[] voltageArray = voltage.Split('|');
                    // string[] currentArray = current.Split('|');
                    string[] coreArray = core.Split('|');
                    // string[] armourArray = armour.Split('|');
                    string[] caArray = ca.Split('|');
                    string[] cgArray = cg.Split('|');
                    string[] ciArray = ci.Split('|');
                    // string[] deratingFactorsArray = deratingFactors.Split('|');
                    //string[] zValuesArray = zValues.Split('|');
                    // string[] deratedCurrentArray = deratedCurrent.Split('|');
                    string[] voltageDropArray = voltageDrop.Split('|');
                    string[] voltageDropPercentageArray = voltageDropPercentage.Split('|');
                    string[] allowVDPercentageArray = allowVDPercentage.Split('|');



                    string[] cableTypeArray = cableType.Split('|');
                    string[] cableNoArray = cableNo.Split('|');
                    string[] cableSizeArray = cableSize.Split('|');
                    string[] cableEarthArray = cableEarth.Split('|');
                    string[] cableEarth2Array = cableEarth2.Split('|');
                    string[] cableMethodArray = cableMethod.Split('|');
                    string[] cableRatingArray = cableRating.Split('|');
                    string[] cableLengthArray = cableLength.Split('|');
                    string[] cableSetArray = cableSet.Split('|');
                     string[] circuitBreakerTypeArray= circuitBreakerType.Split('|');

                    string result;

                if (cableSetArray[0] != "")
                {
                    cableSetText = cableSetArray[0] + " ";
                }
                else
                {
                    cableSetText = "N/A";
                }
                if (cableTypeArray[0] != "")
                {
                    cableTypeText = cableTypeArray[0] + " ";
                }
                else
                {
                    cableTypeText = "N/A";
                }
                if (cableMethodArray[0] != "")
                {
                    cableMethodText = cableMethodArray[0] + " ";
                }
                else
                {
                    cableMethodText = "N/A";
                }
                string cableLengthText;
                Double n2;
                if (cableLengthArray[0] != "")
                {
                    Boolean tryParseResult = Double.TryParse(cableLengthArray[0], out n2);
                    if (tryParseResult == true)
                    {
                        cableLengthText = "Length: " + cableLengthArray[0] + "m";
                    }
                    else
                    {
                        cableLengthText = "N/A";
                    }
                }
                else
                {
                    cableLengthText = "N/A";
                }
                string x;
                if (coreArray[0].ToString() == "SC")
                {
                    x = "4";
                }
                else if (coreArray[0].ToString() == "MC")
                {
                    x = "3";
                }
                else
                {
                    x = "N/A";
                }
                if (cableSizeArray[0] != "")
                {
                    cableSizeText = cableSizeArray[0];
                }
                else
                {
                    cableSizeText = "N/A";
                }
                if (coreArray[0] != "")
                {
                    coreArrayText = coreArray[0];
                }
                else
                {
                    coreArrayText = "N/A";
                }
                if (cableEarth2Array[0] != "")
                {
                    cableEarth2ArrayText = cableEarth2Array[0];
                }
                else
                {
                    cableEarth2ArrayText = "N/A";
                }
                TypeOfCableInfo.Text = cableSetText + "x" + x + "x" + cableSizeText + "sq.mm," + coreArrayText + "/LSOH/XLPE/" + cableTypeText + "," + cableEarth2ArrayText + "sq.mm CPC";

                if (circuitBreakerType != "") {
                    if (circuitBreakerTypeArray[0] == "ACB")
                    {
                        panel1.BackgroundImage = Properties.Resources.childPanelAB;
                    }
                    else if (circuitBreakerTypeArray[0] == "RCCB")
                    {
                        panel1.BackgroundImage = Properties.Resources.childPanelRCCB;
                    }
                    else
                    {
                        panel1.BackgroundImage = Properties.Resources.childPanelv2;
                    }
                }
                else
                {
                    panel1.BackgroundImage = Properties.Resources.childPanelv2;
                }
                //TypeOfCableInfo.Text = cableSetArray[0] + "x" + x + "x" + cableSizeArray[0] + "sq.mm," + coreArray[0] + "/LSOH/XLPE/" + cableTypeArray[0] + "," + cableEarth2Array[0] + "sq.mm CPC";
                LengthOfCableLabel.Text = cableMethodText + "," + cableLengthText;
                if (toDbNameArray[0] != "")
                    {
                        dLabel.Text = toDbNameArray[0];
                    }
                    else
                    {
                        dLabel.Text = "Undefined Destination";
                    }
                     dLabel.Font = new System.Drawing.Font(dLabel.Font, FontStyle.Bold);
                atLabel.Text = breakerATArray[0]+"AT";
                    Double t;
                    Boolean VDPtoDouble = false;
                    Boolean AVDPtoDouble = false;

                    if (voltageDropPercentageArray[0] != "" && allowVDPercentageArray[0] != "")
                    {
                        VDPtoDouble = Double.TryParse(voltageDropPercentageArray[0].Remove(voltageDropPercentageArray[0].Length - 1), out t);
                        AVDPtoDouble = Double.TryParse(allowVDPercentageArray[0].Remove(allowVDPercentageArray[0].Length - 1), out t);
                    }
                    if(VDPtoDouble == true && AVDPtoDouble == true)
                    {
                        if (voltageDropPercentageArray[0] != "null" && allowVDPercentageArray[0] != "null")
                        {
                           // MessageBox.Show("1:"+Convert.ToDouble(voltageDropPercentageArray[0].Remove(voltageDropPercentageArray[0].Length - 1)).ToString());
                            //MessageBox.Show("2:"+Convert.ToDouble(allowVDPercentageArray[0].Remove(allowVDPercentageArray[0].Length - 1)).ToString());
                            if (Convert.ToDouble(voltageDropPercentageArray[0].Remove(voltageDropPercentageArray[0].Length - 1)) <= Convert.ToDouble(allowVDPercentageArray[0].Remove(allowVDPercentageArray[0].Length - 1)))
                            {
                                result = "Passed";
                                sideInformation.ForeColor = System.Drawing.Color.Blue;
                            }
                            else
                            {
                                result = "Failed";
                                sideInformation.ForeColor = System.Drawing.Color.Red;
                            }
                        }
                        else
                        {
                            result = "Unable to calculate result due to lack of information";
                            sideInformation.ForeColor = System.Drawing.Color.Black;
                        }
                    }
                    else
                    {
                        result = "Unable to calculate result due to lack of information";
                        sideInformation.ForeColor = System.Drawing.Color.Black;
                    }
                    if (voltageDropArray[0] != "")
                    {
                        voltageDropText = voltageDropArray[0] + "V";
                    }
                    else
                    {
                        voltageDropText = "N/A";
                    }
                    if (voltageDropPercentageArray[0] != "")
                    {
                        voltageDropPercentageText = voltageDropPercentageArray[0];
                    }
                    else
                    {
                        voltageDropPercentageText = "N/A";
                    }
                    if (allowVDPercentageArray[0] != "")
                    {
                        allowVDPercentageText = allowVDPercentageArray[0];
                    }
                    else
                    {
                        allowVDPercentageText = "N/A";
                    }

                    sideInformation.Text = "Voltage Drop =" + voltageDropText + "\n" + "Voltage Drop(%) =" + voltageDropPercentageText + "\n Allowable Voltage Drop(%) =" + allowVDPercentageText + "\nResult = " + result;
                dateLabel.Text = "DATE:" + System.DateTime.Now.ToString();
                this.Update();
                    this.Show();
                    if (toDbNameArray.Length == 1)
                    {
                    try
                    {
                        backButton.Visible = false;
                        Bitmap bmp1 = new Bitmap(this.panel2.Width, this.panel2.Height);
                        float ratio;
                        float a3Height = PageSize.A3.Height;
                        ratio = this.panel2.Height / a3Height;
                        int ratioUp = (int)Math.Ceiling(ratio);
                        System.Drawing.Image[] imageArrayCut = new System.Drawing.Image[ratioUp];
                        this.panel2.DrawToBitmap(bmp1, new System.Drawing.Rectangle(0, 0, this.panel2.Width, this.panel2.Height));
                        System.Drawing.Image image = bmp1;
                        for (int y = 0; y < imageArrayCut.Length; y++)
                        {
                            System.Drawing.Rectangle rect2 = new System.Drawing.Rectangle(new Point(0, 1100 * y), new Size(800, 1100));
                            Bitmap cutBM = CropImage(bmp1, rect2);
                            System.Drawing.Image cutImage = cutBM;
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(cutBM,
                                             System.Drawing.Imaging.ImageFormat.Png);
                            imageArrayCut[y] = cutBM;

                            doc.Add(iTextSharp.text.Image.GetInstance(imageArrayCut[y],
                                             System.Drawing.Imaging.ImageFormat.Png));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("PDF Error=" + ex.Message);
                    }
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                    this.Refresh();
                }
                if (toDbNameArray.Length != 1)
                {
                    for (int i = 1; i < toDbNameArray.Length; i++)
                    {

                        FontFamily family = new FontFamily("Microsoft Sans Serif");
                        System.Drawing.Font font = new System.Drawing.Font(family, 6.75f);
                        System.Drawing.Font font2 = new System.Drawing.Font(family, 6.25f);
                        System.Drawing.Font font3 = new System.Drawing.Font(family, 6.5f);
                        Panel p = new Panel();
                        mainTable.RowCount++;
                        mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                        mainTable.Controls.Add(p, 0, i);
                        mainTable.RowStyles[i].Height = 83;
                        p.Width = 622;
                        p.Height = 72;
                        p.BackColor = Color.Transparent;
                        if (circuitBreakerType != "")
                        {
                            if (circuitBreakerTypeArray[i] == "ACB")
                            {
                                p.BackgroundImage = Properties.Resources.childPanelAB;
                            }
                            else if (circuitBreakerTypeArray[i] == "RCCB")
                            {
                                p.BackgroundImage = Properties.Resources.childPanelRCCB;
                            }
                            else
                            {
                                p.BackgroundImage = Properties.Resources.childPanelv2;
                            }
                        }
                        else
                        {
                            p.BackgroundImage = Properties.Resources.childPanelv2;
                        }
                        Label label1 = new Label();
                        if (cableSetArray[i] != "")
                        {
                            cableSetText = cableSetArray[i] + " ";
                        }
                        else
                        {
                            cableSetText = "N/A";
                        }
                        if (cableTypeArray[i] != "")
                        {
                            cableTypeText = cableTypeArray[i] + " ";
                        }
                        else
                        {
                            cableTypeText = "N/A";
                        }
                        if (cableMethodArray[i] != "")
                        {
                            cableMethodText = cableMethodArray[i] + " ";
                        }
                        else
                        {
                            cableMethodText = "N/A";
                        }
                        string cableLengthText2;
                        Double n3;
                        if (cableLengthArray[i] != "")
                        {
                            Boolean tryParseResult = Double.TryParse(cableLengthArray[i], out n3);
                            if (tryParseResult == true)
                            {
                                cableLengthText2 = "Length: " + cableLengthArray[i] + "m";
                            }
                            else
                            {
                                cableLengthText2 = "N/A";
                            }
                        }
                        else
                        {
                            cableLengthText2 = "N/A";
                        }
                        string x2;
                        if (coreArray[i] == "SC")
                        {
                            x2 = "4";
                        }
                        else if (coreArray[i] == "MC")
                        {
                            x2 = "1";
                        }
                        else
                        {
                            x2 = "N/A";
                        }
                        if (cableSizeArray[i] != "")
                        {
                            cableSizeText = cableSizeArray[i];
                        }
                        else
                        {
                            cableSizeText = "N/A";
                        }
                        if (coreArray[i] != "")
                        {
                            coreArrayText = coreArray[i];
                        }
                        else
                        {
                            coreArrayText = "N/A";
                        }
                        if (cableEarth2Array[i] != "")
                        {
                            cableEarth2ArrayText = cableEarth2Array[i];
                        }
                        else
                        {
                            cableEarth2ArrayText = "N/A";
                        }
                        label1.Text = cableSetText + "x" + x2 + "x" + cableSizeText + "sq.mm," + coreArrayText + "/LSOH/XLPE/" + cableTypeText + "," + cableEarth2ArrayText + "sq.mm CPC";
                        label1.Location = new Point(69, -1);
                        label1.Width = 259;
                        label1.Height = 40;
                        label1.Font = font3;
                        label1.TextAlign = ContentAlignment.BottomLeft;
                        Label label5 = new Label();
                        label5.AutoSize = false;
                        label5.Location = new Point(3, -8);
                        label5.Width = 62;
                        label5.Height = 27;
                        label5.TextAlign = ContentAlignment.MiddleCenter;
                        label5.Font = font3;
                        label5.Text = breakerATArray[i] + " AT";
                        Label label2 = new Label();
                        label2.Location = new Point(69, 50);
                        label2.Font = font3;
                        label2.Width = 237;
                        label2.Height = 25;
                        label2.Text = cableMethodText + ", " + cableLengthText2;
                        /*  if (cableLengthArray[i] != "")
                          {
                              Boolean tryParseResult = Double.TryParse(cableLengthArray[i], out n);
                              if (tryParseResult == true)
                              {
                                  label2.Text = "Length: " + cableLengthArray[i] + "m";
                              }
                              else
                              {
                                  label2.Text = cableLengthArray[i] + " ";
                              }
                          }
                          else
                          {
                              label2.Text = "Undefined Cable Length";
                          }*/
                        Label label3 = new Label();
                        Double t2;
                        Boolean VDPtoDouble2 = false;
                        Boolean AVDPtoDouble2 = false;

                        if (voltageDropPercentageArray[i] != "" && allowVDPercentageArray[i] != "")
                        {
                            VDPtoDouble2 = Double.TryParse(voltageDropPercentageArray[i].Remove(voltageDropPercentageArray[i].Length - 1), out t2);
                            AVDPtoDouble2 = Double.TryParse(allowVDPercentageArray[i].Remove(allowVDPercentageArray[i].Length - 1), out t2);
                        }
                        if (VDPtoDouble2 == true && AVDPtoDouble2 == true)
                        {
                            if (voltageDropPercentageArray[i] != "" && allowVDPercentageArray[i] != "")
                            {
                                if (Convert.ToDouble(voltageDropPercentageArray[i].Remove(voltageDropPercentageArray[i].Length - 1)) <= Convert.ToDouble(allowVDPercentageArray[i].Remove(allowVDPercentageArray[i].Length - 1)))
                                {
                                    result = "Passed";
                                    label3.ForeColor = System.Drawing.Color.Blue;
                                }
                                else
                                {
                                    result = "Failed";
                                    label3.ForeColor = System.Drawing.Color.Red;
                                }
                            }
                            else
                            {
                                result = "Lack of information";
                                label3.ForeColor = System.Drawing.Color.Black;
                            }
                        }
                        else
                        {
                            result = "Lack of information";
                            label3.ForeColor = System.Drawing.Color.Black;
                        }
                        if (voltageDropArray[i] != "")
                        {
                            voltageDropText = voltageDropArray[i] + "V";
                        }
                        else
                        {
                            voltageDropText = "N/A";
                        }
                        if (voltageDropPercentageArray[i] != "")
                        {
                            voltageDropPercentageText = voltageDropPercentageArray[i];
                        }
                        else
                        {
                            voltageDropPercentageText = "N/A";
                        }
                        if (allowVDPercentageArray[i] != "")
                        {
                            allowVDPercentageText = allowVDPercentageArray[i];
                        }
                        else
                        {
                            allowVDPercentageText = "N/A";
                        }
                        label3.Text = "Voltage Drop =" + voltageDropText + "\n" + "Voltage Drop(%) =" + voltageDropPercentageText + "\nAllowable Voltage Drop(%) =" + allowVDPercentageText + "\nResult = " + result;
                        label3.Location = new Point(396, 18);
                        label3.AutoSize = true;
                        label3.Font = font2;
                        Label label4 = new Label();
                        label4.Text = toDbNameArray[i];
                        label4.Font = new System.Drawing.Font(dLabel.Font, FontStyle.Bold);
                        label4.AutoSize = true;
                        label4.Location = new Point(398, 3);
                        p.Controls.Add(label1);
                        p.Controls.Add(label2);
                        p.Controls.Add(label3);
                        p.Controls.Add(label4);
                        p.Controls.Add(label5);
                    }
                    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    this.backButton.Visible = false;
                    this.Refresh();
                    try
                    {
                        Bitmap bmp1 = new Bitmap(this.panel2.Width, this.panel2.Height);
                        float ratio;
                        float a3Height = PageSize.A3.Height;
                        ratio = this.panel2.Height / a3Height;
                        int ratioUp = (int)Math.Ceiling(ratio);
                        System.Drawing.Image[] imageArrayCut = new System.Drawing.Image[ratioUp];
                        this.panel2.DrawToBitmap(bmp1, new System.Drawing.Rectangle(0, 0, this.panel2.Width, this.panel2.Height));
                        System.Drawing.Image image = bmp1;
                        for (int y = 0; y < imageArrayCut.Length; y++)
                        {
                            System.Drawing.Rectangle rect2 = new System.Drawing.Rectangle(new Point(0, 1100 * y), new Size(800, 1100));
                            Bitmap cutBM = CropImage(bmp1, rect2);
                            System.Drawing.Image cutImage = cutBM;
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(cutBM,
                                             System.Drawing.Imaging.ImageFormat.Png);
                            imageArrayCut[y] = cutBM;

                            doc.Add(iTextSharp.text.Image.GetInstance(imageArrayCut[y],
                                             System.Drawing.Imaging.ImageFormat.Png));
                        }
                        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
                        this.Refresh();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("PDF Error=" + ex.Message);
                    }
                    }
                  
                    selectedLabel.Text = "";
                    startDbLabel.Text = "";
                    TypeOfCableInfo.Text = "";
                    LengthOfCableLabel.Text = "";
                    sideInformation.Text = "";
                    dLabel.Text = "";
                    this.Controls.Clear();
                    this.InitializeComponent();

                }
            MessageBox.Show(sValue.Length + " Panel(s) captured, and saved on location : " + Form4.sLocation + ", successfully!");
            doc.Close();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.backButton.Visible = true;
            this.Refresh();
        }
        public static void toMultiplePDF()
        {
          
        }
        public static String getData(String columnName)
        {
            string toDbNameBlock = "";
            string conn;
            conn = ("Provider=Microsoft.ACE.OLEDB.12.0;" +
            ("Data Source=" + Form1.fileName + ";" +
            "Extended Properties=\"Excel 12.0;\""));
            OleDbConnection con = new OleDbConnection(conn);
            OleDbDataReader dr;
            string sql = " Select [" + columnName + "] from ["+Form1.firstSheetName+"] WHERE [FROM] ='" + sValues + "'";
            OleDbCommand cmd;
            try
            {
                con.Open();
                cmd = new OleDbCommand(sql, con);
                dr = cmd.ExecuteReader();
                var dataSet = GetDataSetFromExcelFile(Form1.fileName);
                while (dr.Read())
                {
                    if (dr.GetValue(0).ToString() != "")
                    {
                        toDbNameBlock += dr.GetValue(0).ToString() + "|";
                    }else if(dr.GetValue(0).ToString() == ""){
                        toDbNameBlock += "null" + "|";
                    }
                }
                toDbNameBlock = toDbNameBlock.Remove(toDbNameBlock.Length - 1);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(columnName + ": " + ex.Message);
            }
            return toDbNameBlock;
        }
        //  public System.Windows.Forms.TextBox AddNewTable(){
        //    System.Windows.Forms.TableLayoutPanel tble = new System.Windows.Forms.TableLayoutPanel();
        //}
        private static DataSet GetDataSetFromExcelFile(string file)
        {
            DataSet ds = new DataSet();

            string connectionString = GetConnectionString(file);

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                // Get all Sheets in Excel File
                DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

                // Loop through all Sheets to get data
                foreach (DataRow dr in dtSheet.Rows)
                {
                    string sheetName = dr["TABLE_NAME"].ToString();

                    if (!sheetName.EndsWith("$"))
                        continue;

                    // Get all rows from the Sheet
                    cmd.CommandText = "SELECT * FROM [" + sheetName + "]";

                    DataTable dt = new DataTable();
                    dt.TableName = sheetName;

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    da.Fill(dt);

                    ds.Tables.Add(dt);
                }

                cmd = null;
                conn.Close();
            }

            return ds;
        }
        private static string GetConnectionString(string file)
        {
            Dictionary<string, string> props = new Dictionary<string, string>();

            string extension = file.Split('.').Last();

            if (extension == "xls")
            {
                //Excel 2003 and Older
                props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
                props["Extended Properties"] = "Excel 8.0";
            }
            else if (extension == "xlsx")
            {
                //Excel 2007, 2010, 2012, 2013
                props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
                props["Extended Properties"] = "'Excel 12.0 XML;HDR=YES;IMEX=1'";
            }
            else
                throw new Exception(string.Format("error file: {0}", file));

            props["Data Source"] = file;

            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> prop in props)
            {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }
        private void mainPanel_Scroll(object sender, ScrollEventArgs e)
        {
            mainTable.Refresh();
        }

        private void mainTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TypeOfCableInfo_Click(object sender, EventArgs e)
        {

        }

            public Bitmap CropImage(Bitmap source, System.Drawing.Rectangle section)
            {
                var bitmap = new Bitmap(section.Width, section.Height);
                using (var g = Graphics.FromImage(bitmap))
                {
                    g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);
                    return bitmap;
                }
            }
            private void LengthOfCableLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4(Form1.from);
            f4.Show();
        }

        public void exportarPDF(iTextSharp.text.Image[] imgArray, string sLocation,int no)
        {
            try
            {
                // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                //System.Drawing.Image image = img;  //Here I passed a bitmap
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(sLocation, FileMode.Create));
                doc.Open();
                //iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,System.Drawing.Imaging.ImageFormat.Png);
                for (int i = 0; i < no; i++)
                {
                    doc.Add(imgArray[i]);
                }
                doc.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.Filter = "PDF File|*.pdf;";
                SaveFileDialog1.ShowDialog();
                String sLocation;
                sLocation = SaveFileDialog1.FileName;
                string ImagePath = string.Format(sLocation, DateTime.Now.Ticks);
                if (toDbNameArray.Length <= 6)
                {
                    iTextSharp.text.Image[] imageArray = new iTextSharp.text.Image[1];
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.AutoScrollPosition = new Point(0, 0);
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[0] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    exportarPDF(imageArray, sLocation, imageArray.Length);
                }
                else if (toDbNameArray.Length > 6 && toDbNameArray.Length <= 12)
                {
                    iTextSharp.text.Image[] imageArray = new iTextSharp.text.Image[2];
                    this.AutoScrollPosition = new Point(0, 0);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[0] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[1] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    exportarPDF(imageArray, sLocation, imageArray.Length);
                }
                else if (toDbNameArray.Length > 12 && toDbNameArray.Length <= 18)
                {
                    iTextSharp.text.Image[] imageArray = new iTextSharp.text.Image[3];
                    this.AutoScrollPosition = new Point(0, 0);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[0] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[1] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600 * 2);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[2] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    exportarPDF(imageArray, sLocation, imageArray.Length);
                }
                else if (toDbNameArray.Length > 18 && toDbNameArray.Length <= 24)
                {
                    iTextSharp.text.Image[] imageArray = new iTextSharp.text.Image[4];
                    this.AutoScrollPosition = new Point(0, 0);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[0] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[1] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600 * 2);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[2] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600 * 3);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[3] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    exportarPDF(imageArray, sLocation, imageArray.Length);
                }
                else if (toDbNameArray.Length > 24 && toDbNameArray.Length <= 30)
                {
                    iTextSharp.text.Image[] imageArray = new iTextSharp.text.Image[5];
                    this.AutoScrollPosition = new Point(0, 0);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[0] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[1] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600 * 2);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[2] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600 * 3);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[3] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    this.AutoScrollPosition = new Point(0, 600 * 4);
                    using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                    {
                        this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                        try
                        {

                            // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                            System.Drawing.Image image = bmp;  //Here I passed a bitmap
                            iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                    System.Drawing.Imaging.ImageFormat.Png);
                            imageArray[4] = pdfImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    exportarPDF(imageArray, sLocation, imageArray.Length);
                }
                else
                {
                    MessageBox.Show("PDF capture only supports up to '30' children panels for each selected panel.");
                }
                MessageBox.Show("PDF Save Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void dLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
