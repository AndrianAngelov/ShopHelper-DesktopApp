namespace ShopHelper_v0._0.SubForms.ManagerSubForms
{
    partial class VendorsCenter
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
            this.subFormTitle = new System.Windows.Forms.Label();
            this.VendorCenter_containerPanel = new Anyo.WindowsForms.Controls.Panels.RoundedPanel();
            this.editVendors_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.addVendors_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.VendorCenter_containerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // subFormTitle
            // 
            this.subFormTitle.AutoSize = true;
            this.subFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.subFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subFormTitle.ForeColor = System.Drawing.Color.White;
            this.subFormTitle.Location = new System.Drawing.Point(362, 9);
            this.subFormTitle.Name = "subFormTitle";
            this.subFormTitle.Size = new System.Drawing.Size(148, 16);
            this.subFormTitle.TabIndex = 12;
            this.subFormTitle.Text = "VENDORS CENTER";
            // 
            // VendorCenter_containerPanel
            // 
            this.VendorCenter_containerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.VendorCenter_containerPanel.BorderColor = System.Drawing.Color.White;
            this.VendorCenter_containerPanel.BorderWidth = 1;
            this.VendorCenter_containerPanel.CausesValidation = false;
            this.VendorCenter_containerPanel.Controls.Add(this.editVendors_btn);
            this.VendorCenter_containerPanel.Controls.Add(this.addVendors_btn);
            this.VendorCenter_containerPanel.Controls.Add(this.labelSeparator);
            this.VendorCenter_containerPanel.FillColorA = System.Drawing.Color.Empty;
            this.VendorCenter_containerPanel.FillColorB = System.Drawing.Color.Empty;
            this.VendorCenter_containerPanel.Location = new System.Drawing.Point(7, 28);
            this.VendorCenter_containerPanel.Name = "VendorCenter_containerPanel";
            this.VendorCenter_containerPanel.Radius = 2;
            this.VendorCenter_containerPanel.Size = new System.Drawing.Size(820, 536);
            this.VendorCenter_containerPanel.TabIndex = 8;
            // 
            // editVendors_btn
            // 
            this.editVendors_btn.Active = true;
            this.editVendors_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.editVendors;
            this.editVendors_btn.BorderWidth = 1;
            this.editVendors_btn.ButtonRadius = 2;
            this.editVendors_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.editVendors_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.editVendors_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.editVendors_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.editVendors_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editVendors_btn.ForeColor = System.Drawing.Color.White;
            this.editVendors_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.editVendors_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.editVendors_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.editVendors_btn.HoverColorB = System.Drawing.Color.Orange;
            this.editVendors_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.TopCenter;
            this.editVendors_btn.ImageCornerX = 3;
            this.editVendors_btn.ImageCornerY = 5;
            this.editVendors_btn.Location = new System.Drawing.Point(358, 13);
            this.editVendors_btn.Name = "editVendors_btn";
            this.editVendors_btn.NormalBorderColor = System.Drawing.Color.White;
            this.editVendors_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editVendors_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editVendors_btn.Size = new System.Drawing.Size(136, 86);
            this.editVendors_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.editVendors_btn.TabIndex = 5;
            this.editVendors_btn.Text = "Edit/Delete Vendors";
            this.editVendors_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.BottomCenter;
            this.editVendors_btn.TextX = 4.716583F;
            this.editVendors_btn.TextY = 67.24219F;
            this.editVendors_btn.Click += new System.EventHandler(this.editVendors_btn_Click);
            // 
            // addVendors_btn
            // 
            this.addVendors_btn.Active = true;
            this.addVendors_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.addVendors;
            this.addVendors_btn.BorderWidth = 1;
            this.addVendors_btn.ButtonRadius = 2;
            this.addVendors_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.addVendors_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.addVendors_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.addVendors_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.addVendors_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addVendors_btn.ForeColor = System.Drawing.Color.White;
            this.addVendors_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.addVendors_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.addVendors_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.addVendors_btn.HoverColorB = System.Drawing.Color.Orange;
            this.addVendors_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.addVendors_btn.ImageCornerX = 12;
            this.addVendors_btn.ImageCornerY = 12;
            this.addVendors_btn.Location = new System.Drawing.Point(209, 13);
            this.addVendors_btn.Name = "addVendors_btn";
            this.addVendors_btn.NormalBorderColor = System.Drawing.Color.White;
            this.addVendors_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addVendors_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addVendors_btn.Size = new System.Drawing.Size(109, 86);
            this.addVendors_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.addVendors_btn.TabIndex = 4;
            this.addVendors_btn.Text = "Add Vendor";
            this.addVendors_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.addVendors_btn.TextX = 15.5994F;
            this.addVendors_btn.TextY = 65F;
            this.addVendors_btn.Click += new System.EventHandler(this.addVendors_btn_Click);
            // 
            // labelSeparator
            // 
            this.labelSeparator.BackColor = System.Drawing.Color.White;
            this.labelSeparator.Location = new System.Drawing.Point(48, 111);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(763, 1);
            this.labelSeparator.TabIndex = 0;
            this.labelSeparator.Text = "label1";
            // 
            // VendorsCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(835, 572);
            this.Controls.Add(this.subFormTitle);
            this.Controls.Add(this.VendorCenter_containerPanel);
            this.Name = "VendorsCenter";
            this.Text = "VendorsCenter";
            this.Load += new System.EventHandler(this.VendorsCenter_Load);
            this.VendorCenter_containerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Anyo.WindowsForms.Controls.Panels.RoundedPanel VendorCenter_containerPanel;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.Label subFormTitle;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton editVendors_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton addVendors_btn;
    }
}