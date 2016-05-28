using System.Windows.Forms;
namespace ShopHelper_v0._0
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.admin_groupBox = new System.Windows.Forms.GroupBox();
            this.currentUsername_label = new System.Windows.Forms.Label();
            this.NumberOfUsersOnline_label = new System.Windows.Forms.Label();
            this.roles_label = new System.Windows.Forms.Label();
            this.mainMenu_panel = new System.Windows.Forms.Panel();
            this.LastLoginDate_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.POS_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.Manager_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.Admin_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.Reports_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.mainMenu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(25, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(99, 103);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POS";
            // 
            // groupBox2
            // 
            this.groupBox2.CausesValidation = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(25, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manager";
            // 
            // groupBox3
            // 
            this.groupBox3.CausesValidation = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(25, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 106);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reports";
            // 
            // admin_groupBox
            // 
            this.admin_groupBox.CausesValidation = false;
            this.admin_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.admin_groupBox.ForeColor = System.Drawing.Color.White;
            this.admin_groupBox.Location = new System.Drawing.Point(25, 417);
            this.admin_groupBox.Name = "admin_groupBox";
            this.admin_groupBox.Size = new System.Drawing.Size(99, 106);
            this.admin_groupBox.TabIndex = 14;
            this.admin_groupBox.TabStop = false;
            this.admin_groupBox.Text = "Admin";
            // 
            // currentUsername_label
            // 
            this.currentUsername_label.AutoSize = true;
            this.currentUsername_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.currentUsername_label.ForeColor = System.Drawing.Color.White;
            this.currentUsername_label.Location = new System.Drawing.Point(8, 101);
            this.currentUsername_label.Name = "currentUsername_label";
            this.currentUsername_label.Size = new System.Drawing.Size(53, 13);
            this.currentUsername_label.TabIndex = 17;
            this.currentUsername_label.Text = "username";
            // 
            // NumberOfUsersOnline_label
            // 
            this.NumberOfUsersOnline_label.AutoSize = true;
            this.NumberOfUsersOnline_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.NumberOfUsersOnline_label.ForeColor = System.Drawing.Color.White;
            this.NumberOfUsersOnline_label.Location = new System.Drawing.Point(8, 149);
            this.NumberOfUsersOnline_label.Name = "NumberOfUsersOnline_label";
            this.NumberOfUsersOnline_label.Size = new System.Drawing.Size(82, 13);
            this.NumberOfUsersOnline_label.TabIndex = 18;
            this.NumberOfUsersOnline_label.Text = "NumberOfUsers";
            // 
            // roles_label
            // 
            this.roles_label.AutoSize = true;
            this.roles_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.roles_label.ForeColor = System.Drawing.Color.White;
            this.roles_label.Location = new System.Drawing.Point(8, 133);
            this.roles_label.Name = "roles_label";
            this.roles_label.Size = new System.Drawing.Size(29, 13);
            this.roles_label.TabIndex = 20;
            this.roles_label.Text = "roles";
            // 
            // mainMenu_panel
            // 
            this.mainMenu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.mainMenu_panel.Controls.Add(this.POS_btn);
            this.mainMenu_panel.Controls.Add(this.Manager_btn);
            this.mainMenu_panel.Controls.Add(this.Admin_btn);
            this.mainMenu_panel.Controls.Add(this.Reports_btn);
            this.mainMenu_panel.Controls.Add(this.admin_groupBox);
            this.mainMenu_panel.Controls.Add(this.groupBox1);
            this.mainMenu_panel.Controls.Add(this.groupBox2);
            this.mainMenu_panel.Controls.Add(this.groupBox3);
            this.mainMenu_panel.Location = new System.Drawing.Point(21, 163);
            this.mainMenu_panel.Name = "mainMenu_panel";
            this.mainMenu_panel.Size = new System.Drawing.Size(152, 542);
            this.mainMenu_panel.TabIndex = 24;
            // 
            // LastLoginDate_label
            // 
            this.LastLoginDate_label.AutoSize = true;
            this.LastLoginDate_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LastLoginDate_label.ForeColor = System.Drawing.Color.White;
            this.LastLoginDate_label.Location = new System.Drawing.Point(8, 117);
            this.LastLoginDate_label.Name = "LastLoginDate_label";
            this.LastLoginDate_label.Size = new System.Drawing.Size(72, 13);
            this.LastLoginDate_label.TabIndex = 26;
            this.LastLoginDate_label.Text = "last login date";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pictureBox1.Image = global::ShopHelper_v0._0.Properties.Resources.HeaderLogo_OneLine;
            this.pictureBox1.Location = new System.Drawing.Point(16, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // POS_btn
            // 
            this.POS_btn.Active = true;
            this.POS_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.POS;
            this.POS_btn.BorderWidth = 1;
            this.POS_btn.ButtonRadius = 2;
            this.POS_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.POS_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.POS_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.POS_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.POS_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.POS_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.POS_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.POS_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.POS_btn.HoverColorB = System.Drawing.Color.Orange;
            this.POS_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.POS_btn.ImageCornerX = 1;
            this.POS_btn.ImageCornerY = 1;
            this.POS_btn.Location = new System.Drawing.Point(30, 27);
            this.POS_btn.Name = "POS_btn";
            this.POS_btn.NormalBorderColor = System.Drawing.Color.White;
            this.POS_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(100)))));
            this.POS_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(100)))));
            this.POS_btn.Size = new System.Drawing.Size(89, 81);
            this.POS_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.POS_btn.TabIndex = 8;
            this.POS_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.POS_btn.TextX = 44F;
            this.POS_btn.TextY = 40F;
            this.POS_btn.Click += new System.EventHandler(this.POS_btn_Click);
            // 
            // Manager_btn
            // 
            this.Manager_btn.Active = true;
            this.Manager_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.MngM_btn;
            this.Manager_btn.BorderWidth = 1;
            this.Manager_btn.ButtonRadius = 2;
            this.Manager_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.Manager_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.Manager_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.Manager_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.Manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Manager_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.Manager_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.Manager_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.Manager_btn.HoverColorB = System.Drawing.Color.Orange;
            this.Manager_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.Manager_btn.ImageCornerX = 0;
            this.Manager_btn.ImageCornerY = 4;
            this.Manager_btn.Location = new System.Drawing.Point(30, 165);
            this.Manager_btn.Name = "Manager_btn";
            this.Manager_btn.NormalBorderColor = System.Drawing.Color.White;
            this.Manager_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(100)))));
            this.Manager_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(100)))));
            this.Manager_btn.Size = new System.Drawing.Size(89, 86);
            this.Manager_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.Manager_btn.TabIndex = 9;
            this.Manager_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.Manager_btn.TextX = 44F;
            this.Manager_btn.TextY = 43F;
            this.Manager_btn.Click += new System.EventHandler(this.Manager_btn_Click);
            // 
            // Admin_btn
            // 
            this.Admin_btn.Active = true;
            this.Admin_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.adminIcon_v2;
            this.Admin_btn.BorderWidth = 1;
            this.Admin_btn.ButtonRadius = 2;
            this.Admin_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.Admin_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.Admin_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.Admin_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.Admin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Admin_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.Admin_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.Admin_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.Admin_btn.HoverColorB = System.Drawing.Color.Orange;
            this.Admin_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.Admin_btn.ImageCornerX = 2;
            this.Admin_btn.ImageCornerY = 5;
            this.Admin_btn.Location = new System.Drawing.Point(30, 436);
            this.Admin_btn.Name = "Admin_btn";
            this.Admin_btn.NormalBorderColor = System.Drawing.Color.White;
            this.Admin_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(100)))));
            this.Admin_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(100)))));
            this.Admin_btn.Size = new System.Drawing.Size(89, 81);
            this.Admin_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.Admin_btn.TabIndex = 15;
            this.Admin_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.Admin_btn.TextX = 44F;
            this.Admin_btn.TextY = 40F;
            this.Admin_btn.Click += new System.EventHandler(this.Admin_btn_Click);
            // 
            // Reports_btn
            // 
            this.Reports_btn.Active = true;
            this.Reports_btn.AddImage = global::ShopHelper_v0._0.Properties.Resources.Reports_btn;
            this.Reports_btn.BorderWidth = 1;
            this.Reports_btn.ButtonRadius = 2;
            this.Reports_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.Reports_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.Reports_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.Reports_btn.ClickColorB = System.Drawing.Color.DarkGoldenrod;
            this.Reports_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Reports_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.Reports_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.Reports_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.Reports_btn.HoverColorB = System.Drawing.Color.Orange;
            this.Reports_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.Reports_btn.ImageCornerX = 1;
            this.Reports_btn.ImageCornerY = 1;
            this.Reports_btn.Location = new System.Drawing.Point(30, 305);
            this.Reports_btn.Name = "Reports_btn";
            this.Reports_btn.NormalBorderColor = System.Drawing.Color.White;
            this.Reports_btn.NormalColorA = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(100)))));
            this.Reports_btn.NormalColorB = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(97)))), ((int)(((byte)(100)))));
            this.Reports_btn.Size = new System.Drawing.Size(89, 81);
            this.Reports_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.Reports_btn.TabIndex = 10;
            this.Reports_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.Reports_btn.TextX = 44F;
            this.Reports_btn.TextY = 40F;
            this.Reports_btn.Click += new System.EventHandler(this.Reports_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(992, 716);
            this.Controls.Add(this.LastLoginDate_label);
            this.Controls.Add(this.roles_label);
            this.Controls.Add(this.NumberOfUsersOnline_label);
            this.Controls.Add(this.currentUsername_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainMenu_panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shop Helper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton POS_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton Manager_btn;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton Reports_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton Admin_btn;
        private System.Windows.Forms.GroupBox admin_groupBox;
        private System.Windows.Forms.Label currentUsername_label;
        private System.Windows.Forms.Label NumberOfUsersOnline_label;
        private System.Windows.Forms.Label roles_label;
        private System.Windows.Forms.Panel mainMenu_panel;
        private Label LastLoginDate_label;
       

    }
}

