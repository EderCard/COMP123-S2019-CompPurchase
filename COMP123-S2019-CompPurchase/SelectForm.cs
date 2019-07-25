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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the SelectForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_FormClosing(object sender, FormClosingEventArgs e)
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
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the CancelButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HardwareSelectedLabel_Click(object sender, EventArgs e)
        {

        }

        private void YourSelectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }
        /// <summary>
        /// This is the event handler for the HardwareListDataGridView SelectionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HardwareListDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //local variables that are used as aliases
            var currentCell = HardwareListDataGridView.CurrentCell;
            var rowIndex = HardwareListDataGridView.CurrentCell.RowIndex;
            var currentRow = HardwareListDataGridView.Rows[rowIndex];
            var columnCount = HardwareListDataGridView.ColumnCount;
            var cells = currentRow.Cells;

            currentRow.Selected = true;

            string outputString = ""; //or string.Empty

            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value + " ";
            }

            HardwareSelectedLabel.Text = outputString;

            Program.computer.ProductId = int.Parse(cells[(int)computerField.PRODUCT_ID].Value.ToString());
            Program.computer.Condition = cells[(int)computerField.CONDITION].Value.ToString();
            //Program.computer.Cost = float.Parse(cells[(int)computerField.COST].Value.ToString());
            Program.computer.Plataform = cells[(int)computerField.PLATFORM].Value.ToString();
            Program.computer.Os = cells[(int)computerField.OS].Value.ToString();
            Program.computer.Manufacturer = cells[(int)computerField.MANUFACTURER].Value.ToString();
            Program.computer.Model = cells[(int)computerField.MODEL].Value.ToString();
            Program.computer.Memory = cells[(int)computerField.MEMORY].Value.ToString();
            Program.computer.LcdSize = cells[(int)computerField.LCD_SIZE].Value.ToString();
            Program.computer.Hdd = cells[(int)computerField.HDD].Value.ToString();
            Program.computer.CpuBrand = cells[(int)computerField.CPU_BRAND].Value.ToString();
            Program.computer.CpuNumber = cells[(int)computerField.CPU_NUMBER].Value.ToString();
            Program.computer.GpuType = cells[(int)computerField.GPU_TYPE].Value.ToString();
            Program.computer.CpuType = cells[(int)computerField.CPU_TYPE].Value.ToString();
            Program.computer.CpuSpeed = cells[(int)computerField.CPU_SPEED].Value.ToString();
            Program.computer.WebCam = cells[(int)computerField.WEBCAM].Value.ToString();
        }
    }
}
