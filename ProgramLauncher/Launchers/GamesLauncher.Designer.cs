namespace ProgramLauncher
{
    partial class GamesLauncher
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
            this.MCLaunch = new System.Windows.Forms.Button();
            this.Steam = new System.Windows.Forms.Button();
            this.TTR = new System.Windows.Forms.Button();
            this.P64 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MCLaunch
            // 
            this.MCLaunch.Location = new System.Drawing.Point(12, 12);
            this.MCLaunch.Name = "MCLaunch";
            this.MCLaunch.Size = new System.Drawing.Size(75, 23);
            this.MCLaunch.TabIndex = 1;
            this.MCLaunch.Text = "Minecraft";
            this.MCLaunch.UseVisualStyleBackColor = true;
            this.MCLaunch.Click += new System.EventHandler(this.Minecraft_Launch);
            // 
            // Steam
            // 
            this.Steam.Location = new System.Drawing.Point(12, 41);
            this.Steam.Name = "Steam";
            this.Steam.Size = new System.Drawing.Size(75, 23);
            this.Steam.TabIndex = 2;
            this.Steam.Text = "Steam";
            this.Steam.UseVisualStyleBackColor = true;
            this.Steam.Click += new System.EventHandler(this.Steam_Launch);
            // 
            // TTR
            // 
            this.TTR.Location = new System.Drawing.Point(12, 70);
            this.TTR.Name = "TTR";
            this.TTR.Size = new System.Drawing.Size(75, 23);
            this.TTR.TabIndex = 3;
            this.TTR.Text = "Toontown";
            this.TTR.UseVisualStyleBackColor = true;
            this.TTR.Click += new System.EventHandler(this.TTR_Launch);
            // 
            // P64
            // 
            this.P64.Location = new System.Drawing.Point(12, 99);
            this.P64.Name = "P64";
            this.P64.Size = new System.Drawing.Size(75, 23);
            this.P64.TabIndex = 4;
            this.P64.Text = "P64";
            this.P64.UseVisualStyleBackColor = true;
            this.P64.Click += new System.EventHandler(this.P64_Launch);
            // 
            // GamesLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 337);
            this.Controls.Add(this.P64);
            this.Controls.Add(this.TTR);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.MCLaunch);
            this.Name = "GamesLauncher";
            this.Text = "GamesLauncher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MCLaunch;
        private System.Windows.Forms.Button Steam;
        private System.Windows.Forms.Button TTR;
        private System.Windows.Forms.Button P64;
    }
}