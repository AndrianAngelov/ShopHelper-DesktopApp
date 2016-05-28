namespace ShopHelper_v0._0.SubForms.ManagerSubForms
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using ShopHelper_v0._0.SubForms.ManagerSubForms;
    using ShopHelper_v0._0.SubForms.ManagerSubForms.VendorsCenterSubForms;
    using Anyo.WindowsForms.Controls.Buttons;
    using Anyo.WindowsForms.Controls.Panels;
    using Anyo.WindowsForms.CommonFunctionality;
    using Anyo.WindowsForms.CommonFunctionality.UI;

    public partial class VendorsCenter : Form
    {
        #region Fields
        private AddVendors addVendorsForm;
        private EditDeleteVendors editDeleteVendorsForm; 
        #endregion

        #region Constructor
        public VendorsCenter()
        {
            InitializeComponent();
        } 
        #endregion

        #region Events
        private void VendorsCenter_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(165, 130);
        }

        private void addVendors_btn_Click(object sender, EventArgs e)
        {
            this.addVendorsForm = new AddVendors();
            FormsUI.LoadChildForm(this, this.addVendorsForm, ChildNastedLevel.NastedNastedNasted, this.addVendors_btn);
        }

        private void editVendors_btn_Click(object sender, EventArgs e)
        {
            this.editDeleteVendorsForm = new EditDeleteVendors();
            FormsUI.LoadChildForm(this, this.editDeleteVendorsForm, ChildNastedLevel.NastedNastedNasted, this.editVendors_btn);
        }

        #endregion

        #region Methods
        #endregion

    }
}
