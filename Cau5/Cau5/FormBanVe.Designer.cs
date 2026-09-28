namespace Cau5
{
    partial class FormBanVe
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
            lblTenKhach = new Label();
            txtTenKhach = new TextBox();
            lblPhim = new Label();
            cboPhim = new ComboBox();
            lblSuatChieu = new Label();
            cboSuatChieu = new ComboBox();
            lblGheDaChon = new Label();
            txtGheDaChon = new TextBox();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblTenKhach
            // 
            lblTenKhach.AutoSize = true;
            lblTenKhach.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTenKhach.Location = new Point(32, 20);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(93, 23);
            lblTenKhach.TabIndex = 0;
            lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhach
            // 
            txtTenKhach.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenKhach.Location = new Point(32, 48);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(420, 31);
            txtTenKhach.TabIndex = 1;
            // 
            // lblPhim
            // 
            lblPhim.AutoSize = true;
            lblPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhim.Location = new Point(32, 92);
            lblPhim.Name = "lblPhim";
            lblPhim.Size = new Size(53, 23);
            lblPhim.TabIndex = 2;
            lblPhim.Text = "Phim:";
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(32, 120);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(420, 29);
            cboPhim.TabIndex = 3;
            // 
            // lblSuatChieu
            // 
            lblSuatChieu.AutoSize = true;
            lblSuatChieu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSuatChieu.Location = new Point(32, 164);
            lblSuatChieu.Name = "lblSuatChieu";
            lblSuatChieu.Size = new Size(95, 23);
            lblSuatChieu.TabIndex = 4;
            lblSuatChieu.Text = "Suất chiếu:";
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSuatChieu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Location = new Point(32, 192);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(420, 29);
            cboSuatChieu.TabIndex = 5;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGheDaChon.Location = new Point(32, 236);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(111, 23);
            lblGheDaChon.TabIndex = 6;
            lblGheDaChon.Text = "Ghế đã chọn:";
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.BackColor = Color.White;
            txtGheDaChon.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtGheDaChon.Location = new Point(32, 264);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.Size = new Size(420, 31);
            txtGheDaChon.TabIndex = 7;
            // 
            // btnChonGhe
            // 
            btnChonGhe.BackColor = SystemColors.ButtonFace;
            btnChonGhe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnChonGhe.Location = new Point(78, 318);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(105, 36);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.BackColor = SystemColors.ButtonFace;
            btnDatVe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnDatVe.Location = new Point(190, 318);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(105, 36);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = SystemColors.ButtonFace;
            btnHuy.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHuy.Location = new Point(302, 318);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(105, 36);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 376);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(txtGheDaChon);
            Controls.Add(lblGheDaChon);
            Controls.Add(cboSuatChieu);
            Controls.Add(lblSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(lblPhim);
            Controls.Add(txtTenKhach);
            Controls.Add(lblTenKhach);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBanVe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bán vé xem phim";
            Load += FormBanVe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenKhach;
        private TextBox txtTenKhach;
        private Label lblPhim;
        private ComboBox cboPhim;
        private Label lblSuatChieu;
        private ComboBox cboSuatChieu;
        private Label lblGheDaChon;
        private TextBox txtGheDaChon;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
