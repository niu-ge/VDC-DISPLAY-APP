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

namespace Testing11
{
    public partial class Form8 : Form
    {
        public static string projectName;
        public Form8(string sheetList)
        {
            //label1.Visible = false;
            InitializeComponent();
           // MessageBox.Show(sheetList);
            string[] sheetArray = sheetList.Split(',');
            for(int i = 0; i < sheetArray.Length; i++)
            {
                comboBox1.Items.Add(sheetArray[i]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            Form1.from = "";
            try
            {
                if (comboBox1.SelectedItem.ToString() != null)
                {
                    label1.Visible = true;
                    this.Refresh();
                    string conn;
                    conn = ("Provider=Microsoft.ACE.OLEDB.12.0;" +
                    ("Data Source=" + Form1.fileName + ";" +
                    "Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1\""));
                    OleDbConnection con = new OleDbConnection(conn);
                    OleDbDataReader dr;
                    string trimSelect1 = comboBox1.SelectedItem.ToString().TrimStart('\'');
                    string trimSelect2 = trimSelect1.TrimEnd('\'');
                    string sql = "SELECT * FROM [" + trimSelect2 + "A" + Form1.startRow + ":XFD]";
                    //MessageBox.Show(sql);
                    string sql2 = "SELECT * FROM [" + trimSelect2 + "A2:XFD]";
                    OleDbCommand cmd;
                    try
                    {
                        con.Open();
                        cmd = new OleDbCommand(sql2, con);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            projectName = dr.GetValue(0).ToString();
                            break;
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    OleDbDataAdapter oledbAdapter;
                    int blankCounter = 0;
                    int o = 0;
                    try
                    {
                        con.Open();
                        oledbAdapter = new OleDbDataAdapter(sql, con);
                        Form1.panelDS.Reset();
                        oledbAdapter.Fill(Form1.panelDS);
                        oledbAdapter.Dispose();

                        con.Close();
                        //MessageBox.Show(Form1.panelDS.Tables[0].Columns.Count.ToString());
                        for (int k = 0; k < Form1.panelDS.Tables[0].Columns.Count; k++)
                        {
                            //  MessageBox.Show(Form1.panelDS.Tables[0].Rows[0].ItemArray[k].ToString());
                            if (Form1.panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "From")
                            {
                                //  MessageBox.Show(Form1.panelDS.Tables[0].Rows.Count.ToString());
                                for (o = 1; o < Form1.panelDS.Tables[0].Rows.Count; o++)
                                {
                                    if (Form1.panelDS.Tables[0].Rows[o].ItemArray[k].ToString() == "")
                                    {
                                        blankCounter++;
                                    }
                                    if (blankCounter <= 100000)
                                    {
                                        Form1.from += Form1.panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + "|";
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                Form1.from = Form1.from.TrimEnd('|');
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("here:" + ex.Message);
                        this.Close();
                    }
                    MessageBox.Show("Data import completed, 'OK' to proceed");
                    if (Form1.from != "")
                    {
                        Form2 f2 = new Form2(Form1.from);
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("It seems like imported data is not suitable, please check the starting rows and the selected sheet of excel file");
                        label1.Visible = false;
                        this.Refresh();
                    }
                }
                else
                {
                    MessageBox.Show("Please choose the sheet containing the required information");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Please select a panel");
            }
        }

        private void mButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() != null)
                {
                    label1.Visible = true;
            this.Refresh();
            string conn;
            conn = ("Provider=Microsoft.ACE.OLEDB.12.0;" +
            ("Data Source=" + Form1.fileName + ";" +
            "Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1\""));
            OleDbConnection con = new OleDbConnection(conn);
            OleDbDataReader dr;
            string trimSelect1 = comboBox1.SelectedItem.ToString().TrimStart('\'');
            string trimSelect2 = trimSelect1.TrimEnd('\'');
            string sql = "SELECT * FROM [" + trimSelect2 + "A" + Form1.startRow + ":XFD]";
                    //MessageBox.Show(sql);
                    string sql2 = "SELECT * FROM [" + trimSelect2 + "A2:XFD]";
                    OleDbCommand cmd;
                    try
                    {
                        con.Open();
                        cmd = new OleDbCommand(sql2, con);
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            projectName = dr.GetValue(0).ToString();
                            break;
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    OleDbDataAdapter oledbAdapter;
            int blankCounter = 0;
            int o = 0;
            try
            {
                con.Open();
                oledbAdapter = new OleDbDataAdapter(sql, con);
                oledbAdapter.Fill(Form1.panelDS);
                oledbAdapter.Dispose();

                con.Close();
                //MessageBox.Show(Form1.panelDS.Tables[0].Columns.Count.ToString());
                for (int k = 0; k < Form1.panelDS.Tables[0].Columns.Count; k++)
                {
                    //  MessageBox.Show(Form1.panelDS.Tables[0].Rows[0].ItemArray[k].ToString());
                    if (Form1.panelDS.Tables[0].Rows[0].ItemArray[k].ToString() == "From")
                    {
                        //  MessageBox.Show(Form1.panelDS.Tables[0].Rows.Count.ToString());
                        for (o = 1; o < Form1.panelDS.Tables[0].Rows.Count; o++)
                        {
                            if (Form1.panelDS.Tables[0].Rows[o].ItemArray[k].ToString() == "")
                            {
                                blankCounter++;
                            }
                            if (blankCounter <= 10000)
                            {
                                Form1.from += Form1.panelDS.Tables[0].Rows[o].ItemArray[k].ToString() + "|";
                            }
                            else
                            {
                                break;
                            }
                        }
                        Form1.from = Form1.from.TrimEnd('|');
                    }
                }
                //MessageBox.Show(Form1.from);
                MessageBox.Show("Data import completed, 'OK' to proceed");
                        if (Form1.from != "")
                        {
                            Form4 f4 = new Form4(Form1.from);
                            f4.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("It seems like imported data is not suitable, please check the starting rows and the selected sheet of excel file");
                            label1.Visible = false;
                            this.Refresh();
                        }
                    }
            catch (Exception ex)
            {
                MessageBox.Show("here:" + ex.Message);
                this.Close();
            }
                }
                else
                {
                    MessageBox.Show("Please choose the sheet containing the required information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a panel");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
