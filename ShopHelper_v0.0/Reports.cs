

namespace ShopHelper_v0._0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Collections.Specialized;
    using ShopHelper_v0._0.Properties;
    using ShopHelper_v0._0.Utilities.RolesCommonFunctionality;

    public partial class Reports : Form
    {
        #region Fields
        private StringCollection posFormAuthorization;
        #endregion

        #region Constructors
        public Reports()
        {
            InitializeComponent();
            this.posFormAuthorization = RolesForSpecificForm.Default.Reports;
        }
        #endregion

        #region Events
        private void Reports_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(165, 5);
        }

        private void Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Process.GetCurrentProcess().Kill();
        }
        #endregion

        #region Methods
        internal bool CheckForPermission(string[] currentUserRoles, out string invalidAuthorizationMessage)
        {
            return RolesHelper.CheckForPermission(currentUserRoles, this.posFormAuthorization, out invalidAuthorizationMessage);
        }
        #endregion
    }
}
