namespace Testing11
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.projectLabel = new System.Windows.Forms.Label();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.captureButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.exportPDF = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.startDbLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dLabel = new System.Windows.Forms.Label();
            this.breakerInfo = new System.Windows.Forms.Label();
            this.sideInformation = new System.Windows.Forms.Label();
            this.LengthOfCableLabel = new System.Windows.Forms.Label();
            this.TypeOfCableInfo = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectLabel
            // 
            this.projectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.projectLabel.Location = new System.Drawing.Point(17, 9);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(500, 30);
            this.projectLabel.TabIndex = 0;
            this.projectLabel.Text = "Project No: ";
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.selectedLabel.Location = new System.Drawing.Point(17, 39);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(69, 12);
            this.selectedLabel.TabIndex = 1;
            this.selectedLabel.Text = "Selected Panel:";
            // 
            // captureButton
            // 
            this.captureButton.BackColor = System.Drawing.Color.White;
            this.captureButton.Location = new System.Drawing.Point(287, 55);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(98, 34);
            this.captureButton.TabIndex = 5;
            this.captureButton.Text = "Capture as Image";
            this.captureButton.UseVisualStyleBackColor = false;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(22, 55);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(151, 34);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back to Panel Selection";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // exportPDF
            // 
            this.exportPDF.BackColor = System.Drawing.Color.White;
            this.exportPDF.Location = new System.Drawing.Point(179, 56);
            this.exportPDF.Name = "exportPDF";
            this.exportPDF.Size = new System.Drawing.Size(102, 33);
            this.exportPDF.TabIndex = 7;
            this.exportPDF.Text = "Save as PDF";
            this.exportPDF.UseVisualStyleBackColor = false;
            this.exportPDF.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.startDbLabel);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.exportPDF);
            this.panel2.Controls.Add(this.backButton);
            this.panel2.Controls.Add(this.captureButton);
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Controls.Add(this.mainTable);
            this.panel2.Controls.Add(this.selectedLabel);
            this.panel2.Controls.Add(this.projectLabel);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 213);
            this.panel2.TabIndex = 8;
            // 
            // startDbLabel
            // 
            this.startDbLabel.AutoSize = true;
            this.startDbLabel.BackColor = System.Drawing.Color.White;
            this.startDbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Bold);
            this.startDbLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startDbLabel.Location = new System.Drawing.Point(5, 190);
            this.startDbLabel.Margin = new System.Windows.Forms.Padding(5, 55, 3, 0);
            this.startDbLabel.MaximumSize = new System.Drawing.Size(80, 0);
            this.startDbLabel.Name = "startDbLabel";
            this.startDbLabel.Size = new System.Drawing.Size(48, 12);
            this.startDbLabel.TabIndex = 2;
            this.startDbLabel.Text = "DbName";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.dateLabel.Location = new System.Drawing.Point(566, 39);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(28, 12);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Date:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(105, 93);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // mainTable
            // 
            this.mainTable.AutoSize = true;
            this.mainTable.BackColor = System.Drawing.Color.Transparent;
            this.mainTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainTable.BackgroundImage")));
            this.mainTable.ColumnCount = 1;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.Controls.Add(this.panel1, 0, 0);
            this.mainTable.Location = new System.Drawing.Point(105, 95);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTable.Size = new System.Drawing.Size(628, 93);
            this.mainTable.TabIndex = 3;
            this.mainTable.Paint += new System.Windows.Forms.PaintEventHandler(this.mainTable_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dLabel);
            this.panel1.Controls.Add(this.breakerInfo);
            this.panel1.Controls.Add(this.sideInformation);
            this.panel1.Controls.Add(this.LengthOfCableLabel);
            this.panel1.Controls.Add(this.TypeOfCableInfo);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 82);
            this.panel1.TabIndex = 0;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.dLabel.Location = new System.Drawing.Point(398, 3);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(29, 12);
            this.dLabel.TabIndex = 5;
            this.dLabel.Text = "dlabel";
            // 
            // breakerInfo
            // 
            this.breakerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.breakerInfo.Location = new System.Drawing.Point(3, -8);
            this.breakerInfo.Name = "breakerInfo";
            this.breakerInfo.Size = new System.Drawing.Size(62, 27);
            this.breakerInfo.TabIndex = 4;
            this.breakerInfo.Text = "label1";
            this.breakerInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.breakerInfo.Click += new System.EventHandler(this.breakerInfo_Click);
            // 
            // sideInformation
            // 
            this.sideInformation.AutoSize = true;
            this.sideInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.sideInformation.Location = new System.Drawing.Point(396, 18);
            this.sideInformation.Margin = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.sideInformation.Name = "sideInformation";
            this.sideInformation.Size = new System.Drawing.Size(69, 12);
            this.sideInformation.TabIndex = 3;
            this.sideInformation.Text = "sideInformation";
            this.sideInformation.Click += new System.EventHandler(this.sideInformation_Click);
            // 
            // LengthOfCableLabel
            // 
            this.LengthOfCableLabel.AutoSize = true;
            this.LengthOfCableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.LengthOfCableLabel.Location = new System.Drawing.Point(69, 50);
            this.LengthOfCableLabel.MaximumSize = new System.Drawing.Size(240, 25);
            this.LengthOfCableLabel.Name = "LengthOfCableLabel";
            this.LengthOfCableLabel.Size = new System.Drawing.Size(237, 25);
            this.LengthOfCableLabel.TabIndex = 1;
            this.LengthOfCableLabel.Text = "Cable Length Here %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%";
            this.LengthOfCableLabel.Click += new System.EventHandler(this.LengthOfCableLabel_Click);
            // 
            // TypeOfCableInfo
            // 
            this.TypeOfCableInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F);
            this.TypeOfCableInfo.Location = new System.Drawing.Point(69, -1);
            this.TypeOfCableInfo.MaximumSize = new System.Drawing.Size(300, 40);
            this.TypeOfCableInfo.Name = "TypeOfCableInfo";
            this.TypeOfCableInfo.Size = new System.Drawing.Size(259, 40);
            this.TypeOfCableInfo.TabIndex = 0;
            this.TypeOfCableInfo.Text = "cable typ222222222e heretttttttttttttttttttttttttttttttttttttttttttttttttttttt";
            this.TypeOfCableInfo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TypeOfCableInfo.Click += new System.EventHandler(this.TypeOfCableInfo_Click);
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(774, 601);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "VDC Display App - Selected Panel List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.mainTable.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.Label selectedLabel;
        private System.Windows.Forms.Label startDbLabel;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LengthOfCableLabel;
        private System.Windows.Forms.Label TypeOfCableInfo;
        private System.Windows.Forms.Label sideInformation;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button exportPDF;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label breakerInfo;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}