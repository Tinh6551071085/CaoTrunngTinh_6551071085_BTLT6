namespace Cau4
{
    partial class FormDanhBa
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
            lstLienHe = new ListBox();
            lblTen = new Label();
            txtTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstLienHe.FormattingEnabled = true;
            lstLienHe.ItemHeight = 23;
            lstLienHe.Location = new Point(16, 20);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(330, 372);
            lstLienHe.TabIndex = 0;
            // 
            // lblTen
            // 
            lblTen.AutoSize = true;
            lblTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTen.Location = new Point(366, 20);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(36, 23);
            lblTen.TabIndex = 1;
            lblTen.Text = "Tên";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(366, 48);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(270, 30);
            txtTen.TabIndex = 2;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSDT.Location = new Point(366, 92);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(111, 23);
            lblSDT.TabIndex = 3;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(366, 120);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(270, 30);
            txtSDT.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(516, 175);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 35);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSua.Location = new Point(516, 225);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 35);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(516, 275);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 35);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.Location = new Point(516, 355);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 35);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 415);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtTen);
            Controls.Add(lblTen);
            Controls.Add(lstLienHe);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDanhBa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh bạ";
            FormClosing += FormDanhBa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLienHe;
        private Label lblTen;
        private TextBox txtTen;
        private Label lblSDT;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}
