namespace ShopHelper_v0._0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Web.Security;
    using ShopHelper_v0._0.SubForms.AdminSubForms;
    using Anyo.WindowsForms.Controls.Panels;
    using Anyo.WindowsForms.Controls.Buttons;
    using Anyo.WindowsForms.CommonFunctionality;
    using Anyo.WindowsForms.CommonFunctionality.UI;
    using System.Collections.Specialized;
    using ShopHelper_v0._0.Properties;
    using ShopHelper_v0._0.Utilities.RolesCommonFunctionality;
    using System.Configuration;
    using Anyo.WindowsForms.MessageBoxes;

    public partial class Admin : Form
    {
        #region Fields
        private UsersAccountsCenter usersCenterForm;
        private RolesCenter rolesCenterForm;
        private StringCollection adminFormAuthorization; 
        #endregion

        public Admin()
        {
            InitializeComponent();
            try
            {
                this.adminFormAuthorization = RolesForSpecificForm.Default.Admin;
            }
            catch (ConfigurationErrorsException ex)
            {
                SampleMessageBox.Show(ex.Message);
            }
        }

        #region Events
        private void Admin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(190, 7);

        }

        private void usersAccountsCenter_btn_Click(object sender, EventArgs e)
        {
            this.usersCenterForm = new UsersAccountsCenter();
            FormsUI.LoadChildForm(this, this.usersCenterForm, ChildNastedLevel.NastedNasted, this.usersAccountsCenter_btn);
        }

        private void rolesCenter_btn_Click(object sender, EventArgs e)
        {
            this.rolesCenterForm = new RolesCenter();
            FormsUI.LoadChildForm(this, this.rolesCenterForm, ChildNastedLevel.NastedNasted, this.rolesCenter_btn);
        } 
        #endregion

        #region Methods
        internal bool CheckForPermission(string[] currentUserRoles, out string invalidAuthorizationMessage)
        {
            return RolesHelper.CheckForPermission(currentUserRoles, this.adminFormAuthorization, out invalidAuthorizationMessage);
        }
        #endregion
    }
}
