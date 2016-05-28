namespace ShopHelper_v0._0.SubForms.ManagerSubForms.InventoryCenterSubForms
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using ShopHelper_v0._0.ShopHelperService;
    using ShopHelper_v0._0.Utilities.Multithreading;
    using Anyo.WindowsForms.Validation;
    using Anyo.WindowsForms.Controls.Navigations;
    using Anyo.WindowsForms.Controls.DataGridViewHeaderPainting;
    using Anyo.WindowsForms.MessageBoxes;
    using Anyo.WindowsForms.CommonFunctionality;
    using Anyo.WindowsForms.CommonFunctionality.UI;

    public partial class EditDeleteProducts : Form
    {
        #region Fields
        private Validation editDeleteProductValidation;
        private CRUDClient productsCRUD = new CRUDClient("BasicHttpBinding_ICRUD");
        private ProductDTO productsData = new ProductDTO();
        private DataTable dataTableProducts = new DataTable();
        private PopulateUIFromSeparateThread productsDataGridNav;
        private PopulateUIFromSeparateThread vendorsComboBox;
        private PopulateUIFromSeparateThread categoriesComboBox;
        private PopulateUIFromSeparateThread storesComboBox;
        private PopulateUIFromSeparateThread townsComboBox;
        #endregion

        #region Constructors
        public EditDeleteProducts()
        {
            InitializeComponent();

            editDeleteProductValidation = new Validation();
            AddProductsValidationDetails();

            this.productsDataGridNav = new PopulateWithProducts(this, this.dataTableProducts,
                                                                this.dataGridNavigation_EditProducts,
                                                                Display.FirstPage,
                                                                this.ProductsLoadingCircle);
        }
        #endregion

        #region Events
        private void EditDeleteProducts_Load(object sender, EventArgs e)
        {
            FillAllComboBoxesWithDataBaseValues();

            DisplayProducts(Display.FirstPage);
        }

        private void dataGridEditProducts_DoubleClick(object sender, EventArgs e)
        {
            DataManipulation.FillTextBoxesAndComboBoxesWithGridViewRowData(this.EditProducts_Panel, this.dataGridEditProducts);
            this.productsData.ProductOldName = this.ProductName_txt.Text;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            DataManipulation.FillTextBoxesAndComboBoxesWithGridViewRowData(this.EditProducts_Panel, this.dataGridEditProducts);
            this.productsData.ProductOldName = this.ProductName_txt.Text;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            this.productsData.ProductNewName = this.ProductName_txt.Text;
            this.productsData.CategoryName = this.Categories_comboBox.Text;
            this.productsData.VendorName = this.Vendor_comboBox.Text;
            this.productsData.ProductPrice = decimal.Parse(this.UnitPrice_txt.Text);
            this.productsData.Quantity = int.Parse(this.Quantity_txt.Text);
            this.productsData.StoreName = this.Stores_comboBox.Text;
            this.productsData.TownName = this.Towns_comboBox.Text;

            this.productsCRUD.Update(this.productsData);
            SampleMessageBox.Show(this.productsCRUD.GetResult());

            DisplayProducts(Display.FirstPage);
            FillAllComboBoxesWithDataBaseValues();
            ClearAll();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            this.productsData.ProductNewName = this.ProductName_txt.Text;
            this.productsCRUD.Delete(this.productsData);

            SampleMessageBox.Show(this.productsCRUD.GetResult());

            DisplayProducts(Display.FirstPage);
            FillAllComboBoxesWithDataBaseValues();
            ClearAll();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
       
        private void dataGridEditProducts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            OrangeGradient.Painter(e);
        }
        #endregion

        #region Methods
        private void AddProductsValidationDetails()
        {
            this.editDeleteProductValidation.KindOfValidation(this.ProductName_txt, CheckThatInput.IsText);

            this.editDeleteProductValidation.KindOfValidation(this.Categories_comboBox, CheckThatInput.IsText);
            this.editDeleteProductValidation.KindOfValidation(this.Vendor_comboBox, CheckThatInput.IsText);
            this.editDeleteProductValidation.KindOfValidation(this.Stores_comboBox, CheckThatInput.IsText);
            this.editDeleteProductValidation.KindOfValidation(this.Towns_comboBox, CheckThatInput.IsText);

            this.editDeleteProductValidation.KindOfValidation(this.UnitPrice_txt, CheckThatInput.IsDecimal);
            this.editDeleteProductValidation.KindOfValidation(this.Quantity_txt, CheckThatInput.IsInteger);

            this.editDeleteProductValidation.DeactivateControlsDuringValidating(this.update_btn);
            this.editDeleteProductValidation.DeactivateControlsDuringValidating(this.delete_btn);
        }

        private void ClearAll()
        {
            Clear.AllTextBoxesAndComboBoxes(this.EditProducts_Panel);
            this.editDeleteProductValidation.RestartValidation();
        }

        private void DisplayProducts(Display firstOrLastPage)
        {
            this.productsDataGridNav = new PopulateWithProducts(this, this.dataTableProducts,
                                                           this.dataGridNavigation_EditProducts,
                                                           firstOrLastPage,
                                                           this.ProductsLoadingCircle,
                                                           this.productsCRUD);
            this.productsDataGridNav.StartPopulatingDataGridNavigation();
        }

        private void FillAllComboBoxesWithDataBaseValues()
        {
            this.vendorsComboBox = new PopulateWithVendors(this, Vendor_comboBox, productsCRUD);
            this.categoriesComboBox = new PopulateWithCategories(this, Categories_comboBox, productsCRUD);
            this.storesComboBox = new PopulateWithStores(this, Stores_comboBox, productsCRUD);
            this.townsComboBox = new PopulateWithTowns(this, Towns_comboBox, productsCRUD);

            this.vendorsComboBox.StartPopulatingComboBox();
            this.categoriesComboBox.StartPopulatingComboBox();
            this.storesComboBox.StartPopulatingComboBox();
            this.townsComboBox.StartPopulatingComboBox();
        }
        #endregion

        
    }
}
