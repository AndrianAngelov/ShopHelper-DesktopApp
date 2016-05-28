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

    public partial class AddCategory : Form
    {
        #region Fields

        private Validation addCategoryValidation ;
        private CRUDClient categoriesCRUD = new CRUDClient("BasicHttpBinding_ICRUD");
        private CategoryDTO categoriesData = new CategoryDTO();
        private DataTable dataTableCategories = new DataTable();
        private PopulateUIFromSeparateThread categories;
        #endregion

        #region Constructors
        public AddCategory()
        {
            InitializeComponent();

            this.addCategoryValidation = new Validation();
            AddCategoriesValidationDetails();

            this.categories = new PopulateWithCategories(this, this.dataTableCategories,
                                                         this.dataGridNavigation_AddCategory,
                                                         Display.FirstPage,
                                                         this.CategoriesLoadingCircle);
        }

        
        #endregion

        #region Events
        private void AddCategory_Load(object sender, EventArgs e)
        {
            DisplayCategories(Display.FirstPage);
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            this.categoriesData.CategoryName = this.CategoryName_txt.Text;
            this.categoriesCRUD.Insert(this.categoriesData);
            SampleMessageBox.Show(this.categoriesCRUD.GetResult());

            DisplayCategories(Display.LastPage);
            ClearAll();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dataGridAddCategory_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            OrangeGradient.Painter(e);
        }
        #endregion

        #region Methods
        private void AddCategoriesValidationDetails()
        {
            this.addCategoryValidation.KindOfValidation(this.CategoryName_txt, CheckThatInput.IsText);
            this.addCategoryValidation.DeactivateControlsDuringValidating(this.insert_btn);
        }

        private void ClearAll()
        {
            Clear.AllTextBoxesAndComboBoxes(this.AddCategries_Panel);
            this.addCategoryValidation.RestartValidation();
        }

        private void DisplayCategories(Display firstOrLastPage)
        {
            this.categories = new PopulateWithCategories(this, this.dataTableCategories,
                                                         this.dataGridNavigation_AddCategory,
                                                         firstOrLastPage,
                                                         this.CategoriesLoadingCircle,
                                                         this.categoriesCRUD);
            this.categories.StartPopulatingDataGridNavigation();
        }
        #endregion

        
    }
}
