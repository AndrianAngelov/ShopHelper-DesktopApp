namespace ShopHelper_v0._0
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Web.Security;
    using System.Security.Principal;
    using Anyo.WindowsForms.MessageBoxes;

    public partial class Login : Form
    {
        internal static MembershipUser currentUser;
        private MainForm mainForm;

        public Login()
        {
            InitializeComponent();
           
            password_txt.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //username_txt.Text = "admin";
            //password_txt.Text = "admin";

            //username_txt.Text = "Test";
            //password_txt.Text = "testtest";

            //username_txt.Text = "a";
            //password_txt.Text = "aaaaaa";
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Membership.ValidateUser(username_txt.Text, password_txt.Text))
                {
                    currentUser = Membership.GetUser(username_txt.Text);
                    GenericIdentity identity = new GenericIdentity(currentUser.UserName);
                    RolePrincipal principal = new RolePrincipal(identity);
                    System.Threading.Thread.CurrentPrincipal = principal;

                    currentUser.IsApproved = true;

                    mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    invalidLogin_label.Text = "Invalid username or password.Try again!";
                    invalidLogin_label.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                SampleMessageBox.Show(ex.GetType().ToString() + "\n Call lazy administrator"+"\n" +ex.Message);
            }
        }
    }
}
