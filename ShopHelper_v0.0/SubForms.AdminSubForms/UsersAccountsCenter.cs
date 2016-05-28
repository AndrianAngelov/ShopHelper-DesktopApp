namespace ShopHelper_v0._0.SubForms.AdminSubForms
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Web.Security;
    using Anyo.WindowsForms.MessageBoxes;
    using ShopHelper_v0._0.Utilities.Multithreading;
    using Anyo.WindowsForms.Controls.Navigations;
    using Anyo.WindowsForms.Controls.DataGridViewHeaderPainting;
    using ShopHelper_v0._0.Utilities.RolesCommonFunctionality;
    using System.Configuration.Provider;
    using Anyo.WindowsForms.CommonFunctionality.UI;

    public partial class UsersAccountsCenter : Form
    {
        #region Fields
        private enum UserToRoles { Add, Remove };

        private DataTable usersDataTable = new DataTable();
        private PopulateUIFromSeparateThread usersDataGridNavigation;
        private PopulateUIFromSeparateThread usersComboBoxInUserToRole;
        private PopulateUIFromSeparateThread usersComboBoxInDeletUser; 
        #endregion

        public UsersAccountsCenter()
        {
            InitializeComponent();

            this.usersDataGridNavigation = new PopulateWithUsers(this, this.usersDataTable,
                                                                 this.dataGridNavigation_Users,
                                                                 Display.FirstPage,
                                                                 this.UsersLoadingCircle);
        }

        #region Events
        private void UsersAccountsCenter_Load(object sender, EventArgs e)
        {
            this.Location = new Point(185, 140);
            this.FormBorderStyle = FormBorderStyle.None;

            AddCheckBoxesRolesInAllContainers();

            DisplayUsers(Display.FirstPage);
            FillComboBoxWithUsers();
        }

        private void createUser_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Membership.CreateUser(this.newUsername_txt.Text, this.password_txt.Text);
                SampleMessageBox.Show(String.Format("New user: {0} is successfully created", this.newUsername_txt.Text));
                Clear.AllTextBoxesAndComboBoxes(this.createUser_groupBox);
                DisplayUsers(Display.FirstPage);

                FillComboBoxWithUsers();

            }
            catch (MembershipCreateUserException ex)
            {
                SampleMessageBox.Show(GetErrorMessage(ex.StatusCode));
            }
        }

        private void deleteUser_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = allUsersInDeleteUser_comboBox.SelectedItem.ToString();
                if (Membership.DeleteUser(username))
                {
                    SampleMessageBox.Show(String.Format("Successfully deleted {0} from membership database", username));
                    DisplayUsers(Display.FirstPage);
                    
                    FillComboBoxWithUsers();
                    allUsersInDeleteUser_comboBox.SelectedIndex = -1;
                }
            }
            catch (NullReferenceException)
            {
                SampleMessageBox.Show("Please, first select user!");
            }
        }

        private void addUserToRoles_btn_Click(object sender, EventArgs e)
        {
            AddOrRemoveUserToRoles(UserToRoles.Add);
        }

        private void removeUserFromRoles_btn_Click(object sender, EventArgs e)
        {
            AddOrRemoveUserToRoles(UserToRoles.Remove);
        }

        private void clearCreateNewUser_btn_Click(object sender, EventArgs e)
        {
            Clear.AllTextBoxesAndComboBoxes(this.createUser_groupBox);
        }

        private void clearDeleteUser_Click(object sender, EventArgs e)
        {
            Clear.AllTextBoxesAndComboBoxes(this.deleteUser_groupBox);
        }

        private void clearUserToRole_btn_Click(object sender, EventArgs e)
        {
            Clear.AllTextBoxesAndComboBoxes(this.userToRole_groupBox);
        }

        private void dataGrid_Users_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            OrangeGradient.Painter(e);
        }
        #endregion

        #region Methods
        private void AddCheckBoxesRolesInAllContainers()
        {
            RolesHelper.AddCheckBoxForAllRoles(userToRole_groupBox, 158,
                                               this.allUsersInUserToRole_comboBox.Location.X - 40, this.allUsersInUserToRole_comboBox.Location.Y + this.allUsersInUserToRole_comboBox.Height + 10,
                                               66, addUserToRoles_btn, removeUserFromRoles_btn, clearUserToRole_btn);
        }

        private void DisplayUsers(Display firstOrLastPage)
        {
            this.usersDataGridNavigation = new PopulateWithUsers(this, this.usersDataTable,
                                                                 this.dataGridNavigation_Users,
                                                                 firstOrLastPage,
                                                                 this.UsersLoadingCircle);
            this.usersDataGridNavigation.StartPopulatingDataGridNavigation();
        }

        private void FillComboBoxWithUsers()
        {
            this.usersComboBoxInUserToRole = new PopulateWithUsers(this, this.allUsersInUserToRole_comboBox);
            this.usersComboBoxInUserToRole.StartPopulatingComboBox();
            this.usersComboBoxInDeletUser = new PopulateWithUsers(this, this.allUsersInDeleteUser_comboBox);
            this.usersComboBoxInDeletUser.StartPopulatingComboBox();
        }

        private void ClearAll()
        {
            Clear.AllTextBoxesAndComboBoxes(this.createUser_groupBox);
            Clear.AllTextBoxesAndComboBoxes(this.deleteUser_groupBox);
            Clear.AllTextBoxesAndComboBoxes(this.userToRole_groupBox);
        }

        private void AddOrRemoveUserToRoles(UserToRoles addOrRemove)
        {
            try
            {
                string username = allUsersInUserToRole_comboBox.SelectedItem.ToString();
                string[] checkedRolesArray = RolesHelper.GetAllCheckedItemsArray(this.userToRole_groupBox);
                string checkedRolesString = RolesHelper.GetAllCheckedItems(this.userToRole_groupBox);

                switch (addOrRemove)
                {
                    case UserToRoles.Add:
                        {
                            try
                            {
                                Roles.AddUserToRoles(username, checkedRolesArray);
                                SampleMessageBox.Show(String.Format("Successfully add {0} to  {1} role(s)", username, checkedRolesString));
                            }
                            catch (ProviderException)
                            {
                                if (checkedRolesArray.Length == 1)
                                {
                                    SampleMessageBox.Show(String.Format("{0} is already in {1} role", username, checkedRolesString));
                                }
                                else
                                {
                                    SampleMessageBox.Show(String.Format("{0} is already in some of these roles:\n{1} ", username, checkedRolesString));
                                }
                            }
                            catch(ArgumentException)
                            {
                                SampleMessageBox.Show("Please check some of roles");
                            }
                            break;
                        }
                    case UserToRoles.Remove:
                        {
                            try
                            {
                                Roles.RemoveUserFromRoles(username, checkedRolesArray);
                                SampleMessageBox.Show(String.Format("Successfully remove {0} from {1} role(s)", username, checkedRolesString));
                            }
                            catch (ArgumentException)
                            {
                                 SampleMessageBox.Show("Please check some of roles");
                            }
                            break;
                        }
                }
                DisplayUsers(Display.FirstPage);
                RolesHelper.UncheckedAllCheckboxes(this.userToRole_groupBox);
                allUsersInUserToRole_comboBox.SelectedIndex = -1;
            }
            catch (NullReferenceException)
            {
                SampleMessageBox.Show("Please, select user!");
            }
        }

        public string GetErrorMessage(MembershipCreateStatus status)
        {
            switch (status)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Username already exists. Please enter a different Username.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A username for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.\n" +
                            "Password required minimum 5 symbols";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.Success:
                    return "Succssesfull operation!";
                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}
