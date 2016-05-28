namespace ShopHelper_v0._0.SubForms.ManagerSubForms
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using ShopHelper_v0._0.SubForms.ManagerSubForms;
    using ShopHelper_v0._0.SubForms.ManagerSubForms.InventoryCenterSubForms;
    using Anyo.WindowsForms.Controls.Buttons;
    using Anyo.WindowsForms.Controls.Panels;
    using Anyo.WindowsForms.CommonFunctionality;
    using Anyo.WindowsForms.CommonFunctionality.UI;

    public partial class InventoryCenter : Form
    {
        #region Fields
        private AddProducts addProductsForm;
        private EditDeleteProducts editDeleteProductsForm;
        private AddCategory addCategoryForm;
        private EditDeleteCategory editDeleteCategoryForm;
        private Stock stockForm;
        #endregion

        #region Constructor
        public InventoryCenter()
        {
            InitializeComponent();
        }

        #endregion

        #region Events
        public void InventoryCenter_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(165, 130);
        }

        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            this.addProductsForm = new AddProducts();
            FormsUI.LoadChildForm(this, this.addProductsForm, ChildNastedLevel.NastedNastedNasted, this.addProduct_btn);
        }

        private void editProducts_btn_Click(object sender, EventArgs e)
        {
            this.editDeleteProductsForm = new EditDeleteProducts();
            FormsUI.LoadChildForm(this, this.editDeleteProductsForm, ChildNastedLevel.NastedNastedNasted, this.editProducts_btn);
        }

        private void addCategory_btn_Click(object sender, EventArgs e)
        {
            this.addCategoryForm = new AddCategory();
            FormsUI.LoadChildForm(this, this.addCategoryForm, ChildNastedLevel.NastedNastedNasted, this.addCategory_btn);
        }

        private void editCategory_btn_Click(object sender, EventArgs e)
        {
            this.editDeleteCategoryForm = new EditDeleteCategory();
            FormsUI.LoadChildForm(this, this.editDeleteCategoryForm, ChildNastedLevel.NastedNastedNasted, this.editCategory_btn);

        }

        private void InStock_btn_Click(object sender, EventArgs e)
        {
            this.stockForm = new Stock();
            FormsUI.LoadChildForm(this, this.stockForm, ChildNastedLevel.NastedNastedNasted, this.InStock_btn);
        }

        #endregion
    }
}
