namespace ShopHelper_v0._0.SubForms.ManagerSubForms.InventoryCenterSubForms
{
    partial class EditDeleteCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeleteCategory));
            this.CategoryName_txt = new System.Windows.Forms.TextBox();
            this.CategoryName_label = new System.Windows.Forms.Label();
            this.dataGridEditCategories = new System.Windows.Forms.DataGridView();
            this.editCategory_label = new System.Windows.Forms.Label();
            this.EditCategries_Panel = new System.Windows.Forms.Panel();
            this.delete_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.clear_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.update_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.edit_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.dataGridNavigation_EditCategories = new Anyo.WindowsForms.Controls.Navigations.DataGridNavigation();
            this.CategoriesLoadingCircle = new MRG.Controls.UI.LoadingCircle();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditCategories)).BeginInit();
            this.EditCategries_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryName_txt
            // 
            this.CategoryName_txt.Location = new System.Drawing.Point(94, 12);
            this.CategoryName_txt.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.CategoryName_txt.Name = "CategoryName_txt";
            this.CategoryName_txt.Size = new System.Drawing.Size(115, 20);
            this.CategoryName_txt.TabIndex = 22;
            // 
            // CategoryName_label
            // 
            this.CategoryName_label.AutoSize = true;
            this.CategoryName_label.ForeColor = System.Drawing.Color.White;
            this.CategoryName_label.Location = new System.Drawing.Point(16, 26);
            this.CategoryName_label.Name = "CategoryName_label";
            this.CategoryName_label.Size = new System.Drawing.Size(80, 13);
            this.CategoryName_label.TabIndex = 21;
            this.CategoryName_label.Text = "Category Name";
            // 
            // dataGridEditCategories
            // 
            this.dataGridEditCategories.AllowUserToAddRows = false;
            this.dataGridEditCategories.AllowUserToDeleteRows = false;
            this.dataGridEditCategories.AllowUserToResizeColumns = false;
            this.dataGridEditCategories.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridEditCategories.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEditCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEditCategories.CausesValidation = false;
            this.dataGridEditCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEditCategories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEditCategories.ColumnHeadersHeight = 40;
            this.dataGridEditCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(130)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEditCategories.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEditCategories.EnableHeadersVisualStyles = false;
            this.dataGridEditCategories.Location = new System.Drawing.Point(261, 26);
            this.dataGridEditCategories.Name = "dataGridEditCategories";
            this.dataGridEditCategories.ReadOnly = true;
            this.dataGridEditCategories.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(212)))), ((int)(((byte)(215)))));
            this.dataGridEditCategories.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEditCategories.RowTemplate.Height = 20;
            this.dataGridEditCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEditCategories.Size = new System.Drawing.Size(220, 242);
            this.dataGridEditCategories.TabIndex = 28;
            this.dataGridEditCategories.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridEditCategories_CellPainting);
            this.dataGridEditCategories.DoubleClick += new System.EventHandler(this.dataGridEditCategories_DoubleClick);
            // 
            // editCategory_label
            // 
            this.editCategory_label.AutoSize = true;
            this.editCategory_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editCategory_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editCategory_label.ForeColor = System.Drawing.Color.White;
            this.editCategory_label.Location = new System.Drawing.Point(44, 0);
            this.editCategory_label.Name = "editCategory_label";
            this.editCategory_label.Size = new System.Drawing.Size(170, 16);
            this.editCategory_label.TabIndex = 34;
            this.editCategory_label.Text = "Edit or Delete Category";
            // 
            // EditCategries_Panel
            // 
            this.EditCategries_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.EditCategries_Panel.Controls.Add(this.delete_btn);
            this.EditCategries_Panel.Controls.Add(this.clear_btn);
            this.EditCategries_Panel.Controls.Add(this.CategoryName_txt);
            this.EditCategries_Panel.Controls.Add(this.update_btn);
            this.EditCategries_Panel.Controls.Add(this.edit_btn);
            this.EditCategries_Panel.ForeColor = System.Drawing.Color.White;
            this.EditCategries_Panel.Location = new System.Drawing.Point(7, 12);
            this.EditCategries_Panel.Name = "EditCategries_Panel";
            this.EditCategries_Panel.Size = new System.Drawing.Size(243, 207);
            this.EditCategries_Panel.TabIndex = 35;
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
            this.delete_btn.Location = new System.Drawing.Point(32, 102);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.delete_btn.NormalColorA = System.Drawing.Color.Orange;
            this.delete_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.delete_btn.Size = new System.Drawing.Size(177, 25);
            this.delete_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.delete_btn.TabIndex = 33;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.delete_btn.TextX = 69.76067F;
            this.delete_btn.TextY = 5.087402F;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
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
            this.clear_btn.Location = new System.Drawing.Point(121, 38);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.clear_btn.NormalColorA = System.Drawing.Color.Orange;
            this.clear_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.clear_btn.Size = new System.Drawing.Size(88, 25);
            this.clear_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.clear_btn.TabIndex = 31;
            this.clear_btn.Text = "Clear";
            this.clear_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.clear_btn.TextX = 28.59929F;
            this.clear_btn.TextY = 5.087402F;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
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
            this.update_btn.Location = new System.Drawing.Point(32, 70);
            this.update_btn.Name = "update_btn";
            this.update_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.update_btn.NormalColorA = System.Drawing.Color.Orange;
            this.update_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.update_btn.Size = new System.Drawing.Size(177, 25);
            this.update_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.update_btn.TabIndex = 32;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.update_btn.TextX = 67.90227F;
            this.update_btn.TextY = 5.087402F;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
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
            this.edit_btn.Location = new System.Drawing.Point(32, 38);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.edit_btn.NormalColorA = System.Drawing.Color.Orange;
            this.edit_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.edit_btn.Size = new System.Drawing.Size(83, 25);
            this.edit_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.edit_btn.TabIndex = 30;
            this.edit_btn.Text = "Edit";
            this.edit_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.edit_btn.TextX = 29.37248F;
            this.edit_btn.TextY = 5.087402F;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // dataGridNavigation_EditCategories
            // 
            this.dataGridNavigation_EditCategories.ButtonsDistance = 0;
            this.dataGridNavigation_EditCategories.ButtonsHeight = 25;
            this.dataGridNavigation_EditCategories.ButtonsWidth = 40;
            this.dataGridNavigation_EditCategories.CausesValidation = false;
            this.dataGridNavigation_EditCategories.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.dataGridNavigation_EditCategories.ClickColorA = System.Drawing.Color.DarkOrange;
            this.dataGridNavigation_EditCategories.ClickColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_EditCategories.CommandString = null;
            this.dataGridNavigation_EditCategories.ConnectionString = null;
            this.dataGridNavigation_EditCategories.DataGridName = this.dataGridEditCategories;
            this.dataGridNavigation_EditCategories.FontButtons = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridNavigation_EditCategories.FontCurrentPage = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridNavigation_EditCategories.HoverBorderColor = System.Drawing.Color.Linen;
            this.dataGridNavigation_EditCategories.HoverColorA = System.Drawing.Color.PeachPuff;
            this.dataGridNavigation_EditCategories.HoverColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_EditCategories.Location = new System.Drawing.Point(261, 275);
            this.dataGridNavigation_EditCategories.Name = "dataGridNavigation_EditCategories";
            this.dataGridNavigation_EditCategories.NormalBorderColor = System.Drawing.Color.White;
            this.dataGridNavigation_EditCategories.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_EditCategories.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_EditCategories.PageSize = 10;
            this.dataGridNavigation_EditCategories.Size = new System.Drawing.Size(220, 25);
            this.dataGridNavigation_EditCategories.TabIndex = 29;
            this.dataGridNavigation_EditCategories.TextAlignment = Anyo.WindowsForms.Controls.Navigations.DataGridNavigation.Alignment.Center;
            this.dataGridNavigation_EditCategories.TextX = 13.38639F;
            this.dataGridNavigation_EditCategories.TextY = 5.087402F;
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
            this.CategoriesLoadingCircle.TabIndex = 39;
            this.CategoriesLoadingCircle.Text = "loadingCircle1";
            // 
            // EditDeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(492, 309);
            this.Controls.Add(this.CategoriesLoadingCircle);
            this.Controls.Add(this.dataGridNavigation_EditCategories);
            this.Controls.Add(this.dataGridEditCategories);
            this.Controls.Add(this.CategoryName_label);
            this.Controls.Add(this.editCategory_label);
            this.Controls.Add(this.EditCategries_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(180, 280);
            this.Name = "EditDeleteCategory";
            this.Text = "EditDeleteCategory";
            this.Load += new System.EventHandler(this.EditDeleteCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditCategories)).EndInit();
            this.EditCategries_Panel.ResumeLayout(false);
            this.EditCategries_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CategoryName_txt;
        private System.Windows.Forms.Label CategoryName_label;
        private System.Windows.Forms.DataGridView dataGridEditCategories;
        private Anyo.WindowsForms.Controls.Navigations.DataGridNavigation dataGridNavigation_EditCategories;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton edit_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton clear_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton update_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton delete_btn;
        private System.Windows.Forms.Label editCategory_label;
        private System.Windows.Forms.Panel EditCategries_Panel;
        private MRG.Controls.UI.LoadingCircle CategoriesLoadingCircle;
    }
}