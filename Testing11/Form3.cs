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
    public partial class Form3 : Form
    {
        public static string[] circuitIDArray;
       public static string[] toDbNameArray;
        public static string[] destinatedLocationArray;
        public static string[] fromArray;
        public static string[] connectedLoadArray;
        public static string[] maxDemandKVAArray;
        public static string[] maxDemandKWArray;
        public static string[] loadArray;
        public static string[] breakerSettingArray;
        public static string[] breakerAFArray;
        public static string[] breakerATArray;
        public static string[] phaseArray;
        public static string[] voltageArray;
        public static string[] cableTypeArray;
        public static string[] cableNoArray;
        public static string[] cableSizeArray;
        public static string[] cableEarthArray;
        public static string[] cableEarth2Array;
        public static string[] cableMethodArray;
        public static string[] cableLengthArray;
        public static string[] cableRatingArray;
        public static string[] currentArray;
        public static string[] cableSetArray;
        public static string[] coreArray;
        public static string[] armourArray;
        public static string[] caArray;
        public static string[] cgArray;
        public static string[] ciArray;
        public static string[] deratingFactorsArray;
        public static string[] zValuesArray;
        public static string[] deratedCurrentArray;
        public static string[] voltageDropArray;
        public static string[] voltageDropPercentageArray;
        public static string[] allowVDPercentageArray;
        public static string[] circuitBreakerTypeArray;



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
        public static string sValues = "";


        string voltageDropText;
        string voltageDropPercentageText;
        string allowVDPercentageText;

        string cableSetText;
        string cableTypeText;
        string cableMethodText;
        string cableSizeText;
        string coreArrayText;
        string cableEarth2ArrayText;
        Double n;

        public Form3(string sValue)
        {
            InitializeComponent();
            DataSet panelDS = Form1.panelDS;
            sValues = sValue;
            selectedLabel.Text = "SELECTED PANEL: " + sValue;
            projectLabel.Text = Form8.projectName;
            startDbLabel.Text = sValues;
            dateLabel.Text = "Date: "+ System.DateTime.Now.ToString();
            string rowAtList = "";
            for (int k = 0; k < Form1.panelDS.Tables[0].Columns.Count; k++)
            {
                if (Form1.panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "From")
                {
                    for (int o = 1; o < Form1.panelDS.Tables[0].Rows.Count; o++)
                    {
                        if (Form1.panelDS.Tables[0].Rows[o].ItemArray[k].ToString() == sValue) {
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
                        /*mainSwitchBoard = mainSwitchBoard + panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + ",";*/
                    } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Circuit ID") {
                        circuitID += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                    } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "To: DB Name") {
                        toDbName += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                    } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Destination Location")
                    {
                        destinatedLocation += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                    } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "From")
                    {
                        from += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                    } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Connected Load, CL (KVA)")
                    {
                        connectedLoad += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                    } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Maximum Demand, MD (KVA)")
                    {
                        maxDemandKVA += panelDS.Tables[0].Rows[Convert.ToInt32(rowAt[g])].ItemArray[k].ToString() + "|";
                    } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Maximum Demand, MD  (KW)")
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
            //mainSwitchBoard = mainSwitchBoard.Remove(mainSwitchBoard.Length - 1);
            if (circuitID != "") {
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
            if (cableType != "") {
                cableType = cableType.Remove(cableType.Length - 1); }
            if (cableNo != "") { cableNo = cableNo.Remove(cableNo.Length - 1); }
            if(cableSize!=""){ cableSize = cableSize.Remove(cableSize.Length - 1); }
            if(cableEarth!="")cableEarth = cableEarth.Remove(cableEarth.Length - 1);
            if(cableEarth2!="")cableEarth2 = cableEarth2.Remove(cableEarth2.Length - 1);
            if(cableMethod!="")cableMethod = cableMethod.Remove(cableMethod.Length - 1);
            if(cableLength!="")cableLength = cableLength.Remove(cableLength.Length - 1);
            if (cableRating!= "") cableRating = cableRating.Remove(cableRating.Length - 1);
            if(current!="")current = current.Remove(current.Length - 1);
            if(cableSet!="")cableSet = cableSet.Remove(cableSet.Length - 1);
            if(core!="")core = core.Remove(core.Length - 1);
            if(armour!="")armour = armour.Remove(armour.Length - 1);
            if(ca!="")ca = ca.Remove(ca.Length - 1);
            if(cg!="")cg = cg.Remove(cg.Length - 1);
            if(ci!="")ci = ci.Remove(ci.Length - 1);
            if(deratingFactors!="")deratingFactors = deratingFactors.Remove(deratingFactors.Length - 1);
            if (zValues!="") zValues = zValues.Remove(zValues.Length - 1);
            if(deratedCurrent!="")deratedCurrent = deratedCurrent.Remove(deratedCurrent.Length - 1);
            if(voltageDrop!="")voltageDrop = voltageDrop.Remove(voltageDrop.Length - 1);
            if(voltageDropPercentage!="")voltageDropPercentage = voltageDropPercentage.Remove(voltageDropPercentage.Length - 1);
            if (allowVDPercentage!="") allowVDPercentage = allowVDPercentage.Remove(allowVDPercentage.Length - 1);
            if(circuitBreakerType!="")circuitBreakerType = circuitBreakerType.Remove(circuitBreakerType.Length - 1);

            String all = /*mainSwitchBoard*/ circuitID + "|" + toDbName + "|" + destinatedLocation + "|" + from + "|" + connectedLoad + "|" +
    maxDemandKVA + "|" + maxDemandKW + "|" + load + "|" + breakerSetting + "|" + breakerAF + "|" + breakerAT + "|" + maxDemandKW +
phase + "|" + voltage + "|" + cableType + "|" + cableNo + "|" + cableSize + "|" + cableEarth + "|" + cableEarth2 + "|" + cableMethod
    + "|" + cableLength + "|" + cableRating + "|" + current + "|" + cableSet + "|" + core + "|" + armour + "|" + ca + "|" + cg + "|" + ci + "|" +
    deratingFactors + "|" + zValues + "|" + deratedCurrent + "|" + voltageDrop + "|" + voltageDropPercentage + "|" + allowVDPercentage;
            //MessageBox.Show(all);

            //   string[] mainSwitchBoardArray = mainSwitchBoard.Split('|');
            circuitIDArray = circuitID.Split('|');
            toDbNameArray = toDbName.Split('|');
            destinatedLocationArray = destinatedLocation.Split('|');
            fromArray = from.Split('|');
            connectedLoadArray = connectedLoad.Split('|');
            maxDemandKVAArray = maxDemandKVA.Split('|');
            maxDemandKWArray = maxDemandKW.Split('|');
            loadArray = load.Split('|');
            breakerSettingArray = breakerSetting.Split('|');
            breakerAFArray = breakerAF.Split('|');
            breakerATArray = breakerAT.Split('|');
            phaseArray = phase.Split('|');
            voltageArray = voltage.Split('|');
            currentArray = current.Split('|');
            coreArray = core.Split('|');
            armourArray = armour.Split('|');
            caArray = ca.Split('|');
            cgArray = cg.Split('|');
            ciArray = ci.Split('|');
            deratingFactorsArray = deratingFactors.Split('|');
            zValuesArray = zValues.Split('|');
            deratedCurrentArray = deratedCurrent.Split('|');
            voltageDropArray = voltageDrop.Split('|');
            voltageDropPercentageArray = voltageDropPercentage.Split('|');
            allowVDPercentageArray = allowVDPercentage.Split('|');
            circuitBreakerTypeArray = circuitBreakerType.Split('|');



            cableTypeArray = cableType.Split('|');
            cableNoArray = cableNo.Split('|');
            cableSizeArray = cableSize.Split('|');
            cableEarthArray = cableEarth.Split('|');
            cableEarth2Array = cableEarth2.Split('|');
            cableMethodArray = cableMethod.Split('|');
            cableRatingArray = cableRating.Split('|');
            cableLengthArray = cableLength.Split('|');
            cableSetArray = cableSet.Split('|');
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
            if (cableSizeArray[0] != "")
            {
                cableSizeText = cableSizeArray[0] + " ";
            }
            else
            {
                cableSizeText = "N/A";
            }
            string cableLengthText;
            double n3;
            if (cableLengthArray[0] != "")
            {
                Boolean tryParseResult = Double.TryParse(cableLengthArray[0], out n3);
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
            string x = "";
            if (coreArray[0].ToString() == "SC")
            {
                x = "4";
            }
            else if (coreArray[0].ToString() == "MC")
            {
                x = "1";
            }
            else
            {
                x = "N/A";
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
            //  label1.Text = cableSetText + "x" + x2 + "x" + cableSizeText + "sq.mm," + coreArray[0] + "/LSOH/XLPE/" + cableTypeText + "," + cableEarth2ArrayText + "sq.mm CPC";
            if (circuitBreakerType!= "") { 
            if (circuitBreakerTypeArray[0] == "ACB")
            {
                panel1.BackgroundImage = Properties.Resources.childPanelAB;
            }else if(circuitBreakerTypeArray[0] == "RCCB")
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
        TypeOfCableInfo.Text = cableSetText + "x" + x + "x" + cableSizeText + "sq.mm," + coreArrayText + "/LSOH/XLPE/" + cableTypeText + "," + cableEarth2ArrayText + "sq.mm CPC";
           // TypeOfCableInfo.Text = cableSetArray[0] + "x" + x + "x" + cableSizeArray[0] + "sq.mm," + coreArray[0] + "/LSOH/XLPE/" + cableTypeArray[0] + "," + cableEarth2Array[0] + "sq.mm CPC";
            LengthOfCableLabel.Text = cableMethodText + "," + cableLengthText;

            Double t;
            Boolean VDPtoDouble = false;
            Boolean AVDPtoDouble = false;

            if (voltageDropPercentageArray[0] != "" && allowVDPercentageArray[0] != "")
            {
                VDPtoDouble = Double.TryParse(voltageDropPercentageArray[0].Remove(voltageDropPercentageArray[0].Length - 1), out t);
                AVDPtoDouble = Double.TryParse(allowVDPercentageArray[0].Remove(allowVDPercentageArray[0].Length - 1), out t);
            }
            if (VDPtoDouble == true && AVDPtoDouble == true)
            {
                if (voltageDropPercentageArray[0] != "null" && allowVDPercentageArray[0] != "null")
                {
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
                    result = "Lack of information";
                    sideInformation.ForeColor = System.Drawing.Color.Black;
                }
            }
            else
            {
                result = "Lack of information";
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
            breakerInfo.Text = breakerATArray[0]+" AT";
            dLabel.Text = toDbNameArray[0];
            dLabel.Font = new System.Drawing.Font(dLabel.Font, FontStyle.Bold);
            sideInformation.Text ="Voltage Drop =" + voltageDropText + "\n" + "Voltage Drop(%) =" + voltageDropPercentageText + "\n Allowable Voltage Drop(%)=" + allowVDPercentageText + "\nResult = " + result;
            if (toDbNameArray.Length != 1)
            {
                for (int i = 1; i < toDbNameArray.Length; i++)
                {
                    

                    String cableSetText;
                    String cableSizeText;
                    String cableTypeText;
                    String cableMethodText;
                    String coreArrayText;
                    String cableEarth2ArrayText;

                    String voltageDropText;
                    String voltageDropPercentageText;
                    String allowVDPercentageText;


                    FontFamily family = new FontFamily("Microsoft Sans Serif");
                    System.Drawing.Font font = new System.Drawing.Font(family, 6.75f);
                    System.Drawing.Font font2 = new System.Drawing.Font(family, 6.25f);
                    System.Drawing.Font font3 = new System.Drawing.Font(family, 6.5f);
                    Panel p = new Panel();
                    mainTable.RowCount++;
                    mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                    mainTable.Controls.Add(p, 0, i);
                    mainTable.RowStyles[i].Height = 93;
                    p.Width = 622;
                    p.Height = 82;
                    p.BackColor = Color.Transparent;
                    if (circuitBreakerType!="")
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
                    if (cableSizeArray[i] != "")
                    {
                        cableSizeText = cableSizeArray[i] + " ";
                    }
                    else
                    {
                        cableSizeText = "N/A";
                    }
                    string cableLengthText2;
                    Double n2;
                    if (cableLengthArray[i] != "")
                    {
                        Boolean tryParseResult = Double.TryParse(cableLengthArray[i], out n2);
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
                    string x2 = "";
                    if (coreArray[i].ToString() == "SC")
                    {
                        x2 = "4";
                    }
                    else if (coreArray[i].ToString() == "MC")
                    {
                        x2 = "1";
                    }
                    else
                    {
                        x2 = "N/A";
                    }
                    if(coreArray[i] != "")
                    {
                        coreArrayText = coreArray[i];
                    }
                    else
                    {
                        coreArrayText = "N/A";
                    }
                    if(cableEarth2Array[i] != "")
                    {
                        cableEarth2ArrayText = cableEarth2Array[i];
                    }
                    else
                    {
                        cableEarth2ArrayText = "N/A";
                    }
                    label1.Text = cableSetText + "x" + x2 + "x" + cableSizeText + "sq.mm," + coreArrayText + "/LSOH/XLPE/" + cableTypeText + "," + cableEarth2ArrayText + "sq.mm CPC";
                    //label1.Text = "("+cableNoArray[i] + ")x(" +cableSizeArray[i]+"sq.mm)"+ "("+cableTypeText + ")/(" + cableMethodText + ") - "+cableLengthText2;
                    label1.Location = new Point(69, -1);
                    label1.TextAlign = ContentAlignment.BottomLeft;
                    label1.Width = 259;
                    label1.Height = 40;
                    label1.Font = font3;
                    Label label5 = new Label();
                    label5.AutoSize = false;
                    label5.Location = new Point(3, -8);
                    label5.Width = 62;
                    label5.Height = 27;
                    label5.TextAlign = ContentAlignment.MiddleCenter;
                    label5.Font = font3;
                    label5.Text = breakerATArray[i]+" AT";
                    Label label2 = new Label();
                    label2.Location = new Point(69, 50);
                    label2.TextAlign = ContentAlignment.TopLeft;
                    label2.Font = font3;
                    label2.Width =237;
                    label2.Height =25;
                    Double n;
                    label2.Text = cableMethodText + ", " + cableLengthText2;
                    /* if (cableLengthArray[i] != "")
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
                    //label1.MouseClick += new MouseEventHandler(clickOnSpace);
                    //label2.MouseClick += new MouseEventHandler(clickOnSpace);
                    //label3.MouseClick += new MouseEventHandler(clickOnSpace);
                    //label4.MouseClick += new MouseEventHandler(clickOnSpace);
                }
            }
            foreach (Panel space in this.mainTable.Controls)
            {
                space.MouseClick += new MouseEventHandler(clickOnSpace);
            }
            // mainTable.RowStyles[0].Height = 122;
            /*   TableLayoutPanel panel = new TableLayoutPanel();
               panel.ColumnCount = 2;
               panel.RowCount = toDbNameArray.Length;
               panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
               panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
               panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
               panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

               // For Add New Row (Loop this code for add multiple rows)
               for (int i = 0; i < toDbNameArray.Length; i++) {
                   panel.RowCount = panel.RowCount + 1;
                   panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
               }*/
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
        public void clickOnSpace(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Circuit ID: " + circuitIDArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nTo DB Name: " + toDbNameArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nDestinated Location: " + destinatedLocationArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))]
                + "\nFrom: " + fromArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nConnected Load: " + connectedLoadArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nMaximum Demand,MD (KVA): " + maxDemandKVAArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nMaximum Demand,MD (KW): " +
                maxDemandKWArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nLoad(A): " + loadArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nBreaker Setting(AF/AT): " + breakerSettingArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nBreaker Setting(AF): " + breakerAFArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nBreaker Setting(AT): " + breakerATArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))]
                + "\nNumber of Phase: " + phaseArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nVoltage(V): " + voltageArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCable Type: " + cableTypeArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCable Number: " + cableNoArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] +
                "\nCable Size: " + cableSizeArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCable #Earth: " + cableEarthArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCable Earth: " + cableEarth2Array[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nMethod of Installation of Cables: " +
                cableMethodArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCable Length(m): " + cableLengthArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCable Rating: " + cableRatingArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCurrent Capacity(A): " + currentArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] +
                "\nCable Set: " + cableSetArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCore: " + coreArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nArmour(A/NA): " + armourArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCoefficient (Ambient): " + caArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCoefficient(Grouping): " +
                cgArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nCoefficient(Thermal Insulation): " + ciArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nDerating Factors: " + deratingFactorsArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nZ Values(mV/A/m): " + zValuesArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] +
                "\nDerated Current Capacity(A): " + deratedCurrentArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nVoltage Drop(V): " + voltageDropArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nVoltage Drop(%): " + voltageDropPercentageArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))] + "\nAllowable Voltage Drop(%): "
                + allowVDPercentageArray[Convert.ToInt32(mainTable.GetRow((Panel)sender))]);
        }

        private void captureButton_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.captureButton.Visible = false;
            this.exportPDF.Visible = false;
            this.backButton.Visible = false;
            this.Refresh();
            try
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.Filter = "PNG File|*.png;";
                SaveFileDialog1.ShowDialog();
                String sLocation;
                sLocation = SaveFileDialog1.FileName;
                string ImagePath = string.Format(sLocation, DateTime.Now.Ticks);
                Bitmap bmp1 = new Bitmap(this.panel2.Width, this.panel2.Height);
                this.panel2.DrawToBitmap(bmp1, new System.Drawing.Rectangle(0, 0, this.panel2.Width, this.panel2.Height));
                bmp1.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                MessageBox.Show("Screen Capture Save Completed");
                /* if (toDbNameArray.Length > 6 && toDbNameArray.Length < 31)
                  {
                      if (toDbNameArray.Length > 6 && toDbNameArray.Length <= 12)
                      {
                          this.AutoScrollPosition = new Point(0, 0);
                          using (Bitmap bmp = new Bitmap(this.Width, this.mainTable.Height))
                          {

                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 620);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation2;
                              sLocation2 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 2).png";
                              string ImagePath2 = string.Format(sLocation2, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath2, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          MessageBox.Show("Screen Capture Save Completed");
                      }
                      else if (toDbNameArray.Length > 12 && toDbNameArray.Length <= 18)
                      {
                          this.AutoScrollPosition = new Point(0, 0);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {

                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 570);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation2;
                              sLocation2 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 2).png";
                              string ImagePath2 = string.Format(sLocation2, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath2, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 570 * 2);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation3;
                              sLocation3 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 3).png";
                              string ImagePath3 = string.Format(sLocation3, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath3, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          MessageBox.Show("Screen Capture Save Completed");
                      }
                      else if (toDbNameArray.Length > 18 && toDbNameArray.Length <= 24)
                      {
                          this.AutoScrollPosition = new Point(0, 0);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {

                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 570);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation2;
                              sLocation2 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 2).png";
                              string ImagePath2 = string.Format(sLocation2, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath2, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 570 * 2);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation3;
                              sLocation3 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 3).png";
                              string ImagePath3 = string.Format(sLocation3, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath3, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 570 * 3);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation4;
                              sLocation4 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 4).png";
                              string ImagePath4 = string.Format(sLocation4, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath4, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          MessageBox.Show("Screen Capture Save Completed");
                      }
                      else if (toDbNameArray.Length > 24 && toDbNameArray.Length <= 30)
                      {
                          Bitmap bmp1 = new Bitmap(this.panel2.Width, this.panel2.Height);

                          this.panel2.DrawToBitmap(bmp1, new System.Drawing.Rectangle(0, 0, this.panel2.Width, this.panel2.Height));

                          bmp1.Save("C:\\Users\\anu\\Desktop\\panel.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {

                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 570);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation2;
                              sLocation2 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 2).png";
                              string ImagePath2 = string.Format(sLocation2, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath2, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 570 * 2);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation3;
                              sLocation3 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 3).png";
                              string ImagePath3 = string.Format(sLocation3, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath3, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 570 * 3);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation4;
                              sLocation4 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 4).png";
                              string ImagePath4 = string.Format(sLocation4, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath4, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          this.AutoScrollPosition = new Point(0, 570 * 4);
                          using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                          {
                              String sLocation5;
                              sLocation5 = SaveFileDialog1.FileName.Remove(SaveFileDialog1.FileName.Length - 4) + "(Part 5).png";
                              string ImagePath5 = string.Format(sLocation5, DateTime.Now.Ticks);
                              this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                              bmp.Save(ImagePath5, System.Drawing.Imaging.ImageFormat.Png);
                          }
                          MessageBox.Show("Screen Capture Save Completed");


                      }
                      }
                  else if (toDbNameArray.Length <= 6)
                  {
                      this.AutoScrollPosition = new Point(0, 0);
                      using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                      {

                          this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                          bmp.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
                      }
                      MessageBox.Show("Screen Capture Save Completed");
                  }
                  else
                  {
                      MessageBox.Show("Screen capture only supports up to '30' children panels for each selected panel.");
                  }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.captureButton.Visible = true;
            this.exportPDF.Visible = true;
            this.backButton.Visible = true;
            this.Refresh();

        }
        private void LengthOfCableLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Form2 f2 = new Form2(Form1.from);
            f2.Show();
        }
        protected void label_Click(object sender, EventArgs e, Label labelNo)
        {
            Label label= sender as Label;
            /*    MessageBox.Show("Circuit ID:" + circuitIDClick + "\nTo:DB Name:" + toDbNameClick + "\nDestinated Location:" + destinatedLocationClick
                + "\nFrom:" + fromClick + "\nConnected Load:" + connectedLoadClick + "\nMaximum Demand,MD (KVA):" + maxDemandKVAClick + "\nMaximum Demand,MD (KW):" +
                maxDemandKWClick + "\nLoad(A):" + loadClick + "\nBreaker Setting(AF/AT):" + breakerSettingClick + "\nBreaker Setting(AF):" + breakerAFClick + "\nBreaker Setting(AT):" + breakerAFClick
                + "\nNumber of Phase:" + phaseClick + "\nVoltage(V):" + voltageClick + "\nCable Type:" + cableTypeClick + "\nCable Number:" + cableNoClick +
                "\nCable Size:" + cableSizeClick + "\nCable #Earth:" + cableEarthClick + "\nCable Earth:" + cableEarthClick + "\nMethod of Installation of Cables:" +
                cableMethodClick + "\nCable Length(m):" + cableLengthClick + "\nCable Rating:" + cableRatingClick + "\nCurrent Capacity(A):" + currentClick +
                "\nCable Set" + cableSetClick + "\nCore:" + coreClick + "\nArmour(A/NA):" + armourClick + "\nCoefficient (Ambient):" + caClick + "\nCoefficient(Grouping):" +
                cgClick + "\nCoefficient(Thermal Insulation): " + ciClick + "\nDerating Factors:" + deratingFactorsClick + "\nZ Values(mV/A/m):" + zValuesClick +
                "\nDerated Current Capacity(A):" + deratedCurrentClick + "\nVoltage Drop(V):" + voltageDropClick + "\nVoltage Drop(%)" + voltageDropPercentage + "\nAllowable Voltage Drop(%):"
                + allowVDPClick);*/
            MessageBox.Show(mainTable.GetRow(labelNo).ToString());
        }
        public void exportarPDF(System.Drawing.Image[] imgArray, string sLocation,int no)
        {
            try
            {
                // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                //System.Drawing.Image image = img;  //Here I passed a bitmap
                Document doc = new Document(PageSize.A3);
                PdfWriter.GetInstance(doc, new FileStream(sLocation, FileMode.Create));
                doc.Open();
                //iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,System.Drawing.Imaging.ImageFormat.Png);
                for (int i = 0; i < no; i++)
                {
                    doc.Add(iTextSharp.text.Image.GetInstance(imgArray[i], System.Drawing.Imaging.ImageFormat.Png));
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.captureButton.Visible = false;
            this.exportPDF.Visible = false;
            this.backButton.Visible = false;
            this.Refresh();
            try
            {
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.Filter = "PDF File|*.pdf;";
                SaveFileDialog1.ShowDialog();
                String sLocation;
                sLocation = SaveFileDialog1.FileName;
                string ImagePath = string.Format(sLocation, DateTime.Now.Ticks);
                Bitmap bmp1 = new Bitmap(this.panel2.Width, this.panel2.Height);
                float ratio;
                float a3Height = PageSize.A3.Height;
                    ratio = this.panel2.Height/a3Height;
                    int ratioUp = (int)Math.Ceiling(ratio);
                    System.Drawing.Image[] imageArray = new System.Drawing.Image[ratioUp];
                    this.panel2.DrawToBitmap(bmp1, new System.Drawing.Rectangle(0, 0, this.panel2.Width, this.panel2.Height));
                    System.Drawing.Image image = bmp1;
                    for (int y = 0; y < imageArray.Length; y++)
                    {
                        System.Drawing.Rectangle rect = new System.Drawing.Rectangle(new Point(0, 1100 * y), new Size(800, 1100));
                        Bitmap cutBM = CropImage(bmp1, rect);
                        imageArray[y] = cutBM;
                    }
                exportarPDF(imageArray, sLocation, imageArray.Length);
                //exportarPDF(imageArray, sLocation, imageArray.Length);
              /*  try
                {
                    //iTextSharp.text.Rectangle rect = new iTextSharp.text.Rectangle(bmp1.Width, bmp1.Height);
                    //iTextSharp.text.Document doc = new iTextSharp.text.Document(rect, 0, 0, 0, 0);
                   Document doc = new Document(PageSize.A3);
                    PdfWriter.GetInstance(doc, new FileStream(sLocation, FileMode.Create));
                    doc.Open();
                    doc.Add(imageArray[0]);
                    doc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }*/
                /*if (toDbNameArray.Length <= 6)
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
                    this.AutoScrollPosition = new Point(0, 570);
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
                    this.AutoScrollPosition = new Point(0, 570);
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
                    this.AutoScrollPosition = new Point(0, 570 * 2);
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
                    this.AutoScrollPosition = new Point(0, 570);
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
                    this.AutoScrollPosition = new Point(0, 570 * 2);
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
                    this.AutoScrollPosition = new Point(0, 570 * 3);
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
                    this.AutoScrollPosition = new Point(0, 570);
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
                    this.AutoScrollPosition = new Point(0, 570 * 2);
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
                    this.AutoScrollPosition = new Point(0, 570 * 3);
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
                    this.AutoScrollPosition = new Point(0, 570 * 4);
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
                }*/
                MessageBox.Show("PDF Save Completed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.captureButton.Visible = true;
            this.exportPDF.Visible = true;
            this.backButton.Visible = true;
            this.Refresh();
        }
        public void DrawControl(Control control, Bitmap bitmap)
        {
            control.DrawToBitmap(bitmap, control.Bounds);
            foreach (Control childControl in control.Controls)
            {
                DrawControl(childControl, bitmap);
            }
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
        private void dLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void sideInformation_Click(object sender, EventArgs e)
        {

        }

        private void breakerInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
