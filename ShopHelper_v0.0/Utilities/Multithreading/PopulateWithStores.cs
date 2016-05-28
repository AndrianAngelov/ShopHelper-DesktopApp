namespace ShopHelper_v0._0.Utilities.Multithreading
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Data;
    using Anyo.WindowsForms.Controls.Navigations;
    using ShopHelper_v0._0.ShopHelperService;
    using MRG.Controls.UI;

    class PopulateWithStores:PopulateUIFromSeparateThread
    {
        private CRUDClient CRUDClient;

        #region Constructors
        public PopulateWithStores(Form currentForm, DataTable dt,
                                  DataGridNavigation currentPaging,
                                  Display firstOrLastpage,
                                  LoadingCircle currentLoadingCircle,
                                  CRUDClient CRUDClient)
            : base(currentForm, dt, currentPaging, firstOrLastpage, currentLoadingCircle)
        {
            this.CRUDClient = CRUDClient;
        }

        public PopulateWithStores(Form currentForm,
                                  ComboBox currentComboBox,
                                  CRUDClient CRUDClient)
            : base(currentForm, null, currentComboBox)
        {
            this.CRUDClient = CRUDClient;
        }
        #endregion

        protected override void GetItemsForDataGridNavigation()
        {
            List<StoreDTO> stores = CRUDClient.GetStores();
            foreach (StoreDTO item in stores)
            {
                FillAndAddDataRow(item.StoreName);
            }
        }

        protected override void GetItemsForComboBox()
        {
            List<StoreDTO> stores = CRUDClient.GetStores();

            foreach (var item in stores)
            {
                AddToComboBox(item.StoreName.Replace(" ", ""));
            }

        }
    }
}
