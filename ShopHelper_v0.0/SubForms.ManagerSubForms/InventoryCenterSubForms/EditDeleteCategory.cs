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

    public partial class EditDeleteCategory : Form
    {
        #region Fields
        private Validation editDeleteCategoryVaslidation;
        private CRUDClient categoriesCRUD = new CRUDClient("BasicHttpBinding_ICRUD");
        private CategoryDTO categoriesData = new CategoryDTO();
        private DataTable dataTableCategories = new DataTable();
        private PopulateUIFromSeparateThread categories;
        #endregion

        #region Constructors
        public EditDeleteCategory()
        {
            InitializeComponent();

            this.editDeleteCategoryVaslidation = new Validation();
            EditDeleteCategoryValidationDetails();

            this.categories = new PopulateWithCategories(this, this.dataTableCategories,
                                                         this.dataGridNavigation_EditCategories,
                                                         Display.FirstPage,
                                                         this.CategoriesLoadingCircle);
        }
        #endregion
        
        #region Events
        private void EditDeleteCategory_Load(object sender, EventArgs e)
        {
            DisplayCategories(Display.FirstPage);
        }

        private void dataGridEditCategories_DoubleClick(object sender, EventArgs e)
        {
            DataManipulation.FillTextBoxesAndComboBoxesWithGridViewRowData(this.EditCategries_Panel, this.dataGridEditCategories);

            this.categoriesData.CategoryOldName = this.CategoryName_txt.Text;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            DataManipulation.FillTextBoxesAndComboBoxesWithGridViewRowData(this.EditCategries_Panel, this.dataGridEditCategories);

            this.categoriesData.CategoryOldName = this.CategoryName_txt.Text;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            this.categoriesData.CategoryName = this.CategoryName_txt.Text;
            this.categoriesCRUD.Update(this.categoriesData);
            SampleMessageBox.Show(this.categoriesCRUD.GetResult());

            DisplayCategories(Display.FirstPage);
            ClearAll();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            this.categoriesData.CategoryName = this.CategoryName_txt.Text;
            this.categoriesCRUD.Delete(this.categoriesData);

            SampleMessageBox.Show(this.categoriesCRUD.GetResult());

            DisplayCategories(Display.FirstPage);
            ClearAll();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dataGridEditCategories_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            OrangeGradient.Painter(e);
        }
        #endregion

        #region Methods
        private void EditDeleteCategoryValidationDetails()
        {
            this.editDeleteCategoryVaslidation.KindOfValidation(this.CategoryName_txt, CheckThatInput.IsText);

            this.editDeleteCategoryVaslidation.DeactivateControlsDuringValidating(this.update_btn);
            this.editDeleteCategoryVaslidation.DeactivateControlsDuringValidating(this.delete_btn);
        }

        private void ClearAll()
        {
            Clear.AllTextBoxesAndComboBoxes(this.EditCategries_Panel);
            this.editDeleteCategoryVaslidation.RestartValidation();
        }

        private void DisplayCategories(Display firstOrLastPage)
        {
            this.categories = new PopulateWithCategories(this, this.dataTableCategories,
                                                        this.dataGridNavigation_EditCategories,
                                                        firstOrLastPage,
                                                        this.CategoriesLoadingCircle,
                                                        this.categoriesCRUD);
            this.categories.StartPopulatingDataGridNavigation();
        }
        #endregion

        
    }
}
