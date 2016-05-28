namespace ShopHelper_v0._0
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.username_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.login_btn = new Anyo.WindowsForms.Controls.Buttons.GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.invalidLogin_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(253, 164);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(151, 20);
            this.username_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(253, 204);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(151, 20);
            this.password_txt.TabIndex = 1;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(173, 165);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(74, 16);
            this.username_label.TabIndex = 2;
            this.username_label.Text = "Username:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(176, 207);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(71, 16);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "Password:";
            // 
            // login_btn
            // 
            this.login_btn.Active = true;
            this.login_btn.BorderWidth = 1;
            this.login_btn.ButtonRadius = 2;
            this.login_btn.ButtonStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.ButtonStyles.RoundedEdgesRectangel;
            this.login_btn.ClickBorderColor = System.Drawing.Color.Cornsilk;
            this.login_btn.ClickColorA = System.Drawing.Color.DarkOrange;
            this.login_btn.ClickColorB = System.Drawing.Color.Orange;
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.login_btn.GradientStyle = Anyo.WindowsForms.Controls.Buttons.GradientButton.GradientStyles.Vertical;
            this.login_btn.HoverBorderColor = System.Drawing.Color.Linen;
            this.login_btn.HoverColorA = System.Drawing.Color.PeachPuff;
            this.login_btn.HoverColorB = System.Drawing.Color.Orange;
            this.login_btn.ImageAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.None;
            this.login_btn.ImageCornerX = 0;
            this.login_btn.ImageCornerY = 0;
            this.login_btn.Location = new System.Drawing.Point(240, 245);
            this.login_btn.Name = "login_btn";
            this.login_btn.NormalBorderColor = System.Drawing.Color.Black;
            this.login_btn.NormalColorA = System.Drawing.Color.Orange;
            this.login_btn.NormalColorB = System.Drawing.Color.PeachPuff;
            this.login_btn.Size = new System.Drawing.Size(100, 25);
            this.login_btn.SmoothingQuality = Anyo.WindowsForms.Controls.Buttons.GradientButton.SmoothingQualities.AntiAlias;
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Login";
            this.login_btn.TextAlignment = Anyo.WindowsForms.Controls.Buttons.GradientButton.Alignment.Center;
            this.login_btn.TextX = 34.27433F;
            this.login_btn.TextY = 5.087402F;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShopHelper_v0._0.Properties.Resources.HeaderLogo_OneLine;
            this.pictureBox1.Location = new System.Drawing.Point(163, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // invalidLogin_label
            // 
            this.invalidLogin_label.AutoSize = true;
            this.invalidLogin_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invalidLogin_label.ForeColor = System.Drawing.Color.White;
            this.invalidLogin_label.Location = new System.Drawing.Point(180, 297);
            this.invalidLogin_label.Name = "invalidLogin_label";
            this.invalidLogin_label.Size = new System.Drawing.Size(0, 16);
            this.invalidLogin_label.TabIndex = 14;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(584, 373);
            this.Controls.Add(this.invalidLogin_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private Anyo.WindowsForms.Controls.Buttons.GradientButton login_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label invalidLogin_label;
    }
}