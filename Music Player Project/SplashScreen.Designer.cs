namespace Music_Player_Project
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LaunchCmd = new System.Windows.Forms.Button();
            this.ExitMainCmd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 170);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LaunchCmd
            // 
            this.LaunchCmd.Location = new System.Drawing.Point(28, 358);
            this.LaunchCmd.Name = "LaunchCmd";
            this.LaunchCmd.Size = new System.Drawing.Size(145, 80);
            this.LaunchCmd.TabIndex = 1;
            this.LaunchCmd.Text = "Launch Application";
            this.LaunchCmd.UseVisualStyleBackColor = true;
            // 
            // ExitMainCmd
            // 
            this.ExitMainCmd.Location = new System.Drawing.Point(616, 358);
            this.ExitMainCmd.Name = "ExitMainCmd";
            this.ExitMainCmd.Size = new System.Drawing.Size(145, 80);
            this.ExitMainCmd.TabIndex = 2;
            this.ExitMainCmd.Text = "Exit";
            this.ExitMainCmd.UseVisualStyleBackColor = true;
            this.ExitMainCmd.Click += new System.EventHandler(this.ExitMainCmd_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitMainCmd);
            this.Controls.Add(this.LaunchCmd);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LaunchCmd;
        private System.Windows.Forms.Button ExitMainCmd;
    }
}