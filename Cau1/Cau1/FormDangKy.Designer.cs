namespace Cau1
{
    partial class FormDangKy
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblSubTitle = new Label();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblMatKhau = new Label();
            txtMatKhau = new TextBox();
            lblXacNhanMK = new Label();
            txtXacNhanMK = new TextBox();
            btnDangKy = new Button();
            btnHuy = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(22, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(230, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Đăng ký tài khoản mới";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubTitle.ForeColor = Color.FromArgb(60, 60, 60);
            lblSubTitle.Location = new Point(24, 48);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(168, 15);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Vui lòng nhập đầy đủ thông tin";
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHoTen.Location = new Point(12, 85);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(130, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên";
            lblHoTen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHoTen.Location = new Point(148, 85);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(180, 24);
            txtHoTen.TabIndex = 3;
            // 
            // lblSDT
            // 
            lblSDT.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.Location = new Point(12, 122);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(130, 23);
            lblSDT.TabIndex = 4;
            lblSDT.Text = "Số điện thoại";
            lblSDT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(148, 122);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(180, 24);
            txtSDT.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(12, 159);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(130, 23);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(148, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 24);
            txtEmail.TabIndex = 7;
            // 
            // lblMatKhau
            // 
            lblMatKhau.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMatKhau.Location = new Point(12, 196);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(130, 23);
            lblMatKhau.TabIndex = 8;
            lblMatKhau.Text = "Mật khẩu";
            lblMatKhau.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.Location = new Point(148, 196);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.Size = new Size(180, 24);
            txtMatKhau.TabIndex = 9;
            // 
            // lblXacNhanMK
            // 
            lblXacNhanMK.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblXacNhanMK.Location = new Point(12, 233);
            lblXacNhanMK.Name = "lblXacNhanMK";
            lblXacNhanMK.Size = new Size(130, 23);
            lblXacNhanMK.TabIndex = 10;
            lblXacNhanMK.Text = "Xác nhận mật khẩu";
            lblXacNhanMK.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtXacNhanMK.Location = new Point(148, 233);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.PasswordChar = '*';
            txtXacNhanMK.UseSystemPasswordChar = true;
            txtXacNhanMK.Size = new Size(180, 24);
            txtXacNhanMK.TabIndex = 11;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.FromArgb(0, 114, 206);
            btnDangKy.Cursor = Cursors.Hand;
            btnDangKy.FlatAppearance.BorderSize = 0;
            btnDangKy.FlatStyle = FlatStyle.Flat;
            btnDangKy.Font = new Font("Segoe UI", 9.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(148, 280);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(95, 32);
            btnDangKy.TabIndex = 12;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(204, 204, 204);
            btnHuy.CausesValidation = false;
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.FlatAppearance.BorderColor = Color.FromArgb(170, 170, 170);
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 9.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.Black;
            btnHuy.Location = new Point(253, 280);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 32);
            btnHuy.TabIndex = 13;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            btnHuy.Click += btnHuy_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(390, 335);
            Controls.Add(btnHuy);
            Controls.Add(btnDangKy);
            Controls.Add(txtXacNhanMK);
            Controls.Add(lblXacNhanMK);
            Controls.Add(txtMatKhau);
            Controls.Add(lblMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(lblSubTitle);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký tài khoản";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubTitle;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblMatKhau;
        private TextBox txtMatKhau;
        private Label lblXacNhanMK;
        private TextBox txtXacNhanMK;
        private Button btnDangKy;
        private Button btnHuy;
        private ErrorProvider errorProvider1;
    }
}
