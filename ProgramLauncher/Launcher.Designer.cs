namespace ProgramLauncher
{
    partial class Launcher
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
            this.GamesButton = new System.Windows.Forms.Button();
            this.ProgButton = new System.Windows.Forms.Button();
            this.OtherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GamesButton
            // 
            this.GamesButton.Location = new System.Drawing.Point(132, 219);
            this.GamesButton.Name = "GamesButton";
            this.GamesButton.Size = new System.Drawing.Size(75, 23);
            this.GamesButton.TabIndex = 0;
            this.GamesButton.Text = "Games";
            this.GamesButton.UseVisualStyleBackColor = true;
            this.GamesButton.Click += new System.EventHandler(this.GamesButton_Click);
            // 
            // ProgButton
            // 
            this.ProgButton.Location = new System.Drawing.Point(341, 219);
            this.ProgButton.Name = "ProgButton";
            this.ProgButton.Size = new System.Drawing.Size(79, 23);
            this.ProgButton.TabIndex = 1;
            this.ProgButton.Text = "Programming";
            this.ProgButton.UseVisualStyleBackColor = true;
            this.ProgButton.Click += new System.EventHandler(this.ProgButton_Click);
            // 
            // OtherButton
            // 
            this.OtherButton.Location = new System.Drawing.Point(556, 219);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(75, 23);
            this.OtherButton.TabIndex = 2;
            this.OtherButton.Text = "Other";
            this.OtherButton.UseVisualStyleBackColor = true;
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 321);
            this.Controls.Add(this.OtherButton);
            this.Controls.Add(this.ProgButton);
            this.Controls.Add(this.GamesButton);
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GamesButton;
        private System.Windows.Forms.Button ProgButton;
        private System.Windows.Forms.Button OtherButton;
    }
}

