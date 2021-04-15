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
using System.Diagnostics;
using System.IO;
namespace Testing11
{
    public partial class Form1 : Form
    {
        public static string fileName;
        public static string firstSheetName = "Sheet1";
        public static DataSet panelDS;
        public static string startRow;

        public static string panelList;
        public static string mainSwitchBoard = "";
        public static string circuitID = "";
        public static string toDbName = "";
        public static string destinatedLocation = "";
        public static string from = "";
        public static string connectedLoad = "";
        public static string maxDemandKVA = "";
        public static string maxDemandKW = "";
        public static string load = "";
        public static string breakerSetting = "";
        public static string breakerAF = "";
        public static string breakerAT = "";
        public static string phase = "";
        public static string voltage = "";
        public static string cableType = "";
        public static string cableNo = "";
        public static string cableSize = "";
        public static string cableEarth = "";
        public static string cableEarth2 = "";
        public static string cableMethod = "";
        public static string cableLength = "";
        public static string cableRating = "";
        public static string current = "";
        public static string cableSet = "";
        public static string core = "";
        public static string armour = "";
        public static string ca = "";
        public static string cg = "";
        public static string ci = "";
        public static string deratingFactors = "";
        public static string zValues = "";
        public static string deratedCurrent = "";
        public static string voltageDrop = "";
        public static string voltageDropPercentage = "";
        public static string allowVDPercentage = "";

        public static string firstSheetNameList;
        //String[] panelArray;
        //int i = 0;
        public Form1()
        {
            InitializeComponent();
            firstSheetNameList = "";
            textBox1.Text = "File Location Here";
            label1.Text = "Please choose the excel file, you want to upload for the visual display.\n Please input the starting row of the excel table in the start row";
            panelDS = new DataSet();
            panelList = ""; 
            mainSwitchBoard = "";
        circuitID = "";
         toDbName = "";
      destinatedLocation = "";
        from = "";
         connectedLoad = "";
         maxDemandKVA = "";
        maxDemandKW = "";
         load = "";
        breakerSetting = "";
         breakerAF = "";
         breakerAT = "";
        phase = "";
         voltage = "";
        cableType = "";
         cableNo = "";
         cableSize = "";
        cableEarth = "";
        cableEarth2 = "";
         cableMethod = "";
        cableLength = "";
        cableRating = "";
        current = "";
        cableSet = "";
        core = "";
        armour = "";
        ca = "";
        cg = "";
        ci = "";
        deratingFactors = "";
        zValues = "";
        deratedCurrent = "";
        voltageDrop = "";
        voltageDropPercentage = "";
        allowVDPercentage = "";
    }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = of.FileName;
                textBox1.Text = fileName;
            }
        }
        private void importButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "File Location Here" || textBox1.Text != null)
            {
                string conn;
                conn = ("Provider=Microsoft.ACE.OLEDB.12.0;" +
                ("Data Source=" + fileName + ";" +
                "Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1\""));
                OleDbConnection con = new OleDbConnection(conn);
                OleDbDataReader dr;
                try
                {
                    con.Open();
                    DataTable dbSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    if (dbSchema == null || dbSchema.Rows.Count < 1)
                    {
                        throw new Exception("Error: Could not determine the name of the first worksheet.");
                    }
                    for(int u = 0; u < dbSchema.Rows.Count; u++) { 
                   firstSheetNameList += dbSchema.Rows[u]["TABLE_NAME"].ToString()+",";
                     }
                    firstSheetNameList.Remove(firstSheetNameList.Length - 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }
                startRow = numericUpDown1.Value.ToString();
                con.Close();
                Form8 f8 = new Form8(firstSheetNameList);
                f8.Show();
                this.Hide();
                
/*
                string sql = "SELECT * FROM [" + firstSheetName + "B"+numericUpDown1.Value.ToString()+":XFD]";
                MessageBox.Show(sql);
                OleDbCommand cmd;
                OleDbDataAdapter oledbAdapter;
                int o = 0;
                try
                {
                    con.Open();
                    oledbAdapter = new OleDbDataAdapter(sql, con);
                    oledbAdapter.Fill(panelDS);
                    oledbAdapter.Dispose();
                    con.Close();
                    for(int k = 0; k < panelDS.Tables[0].Columns.Count;k++)
                    {
                        if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Main Switchboard")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                    mainSwitchBoard += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            mainSwitchBoard = mainSwitchBoard.TrimEnd(',');
                        } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Circuit ID")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                circuitID += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            circuitID = circuitID.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "To: DB Name")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                toDbName += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            toDbName = toDbName.TrimEnd(',');
                        } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Destination Location")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                destinatedLocation += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            destinatedLocation = destinatedLocation.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "From")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                from += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            from = from.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Connected Load, CL (KVA)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                connectedLoad += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            connectedLoad = connectedLoad.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Maximum Demand, MD (KVA)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                maxDemandKVA += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            maxDemandKVA = maxDemandKVA.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Maximum Demand, MD  (KW)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                maxDemandKW += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            maxDemandKW = maxDemandKW.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Load (A)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                load += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            load = load.TrimEnd(',');
                        } else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Breaker Setting (AF/AT)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                breakerSetting += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            breakerSetting = breakerSetting.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Breaker Setting (AF)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                breakerAF += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            breakerAF = breakerAF.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Breaker Setting (AT)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                breakerAT += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            breakerAT = breakerAT.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "No of Phase(3/1)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                phase += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            phase = phase.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Voltage (V)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                voltage += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            voltage = voltage.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable Type")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cableType += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cableType = cableType.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable No")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cableNo += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cableNo = cableNo.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable Size")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cableSize += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cableSize = cableSize.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable #Earth")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cableEarth += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cableEarth = cableEarth.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable Earth")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cableEarth2 += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cableEarth2 = cableEarth2.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Method of Installation of Cables")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cableMethod += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cableMethod = cableMethod.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Length (m)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cableLength += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cableLength = cableLength.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Rating")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cableRating += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cableRating = cableRating.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Current Capacity (A)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                current += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            current = current.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cable Set")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cableSet += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cableSet = cableSet.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Core")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                core += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            core = core.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Armour (A/NA)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                armour += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            armour = armour.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Ca")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                ca += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            ca = ca.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Cg")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                cg += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            cg = cg.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Ci")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                ci += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            ci = ci.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Derating Factors")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                deratingFactors += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            deratingFactors = deratingFactors.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Z Values (mV/A/m)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                zValues += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            zValues = zValues.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Current Capacity' (A)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                deratedCurrent += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            deratedCurrent = deratedCurrent.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "VD (V)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                voltageDrop += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            voltageDrop = voltageDrop.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "VD (%)")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                voltageDropPercentage += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            voltageDropPercentage = voltageDropPercentage.TrimEnd(',');
                        }
                        else if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "Allowable Voltage Drop")
                        {
                            for (o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                            {
                                allowVDPercentage += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                            }
                            allowVDPercentage = allowVDPercentage.TrimEnd(',');
                        }
                        else
                        {

                        }
                    }*/
                    /*   cmd = new OleDbCommand(sql, con);
                       dr = cmd.ExecuteReader();
                       var dataSet = GetDataSetFromExcelFile(fileName);
                       while (dr.Read())
                       {
                           if (dr.GetValue(0).ToString() != "")
                           {
                               panelList += dr.GetValue(0).ToString() + ",";
                           }
                       }
                    Form2 f2 = new Form2(from);
                    f2.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("here:"+ ex.Message);
                    this.Close();
                }*/
                con.Close();
            }
            else
            {
                MessageBox.Show("Error: Please browse a valid excel file for the program");
            }
  }
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
                    cmd.CommandText = "SELECT * FROM [" + firstSheetName +"]";

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

        private void button2_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text != "File Location Here" || textBox1.Text != null)
            {
                string conn;
                conn = ("Provider=Microsoft.ACE.OLEDB.12.0;" +
                ("Data Source=" + fileName + ";" +
                "Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1\""));
                OleDbConnection con = new OleDbConnection(conn);
                OleDbDataReader dr;
                try
                {
                    con.Open();
                    DataTable dbSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    if (dbSchema == null || dbSchema.Rows.Count < 1)
                    {
                        throw new Exception("Error: Could not determine the name of the first worksheet.");
                    }
                    firstSheetName = dbSchema.Rows[0]["TABLE_NAME"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }
                con.Close();

                string sql = "SELECT * FROM [:XFD]";*/
                //string sql2 = "SELECT * FROM [" + firstSheetName + "]";
                //OleDbCommand cmd;
               // OleDbDataAdapter oledbAdapter;
              /*  try
                {
*/               /*     con.Open();
                    oledbAdapter = new OleDbDataAdapter(sql, con);
                    oledbAdapter.Fill(panelDS);
                    oledbAdapter.Dispose();
                    con.Close();
                for (int k = 0; k < panelDS.Tables[0].Columns.Count; k++)
                {
                    if (panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "From")
                    {
                        for (int o = 1; o < panelDS.Tables[0].Rows.Count; o++)
                        {
                            from += panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + ",";
                        }
                        from = from.TrimEnd(',');
                    }
                }
                panelList = from;
                /*  cmd = new OleDbCommand(sql, con);
                  dr = cmd.ExecuteReader();
                  var dataSet = GetDataSetFromExcelFile(fileName);
                  while (dr.Read())
                  {
                      // String arraySize = string.Format("{0}", dataSet.Tables[0].Rows.Count);
                      //int arraySizeInInt = Convert.ToInt32(arraySize);
                      //panelArray = new String[arraySizeInInt];
                      if (dr.GetValue(0).ToString() != "")
                      {
                          panelList += dr.GetValue(0).ToString() + ",";
                      }
                      //MessageBox.Show("panelArray[" + i + "] = " + panelArray[i]);
                      //i++;
                  }*/
                /*Form4 f4 = new Form4(panelList);
                    f4.Show();
                    this.Hide();
                */
                /*  }
                / catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                     this.Close();
                 }*/
           /*}
            else
            {
                MessageBox.Show("Error: Please browse a valid excel file for the program");
            }*/
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //Convert The resource Data into Byte[] 
            byte[] PDF = Properties.Resources.Manual;

            MemoryStream ms = new MemoryStream(PDF);

            //Create PDF File From Binary of resources folders helpFile.pdf
            FileStream f = new FileStream("helpFile.pdf", FileMode.OpenOrCreate);

            //Write Bytes into Our Created helpFile.pdf
            ms.WriteTo(f);
            f.Close();
            ms.Close();

            // Finally Show the Created PDF from resources 
            Process.Start("helpFile.pdf");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
    }

