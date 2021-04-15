namespace Testing11
{
    partial class Form2
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
            this.projectNoLabel = new System.Windows.Forms.Label();
            this.panelSelectLabel = new System.Windows.Forms.Label();
            this.panelListBox = new System.Windows.Forms.ComboBox();
            this.panelSelectedButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // projectNoLabel
            // 
            this.projectNoLabel.Location = new System.Drawing.Point(51, 148);
            this.projectNoLabel.Name = "projectNoLabel";
            this.projectNoLabel.Size = new System.Drawing.Size(523, 31);
            this.projectNoLabel.TabIndex = 0;
            this.projectNoLabel.Text = "Project No:";
            // 
            // panelSelectLabel
            // 
            this.panelSelectLabel.AutoSize = true;
            this.panelSelectLabel.Location = new System.Drawing.Point(48, 185);
            this.panelSelectLabel.Name = "panelSelectLabel";
            this.panelSelectLabel.Size = new System.Drawing.Size(79, 13);
            this.panelSelectLabel.TabIndex = 1;
            this.panelSelectLabel.Text = "Panel Selector:";
            // 
            // panelListBox
            // 
            this.panelListBox.FormattingEnabled = true;
            this.panelListBox.Location = new System.Drawing.Point(133, 182);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(441, 21);
            this.panelListBox.TabIndex = 3;
            // 
            // panelSelectedButton
            // 
            this.panelSelectedButton.BackColor = System.Drawing.Color.White;
            this.panelSelectedButton.Location = new System.Drawing.Point(361, 222);
            this.panelSelectedButton.Name = "panelSelectedButton";
            this.panelSelectedButton.Size = new System.Drawing.Size(130, 32);
            this.panelSelectedButton.TabIndex = 6;
            this.panelSelectedButton.Text = "Select!";
            this.panelSelectedButton.UseVisualStyleBackColor = false;
            this.panelSelectedButton.Click += new System.EventHandler(this.panelSelectedButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.BackColor = System.Drawing.Color.White;
            this.prevButton.Location = new System.Drawing.Point(234, 223);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(121, 31);
            this.prevButton.TabIndex = 7;
            this.prevButton.Text = "Previous";
            this.prevButton.UseVisualStyleBackColor = false;
            this.prevButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(6, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(598, 266);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.panelSelectedButton);
            this.Controls.Add(this.panelListBox);
            this.Controls.Add(this.panelSelectLabel);
            this.Controls.Add(this.projectNoLabel);
            this.Name = "Form2";
            this.Text = "VDC Display App - Selection of Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label projectNoLabel;
        private System.Windows.Forms.Label panelSelectLabel;
        private System.Windows.Forms.ComboBox panelListBox;
        private System.Windows.Forms.Button panelSelectedButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.Button button1;
    }
}