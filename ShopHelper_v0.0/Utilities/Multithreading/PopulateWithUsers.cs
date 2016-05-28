namespace ShopHelper_v0._0.Utilities.Multithreading
{
    using System;
    using System.Collections.Generic;
    using System.Web.Security;
    using System.Windows.Forms;
    using System.Data;
    using Anyo.WindowsForms.Controls.Navigations;
    using MRG.Controls.UI;
    using ShopHelper_v0._0.Utilities.RolesCommonFunctionality;
    using Anyo.WindowsForms.CommonFunctionality;

    class PopulateWithUsers:PopulateUIFromSeparateThread
    {
        public PopulateWithUsers(Form currentForm, DataTable dt,
                                 DataGridNavigation currentPaging,
                                 Display firstOrLastpage,
                                 LoadingCircle currentLoadingCircle)
            : base(currentForm,dt, currentPaging, firstOrLastpage, currentLoadingCircle)
        {
            if (dt.Columns.Count == 0)
            {
                DataManipulation.AddColumnsTheirNamesInDataTable(dt, "Username", "LastLoginDate", "LastLoginTime", "User roles", "IsUserOnline", "CreationDate");

                currentPaging.AllPages = dt;
                currentPaging.FillDataGridWithRecords(Display.FirstPage);
            }
        }

        public PopulateWithUsers(Form currentForm,ComboBox currentComboBox)
            : base(currentForm, null, currentComboBox)
        {

        }

        protected override void GetItemsForDataGridNavigation()
        {
            string userRoles;
            foreach (MembershipUser user in Membership.GetAllUsers())
            {
                userRoles =RolesHelper.GetAllRolesForUserInOneString(user.UserName);

                FillAndAddDataRow(user.UserName, user.LastLoginDate.Date.ToString("dd-MM-yyyy"), user.LastLoginDate.ToString("t"), userRoles, user.IsOnline, user.CreationDate.Date.ToString("dd-MM-yyyy"));
            }
        }

        protected override void GetItemsForComboBox()
        {
            foreach (MembershipUser user in Membership.GetAllUsers())
            {
                AddToComboBox(user.UserName);
            }
        }
    }
}
