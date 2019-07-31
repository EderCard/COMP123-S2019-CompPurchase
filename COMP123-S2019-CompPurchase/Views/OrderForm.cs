using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_CompPurchase.Views
{
    public partial class OrderForm : Form
    {
        const double SALES_TAX = .13;
        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the OrderForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the FinishButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for your purchase.\n\nYour Order will be processed in 7-10 business days.", 
                "Order Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
        /// <summary>
        ///  This is the shared event handler for the CancelButton and ExitToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the shared event handler for the BackButton and BackToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the OrderForm activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionDataLabel.Text = Program.computer.Condition;
            PriceDataLabel.Text = (Program.computer.Cost).ToString("C");
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
            //Calculate Sales Tax
            SalesTaxDataLabel.Text = (Program.computer.Cost * SALES_TAX).ToString("C");
            //Calculate Total Price
            TotalDataLabel.Text = (Program.computer.Cost * (1+ SALES_TAX)).ToString("C");
        }
        /// <summary>
        /// This is the evnt handler for the PrintToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing Order...", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// This is the event handler for the AboutToolStripMenuItem click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }
    }
}
