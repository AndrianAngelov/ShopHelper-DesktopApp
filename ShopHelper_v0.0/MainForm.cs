namespace ShopHelper_v0._0
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Diagnostics;
    using System.Web.Security;
    using ShopHelper_v0._0.Utilities.RolesCommonFunctionality;
    using Anyo.WindowsForms.CommonFunctionality.UI;
    using Anyo.WindowsForms.MessageBoxes;

    public partial class MainForm : Form
    {
        #region Fields
        private POS posMainForm;
        private Manager managerMainForm;
        private Reports reportsMainForm;
        private Admin adminForm;
        private string[] userRoles;

        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            this.userRoles = Roles.GetRolesForUser(Login.currentUser.UserName);
        }
        #endregion

        #region Events
        private void MainForm_Load(object sender, EventArgs e)
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(width, height);
            FormsUI.SetBackGroundColorOfMDIForm(Color.FromArgb(40, 40, 40), this.Controls);

            GetCurrentUserInfo();
        }

        private void POS_btn_Click(object sender, EventArgs e)
        {
            this.posMainForm = new POS();
            string invalidAuthorizationMessage;
            bool isUserAuthorized = this.posMainForm.CheckForPermission(userRoles, out invalidAuthorizationMessage);

            if (isUserAuthorized)
            {
                FormsUI.LoadChildForm(this, this.posMainForm, ChildNastedLevel.Nasted, this.POS_btn);
            }
            else
            {
                SampleMessageBox.Show(invalidAuthorizationMessage);
            }
        }

        private void Manager_btn_Click(object sender, EventArgs e)
        {
            this.managerMainForm = new Manager();
            string invalidAuthorizationMessage;
            bool isUserAuthorized = this.managerMainForm.CheckForPermission(userRoles, out invalidAuthorizationMessage);

            if (isUserAuthorized)
            {
                FormsUI.LoadChildForm(this, this.managerMainForm, ChildNastedLevel.Nasted, this.Manager_btn);
            }
            else
            {
                SampleMessageBox.Show(invalidAuthorizationMessage);
            }
        }

        private void Reports_btn_Click(object sender, EventArgs e)
        {
            this.reportsMainForm = new Reports();

            string invalidAuthorizationMessage;
            bool isUserAuthorized = this.reportsMainForm.CheckForPermission(userRoles, out invalidAuthorizationMessage);

            if (isUserAuthorized)
            {
                FormsUI.LoadChildForm(this, this.reportsMainForm, ChildNastedLevel.Nasted, this.Reports_btn);
            }
            else
            {
                SampleMessageBox.Show(invalidAuthorizationMessage);
            }

        }

        private void Admin_btn_Click(object sender, EventArgs e)
        {
            this.adminForm = new Admin();

            string invalidAuthorizationMessage;
            bool isUserAuthorized = this.adminForm.CheckForPermission(userRoles, out invalidAuthorizationMessage);

            if (isUserAuthorized)
            {
                FormsUI.LoadChildForm(this, this.adminForm, ChildNastedLevel.Nasted, this.Admin_btn);
            }
            else
            {
                SampleMessageBox.Show(invalidAuthorizationMessage);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.currentUser.LastActivityDate = DateTime.Now;

            Process.GetCurrentProcess().Kill();
        }
        #endregion

        #region Methods
        private void GetCurrentUserInfo()
        {
            currentUsername_label.Text = "Hello " + Membership.GetUser().UserName;
            LastLoginDate_label.Text = "Last login date: " + Login.currentUser.LastLoginDate.ToShortTimeString() + " " +
                                      Login.currentUser.LastLoginDate.ToShortDateString();
            NumberOfUsersOnline_label.Text = "Online users:" + Membership.GetNumberOfUsersOnline().ToString();

            roles_label.Text = "User's roles:" + RolesHelper.GetAllRolesForUserInOneString(Login.currentUser.UserName);
        }
        #endregion
    }
}