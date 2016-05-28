namespace ShopHelper_v0._0.Utilities.Multithreading
{
    using System;
    using System.Windows.Forms;
    using System.Data;
    using Anyo.WindowsForms.Controls.Navigations;
    using MRG.Controls.UI;
    using Anyo.WindowsForms.CommonFunctionality;
    using ShopHelper_v0._0.Properties;
    using System.Configuration;
    using System.Collections.Specialized;
    using System.Text;

    class PopulateWithFormsRoles : PopulateUIFromSeparateThread
    {
        static readonly object locker = new object();

        #region Constructors
        public PopulateWithFormsRoles(Form currentForm, DataTable dt,
                                 DataGridNavigation currentPaging,
                                 Display firstOrLastpage,
                                 LoadingCircle currentLoadingCircle)
            : base(currentForm, dt, currentPaging, firstOrLastpage, currentLoadingCircle)
        {
            if (dt.Columns.Count == 0)
            {
                DataManipulation.AddColumnsTheirNamesInDataTable(dt, "FormName", "Roles");

                currentPaging.AllPages = dt;
                currentPaging.FillDataGridWithRecords(Display.FirstPage);
            }
        }

        public PopulateWithFormsRoles(Form currentForm, ComboBox currentComboBox)
            : base(currentForm, null, currentComboBox)
        {

        }
        public PopulateWithFormsRoles(Form currentForm, DataTable dt,
                                DataGridNavigation currentPaging,
                                Display firstOrLastpage,
                                LoadingCircle currentLoadingCircle,
                                ComboBox currentComboBox)
            : base(currentForm, dt, currentPaging, firstOrLastpage, currentLoadingCircle, currentComboBox)
        {
        } 
        #endregion

        #region Override Methods
        protected override void GetItemsForDataGridNavigation()
        {
            StringBuilder currentFormRoles;

            lock (locker)
            {
                //MessageBox.Show("Enter in DataGrid Locker");
                foreach (SettingsProperty currentProperty in RolesForSpecificForm.Default.Properties)
                {
                    currentFormRoles = new StringBuilder();

                    if (RolesForSpecificForm.Default[currentProperty.Name] == null)
                    {
                        RolesForSpecificForm.Default[currentProperty.Name] = new StringCollection();
                    }

                    foreach (string item in (RolesForSpecificForm.Default[currentProperty.Name] as StringCollection))
                    {
                        if (currentFormRoles.Length >= 1)
                        {
                            currentFormRoles.Append(" , ");
                            currentFormRoles.Append(item);
                        }
                        else
                        {
                            currentFormRoles.Append(item);
                        }
                    }
                    FillAndAddDataRow(currentProperty.Name, currentFormRoles.ToString());
                }
            }
            //MessageBox.Show("Exsit in DataGrid Locker");
        }

        protected override void GetItemsForComboBox()
        {
            lock (locker)
            {
                //MessageBox.Show("Enter in ComboBox Locker");
                foreach (SettingsProperty currentProperty in RolesForSpecificForm.Default.Properties)
                {
                    AddToComboBox(currentProperty.Name);
                }
            }
            //MessageBox.Show("Exsit in ComboBox Locker");
        } 
        #endregion
    }
}
