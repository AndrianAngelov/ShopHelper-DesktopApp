using System.Windows.Forms;
using System.Drawing;

namespace ShopHelper_v0._0.SubForms.ManagerSubForms.InventoryCenterSubForms
{
    partial class AddProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts));
            this.dataGridAddProducts = new System.Windows.Forms.DataGridView();
            this.AddProducts_panel = new System.Windows.Forms.Panel();
            this.addProduct_label = new System.Windows.Forms.Label();
            this.clear_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.insert_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.Towns_comboBox = new System.Windows.Forms.ComboBox();
            this.Stores_comboBox = new System.Windows.Forms.ComboBox();
            this.Categories_comboBox = new System.Windows.Forms.ComboBox();
            this.Vendor_comboBox = new System.Windows.Forms.ComboBox();
            this.Quantity_label = new System.Windows.Forms.Label();
            this.Quantity_txt = new System.Windows.Forms.TextBox();
            this.UnitPrice_txt = new System.Windows.Forms.TextBox();
            this.ProductName_txt = new System.Windows.Forms.TextBox();
            this.Town_label = new System.Windows.Forms.Label();
            this.Store_label = new System.Windows.Forms.Label();
            this.Category_label = new System.Windows.Forms.Label();
            this.UntitPrice_label = new System.Windows.Forms.Label();
            this.Vendor_label = new System.Windows.Forms.Label();
            this.ProductName_label = new System.Windows.Forms.Label();
            this.dataGridNavigation_AddProducts = new Anyo.WindowsForms.Controls.Navigations.DataGridNavigation();
            this.ProductsLoadingCircle = new MRG.Controls.UI.LoadingCircle();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddProducts)).BeginInit();
            this.AddProducts_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAddProducts
            // 
            this.dataGridAddProducts.AllowUserToAddRows = false;
            this.dataGridAddProducts.AllowUserToDeleteRows = false;
            this.dataGridAddProducts.AllowUserToResizeColumns = false;
            this.dataGridAddProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridAddProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridAddProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAddProducts.CausesValidation = false;
            this.dataGridAddProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAddProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridAddProducts.ColumnHeadersHeight = 40;
            this.dataGridAddProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(130)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAddProducts.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridAddProducts.EnableHeadersVisualStyles = false;
            this.dataGridAddProducts.Location = new System.Drawing.Point(268, 9);
            this.dataGridAddProducts.Name = "dataGridAddProducts";
            this.dataGridAddProducts.ReadOnly = true;
            this.dataGridAddProducts.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(212)))), ((int)(((byte)(215)))));
            this.dataGridAddProducts.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridAddProducts.RowTemplate.Height = 20;
            this.dataGridAddProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddProducts.Size = new System.Drawing.Size(521, 342);
            this.dataGridAddProducts.TabIndex = 4;
            this.dataGridAddProducts.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridAddProducts_CellPainting);
            // 
            // AddProducts_panel
            // 
            this.AddProducts_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddProducts_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddProducts_panel.Controls.Add(this.addProduct_label);
            this.AddProducts_panel.Controls.Add(this.clear_btn);
            this.AddProducts_panel.Controls.Add(this.insert_btn);
            this.AddProducts_panel.Controls.Add(this.Towns_comboBox);
            this.AddProducts_panel.Controls.Add(this.Stores_comboBox);
            this.AddProducts_panel.Controls.Add(this.Categories_comboBox);
            this.AddProducts_panel.Controls.Add(this.Vendor_comboBox);
            this.AddProducts_panel.Controls.Add(this.Quantity_label);
            this.AddProducts_panel.Controls.Add(this.Quantity_txt);
            this.AddProducts_panel.Controls.Add(this.UnitPrice_txt);
            this.AddProducts_panel.Controls.Add(this.ProductName_txt);
            this.AddProducts_panel.Controls.Add(this.Town_label);
            this.AddProducts_panel.Controls.Add(this.Store_label);
            this.AddProducts_panel.Controls.Add(this.Category_label);
            this.AddProducts_panel.Controls.Add(this.UntitPrice_label);
            this.AddProducts_panel.Controls.Add(this.Vendor_label);
            this.AddProducts_panel.Controls.Add(this.ProductName_label);
            this.AddProducts_panel.ForeColor = System.Drawing.Color.White;
            this.AddProducts_panel.Location = new System.Drawing.Point(8, 11);
            this.AddProducts_panel.Name = "AddProducts_panel";
            this.AddProducts_panel.Size = new System.Drawing.Size(254, 340);
            this.AddProducts_panel.TabIndex = 3;
            // 
            // addProduct_label
            // 
            this.addProduct_label.AutoSize = true;
            this.addProduct_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addProduct_label.CausesValidation = false;
            this.addProduct_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProduct_label.ForeColor = System.Drawing.Color.White;
            this.addProduct_label.Location = new System.Drawing.Point(77, 1);
            this.addProduct_label.Name = "addProduct_label";
            this.addProduct_label.Size = new System.Drawing.Size(93, 16);
            this.addProduct_label.TabIndex = 2;
            this.addProduct_label.Text = "Add Product";
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
            this.clear_btn.Size = new System.Drawing.Size(100, 26);
            this.clear_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.clear_btn.TabIndex = 19;
            this.clear_btn.Text = "Clear";
            this.clear_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.clear_btn.TextX = 34.59929F;
            this.clear_btn.TextY = 6.087402F;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Active = true;
            this.insert_btn.BorderWidth = 1;
            this.insert_btn.ButtonRadius = 2;
            this.insert_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.insert_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.insert_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.insert_btn.ClickColorB = System.Drawing.Color.Orange;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.insert_btn.ForeColor = System.Drawing.Color.Black;
            this.insert_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.insert_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.insert_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.insert_btn.HoverColorB = System.Drawing.Color.Orange;
            this.insert_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.insert_btn.ImageCornerX = 0;
            this.insert_btn.ImageCornerY = 0;
            this.insert_btn.Location = new System.Drawing.Point(66, 275);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.insert_btn.NormalColorA = System.Drawing.Color.Orange;
            this.insert_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.insert_btn.Size = new System.Drawing.Size(157, 26);
            this.insert_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.insert_btn.TabIndex = 6;
            this.insert_btn.Text = "Save";
            this.insert_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.insert_btn.TextX = 63.25456F;
            this.insert_btn.TextY = 6.087402F;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
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
            this.Towns_comboBox.TabIndex = 18;
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
            this.Stores_comboBox.TabIndex = 17;
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
            this.Categories_comboBox.TabIndex = 16;
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
            this.Vendor_comboBox.TabIndex = 7;
            // 
            // Quantity_label
            // 
            this.Quantity_label.AutoSize = true;
            this.Quantity_label.Location = new System.Drawing.Point(42, 153);
            this.Quantity_label.Name = "Quantity_label";
            this.Quantity_label.Size = new System.Drawing.Size(46, 13);
            this.Quantity_label.TabIndex = 3;
            this.Quantity_label.Text = "Quantity";
            // 
            // Quantity_txt
            // 
            this.Quantity_txt.Location = new System.Drawing.Point(94, 151);
            this.Quantity_txt.Name = "Quantity_txt";
            this.Quantity_txt.Size = new System.Drawing.Size(115, 20);
            this.Quantity_txt.TabIndex = 11;
            // 
            // UnitPrice_txt
            // 
            this.UnitPrice_txt.Location = new System.Drawing.Point(94, 120);
            this.UnitPrice_txt.Name = "UnitPrice_txt";
            this.UnitPrice_txt.Size = new System.Drawing.Size(115, 20);
            this.UnitPrice_txt.TabIndex = 10;
            // 
            // ProductName_txt
            // 
            this.ProductName_txt.Location = new System.Drawing.Point(93, 25);
            this.ProductName_txt.Name = "ProductName_txt";
            this.ProductName_txt.Size = new System.Drawing.Size(115, 20);
            this.ProductName_txt.TabIndex = 5;
            // 
            // Town_label
            // 
            this.Town_label.AutoSize = true;
            this.Town_label.Location = new System.Drawing.Point(52, 218);
            this.Town_label.Name = "Town_label";
            this.Town_label.Size = new System.Drawing.Size(34, 13);
            this.Town_label.TabIndex = 6;
            this.Town_label.Text = "Town";
            // 
            // Store_label
            // 
            this.Store_label.AutoSize = true;
            this.Store_label.Location = new System.Drawing.Point(55, 185);
            this.Store_label.Name = "Store_label";
            this.Store_label.Size = new System.Drawing.Size(32, 13);
            this.Store_label.TabIndex = 14;
            this.Store_label.Text = "Store";
            // 
            // Category_label
            // 
            this.Category_label.AutoSize = true;
            this.Category_label.Location = new System.Drawing.Point(38, 58);
            this.Category_label.Name = "Category_label";
            this.Category_label.Size = new System.Drawing.Size(49, 13);
            this.Category_label.TabIndex = 4;
            this.Category_label.Text = "Category";
            // 
            // UntitPrice_label
            // 
            this.UntitPrice_label.AutoSize = true;
            this.UntitPrice_label.Location = new System.Drawing.Point(36, 122);
            this.UntitPrice_label.Name = "UntitPrice_label";
            this.UntitPrice_label.Size = new System.Drawing.Size(52, 13);
            this.UntitPrice_label.TabIndex = 2;
            this.UntitPrice_label.Text = "Unit price";
            // 
            // Vendor_label
            // 
            this.Vendor_label.AutoSize = true;
            this.Vendor_label.Location = new System.Drawing.Point(46, 91);
            this.Vendor_label.Name = "Vendor_label";
            this.Vendor_label.Size = new System.Drawing.Size(41, 13);
            this.Vendor_label.TabIndex = 1;
            this.Vendor_label.Text = "Vendor";
            // 
            // ProductName_label
            // 
            this.ProductName_label.AutoSize = true;
            this.ProductName_label.Location = new System.Drawing.Point(13, 27);
            this.ProductName_label.Name = "ProductName_label";
            this.ProductName_label.Size = new System.Drawing.Size(75, 13);
            this.ProductName_label.TabIndex = 0;
            this.ProductName_label.Text = "Product Name";
            // 
            // dataGridNavigation_AddProducts
            // 
            this.dataGridNavigation_AddProducts.ButtonsDistance = 0;
            this.dataGridNavigation_AddProducts.ButtonsHeight = 25;
            this.dataGridNavigation_AddProducts.ButtonsWidth = 40;
            this.dataGridNavigation_AddProducts.CausesValidation = false;
            this.dataGridNavigation_AddProducts.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.dataGridNavigation_AddProducts.ClickColorA = System.Drawing.Color.DarkOrange;
            this.dataGridNavigation_AddProducts.ClickColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_AddProducts.CommandString = null;
            this.dataGridNavigation_AddProducts.ConnectionString = "";
            this.dataGridNavigation_AddProducts.DataGridName = this.dataGridAddProducts;
            this.dataGridNavigation_AddProducts.FontButtons = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridNavigation_AddProducts.FontCurrentPage = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridNavigation_AddProducts.HoverBorderColor = System.Drawing.Color.Linen;
            this.dataGridNavigation_AddProducts.HoverColorA = System.Drawing.Color.PeachPuff;
            this.dataGridNavigation_AddProducts.HoverColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_AddProducts.Location = new System.Drawing.Point(420, 357);
            this.dataGridNavigation_AddProducts.Name = "dataGridNavigation_AddProducts";
            this.dataGridNavigation_AddProducts.NormalBorderColor = System.Drawing.Color.White;
            this.dataGridNavigation_AddProducts.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_AddProducts.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_AddProducts.PageSize = 15;
            this.dataGridNavigation_AddProducts.Size = new System.Drawing.Size(220, 25);
            this.dataGridNavigation_AddProducts.TabIndex = 15;
            this.dataGridNavigation_AddProducts.TextAlignment = Anyo.WindowsForms.Controls.Navigations.DataGridNavigation.Alignment.Center;
            this.dataGridNavigation_AddProducts.TextX = 13.38639F;
            this.dataGridNavigation_AddProducts.TextY = 5.087402F;
            // 
            // ProductsLoadingCircle
            // 
            this.ProductsLoadingCircle.Active = true;
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
            this.ProductsLoadingCircle.TabIndex = 6;
            this.ProductsLoadingCircle.Text = "loadingCircle1";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(797, 386);
            this.Controls.Add(this.ProductsLoadingCircle);
            this.Controls.Add(this.dataGridNavigation_AddProducts);
            this.Controls.Add(this.dataGridAddProducts);
            this.Controls.Add(this.AddProducts_panel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(180, 280);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            this.Load += new System.EventHandler(this.AddProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddProducts)).EndInit();
            this.AddProducts_panel.ResumeLayout(false);
            this.AddProducts_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAddProducts;
        private System.Windows.Forms.Panel AddProducts_panel;
        private System.Windows.Forms.TextBox Quantity_txt;
        private System.Windows.Forms.TextBox UnitPrice_txt;
        private System.Windows.Forms.TextBox ProductName_txt;
        private System.Windows.Forms.Label Town_label;
        private System.Windows.Forms.Label Store_label;
        private System.Windows.Forms.Label Category_label;
        private System.Windows.Forms.Label Quantity_label;
        private System.Windows.Forms.Label UntitPrice_label;
        private System.Windows.Forms.Label Vendor_label;
        private System.Windows.Forms.Label ProductName_label;
        private System.Windows.Forms.ComboBox Vendor_comboBox;
        private System.Windows.Forms.ComboBox Categories_comboBox;
        private System.Windows.Forms.ComboBox Towns_comboBox;
        private System.Windows.Forms.ComboBox Stores_comboBox;
        private Anyo.WindowsForms.Controls.Navigations.DataGridNavigation dataGridNavigation_AddProducts;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton insert_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton clear_btn;
        private System.Windows.Forms.Label addProduct_label;
        private MRG.Controls.UI.LoadingCircle ProductsLoadingCircle;
    }
}