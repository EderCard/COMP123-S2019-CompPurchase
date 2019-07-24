namespace COMP123_S2019_CompPurchase
{
    partial class SelectForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DollarComputerHardwareListLabel = new System.Windows.Forms.Label();
            this.HardwareListDataGridView = new System.Windows.Forms.DataGridView();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.HardwareSelectedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HardwareListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(698, 516);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 35);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(604, 515);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 35);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DollarComputerHardwareListLabel
            // 
            this.DollarComputerHardwareListLabel.AutoSize = true;
            this.DollarComputerHardwareListLabel.Location = new System.Drawing.Point(9, 10);
            this.DollarComputerHardwareListLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DollarComputerHardwareListLabel.Name = "DollarComputerHardwareListLabel";
            this.DollarComputerHardwareListLabel.Size = new System.Drawing.Size(265, 24);
            this.DollarComputerHardwareListLabel.TabIndex = 1;
            this.DollarComputerHardwareListLabel.Text = "Dollar Computer Hardware List";
            // 
            // HardwareListDataGridView
            // 
            this.HardwareListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HardwareListDataGridView.Location = new System.Drawing.Point(13, 37);
            this.HardwareListDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HardwareListDataGridView.Name = "HardwareListDataGridView";
            this.HardwareListDataGridView.ReadOnly = true;
            this.HardwareListDataGridView.Size = new System.Drawing.Size(760, 463);
            this.HardwareListDataGridView.TabIndex = 2;
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.Location = new System.Drawing.Point(11, 516);
            this.YourSelectionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(138, 24);
            this.YourSelectionLabel.TabIndex = 3;
            this.YourSelectionLabel.Text = "Your Selection:";
            this.YourSelectionLabel.Click += new System.EventHandler(this.YourSelectionLabel_Click);
            // 
            // HardwareSelectedLabel
            // 
            this.HardwareSelectedLabel.AutoSize = true;
            this.HardwareSelectedLabel.Location = new System.Drawing.Point(153, 516);
            this.HardwareSelectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HardwareSelectedLabel.Name = "HardwareSelectedLabel";
            this.HardwareSelectedLabel.Size = new System.Drawing.Size(86, 24);
            this.HardwareSelectedLabel.TabIndex = 4;
            this.HardwareSelectedLabel.Text = "--Select--";
            this.HardwareSelectedLabel.Click += new System.EventHandler(this.HardwareSelectedLabel_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.HardwareSelectedLabel);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.HardwareListDataGridView);
            this.Controls.Add(this.DollarComputerHardwareListLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.HardwareListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label DollarComputerHardwareListLabel;
        private System.Windows.Forms.DataGridView HardwareListDataGridView;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.Label HardwareSelectedLabel;
    }
}

