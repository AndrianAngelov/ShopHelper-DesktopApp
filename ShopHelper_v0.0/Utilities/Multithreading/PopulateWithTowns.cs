namespace ShopHelper_v0._0.Utilities.Multithreading
{
    using System;
    using System.Collections.Generic;
    using ShopHelper_v0._0.ShopHelperService;
    using System.Windows.Forms;
    using System.Data;
    using Anyo.WindowsForms.Controls.Navigations;
    using MRG.Controls.UI;

    class PopulateWithTowns : PopulateUIFromSeparateThread
    {
        private CRUDClient CRUDClient;

        #region Constructors
        public PopulateWithTowns(Form currentForm, DataTable dt,
                                  DataGridNavigation currentPaging,
                                  Display firstOrLastpage,
                                  LoadingCircle currentLoadingCircle,
                                  CRUDClient CRUDClient)
            : base(currentForm, dt, currentPaging, firstOrLastpage, currentLoadingCircle)
        {
            this.CRUDClient = CRUDClient;
        }

        public PopulateWithTowns(Form currentForm,
                                  ComboBox currentComboBox,
                                  CRUDClient CRUDClient)
            : base(currentForm, null, currentComboBox)
        {
            this.CRUDClient = CRUDClient;
        }
        #endregion

        protected override void GetItemsForDataGridNavigation()
        {
            List<TownDTO> towns = CRUDClient.GetTowns();
            foreach (TownDTO item in towns)
            {
                FillAndAddDataRow(item.TownName);
            }
        }

        protected override void GetItemsForComboBox()
        {
            List<TownDTO> towns = CRUDClient.GetTowns();

            foreach (var item in towns)
            {
                AddToComboBox(item.TownName.Replace(" ", ""));
            }

        }
    }
}
