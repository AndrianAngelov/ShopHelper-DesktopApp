namespace ShopHelper_v0._0.SubForms.ManagerSubForms.VendorsCenterSubForms
{
    //using System.ComponentModel;
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Configuration;
    using ShopHelper_v0._0.ShopHelperService;
    using ShopHelper_v0._0.Utilities.Multithreading;
    using Anyo.WindowsForms.Validation;
    using Anyo.WindowsForms.Controls.Navigations;
    using Anyo.WindowsForms.Controls.DataGridViewHeaderPainting;
    using Anyo.WindowsForms.MessageBoxes;
    using Anyo.WindowsForms.CommonFunctionality;
    using Anyo.WindowsForms.CommonFunctionality.UI;

    public partial class AddVendors : Form
    {
        #region Fields
        private Validation addVendorsValidation ;
        private CRUDClient vendorsCRUD = new CRUDClient("BasicHttpBinding_ICRUD");
        private VendorDTO vendorsData = new VendorDTO();
        private DataTable dataTableVendors= new DataTable();
        private PopulateUIFromSeparateThread vendors;
        #endregion

        #region Constructors
        public AddVendors()
        {
            InitializeComponent();

            this.addVendorsValidation = new Validation();
            AddVendorsValidationDetails();

            this.vendors = new PopulateWithVendors(this, this.dataTableVendors,
                                                   this.dataGridnavigation_AddVendors,
                                                   Display.FirstPage,
                                                   this.vendorsLoadingCircle);
        }
        #endregion

        #region Events
        private void AddVendors_Load(object sender, EventArgs e)
        {
            DisplayVendors(Display.FirstPage);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            this.vendorsData.VendorName = VendorName_txt.Text;
            this.vendorsCRUD.Insert(vendorsData);
            SampleMessageBox.Show(this.vendorsCRUD.GetResult());
            SampleMessageBox.Show(this.vendorsCRUD.GetResult());

            ClearAll();
            DisplayVendors(Display.LastPage);
            
        }

        private void dataGridAddVendors_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            OrangeGradient.Painter(e);
        }
        #endregion

        #region Methods
        private void AddVendorsValidationDetails()
        {
            this.addVendorsValidation.KindOfValidation(VendorName_txt, CheckThatInput.IsText);
            this.addVendorsValidation.DeactivateControlsDuringValidating(insert_btn);
        }

        private void DisplayVendors(Display firstOrLastPage)
        {
            this.vendors = new PopulateWithVendors(this, this.dataTableVendors,
                                                         this.dataGridnavigation_AddVendors,
                                                         firstOrLastPage,
                                                         this.vendorsLoadingCircle,
                                                         this.vendorsCRUD);
            this.vendors.StartPopulatingDataGridNavigation();
        }

        private void ClearAll()
        {
            Clear.AllTextBoxesAndComboBoxes(this.addVendors_panel);
            this.addVendorsValidation.RestartValidation();
        }
        #endregion
    }
}
