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
/*
 * Name: Ederson Cardoso
 *   ID: 301033332
 *   
 * This program calculate simulate a computer purchase from Dollar Computers store.
 * Created on: July 22, 2019.
 * Last modified on: August 01, 2019.
 * V: 1.0.0-00
 */
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

            //Disable Next button until selection
            NextButton.Enabled = false;
        }
        /// <summary>
        /// This is the event handler for the ProductsDataGridView SelectionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //local variables that are used as aliases
            var _currentCell = ProductsDataGridView.CurrentCell;
            var _rowIndex = ProductsDataGridView.CurrentCell.RowIndex;
            var _currentRow = ProductsDataGridView.Rows[_rowIndex];
            var _columnCount = ProductsDataGridView.ColumnCount;
            var _cells = _currentRow.Cells;

            _currentRow.Selected = true;

            string _outputString = string.Empty;

            for (int _index = 0; _index < _columnCount; _index++)
            {
                _outputString += _cells[_index].Value + " ";
            }

            //Populate a computer object with info from a line selected in DataGridView
            Program.product.productID = short.Parse(_cells[(int)ProductFields.PRODUCT_ID].Value.ToString());
            Program.product.cost = decimal.Parse(_cells[(int)ProductFields.COST].Value.ToString());
            Program.product.manufacturer = _cells[(int)ProductFields.MANUFACTURER].Value.ToString();
            Program.product.condition = _cells[(int)ProductFields.CONDITION].Value.ToString();
            Program.product.platform = _cells[(int)ProductFields.PLATFORM].Value.ToString();
            Program.product.OS = _cells[(int)ProductFields.OS].Value.ToString();
            Program.product.model = _cells[(int)ProductFields.MODEL].Value.ToString();
            Program.product.RAM_size = _cells[(int)ProductFields.RAM_SIZE].Value.ToString();
            Program.product.screensize = _cells[(int)ProductFields.SCREEN_SIZE].Value.ToString();
            Program.product.HDD_size = _cells[(int)ProductFields.HDD_SIZE].Value.ToString();
            Program.product.CPU_brand = _cells[(int)ProductFields.CPU_BRAND].Value.ToString();
            Program.product.CPU_number = _cells[(int)ProductFields.CPU_NUMBER].Value.ToString();
            Program.product.GPU_Type = _cells[(int)ProductFields.GPU_TYPE].Value.ToString();
            Program.product.CPU_type = _cells[(int)ProductFields.CPU_TYPE].Value.ToString();
            Program.product.CPU_speed = _cells[(int)ProductFields.CPU_SPEED].Value.ToString();
            Program.product.webcam = _cells[(int)ProductFields.WEBCAM].Value.ToString();

            //Populate Your Selection TextBox
            SelectedProductTextBox.Text = Program.product.manufacturer.ToString() + " " +
                                         Program.product.model.ToString() + " " +
                                         ((decimal)Program.product.cost).ToString("C");

            //Enable Next button after selecion
            NextButton.Enabled = true;
        }
    }
}
