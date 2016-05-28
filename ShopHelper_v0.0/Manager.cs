namespace ShopHelper_v0._0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using ShopHelper_v0._0.SubForms.ManagerSubForms;
    using Anyo.WindowsForms.Controls.Panels;
    using Anyo.WindowsForms.Controls.Buttons;
    using Anyo.WindowsForms.CommonFunctionality.UI;
    using System.Collections.Specialized;
    using ShopHelper_v0._0.Properties;
    using ShopHelper_v0._0.Utilities.RolesCommonFunctionality;
    using System.Configuration;
    using Anyo.WindowsForms.MessageBoxes;

    public partial class Manager : Form
    {
        #region Fields
        private InventoryCenter inventoryCenterForm;
        private VendorsCenter vendorsCenterForm;
        private StringCollection managerFormAuthorization;
        #endregion

        #region Constructor
        public Manager()
        {
            InitializeComponent();

            try
            {
                this.managerFormAuthorization = RolesForSpecificForm.Default.Manager;
            }
            catch (ConfigurationErrorsException ex)
            {
                SampleMessageBox.Show(ex.Message);
            }
            //this.managerFormAuthorization = RolesForSpecificForm.Default.Manager;
        }
        #endregion

        #region Events
        private void Manager_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(180, 7);
        }

        private void InventoryCenter_btn_Click(object sender, EventArgs e)
        {
            this.inventoryCenterForm = new InventoryCenter();
            FormsUI.LoadChildForm(this, this.inventoryCenterForm, ChildNastedLevel.NastedNasted, this.InventoryCenter_btn);
        }

        private void VendorsCenter_btn_Click(object sender, EventArgs e)
        {
            this.vendorsCenterForm = new VendorsCenter();
            FormsUI.LoadChildForm(this, this.vendorsCenterForm, ChildNastedLevel.NastedNasted, this.VendorsCenter_btn);
        }
        #endregion

        #region Methods
        internal bool CheckForPermission(string[] currentUserRoles, out string invalidAuthorizationMessage)
        {
            return RolesHelper.CheckForPermission(currentUserRoles, this.managerFormAuthorization, out invalidAuthorizationMessage);
        } 
        #endregion
    }
}
