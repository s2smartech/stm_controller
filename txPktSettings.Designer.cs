namespace stm_controller
{
    partial class txPktSettings
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
            this.SOTtextBox = new System.Windows.Forms.TextBox();
            this.SOTcheckBox = new System.Windows.Forms.CheckBox();
            this.EOTtextBox = new System.Windows.Forms.TextBox();
            this.EOTcheckBox = new System.Windows.Forms.CheckBox();
            this.saveSettingButton = new System.Windows.Forms.Button();
            this.cancelSettingButton = new System.Windows.Forms.Button();
            this.loadSettingsButton = new System.Windows.Forms.Button();
            this.saveSettingsAsButton = new System.Windows.Forms.Button();
            this.CRCcheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SOTtextBox
            // 
            this.SOTtextBox.Location = new System.Drawing.Point(146, 25);
            this.SOTtextBox.Name = "SOTtextBox";
            this.SOTtextBox.Size = new System.Drawing.Size(100, 20);
            this.SOTtextBox.TabIndex = 0;
            // 
            // SOTcheckBox
            // 
            this.SOTcheckBox.AutoSize = true;
            this.SOTcheckBox.Location = new System.Drawing.Point(13, 27);
            this.SOTcheckBox.Name = "SOTcheckBox";
            this.SOTcheckBox.Size = new System.Drawing.Size(124, 17);
            this.SOTcheckBox.TabIndex = 2;
            this.SOTcheckBox.Text = "Start-of-Transmission";
            this.SOTcheckBox.UseVisualStyleBackColor = true;
            // 
            // EOTtextBox
            // 
            this.EOTtextBox.Location = new System.Drawing.Point(146, 51);
            this.EOTtextBox.Name = "EOTtextBox";
            this.EOTtextBox.Size = new System.Drawing.Size(100, 20);
            this.EOTtextBox.TabIndex = 3;
            // 
            // EOTcheckBox
            // 
            this.EOTcheckBox.AutoSize = true;
            this.EOTcheckBox.Location = new System.Drawing.Point(13, 51);
            this.EOTcheckBox.Name = "EOTcheckBox";
            this.EOTcheckBox.Size = new System.Drawing.Size(121, 17);
            this.EOTcheckBox.TabIndex = 4;
            this.EOTcheckBox.Text = "End-of-Transmission";
            this.EOTcheckBox.UseVisualStyleBackColor = true;
            // 
            // saveSettingButton
            // 
            this.saveSettingButton.Location = new System.Drawing.Point(118, 114);
            this.saveSettingButton.Name = "saveSettingButton";
            this.saveSettingButton.Size = new System.Drawing.Size(75, 23);
            this.saveSettingButton.TabIndex = 5;
            this.saveSettingButton.Text = "Save";
            this.saveSettingButton.UseVisualStyleBackColor = true;
            this.saveSettingButton.Click += new System.EventHandler(this.saveSettingButton_Click);
            // 
            // cancelSettingButton
            // 
            this.cancelSettingButton.Location = new System.Drawing.Point(223, 114);
            this.cancelSettingButton.Name = "cancelSettingButton";
            this.cancelSettingButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSettingButton.TabIndex = 6;
            this.cancelSettingButton.Text = "Cancel";
            this.cancelSettingButton.UseVisualStyleBackColor = true;
            // 
            // loadSettingsButton
            // 
            this.loadSettingsButton.Location = new System.Drawing.Point(323, 114);
            this.loadSettingsButton.Name = "loadSettingsButton";
            this.loadSettingsButton.Size = new System.Drawing.Size(75, 23);
            this.loadSettingsButton.TabIndex = 7;
            this.loadSettingsButton.Text = "Load";
            this.loadSettingsButton.UseVisualStyleBackColor = true;
            // 
            // saveSettingsAsButton
            // 
            this.saveSettingsAsButton.Location = new System.Drawing.Point(422, 114);
            this.saveSettingsAsButton.Name = "saveSettingsAsButton";
            this.saveSettingsAsButton.Size = new System.Drawing.Size(116, 23);
            this.saveSettingsAsButton.TabIndex = 8;
            this.saveSettingsAsButton.Text = "Save Settings As...";
            this.saveSettingsAsButton.UseVisualStyleBackColor = true;
            // 
            // CRCcheckBox
            // 
            this.CRCcheckBox.AutoSize = true;
            this.CRCcheckBox.Location = new System.Drawing.Point(13, 75);
            this.CRCcheckBox.Name = "CRCcheckBox";
            this.CRCcheckBox.Size = new System.Drawing.Size(48, 17);
            this.CRCcheckBox.TabIndex = 9;
            this.CRCcheckBox.Text = "CRC";
            this.CRCcheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CRC-8",
            "CRC-16"});
            this.comboBox1.Location = new System.Drawing.Point(146, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // Transmit_Packets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 156);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CRCcheckBox);
            this.Controls.Add(this.saveSettingsAsButton);
            this.Controls.Add(this.loadSettingsButton);
            this.Controls.Add(this.cancelSettingButton);
            this.Controls.Add(this.saveSettingButton);
            this.Controls.Add(this.EOTcheckBox);
            this.Controls.Add(this.EOTtextBox);
            this.Controls.Add(this.SOTcheckBox);
            this.Controls.Add(this.SOTtextBox);
            this.Name = "Transmit_Packets";
            this.Text = "Transmit Packets Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SOTtextBox;
        private System.Windows.Forms.CheckBox SOTcheckBox;
        private System.Windows.Forms.TextBox EOTtextBox;
        private System.Windows.Forms.CheckBox EOTcheckBox;
        private System.Windows.Forms.Button saveSettingButton;
        private System.Windows.Forms.Button cancelSettingButton;
        private System.Windows.Forms.Button loadSettingsButton;
        private System.Windows.Forms.Button saveSettingsAsButton;
        private System.Windows.Forms.CheckBox CRCcheckBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}