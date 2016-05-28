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

    class PopulateWithCategories : PopulateUIFromSeparateThread
    {
        private CRUDClient CRUDClient;

        #region Constructors
        public PopulateWithCategories(Form currentForm, DataTable dt,
                                     DataGridNavigation currentPaging,
                                     Display firstOrLastpage,
                                     LoadingCircle currentLoadingCircle)
            : base(currentForm, dt, currentPaging, firstOrLastpage, currentLoadingCircle)
        {
            if (dt.Columns.Count == 0)
            {
                DataManipulation.AddColumnsTheirNamesInDataTable(dt, "Category");

                currentPaging.AllPages = dt;
                currentPaging.FillDataGridWithRecords(Display.FirstPage);
                currentLoadingCircle.Active = true;
            }
        }

        public PopulateWithCategories(Form currentForm, DataTable dt,
                                      DataGridNavigation currentPaging,
                                      Display firstOrLastpage,
                                      LoadingCircle currentLoadingCircle,
                                      CRUDClient CRUDClient)
            : base(currentForm, dt, currentPaging, firstOrLastpage, currentLoadingCircle)
        {
            this.CRUDClient = CRUDClient;
        }

        public PopulateWithCategories(Form currentForm,
                                      ComboBox currentComboBox,
                                      CRUDClient CRUDClient)
            : base(currentForm, null, currentComboBox)
        {
            this.CRUDClient = CRUDClient;
        }
        #endregion

        protected override void GetItemsForDataGridNavigation()
        {
            List<CategoryDTO> categories = CRUDClient.GetCategories();
            foreach (CategoryDTO item in categories)
            {
                FillAndAddDataRow(item.CategoryName);
            }
        }

        protected override void GetItemsForComboBox()
        {
            List<CategoryDTO> categories = CRUDClient.GetCategories();

            foreach (var item in categories)
            {
                AddToComboBox(item.CategoryName.Replace(" ", ""));
            }

        }
    }
}
