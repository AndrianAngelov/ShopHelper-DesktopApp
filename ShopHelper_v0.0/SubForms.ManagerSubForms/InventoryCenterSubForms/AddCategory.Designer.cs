using System.ComponentModel;
namespace ShopHelper_v0._0.SubForms.ManagerSubForms.InventoryCenterSubForms
{
    partial class AddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCategory));
            this.CategoryName_txt = new System.Windows.Forms.TextBox();
            this.CategoryName_label = new System.Windows.Forms.Label();
            this.dataGridAddCategory = new System.Windows.Forms.DataGridView();
            this.addCategory_label = new System.Windows.Forms.Label();
            this.AddCategries_Panel = new System.Windows.Forms.Panel();
            this.clear_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.insert_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.dataGridNavigation_AddCategory = new Anyo.WindowsForms.Controls.Navigations.DataGridNavigation();
            this.CategoriesLoadingCircle = new MRG.Controls.UI.LoadingCircle();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddCategory)).BeginInit();
            this.AddCategries_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryName_txt
            // 
            this.CategoryName_txt.Location = new System.Drawing.Point(94, 12);
            this.CategoryName_txt.Margin = new System.Windows.Forms.Padding(3, 15, 15, 3);
            this.CategoryName_txt.Name = "CategoryName_txt";
            this.CategoryName_txt.Size = new System.Drawing.Size(115, 20);
            this.CategoryName_txt.TabIndex = 19;
            // 
            // CategoryName_label
            // 
            this.CategoryName_label.AutoSize = true;
            this.CategoryName_label.ForeColor = System.Drawing.Color.White;
            this.CategoryName_label.Location = new System.Drawing.Point(16, 26);
            this.CategoryName_label.Name = "CategoryName_label";
            this.CategoryName_label.Size = new System.Drawing.Size(80, 13);
            this.CategoryName_label.TabIndex = 18;
            this.CategoryName_label.Text = "Category Name";
            // 
            // dataGridAddCategory
            // 
            this.dataGridAddCategory.AllowUserToAddRows = false;
            this.dataGridAddCategory.AllowUserToDeleteRows = false;
            this.dataGridAddCategory.AllowUserToResizeColumns = false;
            this.dataGridAddCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridAddCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAddCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAddCategory.CausesValidation = false;
            this.dataGridAddCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAddCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAddCategory.ColumnHeadersHeight = 40;
            this.dataGridAddCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(130)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAddCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAddCategory.EnableHeadersVisualStyles = false;
            this.dataGridAddCategory.Location = new System.Drawing.Point(261, 26);
            this.dataGridAddCategory.Name = "dataGridAddCategory";
            this.dataGridAddCategory.ReadOnly = true;
            this.dataGridAddCategory.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(212)))), ((int)(((byte)(215)))));
            this.dataGridAddCategory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAddCategory.RowTemplate.Height = 20;
            this.dataGridAddCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddCategory.Size = new System.Drawing.Size(220, 243);
            this.dataGridAddCategory.TabIndex = 24;
            this.dataGridAddCategory.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridAddCategory_CellPainting);
            // 
            // addCategory_label
            // 
            this.addCategory_label.AutoSize = true;
            this.addCategory_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addCategory_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCategory_label.ForeColor = System.Drawing.Color.White;
            this.addCategory_label.Location = new System.Drawing.Point(78, 1);
            this.addCategory_label.Name = "addCategory_label";
            this.addCategory_label.Size = new System.Drawing.Size(103, 16);
            this.addCategory_label.TabIndex = 36;
            this.addCategory_label.Text = "Add Category";
            // 
            // AddCategries_Panel
            // 
            this.AddCategries_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.AddCategries_Panel.Controls.Add(this.CategoryName_txt);
            this.AddCategries_Panel.Controls.Add(this.clear_btn);
            this.AddCategries_Panel.Controls.Add(this.insert_btn);
            this.AddCategries_Panel.ForeColor = System.Drawing.Color.White;
            this.AddCategries_Panel.Location = new System.Drawing.Point(7, 12);
            this.AddCategries_Panel.Name = "AddCategries_Panel";
            this.AddCategries_Panel.Size = new System.Drawing.Size(243, 207);
            this.AddCategries_Panel.TabIndex = 37;
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
            this.clear_btn.Location = new System.Drawing.Point(111, 39);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.clear_btn.NormalColorA = System.Drawing.Color.Orange;
            this.clear_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.clear_btn.Size = new System.Drawing.Size(100, 26);
            this.clear_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.clear_btn.TabIndex = 26;
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
            this.insert_btn.Location = new System.Drawing.Point(54, 71);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.insert_btn.NormalColorA = System.Drawing.Color.Orange;
            this.insert_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.insert_btn.Size = new System.Drawing.Size(157, 26);
            this.insert_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.insert_btn.TabIndex = 25;
            this.insert_btn.Text = "Save";
            this.insert_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.insert_btn.TextX = 63.25456F;
            this.insert_btn.TextY = 6.087402F;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // dataGridNavigation_AddCategory
            // 
            this.dataGridNavigation_AddCategory.ButtonsDistance = 0;
            this.dataGridNavigation_AddCategory.ButtonsHeight = 25;
            this.dataGridNavigation_AddCategory.ButtonsWidth = 40;
            this.dataGridNavigation_AddCategory.CausesValidation = false;
            this.dataGridNavigation_AddCategory.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.dataGridNavigation_AddCategory.ClickColorA = System.Drawing.Color.DarkOrange;
            this.dataGridNavigation_AddCategory.ClickColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_AddCategory.CommandString = null;
            this.dataGridNavigation_AddCategory.ConnectionString = null;
            this.dataGridNavigation_AddCategory.DataGridName = this.dataGridAddCategory;
            this.dataGridNavigation_AddCategory.FontButtons = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridNavigation_AddCategory.FontCurrentPage = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridNavigation_AddCategory.HoverBorderColor = System.Drawing.Color.Linen;
            this.dataGridNavigation_AddCategory.HoverColorA = System.Drawing.Color.PeachPuff;
            this.dataGridNavigation_AddCategory.HoverColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_AddCategory.Location = new System.Drawing.Point(261, 274);
            this.dataGridNavigation_AddCategory.Name = "dataGridNavigation_AddCategory";
            this.dataGridNavigation_AddCategory.NormalBorderColor = System.Drawing.Color.White;
            this.dataGridNavigation_AddCategory.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_AddCategory.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_AddCategory.PageSize = 10;
            this.dataGridNavigation_AddCategory.Size = new System.Drawing.Size(220, 25);
            this.dataGridNavigation_AddCategory.TabIndex = 23;
            this.dataGridNavigation_AddCategory.TextAlignment = Anyo.WindowsForms.Controls.Navigations.DataGridNavigation.Alignment.Center;
            this.dataGridNavigation_AddCategory.TextX = 13.38639F;
            this.dataGridNavigation_AddCategory.TextY = 5.087402F;
            // 
            // CategoriesLoadingCircle
            // 
            this.CategoriesLoadingCircle.Active = false;
            this.CategoriesLoadingCircle.Color = System.Drawing.Color.DarkOrange;
            this.CategoriesLoadingCircle.InnerCircleRadius = 5;
            this.CategoriesLoadingCircle.Location = new System.Drawing.Point(333, 132);
            this.CategoriesLoadingCircle.Name = "CategoriesLoadingCircle";
            this.CategoriesLoadingCircle.NumberSpoke = 12;
            this.CategoriesLoadingCircle.OuterCircleRadius = 11;
            this.CategoriesLoadingCircle.RotationSpeed = 100;
            this.CategoriesLoadingCircle.Size = new System.Drawing.Size(75, 37);
            this.CategoriesLoadingCircle.SpokeThickness = 2;
            this.CategoriesLoadingCircle.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.CategoriesLoadingCircle.TabIndex = 38;
            this.CategoriesLoadingCircle.Text = "loadingCircle1";
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(497, 309);
            this.Controls.Add(this.CategoriesLoadingCircle);
            this.Controls.Add(this.addCategory_label);
            this.Controls.Add(this.dataGridAddCategory);
            this.Controls.Add(this.dataGridNavigation_AddCategory);
            this.Controls.Add(this.CategoryName_label);
            this.Controls.Add(this.AddCategries_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(180, 280);
            this.Name = "AddCategory";
            this.Text = "AddCategory";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddCategory)).EndInit();
            this.AddCategries_Panel.ResumeLayout(false);
            this.AddCategries_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoryName_txt;
        private System.Windows.Forms.Label CategoryName_label;
        private System.Windows.Forms.DataGridView dataGridAddCategory;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton clear_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton insert_btn;
        private System.Windows.Forms.Label addCategory_label;
        private System.Windows.Forms.Panel AddCategries_Panel;
        private Anyo.WindowsForms.Controls.Navigations.DataGridNavigation dataGridNavigation_AddCategory;
        private MRG.Controls.UI.LoadingCircle CategoriesLoadingCircle;
    }
}