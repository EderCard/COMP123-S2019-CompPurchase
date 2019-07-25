using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_CompPurchase
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
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
        /// This is the event handler for the SelectAnotherProductButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the ancelButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.START_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the OpenMenu option SelectOrderOpenFileDialog event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }
        /// <summary>
        /// This is the evet handler for the ProductInfoForm Activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ProductIDDataLabel.Text = Program.computer.ProductId.ToString();
            ConditionDataLabel.Text = Program.computer.Condition;
            CostDataLabel.Text = Program.computer.Cost.ToString();
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
}
