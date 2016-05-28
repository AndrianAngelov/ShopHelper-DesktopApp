using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ShopHelper_v0._0.SubForms.ManagerSubForms.VendorsCenterSubForms;
using ShopHelper_v0._0.SubForms.ManagerSubForms.InventoryCenterSubForms;
using ShopHelper_v0._0.SubForms.ManagerSubForms;

namespace ShopHelper_v0._0
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
