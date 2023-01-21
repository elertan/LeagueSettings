namespace LeagueSettings
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GetButton = new System.Windows.Forms.Button();
            this.SetButton = new System.Windows.Forms.Button();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GetButton
            // 
            this.GetButton.Location = new System.Drawing.Point(12, 12);
            this.GetButton.Name = "GetButton";
            this.GetButton.Size = new System.Drawing.Size(214, 40);
            this.GetButton.TabIndex = 0;
            this.GetButton.Text = "Get";
            this.GetButton.UseVisualStyleBackColor = true;
            this.GetButton.Click += new System.EventHandler(this.GetButton_Click);
            // 
            // SetButton
            // 
            this.SetButton.Enabled = false;
            this.SetButton.Location = new System.Drawing.Point(232, 12);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(204, 40);
            this.SetButton.TabIndex = 1;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(12, 62);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(425, 30);
            this.HelpLabel.TabIndex = 2;
            this.HelpLabel.Text = "Press \'Get\' in order to get your current settings from the logged in account.\r\nPr" +
    "ess \'Set\' in order to set the settings you previously had gotten to this account" +
    ".\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 101);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.GetButton);
            this.Name = "MainForm";
            this.Text = "LeagueSettings";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GetButton;
        private Button SetButton;
        private Label HelpLabel;
    }
}