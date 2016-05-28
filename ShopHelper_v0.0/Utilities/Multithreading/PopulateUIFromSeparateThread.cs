namespace ShopHelper_v0._0.Utilities.Multithreading
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Data;
    using Anyo.WindowsForms.Controls.Navigations;
    using MRG.Controls.UI;
    using System.Threading;
    using Anyo.WindowsForms.MessageBoxes;
    using Anyo.WindowsForms.CommonFunctionality;

    public class PopulateUIFromSeparateThread
    {
        #region Fields
        private Form form;
        private DataTable dataTable;
        private DataGridNavigation paging;
        private LoadingCircle loadingCircle;
        private Display firstOrLastPage;

        private ComboBox comboBox=new ComboBox();
        private List<string> stringList;

        private delegate void UpdateNavigationDelegate(DataTable dt, Display firstOrLastpage);
        private delegate void populateComboBoxDelegate(string item);
        private delegate void clearComboBoxDelegate();
        #endregion

        #region Constructors
        public PopulateUIFromSeparateThread(Form currentForm, DataTable dt)
        {
            this.form = currentForm;
            this.dataTable = dt;
        }

        public PopulateUIFromSeparateThread(Form currentForm, DataTable dt,
                                           DataGridNavigation currentPaging,
                                           Display firstOrLastPage,
                                           LoadingCircle currentLoadingCircle)
            : this(currentForm, dt)
        {
            this.paging = currentPaging;
            this.loadingCircle = currentLoadingCircle;
            this.loadingCircle.Active = true;
            this.firstOrLastPage = firstOrLastPage;
        }

        public PopulateUIFromSeparateThread(Form currentForm, DataTable dt,
                                           ComboBox currentComboBox)
            : this(currentForm, dt)
        {
            this.comboBox = currentComboBox;
            this.ComboBoxItems = new List<string>();
        }

        public PopulateUIFromSeparateThread(Form currentForm, DataTable dt,
                                           DataGridNavigation currentPaging,
                                           Display firstOrLastPage,
                                           LoadingCircle currentLoadingCircle,
                                           ComboBox currentComboBox)
            :this(currentForm,dt,currentPaging,firstOrLastPage,currentLoadingCircle)

        {
            this.comboBox = currentComboBox;
            this.ComboBoxItems = new List<string>();
        }
        #endregion

        #region Properties
        protected DataTable CurrentDataTable
        {
            get
            {
                return this.dataTable;
            }
            set
            {
                this.dataTable = value;
            }
        }

        protected List<string> ComboBoxItems
        {
            get
            {
                return this.stringList;
            }
            set
            {
                this.stringList = value;
            }
        }
        #endregion

        #region Private Methods
        private void DisplayItems()
        {
            try
            {
                this.dataTable.Clear();

                GetItemsForDataGridNavigation();

                //MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());
                if (form.InvokeRequired)
                {
                    try
                    {
                        form.Invoke(new UpdateNavigationDelegate(UpdateNavigation), new object[] { this.dataTable, this.firstOrLastPage });
                    }
                    catch (ObjectDisposedException)
                    {
                        return;
                    }
                }

            }
            catch (ThreadInterruptedException)
            {
                SampleMessageBox.Show("ThreadInterruptedException", "Info");
                return;
            }
            catch (ThreadAbortException)
            {
                SampleMessageBox.Show("ThreadAbortException", "Info");
            }
            finally
            {
                //SampleMessageBox.Show("Finally block reached.", "Info");
            }
        }

        private void FillComboBox()
        {
            GetItemsForComboBox();

            if (form.InvokeRequired && !form.IsDisposed)
            {
                try
                {
                    form.Invoke(new clearComboBoxDelegate(ClearComboBox));
                }
                catch (ObjectDisposedException)
                {
                    return;
                }
            }

            //MessageBox.Show(Thread.CurrentThread.ManagedThreadId.ToString());
            foreach (var item in this.ComboBoxItems)
            {
                if (form.InvokeRequired && !form.IsDisposed)
                {

                    try
                    {
                        form.Invoke(new populateComboBoxDelegate(UpdateComboBox), new object[] { item });
                    }
                    catch (ObjectDisposedException)
                    {
                        return;
                    }
                }
                else
                {
                    this.comboBox.Items.Add(item);
                }
            }
        }

        private void UpdateNavigation(DataTable dt, Display firstOrLastPage)
        {
            this.loadingCircle.Hide();
            this.paging.AllPages = dt;
            this.paging.FillDataGridWithRecords(firstOrLastPage);
        }

        private void ClearComboBox()
        {
            this.comboBox.Items.Clear();
        }

        private void UpdateComboBox(string item)
        {
            this.comboBox.Items.Add(item);
        } 
        #endregion

        #region Proteced Methods
        protected virtual void GetItemsForDataGridNavigation()
        {

        }

        protected virtual void GetItemsForComboBox()
        {
        }

        protected void FillAndAddDataRow(params object[] rowItems)
        {
            this.dataTable.Rows.Add(rowItems);
        }

        protected void AddToComboBox(string item)
        {
            this.ComboBoxItems.Add(item);
        } 
        #endregion

        #region Public Methods
        public void StartPopulatingDataGridNavigation()
        {
            Thread thread = new Thread(new ThreadStart(DisplayItems));
            thread.IsBackground = true;
            thread.Start();
        }

        public void StartPopulatingComboBox()
        {
            Thread thread = new Thread(new ThreadStart(FillComboBox));
            thread.IsBackground = true;
            thread.Start();
        }

        public void StartPopulatingWithSync()
        {
            Thread thread1 = new Thread(new ThreadStart(DisplayItems));
            thread1.IsBackground = true;
            Thread thread2 = new Thread(new ThreadStart(FillComboBox));
            thread2.IsBackground = true;
            thread1.Start();
            thread2.Start();
        } 
        #endregion
    }
}
