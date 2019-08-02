using COMP123_S2019_CompPurchase.Views;
using COMP123_S2019_CompPurchase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
namespace COMP123_S2019_CompPurchase
{
    public static class Program
    {
        public static Product product;
        
        //Using a Dictionary and an ENUM to handle Form Names
        public static Dictionary<FormName, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //creating forms from an ENUM
            Forms = new Dictionary<FormName, Form>();
            Forms.Add(FormName.SPLASH_FORM, new SplashForm());
            Forms.Add(FormName.START_FORM, new StartForm());
            Forms.Add(FormName.SELECT_FORM, new SelectForm());
            Forms.Add(FormName.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormName.ORDER_FORM, new OrderForm());
            Forms.Add(FormName.ABOUT_FORM, new AboutForm());

            //creating a product object
            product = new Product();

            Application.Run(Forms[FormName.SPLASH_FORM]);
        }
    }
}
