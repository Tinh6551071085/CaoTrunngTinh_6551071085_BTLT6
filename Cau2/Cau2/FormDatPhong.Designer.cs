namespace Cau2
{
    partial class FormDatPhong
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
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblCCCD = new Label();
            txtCCCD = new TextBox();
            lblNgayNhan = new Label();
            txtNgayNhan = new TextBox();
            lblNgayTra = new Label();
            txtNgayTra = new TextBox();
            lblSoNguoiLon = new Label();
            txtSoNguoiLon = new TextBox();
            lblSoTreEm = new Label();
            txtSoTreEm = new TextBox();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.ForeColor = Color.FromArgb(40, 40, 40);
            lblHoTen.Location = new Point(60, 24);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(51, 19);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 10.5F);
            txtHoTen.Location = new Point(60, 48);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(350, 26);
            txtHoTen.TabIndex = 1;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += txtHoTen_Validated;
            // 
            // lblCCCD
            // 
            lblCCCD.AutoSize = true;
            lblCCCD.Font = new Font("Segoe UI", 10F);
            lblCCCD.ForeColor = Color.FromArgb(40, 40, 40);
            lblCCCD.Location = new Point(60, 88);
            lblCCCD.Name = "lblCCCD";
            lblCCCD.Size = new Size(62, 19);
            lblCCCD.TabIndex = 2;
            lblCCCD.Text = "Số CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.BorderStyle = BorderStyle.FixedSingle;
            txtCCCD.Font = new Font("Segoe UI", 10.5F);
            txtCCCD.Location = new Point(60, 112);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(350, 26);
            txtCCCD.TabIndex = 3;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += txtCCCD_Validated;
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.AutoSize = true;
            lblNgayNhan.Font = new Font("Segoe UI", 10F);
            lblNgayNhan.ForeColor = Color.FromArgb(40, 40, 40);
            lblNgayNhan.Location = new Point(60, 152);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(117, 19);
            lblNgayNhan.TabIndex = 4;
            lblNgayNhan.Text = "Ngày nhận phòng";
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.BorderStyle = BorderStyle.FixedSingle;
            txtNgayNhan.Font = new Font("Segoe UI", 10.5F);
            txtNgayNhan.Location = new Point(60, 176);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(350, 26);
            txtNgayNhan.TabIndex = 5;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += txtNgayNhan_Validated;
            // 
            // lblNgayTra
            // 
            lblNgayTra.AutoSize = true;
            lblNgayTra.Font = new Font("Segoe UI", 10F);
            lblNgayTra.ForeColor = Color.FromArgb(40, 40, 40);
            lblNgayTra.Location = new Point(60, 216);
            lblNgayTra.Name = "lblNgayTra";
            lblNgayTra.Size = new Size(103, 19);
            lblNgayTra.TabIndex = 6;
            lblNgayTra.Text = "Ngày trả phòng";
            // 
            // txtNgayTra
            // 
            txtNgayTra.BorderStyle = BorderStyle.FixedSingle;
            txtNgayTra.Font = new Font("Segoe UI", 10.5F);
            txtNgayTra.Location = new Point(60, 240);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(350, 26);
            txtNgayTra.TabIndex = 7;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += txtNgayTra_Validated;
            // 
            // lblSoNguoiLon
            // 
            lblSoNguoiLon.AutoSize = true;
            lblSoNguoiLon.Font = new Font("Segoe UI", 10F);
            lblSoNguoiLon.ForeColor = Color.FromArgb(40, 40, 40);
            lblSoNguoiLon.Location = new Point(60, 280);
            lblSoNguoiLon.Name = "lblSoNguoiLon";
            lblSoNguoiLon.Size = new Size(88, 19);
            lblSoNguoiLon.TabIndex = 8;
            lblSoNguoiLon.Text = "Số người lớn";
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.BorderStyle = BorderStyle.FixedSingle;
            txtSoNguoiLon.Font = new Font("Segoe UI", 10.5F);
            txtSoNguoiLon.Location = new Point(60, 304);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(350, 26);
            txtSoNguoiLon.TabIndex = 9;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += txtSoNguoiLon_Validated;
            // 
            // lblSoTreEm
            // 
            lblSoTreEm.AutoSize = true;
            lblSoTreEm.Font = new Font("Segoe UI", 10F);
            lblSoTreEm.ForeColor = Color.FromArgb(40, 40, 40);
            lblSoTreEm.Location = new Point(60, 344);
            lblSoTreEm.Name = "lblSoTreEm";
            lblSoTreEm.Size = new Size(66, 19);
            lblSoTreEm.TabIndex = 10;
            lblSoTreEm.Text = "Số trẻ em";
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.BorderStyle = BorderStyle.FixedSingle;
            txtSoTreEm.Font = new Font("Segoe UI", 10.5F);
            txtSoTreEm.Location = new Point(60, 368);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(350, 26);
            txtSoTreEm.TabIndex = 11;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += txtSoTreEm_Validated;
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.FromArgb(0, 114, 206);
            btnDatPhong.Cursor = Cursors.Hand;
            btnDatPhong.FlatAppearance.BorderSize = 0;
            btnDatPhong.FlatStyle = FlatStyle.Flat;
            btnDatPhong.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(60, 420);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(350, 38);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt Phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 247, 245);
            ClientSize = new Size(480, 490);
            Controls.Add(btnDatPhong);
            Controls.Add(txtSoTreEm);
            Controls.Add(lblSoTreEm);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(lblSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(lblNgayTra);
            Controls.Add(txtNgayNhan);
            Controls.Add(lblNgayNhan);
            Controls.Add(txtCCCD);
            Controls.Add(lblCCCD);
            Controls.Add(txtHoTen);
            Controls.Add(lblHoTen);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormDatPhong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt phòng khách sạn";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private TextBox txtHoTen;
        private Label lblCCCD;
        private TextBox txtCCCD;
        private Label lblNgayNhan;
        private TextBox txtNgayNhan;
        private Label lblNgayTra;
        private TextBox txtNgayTra;
        private Label lblSoNguoiLon;
        private TextBox txtSoNguoiLon;
        private Label lblSoTreEm;
        private TextBox txtSoTreEm;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
