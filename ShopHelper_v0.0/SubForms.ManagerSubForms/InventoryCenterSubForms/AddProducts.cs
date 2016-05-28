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

    public partial class AddProducts : Form
    {
        #region Fields
        private Validation addProductValidation;
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
        public AddProducts()
        {
            InitializeComponent();
           
            addProductValidation = new Validation();
            AddProductsValidationDetails();
            ClearAll();

            this.productsDataGridNav = new PopulateWithProducts(this, this.dataTableProducts,
                                                                this.dataGridNavigation_AddProducts,
                                                                Display.FirstPage,
                                                                this.ProductsLoadingCircle);
        }
        #endregion

        #region Events
        private void AddProducts_Load(object sender, EventArgs e)
        {
            FillAllComboBoxesWithDataBaseValues();

            DisplayProducts(Display.FirstPage);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            this.productsData.ProductNewName = this.ProductName_txt.Text;
            this.productsData.CategoryName = this.Categories_comboBox.Text;
            this.productsData.VendorName = this.Vendor_comboBox.Text;
            this.productsData.ProductPrice = decimal.Parse(this.UnitPrice_txt.Text);
            this.productsData.Quantity = int.Parse(this.Quantity_txt.Text);
            this.productsData.StoreName = this.Stores_comboBox.Text;
            this.productsData.TownName = this.Towns_comboBox.Text;

            this.productsCRUD.Insert(this.productsData);
            SampleMessageBox.Show(this.productsCRUD.GetResult());

            DisplayProducts(Display.LastPage);
            FillAllComboBoxesWithDataBaseValues();
            ClearAll();
        }

        private void dataGridAddProducts_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            OrangeGradient.Painter(e);
        }
        #endregion

        #region Methods
        private void AddProductsValidationDetails()
        {
            this.addProductValidation.KindOfValidation(this.ProductName_txt, CheckThatInput.IsText);

            this.addProductValidation.KindOfValidation(this.Categories_comboBox, CheckThatInput.IsText);
            this.addProductValidation.KindOfValidation(this.Vendor_comboBox, CheckThatInput.IsText);
            this.addProductValidation.KindOfValidation(this.Stores_comboBox, CheckThatInput.IsText);
            this.addProductValidation.KindOfValidation(this.Towns_comboBox, CheckThatInput.IsText);

            this.addProductValidation.KindOfValidation(this.UnitPrice_txt, CheckThatInput.IsDecimal);
            this.addProductValidation.KindOfValidation(this.Quantity_txt, CheckThatInput.IsInteger);

            this.addProductValidation.DeactivateControlsDuringValidating(this.insert_btn);
        }

        private void ClearAll()
        {
            Clear.AllTextBoxesAndComboBoxes(this.AddProducts_panel);
            this.addProductValidation.RestartValidation();
        }

        private void DisplayProducts(Display firstOrLastPage)
        {
            this.productsDataGridNav = new PopulateWithProducts(this, this.dataTableProducts,
                                                           this.dataGridNavigation_AddProducts,
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
