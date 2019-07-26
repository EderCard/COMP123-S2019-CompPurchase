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
        // Properties
       // public products SelectedProduct { get; set; }
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
        /// <summary>
        /// This is the event handler for the  SelectForm load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            NextButton.Enabled = false;
        }
        /// <summary>
        /// This is the event handler for the HardwareListDataGridView SelectionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HardwareListDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Store temporal the product selected on the datagrid
            //products tempProduct = HardwareListDataGridView.CurrentRow.DataBoundItem as products;

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

            HardwareSelectedLabel.Text = 
                HardwareListDataGridView.SelectedRows[0].Cells[(int)ComputerField.MANUFACTURER].Value.ToString() + " " + 
                HardwareListDataGridView.SelectedRows[0].Cells[(int)ComputerField.MODEL].Value.ToString() + " Priced at: " +
                double.Parse(HardwareListDataGridView.SelectedRows[0].Cells[(int)ComputerField.COST].Value.ToString());

            PopulateProductInfoForm(cells);

            NextButton.Enabled = true;
        }
        /// <summary>
        /// This method populate a computer object with info from a line selected in DataGridView
        /// </summary>
        /// <param name="cells"></param>
        private static void PopulateProductInfoForm(DataGridViewCellCollection cells)
        {
            Program.computer.ProductId = int.Parse(cells[(int)ComputerField.PRODUCT_ID].Value.ToString());
            Program.computer.Cost = double.Parse(cells[(int)ComputerField.COST].Value.ToString());
            Program.computer.Manufacturer = cells[(int)ComputerField.MANUFACTURER].Value.ToString();
            Program.computer.Condition = cells[(int)ComputerField.CONDITION].Value.ToString();
            Program.computer.Plataform = cells[(int)ComputerField.PLATFORM].Value.ToString();
            Program.computer.Os = cells[(int)ComputerField.OS].Value.ToString();
            Program.computer.Model = cells[(int)ComputerField.MODEL].Value.ToString();
            Program.computer.Memory = cells[(int)ComputerField.MEMORY].Value.ToString();
            Program.computer.LcdSize = cells[(int)ComputerField.LCD_SIZE].Value.ToString();
            Program.computer.Hdd = cells[(int)ComputerField.HDD].Value.ToString();
            Program.computer.CpuBrand = cells[(int)ComputerField.CPU_BRAND].Value.ToString();
            Program.computer.CpuNumber = cells[(int)ComputerField.CPU_NUMBER].Value.ToString();
            Program.computer.GpuType = cells[(int)ComputerField.GPU_TYPE].Value.ToString();
            Program.computer.CpuType = cells[(int)ComputerField.CPU_TYPE].Value.ToString();
            Program.computer.CpuSpeed = cells[(int)ComputerField.CPU_SPEED].Value.ToString();
            Program.computer.WebCam = cells[(int)ComputerField.WEBCAM].Value.ToString();
        }
    }
}
