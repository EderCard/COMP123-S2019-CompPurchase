using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace COMP123_S2019_CompPurchase.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This method populate ProductInfoForm with computer object info 
        /// </summary>
        private void PopulateProductInfo()
        {
            //Fill up fields only when a product (Computer) is selected
            if (Program.computer.ProductId != 0)
            {
                ProductIDDataLabel.Text = Program.computer.ProductId.ToString();
                ConditionDataLabel.Text = Program.computer.Condition;
                CostDataLabel.Text = Program.computer.Cost.ToString("C");
                PlataformDataLabel.Text = Program.computer.Plataform;
                OSDataLabel.Text = Program.computer.Os;
                ManufacturerDataLabel.Text = Program.computer.Manufacturer;
                ModelDataLabel.Text = Program.computer.Model;
                MemoryDataLabel.Text = Program.computer.Memory;
                LCDSizeDataLabel.Text = Program.computer.LcdSize;
                HDDDataLabel.Text = Program.computer.Hdd;
                CPUBrandDataLabel.Text = Program.computer.CpuBrand;
                CPUNumberDataLabel.Text = Program.computer.CpuNumber;
                GPUTypeDataLabel.Text = Program.computer.GpuType;
                CPUTypeDataLabel.Text = Program.computer.CpuType;
                CPUSpeedDataLabel.Text = Program.computer.CpuSpeed;
                WebCamDataLabel.Text = Program.computer.WebCam;
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
        public void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Configure the file dialog
            SelectOrderOpenFileDialog.FileName = "Product";
            SelectOrderOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            SelectOrderOpenFileDialog.Filter = "Text documents (*.txt)|*.txt| All Files(*.*)|*.*";
            SelectOrderOpenFileDialog.DefaultExt = ".txt";

            //Open file dialog
            var result = SelectOrderOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(SelectOrderOpenFileDialog.FileName, FileMode.Open)))
                    {
                        //Read stuff from the file into the Computer object
                        Program.computer.ProductId = int.Parse(inputStream.ReadLine());
                        Program.computer.Condition = inputStream.ReadLine();
                        Program.computer.Cost = double.Parse(inputStream.ReadLine());
                        Program.computer.Plataform = inputStream.ReadLine();
                        Program.computer.Os = inputStream.ReadLine();
                        Program.computer.Manufacturer = inputStream.ReadLine();
                        Program.computer.Model = inputStream.ReadLine();
                        Program.computer.Memory = inputStream.ReadLine();
                        Program.computer.LcdSize = inputStream.ReadLine();
                        Program.computer.Hdd = inputStream.ReadLine();
                        Program.computer.CpuBrand = inputStream.ReadLine();
                        Program.computer.CpuNumber = inputStream.ReadLine();
                        Program.computer.GpuType = inputStream.ReadLine();
                        Program.computer.CpuType = inputStream.ReadLine();
                        Program.computer.CpuSpeed = inputStream.ReadLine();
                        Program.computer.WebCam = inputStream.ReadLine();

                        //Cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
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
            var result = SelectOrderSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    //Open stream to write
                    using (StreamWriter outputStream = new StreamWriter(
                        File.Open(SelectOrderSaveFileDialog.FileName, FileMode.Create)))
                    {
                        //Write stuff to the file
                        outputStream.WriteLine(Program.computer.ProductId.ToString());
                        outputStream.WriteLine(Program.computer.Condition);
                        outputStream.WriteLine(Program.computer.Cost);
                        outputStream.WriteLine(Program.computer.Plataform);
                        outputStream.WriteLine(Program.computer.Os);
                        outputStream.WriteLine(Program.computer.Manufacturer);
                        outputStream.WriteLine(Program.computer.Model);
                        outputStream.WriteLine(Program.computer.Memory);
                        outputStream.WriteLine(Program.computer.LcdSize);
                        outputStream.WriteLine(Program.computer.Hdd);
                        outputStream.WriteLine(Program.computer.CpuBrand);
                        outputStream.WriteLine(Program.computer.CpuNumber);
                        outputStream.WriteLine(Program.computer.GpuType);
                        outputStream.WriteLine(Program.computer.CpuType);
                        outputStream.WriteLine(Program.computer.CpuSpeed);
                        outputStream.WriteLine(Program.computer.WebCam);

                        //Cleanup
                        outputStream.Close();
                        outputStream.Dispose();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                MessageBox.Show("File saved successfully!", "Saving...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
