namespace ShopHelper_v0._0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Collections.Specialized;
    using ShopHelper_v0._0.Properties;
    using ShopHelper_v0._0.Utilities.RolesCommonFunctionality;

    public partial class POS : Form
    {
        #region Fields
        private StringCollection posFormAuthorization;
        #endregion

        #region Constructors
        public POS()
        {
            InitializeComponent();
            this.posFormAuthorization = RolesForSpecificForm.Default.POS;
        }
        #endregion

        #region Events
        private void POS_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Location = new Point(165, 5);
        }

        private void POS_FormClosed(object sender, FormClosedEventArgs e)
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
