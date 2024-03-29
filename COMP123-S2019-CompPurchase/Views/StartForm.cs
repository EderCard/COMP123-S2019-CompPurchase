﻿using System;
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
 * This program simulate a computer purchase from Dollar Computers store.
 * Created on: July 22, 2019.
 * Last modified on: August 12, 2019.
 * V: 1.0.0-00
 */
namespace COMP123_S2019_CompPurchase.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This is the event handler for the StarForm closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the ExitButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This is the event handler for the StartNewOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartNewOrderButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }
        /// <summary>
        /// This is the event handler for the OpenSavedOrderButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenSavedOrderButton_Click(object sender, EventArgs e)
        {
            // Local variable to handle ProductInfoForm instantiation
            var _productInfoForm = Program.Forms[FormName.PRODUCT_INFO_FORM] as ProductInfoForm;

            _productInfoForm.Show();
            _productInfoForm.OpenFileDialog();

            this.Hide();
        }
    }
}
