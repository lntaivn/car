namespace car
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_dangNhap = new Guna.UI.WinForms.GunaButton();
            this.btnOut = new System.Windows.Forms.Button();
            this.tb_tenDangNhap = new Guna.UI.WinForms.GunaLineTextBox();
            this.tb_matKhau = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 650);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(226, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ô TÔ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaCirclePictureBox1.Image")));
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(118, 268);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(279, 205);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 0;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(702, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(583, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(584, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên đăng nhập";
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.AnimationHoverSpeed = 0.07F;
            this.btn_dangNhap.AnimationSpeed = 0.03F;
            this.btn_dangNhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_dangNhap.BaseColor = System.Drawing.Color.Crimson;
            this.btn_dangNhap.BorderColor = System.Drawing.Color.Black;
            this.btn_dangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.btn_dangNhap.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangNhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangNhap.Image = null;
            this.btn_dangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_dangNhap.Location = new System.Drawing.Point(589, 442);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_dangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_dangNhap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_dangNhap.OnHoverImage = null;
            this.btn_dangNhap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_dangNhap.Size = new System.Drawing.Size(200, 50);
            this.btn_dangNhap.TabIndex = 2;
            this.btn_dangNhap.Text = "ĐĂNG NHẬP";
            this.btn_dangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            this.btn_dangNhap.Enter += new System.EventHandler(this.login_Load);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.Color.Crimson;
            this.btnOut.FlatAppearance.BorderSize = 0;
            this.btnOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOut.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.ForeColor = System.Drawing.Color.White;
            this.btnOut.Location = new System.Drawing.Point(1006, 0);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(45, 45);
            this.btnOut.TabIndex = 5;
            this.btnOut.Text = "X";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // tb_tenDangNhap
            // 
            this.tb_tenDangNhap.BackColor = System.Drawing.Color.White;
            this.tb_tenDangNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_tenDangNhap.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_tenDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_tenDangNhap.LineColor = System.Drawing.Color.Crimson;
            this.tb_tenDangNhap.LineSize = 2;
            this.tb_tenDangNhap.Location = new System.Drawing.Point(588, 233);
            this.tb_tenDangNhap.Margin = new System.Windows.Forms.Padding(0);
            this.tb_tenDangNhap.Name = "tb_tenDangNhap";
            this.tb_tenDangNhap.PasswordChar = '\0';
            this.tb_tenDangNhap.SelectedText = "";
            this.tb_tenDangNhap.Size = new System.Drawing.Size(385, 50);
            this.tb_tenDangNhap.TabIndex = 7;
            // 
            // tb_matKhau
            // 
            this.tb_matKhau.Animated = true;
            this.tb_matKhau.BackColor = System.Drawing.Color.White;
            this.tb_matKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_matKhau.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tb_matKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_matKhau.LineColor = System.Drawing.Color.Crimson;
            this.tb_matKhau.LineSize = 2;
            this.tb_matKhau.Location = new System.Drawing.Point(588, 358);
            this.tb_matKhau.Name = "tb_matKhau";
            this.tb_matKhau.PasswordChar = '*';
            this.tb_matKhau.SelectedText = "";
            this.tb_matKhau.Size = new System.Drawing.Size(385, 50);
            this.tb_matKhau.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(194, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 46);
            this.label5.TabIndex = 1;
            this.label5.Text = "TAIKA";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.tb_matKhau);
            this.Controls.Add(this.tb_tenDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.Enter += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btn_dangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOut;
        private Guna.UI.WinForms.GunaLineTextBox tb_tenDangNhap;
        private Guna.UI.WinForms.GunaLineTextBox tb_matKhau;
        private System.Windows.Forms.Label label5;
    }
}