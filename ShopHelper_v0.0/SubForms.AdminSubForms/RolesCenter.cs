namespace ShopHelper_v0._0.SubForms.AdminSubForms
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using Anyo.WindowsForms.Controls.Navigations;
    using System.Web.Security;
    using ShopHelper_v0._0.Utilities.Multithreading;
    using Anyo.WindowsForms.MessageBoxes;
    using Anyo.WindowsForms.Controls.DataGridViewHeaderPainting;
    using Anyo.WindowsForms.CommonFunctionality.UI;
    using ShopHelper_v0._0.Utilities.RolesCommonFunctionality;
    using ShopHelper_v0._0.Properties;
    using System.Configuration;
    using System.Collections.Specialized;

    public partial class RolesCenter : Form
    {
        #region Fields
        private enum RolesToForm { Add, Remove };

        private DataTable usersDataTable = new DataTable();
        private DataTable formsRolesDataTable = new DataTable();
        private PopulateUIFromSeparateThread usersDataGridNavigation;
        private PopulateUIFromSeparateThread formsRolesDataGridNavigation;
        private PopulateUIFromSeparateThread formsRolesDisplayAndFillSync; 
        #endregion

        #region Constructor
        public RolesCenter()
        {
            InitializeComponent();

            this.usersDataGridNavigation = new PopulateWithUsers(this, this.usersDataTable,
                                               this.dataGridNavigation_Users,
                                               Display.FirstPage,
                                               this.UsersLoadingCircle);

            this.formsRolesDataGridNavigation = new PopulateWithFormsRoles(this, this.formsRolesDataTable,
                                                          this.dataGridNavigation_FormsRoles,
                                                          Display.FirstPage,
                                                          this.formsRolesLoadingCircle);
        } 
        #endregion

        #region Events
        private void RolesCenter_Load(object sender, EventArgs e)
        {
            this.Location = new Point(185, 140);
            this.FormBorderStyle = FormBorderStyle.None;

            AddCheckBoxesRolesInAllContainers();

            DisplayUsers(Display.FirstPage);
            DisplayAndFillFormsRolesSync(Display.FirstPage);
        }

        private void createRole_btn_Click(object sender, EventArgs e)
        {
            if (!Roles.RoleExists(createRole_txt.Text))
            {
                Roles.CreateRole(createRole_txt.Text);
                if (Roles.RoleExists(createRole_txt.Text))
                {
                    SampleMessageBox.Show(createRole_txt.Text + " role is created!");
                    Clear.AllTextBoxesAndComboBoxes(this.createRole_groupBox);
                    AddCheckBoxesRolesInAllContainers();
                }
            }
            else
            {
                SampleMessageBox.Show(createRole_txt.Text + " is already exists!");
            }

        }

        private void deleteRoles_btn_Click(object sender, EventArgs e)
        {
            string[] checkedRolesArray = RolesHelper.GetAllCheckedItemsArray(this.deleteRoles_groupBox);
            string checkedRolesString = RolesHelper.GetAllCheckedItems(this.deleteRoles_groupBox);
            int counter = 0;

            for (int i = 0; i < checkedRolesArray.Length; i++)
            {
                try
                    {
                        string[] usersInRole = Roles.GetUsersInRole(checkedRolesArray[i]);

                        if (usersInRole.Length > 0)
                        {
                            Roles.RemoveUsersFromRole(usersInRole, checkedRolesArray[i]);
                        }

                        if (Roles.DeleteRole(checkedRolesArray[i], true))
                        {
                            counter++;
                        }

                    }
                    catch (Exception ex)
                    {
                        SampleMessageBox.Show(ex.Message);
                    }
            }

            if (counter != 0)
            {
                SampleMessageBox.Show(String.Format("Successfully deleted {0} role(s)", checkedRolesString));
                RolesHelper.UncheckedAllCheckboxes(this.deleteRoles_groupBox);
                AddCheckBoxesRolesInAllContainers();
                DisplayUsers(Display.FirstPage);
            }
            else
            {
                SampleMessageBox.Show("Please,check some of roles to delete it");
            }
        }

        private void addRolesToForm_btn_Click(object sender, EventArgs e)
        {
            AddOrRemoveRolesToForm(RolesToForm.Add);
        }

        private void removeRolesFromForm_btn_Click(object sender, EventArgs e)
        {
            AddOrRemoveRolesToForm(RolesToForm.Remove);
        }

        private void clearNewRole_btn_Click(object sender, EventArgs e)
        {
            Clear.AllTextBoxesAndComboBoxes(this.createRole_groupBox);
        }

        private void clearFormsRoles_btn_Click(object sender, EventArgs e)
        {
            this.formsRolesCollections_comboBox.SelectedIndex = -1;
        }

        private void dataGrid_Users_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            OrangeGradient.Painter(e);
        }

        private void FormsRoles_dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            OrangeGradient.Painter(e);
        }
        #endregion

        #region Methods
        private void AddCheckBoxesRolesInAllContainers()
        {
            RolesHelper.AddCheckBoxForAllRoles(this.deleteRoles_groupBox, 58,
                                              this.deleteRoles_groupBox.Location.X + 2, deleteRoles_groupBox.Location.Y - 90,
                                              25, deleteRoles_btn);

            RolesHelper.AddCheckBoxForAllRoles(this.rolesToForm_groupBox, 158,
                                              this.rolesToForm_groupBox.Location.X + 2, rolesToForm_groupBox.Location.Y - 190,
                                              66, addRolesToForm_btn, removeRolesFromForm_btn, clearFormsRoles_btn);
        }

        private void DisplayUsers(Display firstOrLastPage)
        {
            this.usersDataGridNavigation = new PopulateWithUsers(this, this.usersDataTable,
                                               this.dataGridNavigation_Users,
                                               firstOrLastPage,
                                               this.UsersLoadingCircle);
            this.usersDataGridNavigation.StartPopulatingDataGridNavigation();
        }

        private void DisplayFormsRoles(Display firstOrLastPage)
        {
            this.formsRolesDataGridNavigation = new PopulateWithFormsRoles(this, this.formsRolesDataTable,
                                                          this.dataGridNavigation_FormsRoles,
                                                          firstOrLastPage,
                                                          this.formsRolesLoadingCircle);
            this.formsRolesDataGridNavigation.StartPopulatingDataGridNavigation();
        }

        private void DisplayAndFillFormsRolesSync(Display firstOrLastPage)
        {
            this.formsRolesDisplayAndFillSync = new PopulateWithFormsRoles(this, this.formsRolesDataTable,
                                                          this.dataGridNavigation_FormsRoles,
                                                          firstOrLastPage,
                                                          this.formsRolesLoadingCircle,
                                                          this.formsRolesCollections_comboBox);
            this.formsRolesDisplayAndFillSync.StartPopulatingWithSync();
        }

        private void AddOrRemoveRolesToForm(RolesToForm addOrRemove)
        {
            string[] checkedRolesArray = RolesHelper.GetAllCheckedItemsArray(this.rolesToForm_groupBox);
            string checkedRolesString = RolesHelper.GetAllCheckedItems(this.rolesToForm_groupBox);
           
            int addCounter = 0;
            int removeCounter = 0;
            bool isRoleExistToForm = false;

            try
            {
                string selectedForm = this.formsRolesCollections_comboBox.SelectedItem.ToString();

                if (checkedRolesArray.Length!=0)
                {
                    foreach (SettingsProperty currentProperty in RolesForSpecificForm.Default.Properties)
                    {
                        if (currentProperty.Name.Equals(selectedForm))
                        {
                            foreach (string role in checkedRolesArray)
                            {
                                if (currentProperty.PropertyType == typeof(StringCollection))
                                {
                                    if (RolesForSpecificForm.Default[currentProperty.Name] == null)
                                    {
                                        RolesForSpecificForm.Default[currentProperty.Name] = new StringCollection();
                                    }
                                    switch (addOrRemove)
                                    {
                                        case RolesToForm.Add:
                                            {
                                                if (!(RolesForSpecificForm.Default[currentProperty.Name] as StringCollection).Contains(role))
                                                {
                                                    try
                                                    {
                                                        (RolesForSpecificForm.Default[currentProperty.Name] as StringCollection).Add(role);
                                                        RolesForSpecificForm.Default.Save();
                                                        addCounter++;
                                                    }
                                                    catch (Exception ex)
                                                    {
                                                        SampleMessageBox.Show(ex.Message);
                                                    }
                                                }
                                                else
                                                {
                                                    isRoleExistToForm = true;
                                                }
                                                break;
                                            }
                                        case RolesToForm.Remove:
                                            {
                                                try
                                                {
                                                    (RolesForSpecificForm.Default[currentProperty.Name] as StringCollection).Remove(role);
                                                    RolesForSpecificForm.Default.Save();
                                                    removeCounter++;
                                                }
                                                catch (Exception ex)
                                                {
                                                    SampleMessageBox.Show(ex.Message);
                                                }
                                                break;
                                            }
                                    }
                                }
                            }
                        }
                    }
                    if (isRoleExistToForm)
                    {
                        SampleMessageBox.Show(String.Format("{0} role(s) already to {1} form", checkedRolesString, selectedForm));
                    }
                    if (addCounter == checkedRolesArray.Length)
                    {
                        SampleMessageBox.Show(String.Format("Successfully add {0} role(s) to {1} form", checkedRolesString, selectedForm));
                    }
                    if (removeCounter == checkedRolesArray.Length)
                    {
                        SampleMessageBox.Show(String.Format("Successfully remove {0} role(s) from {1} form", checkedRolesString, selectedForm));
                    } 
                }
                else
                {
                    SampleMessageBox.Show(String.Format("Please first check some of roles"));
                }

            }
            catch (NullReferenceException)
            {
                SampleMessageBox.Show("Please first select FormsRolesCollection");
            }

            DisplayFormsRoles(Display.FirstPage);
            RolesHelper.UncheckedAllCheckboxes(this.rolesToForm_groupBox);
            this.formsRolesCollections_comboBox.SelectedIndex = -1;
        }
        #endregion
    }
}
