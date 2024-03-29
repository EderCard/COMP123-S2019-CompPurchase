﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*
 * Name: Ederson Cardoso
 *   ID: 301033332
 *   
 * This program simulate a computer purchase from Dollar Computers store.
 * Created on: July 22, 2019.
 * Last modified on: August 12, 2019.
 * V: 1.0.0-00
 */
namespace COMP123_S2019_CompPurchase.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            //Disable Next button until form filled
            NextButton.Enabled = false;
        }
        /// <summary>
        /// This method populate ProductInfoForm with computer object info 
        /// </summary>
        private void PopulateProductInfo()
        {
            //Fill up fields only when a product (Computer) is selected
            if (Program.product.productID != 0)
            {
                ProductIDDataLabel.Text = Program.product.productID.ToString();
                ConditionDataLabel.Text = Program.product.condition;
                CostDataLabel.Text = ((decimal)Program.product.cost).ToString("C");
                PlataformDataLabel.Text = Program.product.platform;
                OSDataLabel.Text = Program.product.OS;
                ManufacturerDataLabel.Text = Program.product.manufacturer;
                ModelDataLabel.Text = Program.product.model;
                MemoryDataLabel.Text = Program.product.RAM_size;
                LCDSizeDataLabel.Text = Program.product.screensize;
                HDDDataLabel.Text = Program.product.HDD_size;
                CPUBrandDataLabel.Text = Program.product.CPU_brand;
                CPUNumberDataLabel.Text = Program.product.CPU_number;
                GPUTypeDataLabel.Text = Program.product.GPU_Type;
                CPUTypeDataLabel.Text = Program.product.CPU_type;
                CPUSpeedDataLabel.Text = Program.product.CPU_speed;
                WebCamDataLabel.Text = Program.product.webcam;
                
                //Enabble Next button after form filled
                NextButton.Enabled = true;
            }
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm Activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            PopulateProductInfo();
        }
        /// <summary>
        /// This is the event handler for the ProductInfoForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is the shared event handler for the SelectAnotherProductButton and SelectAnotherProductToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is the shared event handler for the CancelButton and exitToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the OpenToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog();
        }
        /// <summary>
        /// This method opens a OpenFileDialog.
        /// </summary>
        public void OpenFileDialog()
        {
            //Configure the file dialog
            SelectOrderOpenFileDialog.FileName = "Product";
            SelectOrderOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SelectOrderOpenFileDialog.Filter = "Text documents (*.txt)|*.txt| All Files(*.*)|*.*";
            SelectOrderOpenFileDialog.DefaultExt = ".txt";

            //Open file dialog
            var _result = SelectOrderOpenFileDialog.ShowDialog();
            if (_result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(SelectOrderOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Read stuff from the file into the Product object
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();

                        //Cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            PopulateProductInfo();
        }
        /// <summary>
        /// This is the event handler for the SaveToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configure the file dialog
            SelectOrderSaveFileDialog.FileName = "Product";
            SelectOrderSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SelectOrderSaveFileDialog.Filter= "Text documents (*.txt)|*.txt| All Files(*.*)|*.*";
            SelectOrderSaveFileDialog.DefaultExt = ".txt";

            //Open file dialog
            var _result = SelectOrderSaveFileDialog.ShowDialog();
            if (_result != DialogResult.Cancel)
            {
                try
                {
                    //Open stream to write
                    using (StreamWriter outputStream = new StreamWriter(
                        File.Open(SelectOrderSaveFileDialog.FileName, FileMode.Create)))
                    {
                        //Write stuff to the file
                        outputStream.WriteLine(Program.product.productID.ToString());
                        outputStream.WriteLine(Program.product.condition);
                        outputStream.WriteLine(Program.product.cost);
                        outputStream.WriteLine(Program.product.platform);
                        outputStream.WriteLine(Program.product.OS);
                        outputStream.WriteLine(Program.product.manufacturer);
                        outputStream.WriteLine(Program.product.model);
                        outputStream.WriteLine(Program.product.RAM_size);
                        outputStream.WriteLine(Program.product.screensize);
                        outputStream.WriteLine(Program.product.HDD_size);
                        outputStream.WriteLine(Program.product.CPU_brand);
                        outputStream.WriteLine(Program.product.CPU_number);
                        outputStream.WriteLine(Program.product.GPU_Type);
                        outputStream.WriteLine(Program.product.CPU_type);
                        outputStream.WriteLine(Program.product.CPU_speed);
                        outputStream.WriteLine(Program.product.webcam);

                        //Cleanup
                        outputStream.Close();
                        outputStream.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("File saved successfully!", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
