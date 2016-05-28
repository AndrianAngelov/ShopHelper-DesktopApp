namespace ShopHelper_v0._0.SubForms.ManagerSubForms.VendorsCenterSubForms
{
    partial class AddVendors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVendors));
            this.VendorName_label = new System.Windows.Forms.Label();
            this.VendorName_txt = new System.Windows.Forms.TextBox();
            this.dataGridAddVendors = new System.Windows.Forms.DataGridView();
            this.dataGridnavigation_AddVendors = new Anyo.WindowsForms.Controls.Navigations.DataGridNavigation();
            this.clear_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.insert_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.addVendors_panel = new System.Windows.Forms.Panel();
            this.addVendors_label = new System.Windows.Forms.Label();
            this.vendorsLoadingCircle = new MRG.Controls.UI.LoadingCircle();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddVendors)).BeginInit();
            this.addVendors_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VendorName_label
            // 
            this.VendorName_label.AutoSize = true;
            this.VendorName_label.ForeColor = System.Drawing.Color.White;
            this.VendorName_label.Location = new System.Drawing.Point(8, 12);
            this.VendorName_label.Name = "VendorName_label";
            this.VendorName_label.Size = new System.Drawing.Size(72, 13);
            this.VendorName_label.TabIndex = 0;
            this.VendorName_label.Text = "Vendor Name";
            // 
            // VendorName_txt
            // 
            this.VendorName_txt.Location = new System.Drawing.Point(91, 9);
            this.VendorName_txt.Name = "VendorName_txt";
            this.VendorName_txt.Size = new System.Drawing.Size(129, 20);
            this.VendorName_txt.TabIndex = 1;
            // 
            // dataGridAddVendors
            // 
            this.dataGridAddVendors.AllowUserToAddRows = false;
            this.dataGridAddVendors.AllowUserToDeleteRows = false;
            this.dataGridAddVendors.AllowUserToResizeColumns = false;
            this.dataGridAddVendors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dataGridAddVendors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAddVendors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAddVendors.CausesValidation = false;
            this.dataGridAddVendors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAddVendors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridAddVendors.ColumnHeadersHeight = 40;
            this.dataGridAddVendors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(130)))), ((int)(((byte)(9)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAddVendors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAddVendors.EnableHeadersVisualStyles = false;
            this.dataGridAddVendors.Location = new System.Drawing.Point(261, 15);
            this.dataGridAddVendors.Name = "dataGridAddVendors";
            this.dataGridAddVendors.ReadOnly = true;
            this.dataGridAddVendors.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(212)))), ((int)(((byte)(215)))));
            this.dataGridAddVendors.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAddVendors.RowTemplate.Height = 20;
            this.dataGridAddVendors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAddVendors.Size = new System.Drawing.Size(220, 242);
            this.dataGridAddVendors.TabIndex = 5;
            this.dataGridAddVendors.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridAddVendors_CellPainting);
            // 
            // dataGridnavigation_AddVendors
            // 
            this.dataGridnavigation_AddVendors.ButtonsDistance = 0;
            this.dataGridnavigation_AddVendors.ButtonsHeight = 25;
            this.dataGridnavigation_AddVendors.ButtonsWidth = 40;
            this.dataGridnavigation_AddVendors.CausesValidation = false;
            this.dataGridnavigation_AddVendors.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.dataGridnavigation_AddVendors.ClickColorA = System.Drawing.Color.DarkOrange;
            this.dataGridnavigation_AddVendors.ClickColorB = System.Drawing.Color.Orange;
            this.dataGridnavigation_AddVendors.CommandString = null;
            this.dataGridnavigation_AddVendors.ConnectionString = null;
            this.dataGridnavigation_AddVendors.DataGridName = this.dataGridAddVendors;
            this.dataGridnavigation_AddVendors.FontButtons = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridnavigation_AddVendors.FontCurrentPage = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridnavigation_AddVendors.HoverBorderColor = System.Drawing.Color.Linen;
            this.dataGridnavigation_AddVendors.HoverColorA = System.Drawing.Color.PeachPuff;
            this.dataGridnavigation_AddVendors.HoverColorB = System.Drawing.Color.Orange;
            this.dataGridnavigation_AddVendors.Location = new System.Drawing.Point(261, 263);
            this.dataGridnavigation_AddVendors.Name = "dataGridnavigation_AddVendors";
            this.dataGridnavigation_AddVendors.NormalBorderColor = System.Drawing.Color.White;
            this.dataGridnavigation_AddVendors.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridnavigation_AddVendors.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataGridnavigation_AddVendors.PageSize = 10;
            this.dataGridnavigation_AddVendors.Size = new System.Drawing.Size(220, 25);
            this.dataGridnavigation_AddVendors.TabIndex = 18;
            this.dataGridnavigation_AddVendors.TextAlignment = Anyo.WindowsForms.Controls.Navigations.DataGridNavigation.Alignment.Center;
            this.dataGridnavigation_AddVendors.TextX = 13.38639F;
            this.dataGridnavigation_AddVendors.TextY = 5.087402F;
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
            this.clear_btn.TabIndex = 28;
            this.clear_btn.Text = "Clear";
            this.clear_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.clear_btn.TextX = 28.59929F;
            this.clear_btn.TextY = 5.087402F;
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
            this.insert_btn.Location = new System.Drawing.Point(43, 67);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.insert_btn.NormalColorA = System.Drawing.Color.Orange;
            this.insert_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.insert_btn.Size = new System.Drawing.Size(177, 25);
            this.insert_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.insert_btn.TabIndex = 27;
            this.insert_btn.Text = "Save";
            this.insert_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.insert_btn.TextX = 73.25455F;
            this.insert_btn.TextY = 5.087402F;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // addVendors_panel
            // 
            this.addVendors_panel.Controls.Add(this.VendorName_label);
            this.addVendors_panel.Controls.Add(this.clear_btn);
            this.addVendors_panel.Controls.Add(this.VendorName_txt);
            this.addVendors_panel.Controls.Add(this.insert_btn);
            this.addVendors_panel.Location = new System.Drawing.Point(12, 20);
            this.addVendors_panel.Name = "addVendors_panel";
            this.addVendors_panel.Size = new System.Drawing.Size(243, 245);
            this.addVendors_panel.TabIndex = 29;
            // 
            // addVendors_label
            // 
            this.addVendors_label.AutoSize = true;
            this.addVendors_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addVendors_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addVendors_label.ForeColor = System.Drawing.Color.White;
            this.addVendors_label.Location = new System.Drawing.Point(75, 1);
            this.addVendors_label.Name = "addVendors_label";
            this.addVendors_label.Size = new System.Drawing.Size(98, 16);
            this.addVendors_label.TabIndex = 35;
            this.addVendors_label.Text = "Add Vendors";
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
            this.vendorsLoadingCircle.TabIndex = 36;
            this.vendorsLoadingCircle.Text = "loadingCircle1";
            // 
            // AddVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(492, 292);
            this.Controls.Add(this.vendorsLoadingCircle);
            this.Controls.Add(this.addVendors_label);
            this.Controls.Add(this.dataGridnavigation_AddVendors);
            this.Controls.Add(this.dataGridAddVendors);
            this.Controls.Add(this.addVendors_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(180, 280);
            this.Name = "AddVendors";
            this.Text = "AddVendors";
            this.Load += new System.EventHandler(this.AddVendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAddVendors)).EndInit();
            this.addVendors_panel.ResumeLayout(false);
            this.addVendors_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VendorName_label;
        private System.Windows.Forms.TextBox VendorName_txt;
        private System.Windows.Forms.DataGridView dataGridAddVendors;
        private Anyo.WindowsForms.Controls.Navigations.DataGridNavigation dataGridnavigation_AddVendors;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton clear_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton insert_btn;
        private System.Windows.Forms.Panel addVendors_panel;
        private System.Windows.Forms.Label addVendors_label;
        private MRG.Controls.UI.LoadingCircle vendorsLoadingCircle;
    }
}