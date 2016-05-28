namespace ShopHelper_v0._0.Utilities.Multithreading
{
    using System;
    using System.Collections.Generic;
    using ShopHelper_v0._0.ShopHelperService;
    using System.Data;
    using System.Windows.Forms;
    using Anyo.WindowsForms.Controls.Navigations;
    using MRG.Controls.UI;
    using Anyo.WindowsForms.CommonFunctionality;

    public class PopulateWithProducts : PopulateUIFromSeparateThread
    {
        private CRUDClient CRUDClient;

        public PopulateWithProducts(Form currentForm, DataTable dt,
                                    DataGridNavigation currentPaging,
                                    Display firstOrLastPage,
                                    LoadingCircle currentLoadingCircle)
            : base(currentForm, dt, currentPaging, firstOrLastPage, currentLoadingCircle)
        {
            if (dt.Columns.Count == 0)
            {
                DataManipulation.AddColumnsTheirNamesInDataTable(dt, "Product", "Category", "Vendor", "Price", "Quantity", "Store", "Town");

                currentPaging.AllPages = dt;
                currentPaging.FillDataGridWithRecords(Display.FirstPage);
                currentLoadingCircle.Active = true;
            }
        }

        public PopulateWithProducts(Form currentForm,DataTable dt,
                                    DataGridNavigation currentPaging,
                                    Display firstOrLastPage,
                                    LoadingCircle currentLoadingCircle,
                                    CRUDClient CRUDClient)
            : base(currentForm,dt, currentPaging, firstOrLastPage, currentLoadingCircle)
        {
            this.CRUDClient = CRUDClient;
        }

        protected override void GetItemsForDataGridNavigation()
        {
            List<ProductDTO> products = CRUDClient.GetProducts();

            foreach (ProductDTO item in products)
            {
                FillAndAddDataRow(item.ProductNewName, item.CategoryName, item.VendorName, item.ProductPrice, item.Quantity, item.StoreName, item.TownName);
            }
        }
    }
}
