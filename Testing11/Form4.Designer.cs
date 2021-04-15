namespace Testing11
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelListBox = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.projectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Panel Selection (May choose more than one): ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelListBox
            // 
            this.panelListBox.BackColor = System.Drawing.Color.White;
            this.panelListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelListBox.CheckOnClick = true;
            this.panelListBox.FormattingEnabled = true;
            this.panelListBox.Location = new System.Drawing.Point(172, 74);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.ScrollAlwaysVisible = true;
            this.panelListBox.Size = new System.Drawing.Size(167, 287);
            this.panelListBox.TabIndex = 1;
            this.panelListBox.SelectedIndexChanged += new System.EventHandler(this.panelListBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(343, 325);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(132, 32);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save these as PDF";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.White;
            this.prevButton.Location = new System.Drawing.Point(345, 239);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(132, 32);
            this.prevButton.TabIndex = 4;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(345, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Switch to \\n Single Mode";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projectLabel
            // 
            this.projectLabel.Location = new System.Drawing.Point(15, 12);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(459, 59);
            this.projectLabel.TabIndex = 6;
            this.projectLabel.Text = "Project No:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 366);
            this.Controls.Add(this.projectLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.panelListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "VDC Display - Multiple Panel Selection Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox panelListBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label projectLabel;
    }
}