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
using System.Threading;

namespace Testing11
{
    public partial class Form5 : Form
    {

        //int rows;
        //int column;
        //string mainSwitchBoard = "";
        //string circuitID = "";
        //string toDbName = "";
        //string destinatedLocation = "";
        //string from = "";
        //string connectedLoad = "";
        //string maxDemandKVA = "";
        //string maxDemandKW = "";
        //string load = "";
        //string breakerSetting = "";
        // string breakerAF = "";
        //string breakerAT = "";
        // string phase = "";
        // string voltage = "";
        //string cableType = "";
        //string cableNo = "";
        // string cableSize = "";
        // string cableEarth = "";
        //string cableEarth2 = "";
        //string cableMethod = "";
        //string cableLength = "";
        // string cableRating = "";
        //string current = "";
        //string cableSet = "";
        //string core = "";
        //string armour = "";
        //string ca = "";
        //string cg = "";
        //string ci = "";
        //string deratingFactors = "";
        //string zValues = "";
        //string deratedCurrent = "";
        //string voltageDrop = "";
        //string voltageDropPercentage = "";
        //string allowVDPercentage = "";
        public static string sValues = "";


        //string voltageDropText;
        //string voltageDropPercentageText;
        //string allowVDPercentageText;

        //string cableSetText;
        //string cableTypeText;
        //string cableMethodText;
        //Double n;

        public Form5(string[] sValue)
        {
            iTextSharp.text.Image[] imageArray = new iTextSharp.text.Image[sValue.Length];
            for (int u = 0; u < sValue.Length; u++)
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


                string voltageDropText;
                string voltageDropPercentageText;
                string allowVDPercentageText;

                string cableSetText;
                string cableTypeText;
                string cableMethodText;

                Double n;
                InitializeComponent();
                sValues = sValue[u];
                selectedLabel.Text = "Selected Panel: " + sValues;
             //   mainSwitchBoard = getData("Main Switchboard");
              //  circuitID = getData("Circuit ID");
                toDbName = getData("To: DB Name");
                destinatedLocation = getData("Destination Location");
                from = getData("From");
               // connectedLoad = getData("Connected Load, CL (KVA)");
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
                //deratingFactors = getData("Derating Factors");
                //zValues = getData("Z Values (mV/A/m)");
                //deratedCurrent = getData("Current Capacity' (A)");
                voltageDrop = getData("VD (V)");
                voltageDropPercentage = getData("VD (%)");
                allowVDPercentage = getData("Allowable Voltage Drop");
                startDbLabel.Text = sValues;

                string[] mainSwitchBoardArray = mainSwitchBoard.Split('|');
                string[] circuitIDArray = circuitID.Split('|');
                string[] toDbNameArray = toDbName.Split('|');
                string[] destinatedLocationArray = destinatedLocation.Split('|');
                string[] fromArray = from.Split('|');
                string[] connectedLoadArray = connectedLoad.Split('|');
                string[] maxDemandKVAArray = maxDemandKVA.Split('|');
                string[] maxDemandKWArray = maxDemandKW.Split('|');
                string[] loadArray = load.Split('|');
                string[] breakerSettingArray = breakerSetting.Split('|');
                string[] breakerAFArray = breakerAF.Split('|');
                string[] breakerATArray = breakerAT.Split('|');
                string[] phaseArray = phase.Split('|');
                string[] voltageArray = voltage.Split('|');
                string[] currentArray = current.Split('|');
                string[] coreArray = core.Split('|');
                string[] armourArray = armour.Split('|');
                string[] caArray = ca.Split('|');
                string[] cgArray = cg.Split('|');
                string[] ciArray = ci.Split('|');
                string[] deratingFactorsArray = deratingFactors.Split('|');
                string[] zValuesArray = zValues.Split('|');
                string[] deratedCurrentArray = deratedCurrent.Split('|');
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

                string result;
                Double t1 = 0.0;
                Boolean vdpDouble;
                Boolean avdpDouble;
                TypeOfCableInfo.Text = cableSetArray[0] + "x(" + cableTypeArray[0] + "/" + cableMethodArray[0] + ")";
                if (cableSetArray[0] != "null")
                {
                    cableSetText = cableSetArray[0] + " ";
                }
                else
                {
                    cableSetText = "Undefined Cable Set ";
                }
                if (cableTypeArray[0] != "null")
                {
                    cableTypeText = cableTypeArray[0] + " ";
                }
                else
                {
                    cableTypeText = "Undefined Cable Type ";
                }
                if (cableMethodArray[0] != "null")
                {
                    cableMethodText = cableMethodArray[0] + " ";
                }
                else
                {
                    cableMethodText = "Undefined Cable Method";
                }
                TypeOfCableInfo.Text = cableSetText + "x(" + cableTypeText + "/" + cableMethodText + ")";
                if (cableLengthArray[0] != "null")
                {
                    Boolean tryParseResult = Double.TryParse(cableLengthArray[0], out n);
                    if (tryParseResult == true)
                    {
                        LengthOfCableLabel.Text = "Length: " + cableLengthArray[0] + "m";
                    }
                    else
                    {
                        LengthOfCableLabel.Text = cableLengthArray[0] + " ";
                    }
                }
                else
                {
                    LengthOfCableLabel.Text = "Undefined Cable Length";
                }
                if (toDbNameArray[0] != "null")
                {
                    dLabel.Text = toDbNameArray[0];
                }
                else
                {
                    dLabel.Text = "Undefined Destination";
                }
                Double t;
                Boolean VDPAinDouble = Double.TryParse(voltageDropPercentageArray[0], out t);
                Boolean AVDPAinDouble = Double.TryParse(allowVDPercentageArray[0], out t);
                if (VDPAinDouble == true && AVDPAinDouble == true)
                {
                    if (voltageDropPercentageArray[0] != "null" && allowVDPercentageArray[0] != "null")
                    {
                        if (Convert.ToDouble(voltageDropPercentageArray[0]) <= Convert.ToDouble(allowVDPercentageArray[0]))
                        {
                            result = "Passed";
                            sideInformation.ForeColor = System.Drawing.Color.Blue;
                        }
                        else
                        {
                            result = "Failure";
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
                    if (voltageDropArray[0] != "null")
                    {
                        voltageDropText = voltageDropArray[0] + "V";
                    }
                    else
                    {
                        voltageDropText = "N/A";
                    }
                    if (voltageDropPercentageArray[0] != "null")
                    {
                        voltageDropPercentageText = voltageDropPercentageArray[0] + "%";
                    }
                    else
                    {
                        voltageDropPercentageText = "N/A";
                    }
                    if (allowVDPercentageArray[0] != "null")
                    {
                        allowVDPercentageText = allowVDPercentageArray[0] + "%";
                    }
                    else
                    {
                        allowVDPercentageText = "N/A";
                    }

                    sideInformation.Text = "Voltage Drop =" + voltageDropText + "\n" + "Voltage Drop Percentage =" + voltageDropPercentageText + "\n Allowable Voltage Drop Percentage =" + allowVDPercentageText + "\nResult = " + result;
                   
                if (toDbNameArray.Length != 1)
                    {
                        for (int i = 1; i < toDbNameArray.Length; i++)
                        {


                            FontFamily family = new FontFamily("Microsoft Sans Serif");
                            System.Drawing.Font font = new System.Drawing.Font(family, 6.75f);
                        System.Drawing.Font font2 = new System.Drawing.Font(family, 6.25f);
                        Panel p = new Panel();
                            mainTable.RowCount++;
                            mainTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                            mainTable.Controls.Add(p, 0, i);
                            mainTable.RowStyles[i].Height = 83;
                            p.Width = 413;
                            p.Height = 72;
                            p.BackColor = Color.Transparent;
                            p.BackgroundImage = Properties.Resources.childPanelv1;
                            Label label1 = new Label();
                            if (cableSetArray[i] != "null")
                            {
                                cableSetText = cableSetArray[i] + " ";
                            }
                            else
                            {
                                cableSetText = "Undefined Cable Set ";
                            }
                            if (cableTypeArray[i] != "null")
                            {
                                cableTypeText = cableTypeArray[i] + " ";
                            }
                            else
                            {
                                cableTypeText = "Undefined Cable Type ";
                            }
                            if (cableMethodArray[i] != "null")
                            {
                                cableMethodText = cableMethodArray[i] + " ";
                            }
                            else
                            {
                                cableMethodText = "Undefined Cable Method";
                            }
                            label1.Text = cableSetText + "x(" + cableTypeText + "/" + cableMethodText + ")";
                            label1.Location = new Point(3, 8);
                            label1.Width = 115;
                            label1.Height = 35;
                            label1.Font = font;
                            Label label2 = new Label();
                            label2.Location = new Point(3, 43);
                            label2.Font = font;
                            label2.Width = 120;
                            label2.Height = 25;
                            if (cableLengthArray[i] != "null")
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
                            }
                            Label label3 = new Label();
                        vdpDouble = Double.TryParse(voltageDropPercentageArray[i], out t1);
                        avdpDouble = Double.TryParse(allowVDPercentageArray[i], out t1);
                        if (vdpDouble == true && avdpDouble == true)
                        {
                            if (voltageDropPercentageArray[i] != "null" && allowVDPercentageArray[i] != "null")
                            {
                                if (Convert.ToDouble(voltageDropPercentageArray[i]) <= Convert.ToDouble(allowVDPercentageArray[i]))
                                {
                                    result = "Passed";
                                    label3.ForeColor = System.Drawing.Color.Blue;
                                }
                                else
                                {
                                    result = "Failure";
                                    label3.ForeColor = System.Drawing.Color.Red;
                                }
                            }
                            else
                            {
                                result = "Unable to calculate result due to lack of information";
                                label3.ForeColor = System.Drawing.Color.Black;
                            }
                        }
                        else
                        {
                            result = "Unable to calculate result due to lack of information";
                            label3.ForeColor = System.Drawing.Color.Black;
                        }
                            if (voltageDropArray[i] != "null")
                            {
                                voltageDropText = voltageDropArray[i] + "V";
                            }
                            else
                            {
                                voltageDropText = "N/A";
                            }
                            if (voltageDropPercentageArray[i] != "null")
                            {
                                voltageDropPercentageText = voltageDropPercentageArray[i] + "%";
                            }
                            else
                            {
                                voltageDropPercentageText = "N/A";
                            }
                            if (allowVDPercentageArray[i] != "null")
                            {
                                allowVDPercentageText = allowVDPercentageArray[i] + "%";
                            }
                            else
                            {
                                allowVDPercentageText = "N/A";
                            }
                            label3.Text = "Voltage Drop =" + voltageDropText + "\n" + "Voltage Drop Percentage =" + voltageDropPercentageText + "\n Allowable Voltage Drop Percentage =" + allowVDPercentageText + "\nResult = " + result;
                            label3.Location = new Point(208, 0);
                            label3.AutoSize = true;
                            label3.Font = font2;
                            Label label4 = new Label();
                            label4.Text = toDbNameArray[i];
                            label4.Font = font;
                            label4.Location = new Point(132, 11);
                            label4.Height = 50;
                            label4.Width = 70;
                            p.Controls.Add(label1);
                            p.Controls.Add(label2);
                            p.Controls.Add(label3);
                            p.Controls.Add(label4);
                        }
                    }

                 //   MessageBox.Show(u+1+"/"+sValue.Length+":"+sValue[u] + " has been captured, Ok to Next Panel");
                this.Show();
                this.AutoSize = true;
                this.Refresh();
                string ImagePath = string.Format(Form4.sLocation, DateTime.Now.Ticks);
                using (Bitmap bmp = new Bitmap(this.Width, this.Height))
                {
                    this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                    try
                    {

                        // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                        System.Drawing.Image image = bmp;  //Here I passed a bitmap
                        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                                System.Drawing.Imaging.ImageFormat.Png);
                        imageArray[u] = pdfImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                this.AutoSize = false;
                this.Refresh();
                this.Controls.Clear();
                this.InitializeComponent();
            }
            try
            {
                // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                Document docu = new Document();
                PdfWriter.GetInstance(docu, new FileStream(Form4.sLocation, FileMode.Create));
                docu.Open();
                for(int k = 0; k<=sValue.Length-1; k++)
                {
                    docu.Add(imageArray[k]);
                }
                docu.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF Error: " + ex.Message);
            }
            MessageBox.Show(sValue.Length + " Panel(s) captured, and saved on location : " + Form4.sLocation + ", successfully!");
            selectedLabel.Text = "";
            startDbLabel.Text = "";
            TypeOfCableInfo.Text = "";
            LengthOfCableLabel.Text = "";
            sideInformation.Text = "";
            dLabel.Text = "";
            this.Controls.Clear();
            this.InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(Form1.panelList);
            f4.Show();
            this.Close();
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
            string sql = " Select [" + columnName + "] from ["+Form1.firstSheetName+"] WHERE [FROM] ='" + Form5.sValues + "'";
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

        private void captureButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "PNG File|*.png;";
            SaveFileDialog1.ShowDialog();
            String sLocation;
            sLocation = SaveFileDialog1.FileName;
            string ImagePath = string.Format(sLocation, DateTime.Now.Ticks);
            this.AutoSize = true;
            this.Refresh();


            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {

                this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                bmp.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
            }

            this.AutoSize = false;
            this.Refresh();
        }

        private void LengthOfCableLabel_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f4 = new Form4(Form1.panelList);
            f4.Show();
        }

        public void exportarPDF(Bitmap img, string sLocation)
        {
            try
            {
                // System.Drawing.Image image = System.Drawing.Image.FromFile("C://snippetsource.jpg"); // Here it saves with a physical file
                System.Drawing.Image image = img;  //Here I passed a bitmap
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(sLocation, FileMode.Create));
                doc.Open();
                iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(image,
                        System.Drawing.Imaging.ImageFormat.Png);
                doc.Add(pdfImage);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AutoSize = true;
            this.Refresh();
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "PDF File|*.pdf;";
            SaveFileDialog1.ShowDialog();
            String sLocation;
            sLocation = SaveFileDialog1.FileName;
            string ImagePath = string.Format(sLocation, DateTime.Now.Ticks);
            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                this.DrawToBitmap(bmp, new System.Drawing.Rectangle(Point.Empty, bmp.Size));
                exportarPDF(bmp, sLocation);
            }
            this.AutoSize = false;
            this.Refresh();
        }

        private void dLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
