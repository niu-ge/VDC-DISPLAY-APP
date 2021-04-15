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
    public partial class Form7 : Form
    {
        public Form7(string panelList)
        {
            InitializeComponent();
            Boolean duplicate = false;
            string[] panelArray = panelList.Split(',');
            for (int i = 0; i < panelArray.Length; i++)
            {
                for (int k = 0; k < checkedListBox1.Items.Count; k++)
                {
                    if (checkedListBox1.Items[k].ToString() == panelArray[i])
                    {
                        duplicate = true;
                    }
                }
                if (duplicate == false && panelArray[i] != "")
                {
                    checkedListBox1.Items.Add(panelArray[i]);
                }
                else
                {
                    duplicate = false;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
