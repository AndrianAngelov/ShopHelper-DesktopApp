namespace ShopHelper_v0._0.SubForms.ManagerSubForms.InventoryCenterSubForms
{
    partial class EditDeleteProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeleteProducts));
            this.dataGridEditProducts = new System.Windows.Forms.DataGridView();
            this.dataGridNavigation_EditProducts = new Anyo.WindowsForms.Controls.Navigations.DataGridNavigation();
            this.addProduct_label = new System.Windows.Forms.Label();
            this.EditProducts_Panel = new System.Windows.Forms.Panel();
            this.Towns_comboBox = new System.Windows.Forms.ComboBox();
            this.delete_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.Stores_comboBox = new System.Windows.Forms.ComboBox();
            this.update_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.Categories_comboBox = new System.Windows.Forms.ComboBox();
            this.Vendor_comboBox = new System.Windows.Forms.ComboBox();
            this.clear_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.edit_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.UnitPrice_txt = new System.Windows.Forms.TextBox();
            this.ProductName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductsLoadingCircle = new MRG.Controls.UI.LoadingCircle();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditProducts)).BeginInit();
            this.EditProducts_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridEditProducts
            // 
            this.dataGridEditProducts.AllowUserToAddRows = false;
            this.dataGridEditProducts.AllowUserToDeleteRows = false;
            this.dataGridEditProducts.AllowUserToResizeColumns = false;
            this.dataGridEditProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridEditProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEditProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEditProducts.CausesValidation = false;
            this.dataGridEditProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEditProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEditProducts.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(130)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEditProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEditProducts.EnableHeadersVisualStyles = false;
            this.dataGridEditProducts.Location = new System.Drawing.Point(268, 9);
            this.dataGridEditProducts.Name = "dataGridEditProducts";
            this.dataGridEditProducts.ReadOnly = true;
            this.dataGridEditProducts.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(212)))), ((int)(((byte)(215)))));
            this.dataGridEditProducts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEditProducts.RowTemplate.Height = 20;
            this.dataGridEditProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEditProducts.Size = new System.Drawing.Size(521, 342);
            this.dataGridEditProducts.TabIndex = 6;
            this.dataGridEditProducts.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridEditProducts_CellPainting);
            this.dataGridEditProducts.DoubleClick += new System.EventHandler(this.dataGridEditProducts_DoubleClick);
            // 
            // dataGridNavigation_EditProducts
            // 
            this.dataGridNavigation_EditProducts.ButtonsDistance = 0;
            this.dataGridNavigation_EditProducts.ButtonsHeight = 25;
            this.dataGridNavigation_EditProducts.ButtonsWidth = 40;
            this.dataGridNavigation_EditProducts.CausesValidation = false;
            this.dataGridNavigation_EditProducts.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.dataGridNavigation_EditProducts.ClickColorA = System.Drawing.Color.DarkOrange;
            this.dataGridNavigation_EditProducts.ClickColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_EditProducts.CommandString = null;
            this.dataGridNavigation_EditProducts.ConnectionString = null;
            this.dataGridNavigation_EditProducts.DataGridName = this.dataGridEditProducts;
            this.dataGridNavigation_EditProducts.FontButtons = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridNavigation_EditProducts.FontCurrentPage = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridNavigation_EditProducts.HoverBorderColor = System.Drawing.Color.Linen;
            this.dataGridNavigation_EditProducts.HoverColorA = System.Drawing.Color.PeachPuff;
            this.dataGridNavigation_EditProducts.HoverColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_EditProducts.Location = new System.Drawing.Point(420, 357);
            this.dataGridNavigation_EditProducts.Name = "dataGridNavigation_EditProducts";
            this.dataGridNavigation_EditProducts.NormalBorderColor = System.Drawing.Color.White;
            this.dataGridNavigation_EditProducts.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_EditProducts.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_EditProducts.PageSize = 15;
            this.dataGridNavigation_EditProducts.Size = new System.Drawing.Size(220, 25);
            this.dataGridNavigation_EditProducts.TabIndex = 7;
            this.dataGridNavigation_EditProducts.TextAlignment = Anyo.WindowsForms.Controls.Navigations.DataGridNavigation.Alignment.Center;
            this.dataGridNavigation_EditProducts.TextX = 13.38639F;
            this.dataGridNavigation_EditProducts.TextY = 5.087402F;
            // 
            // addProduct_label
            // 
            this.addProduct_label.AutoSize = true;
            this.addProduct_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addProduct_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProduct_label.ForeColor = System.Drawing.Color.White;
            this.addProduct_label.Location = new System.Drawing.Point(77, 1);
            this.addProduct_label.Name = "addProduct_label";
            this.addProduct_label.Size = new System.Drawing.Size(111, 16);
            this.addProduct_label.TabIndex = 8;
            this.addProduct_label.Text = "Modify Product";
            // 
            // EditProducts_Panel
            // 
            this.EditProducts_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EditProducts_Panel.Controls.Add(this.Towns_comboBox);
            this.EditProducts_Panel.Controls.Add(this.addProduct_label);
            this.EditProducts_Panel.Controls.Add(this.delete_btn);
            this.EditProducts_Panel.Controls.Add(this.Stores_comboBox);
            this.EditProducts_Panel.Controls.Add(this.update_btn);
            this.EditProducts_Panel.Controls.Add(this.Categories_comboBox);
            this.EditProducts_Panel.Controls.Add(this.Vendor_comboBox);
            this.EditProducts_Panel.Controls.Add(this.clear_btn);
            this.EditProducts_Panel.Controls.Add(this.edit_btn);
            this.EditProducts_Panel.Controls.Add(this.label1);
            this.EditProducts_Panel.Controls.Add(this.Quantity_txt);
            this.EditProducts_Panel.Controls.Add(this.UnitPrice_txt);
            this.EditProducts_Panel.Controls.Add(this.ProductName_txt);
            this.EditProducts_Panel.Controls.Add(this.label2);
            this.EditProducts_Panel.Controls.Add(this.label3);
            this.EditProducts_Panel.Controls.Add(this.label4);
            this.EditProducts_Panel.Controls.Add(this.label5);
            this.EditProducts_Panel.Controls.Add(this.label6);
            this.EditProducts_Panel.Controls.Add(this.label7);
            this.EditProducts_Panel.ForeColor = System.Drawing.Color.White;
            this.EditProducts_Panel.Location = new System.Drawing.Point(8, 11);
            this.EditProducts_Panel.Name = "EditProducts_Panel";
            this.EditProducts_Panel.Size = new System.Drawing.Size(254, 336);
            this.EditProducts_Panel.TabIndex = 9;
            // 
            // Towns_comboBox
            // 
            this.Towns_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Towns_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Towns_comboBox.FormattingEnabled = true;
            this.Towns_comboBox.Location = new System.Drawing.Point(93, 214);
            this.Towns_comboBox.Name = "Towns_comboBox";
            this.Towns_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Towns_comboBox.Size = new System.Drawing.Size(130, 21);
            this.Towns_comboBox.TabIndex = 22;
            // 
            // delete_btn
            // 
            this.delete_btn.Active = true;
            this.delete_btn.BorderWidth = 1;
            this.delete_btn.ButtonRadius = 2;
            this.delete_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.delete_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.delete_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.delete_btn.ClickColorB = System.Drawing.Color.Orange;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.delete_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.delete_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.delete_btn.HoverColorB = System.Drawing.Color.Orange;
            this.delete_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.delete_btn.ImageCornerX = 0;
            this.delete_btn.ImageCornerY = 0;
            this.delete_btn.Location = new System.Drawing.Point(32, 308);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.delete_btn.NormalColorA = System.Drawing.Color.Orange;
            this.delete_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.delete_btn.Size = new System.Drawing.Size(177, 25);
            this.delete_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.delete_btn.TabIndex = 37;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.delete_btn.TextX = 69.76067F;
            this.delete_btn.TextY = 5.087402F;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // Stores_comboBox
            // 
            this.Stores_comboBox.AllowDrop = true;
            this.Stores_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Stores_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Stores_comboBox.DropDownWidth = 115;
            this.Stores_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stores_comboBox.FormattingEnabled = true;
            this.Stores_comboBox.Location = new System.Drawing.Point(93, 182);
            this.Stores_comboBox.Name = "Stores_comboBox";
            this.Stores_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Stores_comboBox.Size = new System.Drawing.Size(130, 21);
            this.Stores_comboBox.TabIndex = 21;
            // 
            // update_btn
            // 
            this.update_btn.Active = true;
            this.update_btn.BorderWidth = 1;
            this.update_btn.ButtonRadius = 2;
            this.update_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.update_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.update_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.update_btn.ClickColorB = System.Drawing.Color.Orange;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.update_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.update_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.update_btn.HoverColorB = System.Drawing.Color.Orange;
            this.update_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.update_btn.ImageCornerX = 0;
            this.update_btn.ImageCornerY = 0;
            this.update_btn.Location = new System.Drawing.Point(32, 276);
            this.update_btn.Name = "update_btn";
            this.update_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.update_btn.NormalColorA = System.Drawing.Color.Orange;
            this.update_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.update_btn.Size = new System.Drawing.Size(177, 25);
            this.update_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.update_btn.TabIndex = 36;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.update_btn.TextX = 67.90227F;
            this.update_btn.TextY = 5.087402F;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Categories_comboBox
            // 
            this.Categories_comboBox.AllowDrop = true;
            this.Categories_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Categories_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Categories_comboBox.FormattingEnabled = true;
            this.Categories_comboBox.Location = new System.Drawing.Point(93, 56);
            this.Categories_comboBox.Name = "Categories_comboBox";
            this.Categories_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Categories_comboBox.Size = new System.Drawing.Size(130, 21);
            this.Categories_comboBox.TabIndex = 10;
            // 
            // Vendor_comboBox
            // 
            this.Vendor_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Vendor_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Vendor_comboBox.FormattingEnabled = true;
            this.Vendor_comboBox.Location = new System.Drawing.Point(93, 88);
            this.Vendor_comboBox.Name = "Vendor_comboBox";
            this.Vendor_comboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Vendor_comboBox.Size = new System.Drawing.Size(130, 21);
            this.Vendor_comboBox.TabIndex = 11;
            // 
            // clear_btn
            // 
            this.clear_btn.Active = true;
            this.clear_btn.BorderWidth = 1;
            this.clear_btn.ButtonRadius = 2;
            this.clear_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.clear_btn.CausesValidation = false;
            this.clear_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.clear_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.clear_btn.ClickColorB = System.Drawing.Color.Orange;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clear_btn.ForeColor = System.Drawing.Color.Black;
            this.clear_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.clear_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.clear_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.clear_btn.HoverColorB = System.Drawing.Color.Orange;
            this.clear_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.clear_btn.ImageCornerX = 0;
            this.clear_btn.ImageCornerY = 0;
            this.clear_btn.Location = new System.Drawing.Point(121, 244);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.clear_btn.NormalColorA = System.Drawing.Color.Orange;
            this.clear_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.clear_btn.Size = new System.Drawing.Size(88, 25);
            this.clear_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.clear_btn.TabIndex = 35;
            this.clear_btn.Text = "Clear";
            this.clear_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.clear_btn.TextX = 28.59929F;
            this.clear_btn.TextY = 5.087402F;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Active = true;
            this.edit_btn.BorderWidth = 1;
            this.edit_btn.ButtonRadius = 2;
            this.edit_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.edit_btn.CausesValidation = false;
            this.edit_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.edit_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.edit_btn.ClickColorB = System.Drawing.Color.Orange;
            this.edit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.edit_btn.ForeColor = System.Drawing.Color.Black;
            this.edit_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.edit_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.edit_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.edit_btn.HoverColorB = System.Drawing.Color.Orange;
            this.edit_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.edit_btn.ImageCornerX = 0;
            this.edit_btn.ImageCornerY = 0;
            this.edit_btn.Location = new System.Drawing.Point(32, 244);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.edit_btn.NormalColorA = System.Drawing.Color.Orange;
            this.edit_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.edit_btn.Size = new System.Drawing.Size(83, 25);
            this.edit_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.edit_btn.TabIndex = 34;
            this.edit_btn.Text = "Edit";
            this.edit_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.edit_btn.TextX = 29.37248F;
            this.edit_btn.TextY = 5.087402F;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity";
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Location = new System.Drawing.Point(94, 151);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(115, 20);
            this.Quantity_txt.TabIndex = 20;
            // 
            // UnitPrice_txt
            // 
            this.UnitPrice_txt.Location = new System.Drawing.Point(94, 120);
            this.UnitPrice_txt.Name = "UnitPrice_txt";
            this.UnitPrice_txt.Size = new System.Drawing.Size(115, 20);
            this.UnitPrice_txt.TabIndex = 19;
            // 
            // ProductName_txt
            // 
            this.ProductName_txt.Location = new System.Drawing.Point(93, 25);
            this.ProductName_txt.Name = "ProductName_txt";
            this.ProductName_txt.Size = new System.Drawing.Size(115, 20);
            this.ProductName_txt.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Town";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Store";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Unit price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vendor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Product Name";
            // 
            // ProductsLoadingCircle
            // 
            this.ProductsLoadingCircle.Active = false;
            this.ProductsLoadingCircle.Color = System.Drawing.Color.DarkOrange;
            this.ProductsLoadingCircle.InnerCircleRadius = 5;
            this.ProductsLoadingCircle.Location = new System.Drawing.Point(510, 158);
            this.ProductsLoadingCircle.Name = "ProductsLoadingCircle";
            this.ProductsLoadingCircle.NumberSpoke = 12;
            this.ProductsLoadingCircle.OuterCircleRadius = 11;
            this.ProductsLoadingCircle.RotationSpeed = 100;
            this.ProductsLoadingCircle.Size = new System.Drawing.Size(75, 37);
            this.ProductsLoadingCircle.SpokeThickness = 2;
            this.ProductsLoadingCircle.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.ProductsLoadingCircle.TabIndex = 10;
            this.ProductsLoadingCircle.Text = "loadingCircle1";
            // 
            // EditDeleteProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(797, 389);
            this.Controls.Add(this.ProductsLoadingCircle);
            this.Controls.Add(this.EditProducts_Panel);
            this.Controls.Add(this.dataGridNavigation_EditProducts);
            this.Controls.Add(this.dataGridEditProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(180, 280);
            this.Name = "EditDeleteProducts";
            this.Text = "EditDeleteProducts";
            this.Load += new System.EventHandler(this.EditDeleteProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditProducts)).EndInit();
            this.EditProducts_Panel.ResumeLayout(false);
            this.EditProducts_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEditProducts;
        private Anyo.WindowsForms.Controls.Navigations.DataGridNavigation dataGridNavigation_EditProducts;
        private System.Windows.Forms.Label addProduct_label;
        private System.Windows.Forms.Panel EditProducts_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.TextBox ProductName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton delete_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton update_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton clear_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton edit_btn;
        private System.Windows.Forms.TextBox UnitPrice_txt;
        private System.Windows.Forms.ComboBox Towns_comboBox;
        private System.Windows.Forms.ComboBox Stores_comboBox;
        private System.Windows.Forms.ComboBox Categories_comboBox;
        private System.Windows.Forms.ComboBox Vendor_comboBox;
        private MRG.Controls.UI.LoadingCircle ProductsLoadingCircle;
    }
}