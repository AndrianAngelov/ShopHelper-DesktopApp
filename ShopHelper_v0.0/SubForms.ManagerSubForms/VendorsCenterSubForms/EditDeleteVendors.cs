namespace ShopHelper_v0._0.SubForms.ManagerSubForms.VendorsCenterSubForms
{
    using System;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using ShopHelper_v0._0.ShopHelperService;
    using ShopHelper_v0._0.Utilities.Multithreading;
    using Anyo.WindowsForms.Validation;
    using Anyo.WindowsForms.Controls.Navigations;
    using Anyo.WindowsForms.Controls.DataGridViewHeaderPainting;
    using Anyo.WindowsForms.MessageBoxes;
    using Anyo.WindowsForms.CommonFunctionality;
    using Anyo.WindowsForms.CommonFunctionality.UI;

    public partial class EditDeleteVendors : Form
    {
        #region Fields
        private Validation editDeleteVendorsVaslidation ;
        private CRUDClient vendorsCRUD = new CRUDClient("BasicHttpBinding_ICRUD");
        private VendorDTO vendorsData = new VendorDTO();
        private DataTable dataTableVendors = new DataTable();
        private PopulateUIFromSeparateThread vendors;
        #endregion

        #region Constructors
        public EditDeleteVendors()
        {
            InitializeComponent();

            this.editDeleteVendorsVaslidation = new Validation();
            EditDeleteVendorsValidationDetails();

            this.vendors = new PopulateWithVendors(this, this.dataTableVendors,
                                                   this.dataGridNavigation_EditVendors,
                                                   Display.FirstPage,
                                                   this.vendorsLoadingCircle);
        }
        #endregion

        #region Events
        private void EditDeleteVendors_Load(object sender, EventArgs e)
        {
            DisplayVendors(Display.FirstPage);
        }

        private void dataGridEditVendors_DoubleClick(object sender, EventArgs e)
        {
            DataManipulation.FillTextBoxesAndComboBoxesWithGridViewRowData(this.editVendors_panel, this.dataGridEditVendors);

            this.vendorsData.VendorOldName = this.VendorName_txt.Text;
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            DataManipulation.FillTextBoxesAndComboBoxesWithGridViewRowData(this.editVendors_panel, this.dataGridEditVendors);

            this.vendorsData.VendorOldName = this.VendorName_txt.Text;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            this.vendorsData.VendorName = this.VendorName_txt.Text;
            this.vendorsCRUD.Update(this.vendorsData);
            SampleMessageBox.Show(this.vendorsCRUD.GetResult());

            DisplayVendors(Display.FirstPage);
            ClearAll();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            this.vendorsData.VendorName = this.VendorName_txt.Text;
            this.vendorsCRUD.Delete(this.vendorsData);

            SampleMessageBox.Show(this.vendorsCRUD.GetResult());

            DisplayVendors(Display.FirstPage);
            ClearAll();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void dataGridEditVendors_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            OrangeGradient.Painter(e);
        }
        #endregion

        #region Methods
        private void EditDeleteVendorsValidationDetails()
        {
            this.editDeleteVendorsVaslidation.KindOfValidation(this.VendorName_txt, CheckThatInput.IsText);

            this.editDeleteVendorsVaslidation.DeactivateControlsDuringValidating(this.update_btn);
            this.editDeleteVendorsVaslidation.DeactivateControlsDuringValidating(this.delete_btn);
        }

        private void DisplayVendors(Display firstOrLastPage)
        {
            this.vendors = new PopulateWithVendors(this, this.dataTableVendors,
                                                   this.dataGridNavigation_EditVendors,
                                                   firstOrLastPage,
                                                   this.vendorsLoadingCircle,
                                                   this.vendorsCRUD);
            this.vendors.StartPopulatingDataGridNavigation();
        }

        private void ClearAll()
        {
            Clear.AllTextBoxesAndComboBoxes(this.editVendors_panel);
            this.editDeleteVendorsVaslidation.RestartValidation();
        }
        #endregion
    }
}
