using COMP123_S2019_CompPurchase.Models;
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
        /// <summary>
        /// This is the event handler for the SelectForm load event
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
            //local variables that are used as aliases
            var currentCell = ProductsDataGridView.CurrentCell;
            var rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var currentRow = ProductsDataGridView.Rows[rowIndex];
            var columnCount = ProductsDataGridView.ColumnCount;
            var cells = currentRow.Cells;

            currentRow.Selected = true;

            string outputString = string.Empty;

            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value + " ";
            }

            //Populate a computer object with info from a line selected in DataGridView
            Program.product.productID = short.Parse(cells[(int)ComputersFields.PRODUCT_ID].Value.ToString());
            Program.product.cost = decimal.Parse(cells[(int)ComputersFields.COST].Value.ToString());
            Program.product.manufacturer = cells[(int)ComputersFields.MANUFACTURER].Value.ToString();
            Program.product.condition = cells[(int)ComputersFields.CONDITION].Value.ToString();
            Program.product.platform = cells[(int)ComputersFields.PLATFORM].Value.ToString();
            Program.product.OS = cells[(int)ComputersFields.OS].Value.ToString();
            Program.product.model = cells[(int)ComputersFields.MODEL].Value.ToString();
            Program.product.RAM_size = cells[(int)ComputersFields.RAM_SIZE].Value.ToString();
            Program.product.displaytype = cells[(int)ComputersFields.DISPLAY_TYPE].Value.ToString();
            Program.product.HDD_size = cells[(int)ComputersFields.HDD_SIZE].Value.ToString();
            Program.product.CPU_brand = cells[(int)ComputersFields.CPU_BRAND].Value.ToString();
            Program.product.CPU_number = cells[(int)ComputersFields.CPU_NUMBER].Value.ToString();
            Program.product.GPU_Type = cells[(int)ComputersFields.GPU_TYPE].Value.ToString();
            Program.product.CPU_type = cells[(int)ComputersFields.CPU_TYPE].Value.ToString();
            Program.product.CPU_speed = cells[(int)ComputersFields.CPU_SPEED].Value.ToString();
            Program.product.webcam = cells[(int)ComputersFields.WEBCAM].Value.ToString();

            //Populate Your Selection Label
            HardwareSelectedLabel.Text = Program.product.manufacturer.ToString() + " " +
                                         Program.product.model.ToString() + " " +
                                         (decimal)Program.product.cost;

            NextButton.Enabled = true;
        }
    }
}
