using System.Windows.Forms;
using System.Drawing;

namespace ShopHelper_v0._0.SubForms.ManagerSubForms
{
    partial class InventoryCenter
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
            this.InvetoryCenter_ContainerPanel = new Anyo.WindowsForms.Controls.Panels.RoundedPanel();
            this.InStock_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.editCategory_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.addCategory_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.editProducts_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.addProduct_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.InvetoryCenter_ContainerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // subFormTitle
            // 
            this.subFormTitle.AutoSize = true;
            this.subFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.subFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subFormTitle.ForeColor = System.Drawing.Color.White;
            this.subFormTitle.Location = new System.Drawing.Point(361, 9);
            this.subFormTitle.Name = "subFormTitle";
            this.subFormTitle.Size = new System.Drawing.Size(162, 16);
            this.subFormTitle.TabIndex = 11;
            this.subFormTitle.Text = "INVENTORY CENTER";
            // 
            // InvetoryCenter_ContainerPanel
            // 
            this.InvetoryCenter_ContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.InvetoryCenter_ContainerPanel.BorderColor = System.Drawing.Color.White;
            this.InvetoryCenter_ContainerPanel.BorderWidth = 1;
            this.InvetoryCenter_ContainerPanel.CausesValidation = false;
            this.InvetoryCenter_ContainerPanel.Controls.Add(this.InStock_btn);
            this.InvetoryCenter_ContainerPanel.Controls.Add(this.editCategory_btn);
            this.InvetoryCenter_ContainerPanel.Controls.Add(this.addCategory_btn);
            this.InvetoryCenter_ContainerPanel.Controls.Add(this.editProducts_btn);
            this.InvetoryCenter_ContainerPanel.Controls.Add(this.addProduct_btn);
            this.InvetoryCenter_ContainerPanel.Controls.Add(this.labelSeparator);
            this.InvetoryCenter_ContainerPanel.FillColorA = System.Drawing.Color.Empty;
            this.InvetoryCenter_ContainerPanel.FillColorB = System.Drawing.Color.Empty;
            this.InvetoryCenter_ContainerPanel.ForeColor = System.Drawing.Color.Black;
            this.InvetoryCenter_ContainerPanel.Location = new System.Drawing.Point(6, 28);
            this.InvetoryCenter_ContainerPanel.Name = "InvetoryCenter_ContainerPanel";
            this.InvetoryCenter_ContainerPanel.Radius = 2;
            this.InvetoryCenter_ContainerPanel.Size = new System.Drawing.Size(820, 536);
            this.InvetoryCenter_ContainerPanel.TabIndex = 9;
            // 
            // InStock_btn
            // 
            this.InStock_btn.Active = true;
            this.InStock_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.InStock;
            this.InStock_btn.BorderWidth = 1;
            this.InStock_btn.ButtonRadius = 2;
            this.InStock_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.InStock_btn.CausesValidation = false;
            this.InStock_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.InStock_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.InStock_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.InStock_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InStock_btn.ForeColor = System.Drawing.Color.White;
            this.InStock_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.InStock_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.InStock_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.InStock_btn.HoverColorB = System.Drawing.Color.Orange;
            this.InStock_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.InStock_btn.ImageCornerX = 28;
            this.InStock_btn.ImageCornerY = 10;
            this.InStock_btn.Location = new System.Drawing.Point(705, 14);
            this.InStock_btn.Name = "InStock_btn";
            this.InStock_btn.NormalBorderColor = System.Drawing.Color.White;
            this.InStock_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.InStock_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.InStock_btn.Size = new System.Drawing.Size(104, 86);
            this.InStock_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.InStock_btn.TabIndex = 17;
            this.InStock_btn.Text = "In Stock";
            this.InStock_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.BottomCenter;
            this.InStock_btn.TextX = 25.05447F;
            this.InStock_btn.TextY = 67.24219F;
            this.InStock_btn.Click += new System.EventHandler(this.InStock_btn_Click);
            // 
            // editCategory_btn
            // 
            this.editCategory_btn.Active = true;
            this.editCategory_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.editCategory;
            this.editCategory_btn.BorderWidth = 1;
            this.editCategory_btn.ButtonRadius = 2;
            this.editCategory_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.editCategory_btn.CausesValidation = false;
            this.editCategory_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.editCategory_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.editCategory_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.editCategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editCategory_btn.ForeColor = System.Drawing.Color.White;
            this.editCategory_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.editCategory_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.editCategory_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.editCategory_btn.HoverColorB = System.Drawing.Color.Orange;
            this.editCategory_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.TopCenter;
            this.editCategory_btn.ImageCornerX = 27;
            this.editCategory_btn.ImageCornerY = 5;
            this.editCategory_btn.Location = new System.Drawing.Point(546, 14);
            this.editCategory_btn.Name = "editCategory_btn";
            this.editCategory_btn.NormalBorderColor = System.Drawing.Color.White;
            this.editCategory_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editCategory_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editCategory_btn.Size = new System.Drawing.Size(144, 86);
            this.editCategory_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.editCategory_btn.TabIndex = 16;
            this.editCategory_btn.Text = "Edit/Delete Category";
            this.editCategory_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.BottomCenter;
            this.editCategory_btn.TextX = 6.431427F;
            this.editCategory_btn.TextY = 67.24219F;
            this.editCategory_btn.Click += new System.EventHandler(this.editCategory_btn_Click);
            // 
            // addCategory_btn
            // 
            this.addCategory_btn.Active = true;
            this.addCategory_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.addCategory;
            this.addCategory_btn.BorderWidth = 1;
            this.addCategory_btn.ButtonRadius = 2;
            this.addCategory_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.addCategory_btn.CausesValidation = false;
            this.addCategory_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.addCategory_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.addCategory_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.addCategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addCategory_btn.ForeColor = System.Drawing.Color.White;
            this.addCategory_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.addCategory_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.addCategory_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.addCategory_btn.HoverColorB = System.Drawing.Color.Orange;
            this.addCategory_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.addCategory_btn.ImageCornerX = 10;
            this.addCategory_btn.ImageCornerY = 10;
            this.addCategory_btn.Location = new System.Drawing.Point(427, 14);
            this.addCategory_btn.Name = "addCategory_btn";
            this.addCategory_btn.NormalBorderColor = System.Drawing.Color.White;
            this.addCategory_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addCategory_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addCategory_btn.Size = new System.Drawing.Size(104, 86);
            this.addCategory_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.addCategory_btn.TabIndex = 15;
            this.addCategory_btn.Text = "Add Category";
            this.addCategory_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.BottomCenter;
            this.addCategory_btn.TextX = 7.879993F;
            this.addCategory_btn.TextY = 67.24219F;
            this.addCategory_btn.Click += new System.EventHandler(this.addCategory_btn_Click);
            // 
            // editProducts_btn
            // 
            this.editProducts_btn.Active = true;
            this.editProducts_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.editProducts;
            this.editProducts_btn.BorderWidth = 1;
            this.editProducts_btn.ButtonRadius = 2;
            this.editProducts_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.editProducts_btn.CausesValidation = false;
            this.editProducts_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.editProducts_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.editProducts_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.editProducts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.editProducts_btn.ForeColor = System.Drawing.Color.White;
            this.editProducts_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.editProducts_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.editProducts_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.editProducts_btn.HoverColorB = System.Drawing.Color.Orange;
            this.editProducts_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.TopCenter;
            this.editProducts_btn.ImageCornerX = 26;
            this.editProducts_btn.ImageCornerY = 5;
            this.editProducts_btn.Location = new System.Drawing.Point(271, 14);
            this.editProducts_btn.Name = "editProducts_btn";
            this.editProducts_btn.NormalBorderColor = System.Drawing.Color.White;
            this.editProducts_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editProducts_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.editProducts_btn.Size = new System.Drawing.Size(142, 86);
            this.editProducts_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.editProducts_btn.TabIndex = 14;
            this.editProducts_btn.Text = "Edit/Delete Products";
            this.editProducts_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.BottomCenter;
            this.editProducts_btn.TextX = 6.193146F;
            this.editProducts_btn.TextY = 67.24219F;
            this.editProducts_btn.Click += new System.EventHandler(this.editProducts_btn_Click);
            // 
            // addProduct_btn
            // 
            this.addProduct_btn.Active = true;
            this.addProduct_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.addProduct;
            this.addProduct_btn.BorderWidth = 1;
            this.addProduct_btn.ButtonRadius = 2;
            this.addProduct_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.addProduct_btn.CausesValidation = false;
            this.addProduct_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.addProduct_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.addProduct_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.addProduct_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addProduct_btn.ForeColor = System.Drawing.Color.White;
            this.addProduct_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.addProduct_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.addProduct_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.addProduct_btn.HoverColorB = System.Drawing.Color.Orange;
            this.addProduct_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.addProduct_btn.ImageCornerX = 10;
            this.addProduct_btn.ImageCornerY = 10;
            this.addProduct_btn.Location = new System.Drawing.Point(152, 14);
            this.addProduct_btn.Name = "addProduct_btn";
            this.addProduct_btn.NormalBorderColor = System.Drawing.Color.White;
            this.addProduct_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addProduct_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addProduct_btn.Size = new System.Drawing.Size(104, 86);
            this.addProduct_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.addProduct_btn.TabIndex = 13;
            this.addProduct_btn.Text = "Add Product";
            this.addProduct_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.BottomCenter;
            this.addProduct_btn.TextX = 12.07596F;
            this.addProduct_btn.TextY = 67.24219F;
            this.addProduct_btn.Click += new System.EventHandler(this.addProduct_btn_Click);
            // 
            // labelSeparator
            // 
            this.labelSeparator.BackColor = System.Drawing.Color.White;
            this.labelSeparator.Location = new System.Drawing.Point(48, 111);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(763, 1);
            this.labelSeparator.TabIndex = 7;
            this.labelSeparator.Text = "label1";
            // 
            // InventoryCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(855, 575);
            this.Controls.Add(this.subFormTitle);
            this.Controls.Add(this.InvetoryCenter_ContainerPanel);
            this.Name = "InventoryCenter";
            this.Text = "InventoryCenter";
            this.Load += new System.EventHandler(this.InventoryCenter_Load);
            this.InvetoryCenter_ContainerPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Anyo.WindowsForms.Controls.Panels.RoundedPanel InvetoryCenter_ContainerPanel;
        private Label labelSeparator;
        private Label subFormTitle;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton InStock_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton editCategory_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton addCategory_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton editProducts_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton addProduct_btn;
    }
}