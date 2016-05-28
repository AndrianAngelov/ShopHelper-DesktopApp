namespace ShopHelper_v0._0.Utilities.Multithreading
{
    using System;
    using System.Collections.Generic;
    using ShopHelper_v0._0.ShopHelperService;
    using System.Windows.Forms;
    using System.Data;
    using Anyo.WindowsForms.Controls.Navigations;
    using MRG.Controls.UI;
    using Anyo.WindowsForms.CommonFunctionality;

    class PopulateWithVendors:PopulateUIFromSeparateThread
    {
        private CRUDClient CRUDClient;

        #region Constructors
        public PopulateWithVendors(Form currentForm, DataTable dt,
                                  DataGridNavigation currentPaging,
                                  Display firstOrLastpage,
                                  LoadingCircle currentLoadingCircle)
            : base(currentForm, dt, currentPaging, firstOrLastpage, currentLoadingCircle)
        {
            if (dt.Columns.Count == 0)
            {
                DataManipulation.AddColumnsTheirNamesInDataTable(dt, "Vendor");

                currentPaging.AllPages = dt;
                currentPaging.FillDataGridWithRecords(Display.FirstPage);
                currentLoadingCircle.Active = true;
            }
        }

        public PopulateWithVendors(Form currentForm, DataTable dt,
                                   DataGridNavigation currentPaging,
                                   Display firstOrLastpage,
                                   LoadingCircle currentLoadingCircle,
                                   CRUDClient CRUDClient)
            : base(currentForm, dt, currentPaging, firstOrLastpage, currentLoadingCircle)
        {
            this.CRUDClient = CRUDClient;
        }

        public PopulateWithVendors(Form currentForm,
                                   ComboBox currentComboBox,
                                   CRUDClient CRUDClient)
            : base(currentForm, null,currentComboBox)
        {
            this.CRUDClient = CRUDClient;
        } 
        #endregion

        protected override void GetItemsForDataGridNavigation()
        {
            List<VendorDTO> vendors = CRUDClient.GetVendors();
            foreach (VendorDTO item in vendors)
            {
                FillAndAddDataRow(item.VendorName);
            }
        }

        protected override void GetItemsForComboBox()
        {
            List<VendorDTO> vendors = CRUDClient.GetVendors();

            foreach (var item in vendors)
            {
                AddToComboBox(item.VendorName.Replace(" ", ""));
            }
            
        }
    }
}
