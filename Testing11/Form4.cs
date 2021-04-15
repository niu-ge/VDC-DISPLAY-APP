using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing11
{
    public partial class Form4 : Form
    {
        public static string panelListForCheck;
        public static string sLocation;
        public Form4(string panelList)
        {
            InitializeComponent();
            Boolean duplicate = false;
            string[] panelArray = panelList.Split('|');
            for (int i = 0; i < panelArray.Length; i++)
            {
                for (int k = 0; k < panelListBox.Items.Count; k++)
                {
                    if (panelListBox.Items[k].ToString() == panelArray[i])
                    {
                        duplicate = true;
                    }
                }
                if (duplicate == false && panelArray[i] != "")
                {
                    panelListBox.Items.Add(panelArray[i]);
                }
                else
                {
                    duplicate = false;
                }
            }
            this.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "Available Panel Selection: \n(May choose more than one)";
            button1.Text = "Switch to \n Single Mode";
            projectLabel.Text = Form8.projectName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
            SaveFileDialog1.Filter = "PDF File|*.pdf;";
            SaveFileDialog1.ShowDialog();
            sLocation = SaveFileDialog1.FileName;
            string[] itemArray;
            string itemList="";
            foreach(string item in panelListBox.CheckedItems)
            {

                itemList += item + ",";
            }
            itemList = itemList.Remove(itemList.Length - 1);
            itemArray = itemList.Split(',');
            Form6 f6 = new Form6(itemArray);
            f6.Show();
            this.Hide();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(Form1.firstSheetNameList);
            f8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(Form1.from);
            f2.Show();
            this.Hide();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
