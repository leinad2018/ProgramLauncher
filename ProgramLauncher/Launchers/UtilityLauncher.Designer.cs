namespace ProgramLauncher.Launchers
{
    partial class UtilityLauncher
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
            this.CSDev = new System.Windows.Forms.Button();
            this.Utility = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CSDev
            // 
            this.CSDev.Location = new System.Drawing.Point(13, 13);
            this.CSDev.Name = "CSDev";
            this.CSDev.Size = new System.Drawing.Size(75, 23);
            this.CSDev.TabIndex = 0;
            this.CSDev.Text = "C# Dev";
            this.CSDev.UseVisualStyleBackColor = true;
            this.CSDev.Click += new System.EventHandler(this.CSDev_Launch);
            // 
            // Utility
            // 
            this.Utility.Location = new System.Drawing.Point(13, 43);
            this.Utility.Name = "Utility";
            this.Utility.Size = new System.Drawing.Size(75, 23);
            this.Utility.TabIndex = 1;
            this.Utility.Text = "Dock";
            this.Utility.UseVisualStyleBackColor = true;
            this.Utility.Click += new System.EventHandler(this.Dock_Launch);
            // 
            // UtilityLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 330);
            this.Controls.Add(this.Utility);
            this.Controls.Add(this.CSDev);
            this.Name = "UtilityLauncher";
            this.Text = "UtilityLauncher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CSDev;
        private System.Windows.Forms.Button Utility;
    }
}