namespace COMP123_S2019_CompPurchase.Views
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
            this.WelcomeToDollarComputerLabel = new System.Windows.Forms.Label();
            this.WeSellForLessLabel = new System.Windows.Forms.Label();
            this.SmallSplashPictureBox = new System.Windows.Forms.PictureBox();
            this.MainSplashPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SmallSplashPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplashPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
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
            this.WeSellForLessLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.WeSellForLessLabel.Location = new System.Drawing.Point(522, 49);
            this.WeSellForLessLabel.Name = "WeSellForLessLabel";
            this.WeSellForLessLabel.Size = new System.Drawing.Size(150, 24);
            this.WeSellForLessLabel.TabIndex = 2;
            this.WeSellForLessLabel.Text = "We Sell for Less!";
            // 
            // SmallSplashPictureBox
            // 
            this.SmallSplashPictureBox.Image = global::COMP123_S2019_CompPurchase.Properties.Resources.Money;
            this.SmallSplashPictureBox.Location = new System.Drawing.Point(13, 10);
            this.SmallSplashPictureBox.Name = "SmallSplashPictureBox";
            this.SmallSplashPictureBox.Size = new System.Drawing.Size(72, 72);
            this.SmallSplashPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SmallSplashPictureBox.TabIndex = 3;
            this.SmallSplashPictureBox.TabStop = false;
            // 
            // MainSplashPictureBox
            // 
            this.MainSplashPictureBox.Image = global::COMP123_S2019_CompPurchase.Properties.Resources.SplashImage;
            this.MainSplashPictureBox.Location = new System.Drawing.Point(12, 87);
            this.MainSplashPictureBox.Name = "MainSplashPictureBox";
            this.MainSplashPictureBox.Size = new System.Drawing.Size(660, 362);
            this.MainSplashPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainSplashPictureBox.TabIndex = 1;
            this.MainSplashPictureBox.TabStop = false;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.SmallSplashPictureBox);
            this.Controls.Add(this.WeSellForLessLabel);
            this.Controls.Add(this.WelcomeToDollarComputerLabel);
            this.Controls.Add(this.MainSplashPictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SplashForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SmallSplashPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplashPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.PictureBox MainSplashPictureBox;
        private System.Windows.Forms.Label WelcomeToDollarComputerLabel;
        private System.Windows.Forms.Label WeSellForLessLabel;
        private System.Windows.Forms.PictureBox SmallSplashPictureBox;
    }
}