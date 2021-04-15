namespace Testing11
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.label1 = new System.Windows.Forms.Label();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.startDbLabel = new System.Windows.Forms.Label();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sideInformation = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.LengthOfCableLabel = new System.Windows.Forms.Label();
            this.TypeOfCableInfo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project No: ";
            // 
            // selectedLabel
            // 
            this.selectedLabel.Location = new System.Drawing.Point(18, 39);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(500, 20);
            this.selectedLabel.TabIndex = 1;
            this.selectedLabel.Text = "Selected Panel:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(23, 55);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(151, 34);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back to Panel Selection";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.startDbLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(105, 80);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // startDbLabel
            // 
            this.startDbLabel.AutoSize = true;
            this.startDbLabel.BackColor = System.Drawing.Color.Transparent;
            this.startDbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.startDbLabel.Location = new System.Drawing.Point(5, 30);
            this.startDbLabel.Margin = new System.Windows.Forms.Padding(5, 30, 3, 0);
            this.startDbLabel.Name = "startDbLabel";
            this.startDbLabel.Size = new System.Drawing.Size(0, 12);
            this.startDbLabel.TabIndex = 2;
            // 
            // mainTable
            // 
            this.mainTable.AutoSize = true;
            this.mainTable.BackColor = System.Drawing.Color.Transparent;
            this.mainTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainTable.BackgroundImage")));
            this.mainTable.ColumnCount = 1;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.Controls.Add(this.panel1, 0, 0);
            this.mainTable.Location = new System.Drawing.Point(106, 95);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.Size = new System.Drawing.Size(419, 83);
            this.mainTable.TabIndex = 3;
            this.mainTable.Paint += new System.Windows.Forms.PaintEventHandler(this.mainTable_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.sideInformation);
            this.panel1.Controls.Add(this.dLabel);
            this.panel1.Controls.Add(this.LengthOfCableLabel);
            this.panel1.Controls.Add(this.TypeOfCableInfo);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 72);
            this.panel1.TabIndex = 0;
            // 
            // sideInformation
            // 
            this.sideInformation.AutoSize = true;
            this.sideInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.sideInformation.Location = new System.Drawing.Point(208, 0);
            this.sideInformation.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.sideInformation.Name = "sideInformation";
            this.sideInformation.Size = new System.Drawing.Size(0, 12);
            this.sideInformation.TabIndex = 3;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.dLabel.Location = new System.Drawing.Point(132, 11);
            this.dLabel.Margin = new System.Windows.Forms.Padding(0);
            this.dLabel.MaximumSize = new System.Drawing.Size(70, 50);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(0, 12);
            this.dLabel.TabIndex = 2;
            this.dLabel.Click += new System.EventHandler(this.dLabel_Click);
            // 
            // LengthOfCableLabel
            // 
            this.LengthOfCableLabel.AutoSize = true;
            this.LengthOfCableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.LengthOfCableLabel.Location = new System.Drawing.Point(3, 43);
            this.LengthOfCableLabel.MaximumSize = new System.Drawing.Size(120, 25);
            this.LengthOfCableLabel.Name = "LengthOfCableLabel";
            this.LengthOfCableLabel.Size = new System.Drawing.Size(0, 12);
            this.LengthOfCableLabel.TabIndex = 1;
            this.LengthOfCableLabel.Click += new System.EventHandler(this.LengthOfCableLabel_Click);
            // 
            // TypeOfCableInfo
            // 
            this.TypeOfCableInfo.AutoSize = true;
            this.TypeOfCableInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.TypeOfCableInfo.Location = new System.Drawing.Point(5, 0);
            this.TypeOfCableInfo.MaximumSize = new System.Drawing.Size(115, 40);
            this.TypeOfCableInfo.Name = "TypeOfCableInfo";
            this.TypeOfCableInfo.Size = new System.Drawing.Size(0, 12);
            this.TypeOfCableInfo.TabIndex = 0;
            this.TypeOfCableInfo.Click += new System.EventHandler(this.TypeOfCableInfo_Click);
            // 
            // Form5
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 416);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "VDC Display App - Selected Panel List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.mainTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Label startDbLabel;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LengthOfCableLabel;
        private System.Windows.Forms.Label TypeOfCableInfo;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label sideInformation;
        private System.Windows.Forms.Button backButton;
    }
}