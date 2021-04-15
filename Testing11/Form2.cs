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
    public partial class Form2 : Form
    {
        public static string sValues = "";
        public Form2(string panelList)
        {
            Boolean duplicate = false;
            InitializeComponent();
            string[] panelArray = panelList.Split('|');
            for(int i = 0; i < panelArray.Length; i++)
            {
                for(int k = 0; k < panelListBox.Items.Count; k++){
                    if(panelListBox.Items[k].ToString() == panelArray[i])
                    {
                        duplicate = true;
                    }
                }
             if(duplicate == false && panelArray[i] != "")
                {
                    panelListBox.Items.Add(panelArray[i]);
             }else{
                    duplicate = false;
             }
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Text = "Switch to \n Multiple Mode";
            projectNoLabel.Text = Form8.projectName;
        }

        private void panelSelectedButton_Click(object sender, EventArgs e)
        {
            if (panelListBox.SelectedItem!=null) {
                Form3 f3 = new Form3(panelListBox.SelectedItem.ToString());
                sValues = panelListBox.SelectedItem.ToString();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select the panel you wish to display");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f1 = new Form8(Form1.firstSheetNameList);
            f1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(Form1.from);
            f4.Show();
            this.Hide();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
