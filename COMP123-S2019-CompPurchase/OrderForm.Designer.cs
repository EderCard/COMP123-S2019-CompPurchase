﻿namespace COMP123_S2019_CompPurchase
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.PlataformDataLabel = new System.Windows.Forms.Label();
            this.PlataformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ManufacturerDataLabel = new System.Windows.Forms.Label();
            this.ModelDataLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ProductDetailsPanel = new System.Windows.Forms.Panel();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.LCDSizeDataLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.MemoryDataLabel = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberDataLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUSpeedDataLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.WebCamDataLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.OSDataLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.dollarComputersDataSet1 = new COMP123_S2019_CompPurchase.DollarComputersDataSet();
            this.PriceDataLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SalesTaxDataLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalDataLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.GPUTypeDataLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormMenuStrip.SuspendLayout();
            this.systemComponentsGroupBox.SuspendLayout();
            this.YourPriceGroupBox.SuspendLayout();
            this.ProductDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(610, 526);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(1);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 25);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(699, 526);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(1);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(75, 25);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(543, 526);
            this.BackButton.Margin = new System.Windows.Forms.Padding(1);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(55, 25);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.OrderFormMenuStrip.TabIndex = 5;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.undoToolStripMenuItem.Text = "&Back";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // systemComponentsGroupBox
            // 
            this.systemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.systemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.systemComponentsGroupBox.Controls.Add(this.ProductDetailsPanel);
            this.systemComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.systemComponentsGroupBox.Controls.Add(this.WebCamLabel);
            this.systemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.systemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.systemComponentsGroupBox.Controls.Add(this.ConditionDataLabel);
            this.systemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.systemComponentsGroupBox.Controls.Add(this.PlataformLabel);
            this.systemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.systemComponentsGroupBox.Controls.Add(this.PlataformDataLabel);
            this.systemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.systemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.systemComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.systemComponentsGroupBox.Controls.Add(this.ManufacturerDataLabel);
            this.systemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.systemComponentsGroupBox.Controls.Add(this.ModelDataLabel);
            this.systemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.systemComponentsGroupBox.Location = new System.Drawing.Point(12, 38);
            this.systemComponentsGroupBox.Name = "systemComponentsGroupBox";
            this.systemComponentsGroupBox.Size = new System.Drawing.Size(438, 513);
            this.systemComponentsGroupBox.TabIndex = 6;
            this.systemComponentsGroupBox.TabStop = false;
            this.systemComponentsGroupBox.Text = "System Components";
            // 
            // YourPriceGroupBox
            // 
            this.YourPriceGroupBox.Controls.Add(this.TotalLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceDataLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxDataLabel);
            this.YourPriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.YourPriceGroupBox.Controls.Add(this.TotalDataLabel);
            this.YourPriceGroupBox.Controls.Add(this.PriceLabel);
            this.YourPriceGroupBox.Location = new System.Drawing.Point(456, 214);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.YourPriceGroupBox.Size = new System.Drawing.Size(318, 203);
            this.YourPriceGroupBox.TabIndex = 7;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionDataLabel.BackColor = System.Drawing.Color.White;
            this.ConditionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionDataLabel.Location = new System.Drawing.Point(114, 66);
            this.ConditionDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(104, 23);
            this.ConditionDataLabel.TabIndex = 8;
            this.ConditionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConditionLabel.Location = new System.Drawing.Point(6, 69);
            this.ConditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(104, 17);
            this.ConditionLabel.TabIndex = 9;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlataformDataLabel
            // 
            this.PlataformDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlataformDataLabel.BackColor = System.Drawing.Color.White;
            this.PlataformDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlataformDataLabel.Location = new System.Drawing.Point(329, 32);
            this.PlataformDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlataformDataLabel.Name = "PlataformDataLabel";
            this.PlataformDataLabel.Size = new System.Drawing.Size(104, 23);
            this.PlataformDataLabel.TabIndex = 11;
            this.PlataformDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlataformLabel
            // 
            this.PlataformLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PlataformLabel.Location = new System.Drawing.Point(221, 35);
            this.PlataformLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlataformLabel.Name = "PlataformLabel";
            this.PlataformLabel.Size = new System.Drawing.Size(104, 16);
            this.PlataformLabel.TabIndex = 10;
            this.PlataformLabel.Text = "Plataform";
            this.PlataformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ManufacturerLabel.Location = new System.Drawing.Point(6, 35);
            this.ManufacturerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(104, 16);
            this.ManufacturerLabel.TabIndex = 12;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerDataLabel
            // 
            this.ManufacturerDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerDataLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturerDataLabel.Location = new System.Drawing.Point(114, 32);
            this.ManufacturerDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ManufacturerDataLabel.Name = "ManufacturerDataLabel";
            this.ManufacturerDataLabel.Size = new System.Drawing.Size(104, 23);
            this.ManufacturerDataLabel.TabIndex = 13;
            this.ManufacturerDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelDataLabel
            // 
            this.ModelDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelDataLabel.BackColor = System.Drawing.Color.White;
            this.ModelDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelDataLabel.Location = new System.Drawing.Point(329, 66);
            this.ModelDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModelDataLabel.Name = "ModelDataLabel";
            this.ModelDataLabel.Size = new System.Drawing.Size(104, 21);
            this.ModelDataLabel.TabIndex = 15;
            this.ModelDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ModelLabel.Location = new System.Drawing.Point(224, 66);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(101, 18);
            this.ModelLabel.TabIndex = 14;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductDetailsPanel
            // 
            this.ProductDetailsPanel.BackColor = System.Drawing.Color.White;
            this.ProductDetailsPanel.Controls.Add(this.GPUTypeDataLabel);
            this.ProductDetailsPanel.Controls.Add(this.OSDataLabel);
            this.ProductDetailsPanel.Controls.Add(this.LCDSizeDataLabel);
            this.ProductDetailsPanel.Controls.Add(this.MemoryDataLabel);
            this.ProductDetailsPanel.Controls.Add(this.WebCamDataLabel);
            this.ProductDetailsPanel.Controls.Add(this.CPUBrandDataLabel);
            this.ProductDetailsPanel.Controls.Add(this.CPUTypeDataLabel);
            this.ProductDetailsPanel.Controls.Add(this.CPUNumberDataLabel);
            this.ProductDetailsPanel.Controls.Add(this.CPUSpeedDataLabel);
            this.ProductDetailsPanel.Controls.Add(this.HDDDataLabel);
            this.ProductDetailsPanel.Location = new System.Drawing.Point(114, 141);
            this.ProductDetailsPanel.Name = "ProductDetailsPanel";
            this.ProductDetailsPanel.Size = new System.Drawing.Size(318, 348);
            this.ProductDetailsPanel.TabIndex = 16;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LCDSizeLabel.Location = new System.Drawing.Point(7, 144);
            this.LCDSizeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(103, 16);
            this.LCDSizeLabel.TabIndex = 17;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeDataLabel
            // 
            this.LCDSizeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCDSizeDataLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeDataLabel.Location = new System.Drawing.Point(0, 0);
            this.LCDSizeDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LCDSizeDataLabel.Name = "LCDSizeDataLabel";
            this.LCDSizeDataLabel.Size = new System.Drawing.Size(316, 23);
            this.LCDSizeDataLabel.TabIndex = 18;
            this.LCDSizeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MemoryLabel.Location = new System.Drawing.Point(51, 180);
            this.MemoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(58, 16);
            this.MemoryLabel.TabIndex = 19;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryDataLabel
            // 
            this.MemoryDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryDataLabel.BackColor = System.Drawing.Color.White;
            this.MemoryDataLabel.Location = new System.Drawing.Point(0, 36);
            this.MemoryDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MemoryDataLabel.Name = "MemoryDataLabel";
            this.MemoryDataLabel.Size = new System.Drawing.Size(316, 23);
            this.MemoryDataLabel.TabIndex = 20;
            this.MemoryDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(0, 72);
            this.CPUBrandDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(316, 23);
            this.CPUBrandDataLabel.TabIndex = 21;
            this.CPUBrandDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CPUBrandLabel.Location = new System.Drawing.Point(6, 216);
            this.CPUBrandLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(104, 16);
            this.CPUBrandLabel.TabIndex = 20;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(0, 108);
            this.CPUTypeDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(316, 23);
            this.CPUTypeDataLabel.TabIndex = 23;
            this.CPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CPUTypeLabel.Location = new System.Drawing.Point(10, 252);
            this.CPUTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(100, 16);
            this.CPUTypeLabel.TabIndex = 22;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberDataLabel
            // 
            this.CPUNumberDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUNumberDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberDataLabel.Location = new System.Drawing.Point(0, 145);
            this.CPUNumberDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUNumberDataLabel.Name = "CPUNumberDataLabel";
            this.CPUNumberDataLabel.Size = new System.Drawing.Size(316, 23);
            this.CPUNumberDataLabel.TabIndex = 24;
            this.CPUNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CPUNumberLabel.Location = new System.Drawing.Point(10, 288);
            this.CPUNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(103, 18);
            this.CPUNumberLabel.TabIndex = 23;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedDataLabel
            // 
            this.CPUSpeedDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSpeedDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedDataLabel.Location = new System.Drawing.Point(0, 180);
            this.CPUSpeedDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUSpeedDataLabel.Name = "CPUSpeedDataLabel";
            this.CPUSpeedDataLabel.Size = new System.Drawing.Size(316, 23);
            this.CPUSpeedDataLabel.TabIndex = 25;
            this.CPUSpeedDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(13, 324);
            this.CPUSpeedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(100, 16);
            this.CPUSpeedLabel.TabIndex = 24;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDDataLabel.BackColor = System.Drawing.Color.White;
            this.HDDDataLabel.Location = new System.Drawing.Point(0, 215);
            this.HDDDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(316, 23);
            this.HDDDataLabel.TabIndex = 26;
            this.HDDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.HDDLabel.Location = new System.Drawing.Point(10, 359);
            this.HDDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(98, 16);
            this.HDDLabel.TabIndex = 25;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebCamDataLabel
            // 
            this.WebCamDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebCamDataLabel.BackColor = System.Drawing.Color.White;
            this.WebCamDataLabel.Location = new System.Drawing.Point(0, 289);
            this.WebCamDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebCamDataLabel.Name = "WebCamDataLabel";
            this.WebCamDataLabel.Size = new System.Drawing.Size(316, 23);
            this.WebCamDataLabel.TabIndex = 28;
            this.WebCamDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WebCamLabel.Location = new System.Drawing.Point(10, 433);
            this.WebCamLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(98, 16);
            this.WebCamLabel.TabIndex = 27;
            this.WebCamLabel.Text = "WebCam";
            this.WebCamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSDataLabel
            // 
            this.OSDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OSDataLabel.BackColor = System.Drawing.Color.White;
            this.OSDataLabel.Location = new System.Drawing.Point(0, 325);
            this.OSDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OSDataLabel.Name = "OSDataLabel";
            this.OSDataLabel.Size = new System.Drawing.Size(316, 23);
            this.OSDataLabel.TabIndex = 29;
            this.OSDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSLabel
            // 
            this.OSLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OSLabel.Location = new System.Drawing.Point(4, 469);
            this.OSLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(104, 16);
            this.OSLabel.TabIndex = 28;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dollarComputersDataSet1
            // 
            this.dollarComputersDataSet1.DataSetName = "DollarComputersDataSet";
            this.dollarComputersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PriceDataLabel
            // 
            this.PriceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceDataLabel.BackColor = System.Drawing.Color.White;
            this.PriceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceDataLabel.Location = new System.Drawing.Point(209, 37);
            this.PriceDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceDataLabel.Name = "PriceDataLabel";
            this.PriceDataLabel.Size = new System.Drawing.Size(104, 23);
            this.PriceDataLabel.TabIndex = 9;
            this.PriceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PriceLabel.Location = new System.Drawing.Point(5, 42);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(104, 18);
            this.PriceLabel.TabIndex = 10;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SalesTaxDataLabel
            // 
            this.SalesTaxDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTaxDataLabel.BackColor = System.Drawing.Color.White;
            this.SalesTaxDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesTaxDataLabel.Location = new System.Drawing.Point(209, 73);
            this.SalesTaxDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalesTaxDataLabel.Name = "SalesTaxDataLabel";
            this.SalesTaxDataLabel.Size = new System.Drawing.Size(104, 23);
            this.SalesTaxDataLabel.TabIndex = 9;
            this.SalesTaxDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SalesTaxLabel.Location = new System.Drawing.Point(5, 78);
            this.SalesTaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(200, 18);
            this.SalesTaxLabel.TabIndex = 10;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            this.SalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalDataLabel
            // 
            this.TotalDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalDataLabel.BackColor = System.Drawing.Color.White;
            this.TotalDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalDataLabel.Location = new System.Drawing.Point(209, 145);
            this.TotalDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalDataLabel.Name = "TotalDataLabel";
            this.TotalDataLabel.Size = new System.Drawing.Size(104, 23);
            this.TotalDataLabel.TabIndex = 9;
            this.TotalDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalLabel.Location = new System.Drawing.Point(5, 150);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(104, 18);
            this.TotalLabel.TabIndex = 10;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeDataLabel
            // 
            this.GPUTypeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeDataLabel.Location = new System.Drawing.Point(0, 254);
            this.GPUTypeDataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPUTypeDataLabel.Name = "GPUTypeDataLabel";
            this.GPUTypeDataLabel.Size = new System.Drawing.Size(316, 23);
            this.GPUTypeDataLabel.TabIndex = 31;
            this.GPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GPUTypeLabel.Location = new System.Drawing.Point(15, 398);
            this.GPUTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(95, 16);
            this.GPUTypeLabel.TabIndex = 30;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.Image = global::COMP123_S2019_CompPurchase.Properties.Resources.Product;
            this.ProductPictureBox.Location = new System.Drawing.Point(456, 49);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(178, 149);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPictureBox.TabIndex = 8;
            this.ProductPictureBox.TabStop = false;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.YourPriceGroupBox);
            this.Controls.Add(this.systemComponentsGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Your Order";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.systemComponentsGroupBox.ResumeLayout(false);
            this.YourPriceGroupBox.ResumeLayout(false);
            this.ProductDetailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox systemComponentsGroupBox;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label PlataformDataLabel;
        private System.Windows.Forms.Label PlataformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ManufacturerDataLabel;
        private System.Windows.Forms.Panel ProductDetailsPanel;
        private System.Windows.Forms.Label ModelDataLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label LCDSizeDataLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label MemoryDataLabel;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUNumberDataLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUSpeedDataLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label WebCamDataLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label OSDataLabel;
        private DollarComputersDataSet dollarComputersDataSet1;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label PriceDataLabel;
        private System.Windows.Forms.Label SalesTaxDataLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TotalDataLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label GPUTypeDataLabel;
    }
}