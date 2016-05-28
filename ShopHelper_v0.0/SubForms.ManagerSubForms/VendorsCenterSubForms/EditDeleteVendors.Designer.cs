namespace ShopHelper_v0._0.SubForms.ManagerSubForms.VendorsCenterSubForms
{
    partial class EditDeleteVendors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeleteVendors));
            this.VendorName_txt = new System.Windows.Forms.TextBox();
            this.VendorName_label = new System.Windows.Forms.Label();
            this.dataGridEditVendors = new System.Windows.Forms.DataGridView();
            this.dataGridNavigation_EditVendors = new Anyo.WindowsForms.Controls.Navigations.DataGridNavigation();
            this.delete_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.update_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.clear_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.edit_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.editVendors_panel = new System.Windows.Forms.Panel();
            this.editVendors_label = new System.Windows.Forms.Label();
            this.vendorsLoadingCircle = new MRG.Controls.UI.LoadingCircle();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditVendors)).BeginInit();
            this.editVendors_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VendorName_txt
            // 
            this.VendorName_txt.Location = new System.Drawing.Point(91, 9);
            this.VendorName_txt.Name = "VendorName_txt";
            this.VendorName_txt.Size = new System.Drawing.Size(129, 20);
            this.VendorName_txt.TabIndex = 20;
            // 
            // VendorName_label
            // 
            this.VendorName_label.AutoSize = true;
            this.VendorName_label.ForeColor = System.Drawing.Color.White;
            this.VendorName_label.Location = new System.Drawing.Point(8, 12);
            this.VendorName_label.Name = "VendorName_label";
            this.VendorName_label.Size = new System.Drawing.Size(72, 13);
            this.VendorName_label.TabIndex = 19;
            this.VendorName_label.Text = "Vendor Name";
            // 
            // dataGridEditVendors
            // 
            this.dataGridEditVendors.AllowUserToAddRows = false;
            this.dataGridEditVendors.AllowUserToDeleteRows = false;
            this.dataGridEditVendors.AllowUserToResizeColumns = false;
            this.dataGridEditVendors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridEditVendors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEditVendors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEditVendors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridEditVendors.CausesValidation = false;
            this.dataGridEditVendors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEditVendors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEditVendors.ColumnHeadersHeight = 40;
            this.dataGridEditVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(130)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEditVendors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridEditVendors.EnableHeadersVisualStyles = false;
            this.dataGridEditVendors.Location = new System.Drawing.Point(261, 15);
            this.dataGridEditVendors.Name = "dataGridEditVendors";
            this.dataGridEditVendors.ReadOnly = true;
            this.dataGridEditVendors.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(212)))), ((int)(((byte)(215)))));
            this.dataGridEditVendors.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridEditVendors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEditVendors.Size = new System.Drawing.Size(220, 242);
            this.dataGridEditVendors.TabIndex = 21;
            this.dataGridEditVendors.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridEditVendors_CellPainting);
            this.dataGridEditVendors.DoubleClick += new System.EventHandler(this.dataGridEditVendors_DoubleClick);
            // 
            // dataGridNavigation_EditVendors
            // 
            this.dataGridNavigation_EditVendors.ButtonsDistance = 0;
            this.dataGridNavigation_EditVendors.ButtonsHeight = 25;
            this.dataGridNavigation_EditVendors.ButtonsWidth = 40;
            this.dataGridNavigation_EditVendors.CausesValidation = false;
            this.dataGridNavigation_EditVendors.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.dataGridNavigation_EditVendors.ClickColorA = System.Drawing.Color.DarkOrange;
            this.dataGridNavigation_EditVendors.ClickColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_EditVendors.CommandString = null;
            this.dataGridNavigation_EditVendors.ConnectionString = null;
            this.dataGridNavigation_EditVendors.DataGridName = this.dataGridEditVendors;
            this.dataGridNavigation_EditVendors.FontButtons = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridNavigation_EditVendors.FontCurrentPage = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridNavigation_EditVendors.HoverBorderColor = System.Drawing.Color.Linen;
            this.dataGridNavigation_EditVendors.HoverColorA = System.Drawing.Color.PeachPuff;
            this.dataGridNavigation_EditVendors.HoverColorB = System.Drawing.Color.Orange;
            this.dataGridNavigation_EditVendors.Location = new System.Drawing.Point(261, 263);
            this.dataGridNavigation_EditVendors.Name = "dataGridNavigation_EditVendors";
            this.dataGridNavigation_EditVendors.NormalBorderColor = System.Drawing.Color.White;
            this.dataGridNavigation_EditVendors.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_EditVendors.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridNavigation_EditVendors.PageSize = 10;
            this.dataGridNavigation_EditVendors.Size = new System.Drawing.Size(220, 25);
            this.dataGridNavigation_EditVendors.TabIndex = 22;
            this.dataGridNavigation_EditVendors.TextAlignment = Anyo.WindowsForms.Controls.Navigations.DataGridNavigation.Alignment.Center;
            this.dataGridNavigation_EditVendors.TextX = 13.38639F;
            this.dataGridNavigation_EditVendors.TextY = 5.087402F;
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
            this.delete_btn.Location = new System.Drawing.Point(43, 99);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.delete_btn.NormalColorA = System.Drawing.Color.Orange;
            this.delete_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.delete_btn.Size = new System.Drawing.Size(177, 25);
            this.delete_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.delete_btn.TabIndex = 41;
            this.delete_btn.Text = "Delete";
            this.delete_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.delete_btn.TextX = 69.76067F;
            this.delete_btn.TextY = 5.087402F;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
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
            this.update_btn.Location = new System.Drawing.Point(43, 67);
            this.update_btn.Name = "update_btn";
            this.update_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.update_btn.NormalColorA = System.Drawing.Color.Orange;
            this.update_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.update_btn.Size = new System.Drawing.Size(177, 25);
            this.update_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.update_btn.TabIndex = 40;
            this.update_btn.Text = "Update";
            this.update_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.update_btn.TextX = 67.90227F;
            this.update_btn.TextY = 5.087402F;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
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
            this.clear_btn.Location = new System.Drawing.Point(132, 35);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.clear_btn.NormalColorA = System.Drawing.Color.Orange;
            this.clear_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.clear_btn.Size = new System.Drawing.Size(88, 25);
            this.clear_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.clear_btn.TabIndex = 39;
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
            this.edit_btn.Location = new System.Drawing.Point(43, 35);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.edit_btn.NormalColorA = System.Drawing.Color.Orange;
            this.edit_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.edit_btn.Size = new System.Drawing.Size(83, 25);
            this.edit_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.edit_btn.TabIndex = 38;
            this.edit_btn.Text = "Edit";
            this.edit_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.edit_btn.TextX = 29.37248F;
            this.edit_btn.TextY = 5.087402F;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // editVendors_panel
            // 
            this.editVendors_panel.Controls.Add(this.delete_btn);
            this.editVendors_panel.Controls.Add(this.VendorName_txt);
            this.editVendors_panel.Controls.Add(this.update_btn);
            this.editVendors_panel.Controls.Add(this.VendorName_label);
            this.editVendors_panel.Controls.Add(this.clear_btn);
            this.editVendors_panel.Controls.Add(this.edit_btn);
            this.editVendors_panel.Location = new System.Drawing.Point(12, 20);
            this.editVendors_panel.Name = "editVendors_panel";
            this.editVendors_panel.Size = new System.Drawing.Size(243, 237);
            this.editVendors_panel.TabIndex = 42;
            // 
            // editVendors_label
            // 
            this.editVendors_label.AutoSize = true;
            this.editVendors_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editVendors_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editVendors_label.ForeColor = System.Drawing.Color.White;
            this.editVendors_label.Location = new System.Drawing.Point(49, 1);
            this.editVendors_label.Name = "editVendors_label";
            this.editVendors_label.Size = new System.Drawing.Size(165, 16);
            this.editVendors_label.TabIndex = 43;
            this.editVendors_label.Text = "Edit or Delete Vendors";
            // 
            // vendorsLoadingCircle
            // 
            this.vendorsLoadingCircle.Active = true;
            this.vendorsLoadingCircle.Color = System.Drawing.Color.DarkOrange;
            this.vendorsLoadingCircle.InnerCircleRadius = 5;
            this.vendorsLoadingCircle.Location = new System.Drawing.Point(350, 125);
            this.vendorsLoadingCircle.Name = "vendorsLoadingCircle";
            this.vendorsLoadingCircle.NumberSpoke = 12;
            this.vendorsLoadingCircle.OuterCircleRadius = 11;
            this.vendorsLoadingCircle.RotationSpeed = 100;
            this.vendorsLoadingCircle.Size = new System.Drawing.Size(50, 35);
            this.vendorsLoadingCircle.SpokeThickness = 2;
            this.vendorsLoadingCircle.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.vendorsLoadingCircle.TabIndex = 44;
            this.vendorsLoadingCircle.Text = "loadingCircle1";
            // 
            // EditDeleteVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(490, 291);
            this.Controls.Add(this.vendorsLoadingCircle);
            this.Controls.Add(this.editVendors_label);
            this.Controls.Add(this.dataGridNavigation_EditVendors);
            this.Controls.Add(this.dataGridEditVendors);
            this.Controls.Add(this.editVendors_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(180, 280);
            this.Name = "EditDeleteVendors";
            this.Text = "EditDeleteVendors";
            this.Load += new System.EventHandler(this.EditDeleteVendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditVendors)).EndInit();
            this.editVendors_panel.ResumeLayout(false);
            this.editVendors_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VendorName_txt;
        private System.Windows.Forms.Label VendorName_label;
        private System.Windows.Forms.DataGridView dataGridEditVendors;
        private Anyo.WindowsForms.Controls.Navigations.DataGridNavigation dataGridNavigation_EditVendors;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton delete_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton update_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton clear_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton edit_btn;
        private System.Windows.Forms.Panel editVendors_panel;
        private System.Windows.Forms.Label editVendors_label;
        private MRG.Controls.UI.LoadingCircle vendorsLoadingCircle;
    }
}