namespace Cau3
{
    partial class FormNhapDiem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMaHS = new Label();
            txtMaHS = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblToan = new Label();
            txtToan = new TextBox();
            lblVan = new Label();
            txtVan = new TextBox();
            lblAnh = new Label();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            lstDanhSach = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMaHS
            // 
            lblMaHS.AutoSize = true;
            lblMaHS.Font = new Font("Segoe UI", 11F);
            lblMaHS.Location = new Point(24, 20);
            lblMaHS.Name = "lblMaHS";
            lblMaHS.Size = new Size(54, 20);
            lblMaHS.TabIndex = 10;
            lblMaHS.TabStop = false;
            lblMaHS.Text = "Mã HS";
            // 
            // txtMaHS
            // 
            txtMaHS.Font = new Font("Segoe UI", 11F);
            txtMaHS.Location = new Point(24, 45);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(130, 27);
            txtMaHS.TabIndex = 0;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 11F);
            lblHoTen.Location = new Point(174, 20);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 20);
            lblHoTen.TabIndex = 11;
            lblHoTen.TabStop = false;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 11F);
            txtHoTen.Location = new Point(174, 45);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(140, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblToan
            // 
            lblToan.AutoSize = true;
            lblToan.Font = new Font("Segoe UI", 11F);
            lblToan.Location = new Point(334, 20);
            lblToan.Name = "lblToan";
            lblToan.Size = new Size(79, 20);
            lblToan.TabIndex = 12;
            lblToan.TabStop = false;
            lblToan.Text = "Điểm Toán";
            // 
            // txtToan
            // 
            txtToan.Font = new Font("Segoe UI", 11F);
            txtToan.Location = new Point(334, 45);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(110, 27);
            txtToan.TabIndex = 2;
            // 
            // lblVan
            // 
            lblVan.AutoSize = true;
            lblVan.Font = new Font("Segoe UI", 11F);
            lblVan.Location = new Point(464, 20);
            lblVan.Name = "lblVan";
            lblVan.Size = new Size(71, 20);
            lblVan.TabIndex = 13;
            lblVan.TabStop = false;
            lblVan.Text = "Điểm Văn";
            // 
            // txtVan
            // 
            txtVan.Font = new Font("Segoe UI", 11F);
            txtVan.Location = new Point(464, 45);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(110, 27);
            txtVan.TabIndex = 3;
            // 
            // lblAnh
            // 
            lblAnh.AutoSize = true;
            lblAnh.Font = new Font("Segoe UI", 11F);
            lblAnh.Location = new Point(594, 20);
            lblAnh.Name = "lblAnh";
            lblAnh.Size = new Size(73, 20);
            lblAnh.TabIndex = 14;
            lblAnh.TabStop = false;
            lblAnh.Text = "Điểm Anh";
            // 
            // txtAnh
            // 
            txtAnh.Font = new Font("Segoe UI", 11F);
            txtAnh.Location = new Point(594, 45);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(110, 27);
            txtAnh.TabIndex = 4;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(76, 175, 80);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.FlatAppearance.BorderColor = Color.FromArgb(56, 142, 60);
            btnLuu.FlatAppearance.MouseOverBackColor = Color.FromArgb(102, 187, 106);
            btnLuu.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 125, 50);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuu.ForeColor = Color.Black;
            btnLuu.Location = new Point(24, 88);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 36);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = Color.FromArgb(220, 224, 230);
            btnXoaTrang.Cursor = Cursors.Hand;
            btnXoaTrang.FlatAppearance.BorderColor = Color.FromArgb(180, 185, 190);
            btnXoaTrang.FlatAppearance.MouseOverBackColor = Color.FromArgb(205, 210, 215);
            btnXoaTrang.FlatAppearance.MouseDownBackColor = Color.FromArgb(170, 175, 180);
            btnXoaTrang.FlatStyle = FlatStyle.Flat;
            btnXoaTrang.Font = new Font("Segoe UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoaTrang.ForeColor = Color.Black;
            btnXoaTrang.Location = new Point(144, 88);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(125, 36);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa Trắng";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstDanhSach
            // 
            lstDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstDanhSach.Font = new Font("Segoe UI", 11F);
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.ItemHeight = 20;
            lstDanhSach.Location = new Point(24, 140);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(680, 204);
            lstDanhSach.TabIndex = 7;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 371);
            Controls.Add(lstDanhSach);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(lblAnh);
            Controls.Add(txtVan);
            Controls.Add(lblVan);
            Controls.Add(txtToan);
            Controls.Add(lblToan);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            Controls.Add(txtMaHS);
            Controls.Add(lblMaHS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormNhapDiem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhập điểm học sinh";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaHS;
        private TextBox txtMaHS;
        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblToan;
        private TextBox txtToan;
        private Label lblVan;
        private TextBox txtVan;
        private Label lblAnh;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private ListBox lstDanhSach;
        private ErrorProvider errorProvider1;
    }
}
