namespace ShopHelper_v0._0.Utilities.RolesCommonFunctionality
{
    using System;
    using System.Collections.Generic;
    using System.Web.Security;
    using System.Windows.Forms;
    using System.Drawing;
    using System.Text;
    using System.Collections.Specialized;

    internal class RolesHelper
    {
        public static string[] GetAllCheckedItemsArray(Control containerControl)
        {
            List<string> checkedItemsList = new List<string>();

            foreach (Control control in containerControl.Controls)
            {
                if (control is CheckBox && (control as CheckBox).Checked)
                {
                    checkedItemsList.Add(control.Text);
                }
            }
            return checkedItemsList.ToArray();
        }

        public static string GetAllCheckedItems(Control containerControl)
        {
            StringBuilder checkedItemsList = new StringBuilder();

            foreach (Control control in containerControl.Controls)
            {
                if (control is CheckBox && (control as CheckBox).Checked)
                {
                    if (checkedItemsList.Length != 0)
                    {
                        checkedItemsList.Append(" ,");
                        checkedItemsList.Append(control.Text);
                    }
                    else
                    {
                        checkedItemsList.Append(control.Text);
                    }
                }
            }
            return checkedItemsList.ToString();
        }

        public static bool CheckForPermission(string[] currentUserRoles, StringCollection collectionName, out string invalidAuthorizationMessage)
        {
            bool isUserAuthorized = false;
            invalidAuthorizationMessage = null;

            int countMatches = 0;
            //MessageBox.Show("");
            //if (collectionName == null)
            //{
            //    collectionName = new StringCollection();
            //    collectionName.Add("Admin");
            //    //MessageBox.Show(collectionName.Count.ToString());
            //}
            if (collectionName != null)
            {
                for (int i = 0; i < currentUserRoles.Length; i++)
                {
                    foreach (string role in collectionName)
                    {
                        if (currentUserRoles[i].Equals(role))
                        {
                            countMatches++;
                        }
                    }
                }

                if (countMatches > 0)
                {
                    isUserAuthorized = true;
                    return isUserAuthorized;
                }
                else
                {
                    invalidAuthorizationMessage = "You are not authorized for this action. \n Call the lazy administrator";
                }
            }

            return isUserAuthorized;
        }

        public static string GetAllRolesForUserInOneString(string username)
        {
            string[] userRoles = Roles.GetRolesForUser(username);
            StringBuilder concatUserRoles = new StringBuilder();

            for (int i = 0; i < userRoles.Length; i++)
            {
                if (i == 0 || userRoles.Length == 1)
                {
                    concatUserRoles.Append(userRoles[i]);
                }
                else
                {
                    concatUserRoles.Append(" ,");
                    concatUserRoles.Append(userRoles[i]);
                }
            }
            return concatUserRoles.ToString();
        }

        public static void UncheckedAllCheckboxes(Control containerControl)
        {
            foreach (Control control in containerControl.Controls)
            {
                if (control is CheckBox && (control as CheckBox).Checked)
                {
                    (control as CheckBox).Checked = false;
                }
            }
        }

        public static void AddCheckBoxForAllRoles(Control containerControl, int containerDefaultHeight,
                                                  int firstCheckBoxLocationX, int firstCheckBoxLocationY,
                                                  int firstButtonDeafaultLocationY = 0, params Control[] buttons)
        {


            string[] allRoles = Roles.GetAllRoles();
            List<CheckBox> listOfCheckBoxesRoles = new List<CheckBox>();
            CheckBox currentCheckBox;
            int nextEvenLocationX = firstCheckBoxLocationX;
            int nextEvenLocationY = firstCheckBoxLocationY;
            int nextOddLocationX = 0;
            int nextOddLocationY = 0;
            int maxOddLocationX = 0;
            int buttonLocationY = firstButtonDeafaultLocationY;

            DeleteAllCheckBoxesInContainer(containerControl, allRoles);

            containerControl.Height = containerDefaultHeight;

            for (int i = 0; i < allRoles.Length; i++)
            {
                currentCheckBox = new CheckBox();
                currentCheckBox.Text = allRoles[i];
                currentCheckBox.AutoSize = true;
                listOfCheckBoxesRoles.Add(currentCheckBox);
                containerControl.Controls.Add(listOfCheckBoxesRoles[i]);

                if (i == 0 || i % 2 == 0)
                {
                    listOfCheckBoxesRoles[i].Location = new Point(nextEvenLocationX, nextEvenLocationY);

                    containerControl.Height += currentCheckBox.Height;
                    buttonLocationY += currentCheckBox.Height;

                    if (buttons != null)
                    {
                        buttons[0].Location = new Point(buttons[0].Location.X, buttonLocationY);

                        //for (int k = 1; k < buttons.Length; k++)
                        //{
                        //    MessageBox.Show(buttons[k-1].Text + "\n" + buttons[k].Text);
                        //    //buttons[k].Location = new Point(buttons[k].Location.X, buttonLocationY + buttons[k - 1].Height + 3);
                        //    buttons[k].Location = new Point(buttons[k].Location.X, buttons[k].Location.Y + buttons[k - 1].Height + 3);
                        //}
                    }

                    nextOddLocationY = nextEvenLocationY;
                    nextEvenLocationY += listOfCheckBoxesRoles[i].Height;

                    maxOddLocationX = nextOddLocationX;
                    nextOddLocationX = listOfCheckBoxesRoles[i].Location.X + listOfCheckBoxesRoles[i].Size.Width + 5;

                    if (maxOddLocationX < nextOddLocationX)
                    {
                        maxOddLocationX = nextOddLocationX;
                        for (int j = 0; j < listOfCheckBoxesRoles.Count - 1; j++)
                        {
                            if (j != 0 && j % 2 != 0)
                            {
                                listOfCheckBoxesRoles[j].Location = new Point(maxOddLocationX, listOfCheckBoxesRoles[j].Location.Y);
                            }
                        }
                    }
                }

                if (i != 0 && i % 2 != 0)
                {
                    listOfCheckBoxesRoles[i].Location = new Point(maxOddLocationX, nextOddLocationY);
                }
            }

            for (int nextButtonIndex = 1; nextButtonIndex < buttons.Length; nextButtonIndex++)
            {
                buttons[nextButtonIndex].Location = new Point(buttons[nextButtonIndex].Location.X, buttons[nextButtonIndex - 1].Location.Y + buttons[nextButtonIndex - 1].Height + 3);
            }
        }

        private static void DeleteAllCheckBoxesInContainer(Control containerControl, string[] allRoles)
        {
            int existCheckBoxCounter = 0;
            foreach (Control item in containerControl.Controls)
            {
                if (item is CheckBox)
                {
                    existCheckBoxCounter++;
                }
            }

            if (containerControl.Controls.Count >= allRoles.Length)
            {
                int index = 0;
                int counter = 0;

                for (int i = 0; i < containerControl.Controls.Count; i++)
                {
                    if (index == 0 && containerControl.Controls[i] is CheckBox)
                    {
                        counter++;
                        if (counter == 1)
                        {
                            index = i;
                        }
                    }

                    if (index != 0 && containerControl.Controls[index] is CheckBox)
                    {
                        containerControl.Controls.Remove(containerControl.Controls[index]);
                        containerControl.Controls[index].Dispose();

                        existCheckBoxCounter = existCheckBoxCounter - 2;

                        if (existCheckBoxCounter == 2)
                        {
                            containerControl.Controls.Remove(containerControl.Controls[index]);
                            containerControl.Controls[index].Dispose();
                        }
                        if (existCheckBoxCounter == 1)
                        {
                            containerControl.Controls.RemoveAt(index);
                        }
                    }
                }
            }
        }
    }
}
