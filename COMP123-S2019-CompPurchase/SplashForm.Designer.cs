namespace COMP123_S2019_CompPurchase
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeToDollarComputerLabel = new System.Windows.Forms.Label();
            this.WeSellForLessLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 2000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_S2019_CompPurchase.Properties.Resources.SplashImage;
            this.pictureBox1.Location = new System.Drawing.Point(12, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeToDollarComputerLabel
            // 
            this.WelcomeToDollarComputerLabel.AutoSize = true;
            this.WelcomeToDollarComputerLabel.Location = new System.Drawing.Point(298, 9);
            this.WelcomeToDollarComputerLabel.Name = "WelcomeToDollarComputerLabel";
            this.WelcomeToDollarComputerLabel.Size = new System.Drawing.Size(374, 31);
            this.WelcomeToDollarComputerLabel.TabIndex = 2;
            this.WelcomeToDollarComputerLabel.Text = "Welcome to Dollar Computers";
            // 
            // WeSellForLessLabel
            // 
            this.WeSellForLessLabel.AutoSize = true;
            this.WeSellForLessLabel.Location = new System.Drawing.Point(377, 40);
            this.WeSellForLessLabel.Name = "WeSellForLessLabel";
            this.WeSellForLessLabel.Size = new System.Drawing.Size(218, 31);
            this.WeSellForLessLabel.TabIndex = 2;
            this.WeSellForLessLabel.Text = "We Sell for Less!";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.WeSellForLessLabel);
            this.Controls.Add(this.WelcomeToDollarComputerLabel);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SplashForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label WelcomeToDollarComputerLabel;
        private System.Windows.Forms.Label WeSellForLessLabel;
    }
}