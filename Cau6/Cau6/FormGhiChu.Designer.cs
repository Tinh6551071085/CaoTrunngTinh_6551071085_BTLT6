namespace Cau6
{
    partial class FormGhiChu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTieuDeForm = new Label();
            lblTieuDe = new Label();
            txtTieuDe = new TextBox();
            lblNoiDung = new Label();
            txtNoiDung = new TextBox();
            lblMucDoUuTien = new Label();
            cboMucDoUuTien = new ComboBox();
            btnLuuGhiChu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTieuDeForm
            // 
            lblTieuDeForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTieuDeForm.BackColor = Color.SteelBlue;
            lblTieuDeForm.Cursor = Cursors.Hand;
            lblTieuDeForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTieuDeForm.ForeColor = Color.White;
            lblTieuDeForm.Location = new Point(0, 0);
            lblTieuDeForm.Name = "lblTieuDeForm";
            lblTieuDeForm.Padding = new Padding(12, 0, 0, 0);
            lblTieuDeForm.Size = new Size(584, 42);
            lblTieuDeForm.TabIndex = 0;
            lblTieuDeForm.Text = "GHI CHÚ CÔNG VIỆC";
            lblTieuDeForm.TextAlign = ContentAlignment.MiddleLeft;
            lblTieuDeForm.MouseDoubleClick += lblTieuDeForm_MouseDoubleClick;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Location = new Point(20, 63);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(48, 15);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "Tiêu đề";
            // 
            // txtTieuDe
            // 
            txtTieuDe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTieuDe.Location = new Point(105, 59);
            txtTieuDe.Name = "txtTieuDe";
            txtTieuDe.Size = new Size(445, 23);
            txtTieuDe.TabIndex = 2;
            txtTieuDe.Validating += txtTieuDe_Validating;
            txtTieuDe.Validated += txtTieuDe_Validated;
            // 
            // lblNoiDung
            // 
            lblNoiDung.AutoSize = true;
            lblNoiDung.Location = new Point(20, 102);
            lblNoiDung.Name = "lblNoiDung";
            lblNoiDung.Size = new Size(58, 15);
            lblNoiDung.TabIndex = 3;
            lblNoiDung.Text = "Nội dung";
            // 
            // txtNoiDung
            // 
            txtNoiDung.AcceptsReturn = true;
            txtNoiDung.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNoiDung.Location = new Point(20, 124);
            txtNoiDung.MaxLength = 500;
            txtNoiDung.Multiline = true;
            txtNoiDung.Name = "txtNoiDung";
            txtNoiDung.ScrollBars = ScrollBars.Vertical;
            txtNoiDung.Size = new Size(530, 236);
            txtNoiDung.TabIndex = 4;
            txtNoiDung.KeyPress += txtNoiDung_KeyPress;
            // 
            // lblMucDoUuTien
            // 
            lblMucDoUuTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMucDoUuTien.AutoSize = true;
            lblMucDoUuTien.Location = new Point(20, 383);
            lblMucDoUuTien.Name = "lblMucDoUuTien";
            lblMucDoUuTien.Size = new Size(89, 15);
            lblMucDoUuTien.TabIndex = 5;
            lblMucDoUuTien.Text = "Mức độ ưu tiên";
            // 
            // cboMucDoUuTien
            // 
            cboMucDoUuTien.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cboMucDoUuTien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMucDoUuTien.FormattingEnabled = true;
            cboMucDoUuTien.Items.AddRange(new object[] { "Thấp", "Trung bình", "Cao" });
            cboMucDoUuTien.Location = new Point(20, 404);
            cboMucDoUuTien.Name = "cboMucDoUuTien";
            cboMucDoUuTien.Size = new Size(160, 23);
            cboMucDoUuTien.TabIndex = 6;
            // 
            // btnLuuGhiChu
            // 
            btnLuuGhiChu.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLuuGhiChu.CausesValidation = false;
            btnLuuGhiChu.Location = new Point(430, 395);
            btnLuuGhiChu.Name = "btnLuuGhiChu";
            btnLuuGhiChu.Size = new Size(120, 36);
            btnLuuGhiChu.TabIndex = 7;
            btnLuuGhiChu.Text = "Lưu ghi chú";
            btnLuuGhiChu.UseVisualStyleBackColor = false;
            btnLuuGhiChu.Click += btnLuuGhiChu_Click;
            btnLuuGhiChu.MouseEnter += btnLuuGhiChu_MouseEnter;
            btnLuuGhiChu.MouseLeave += btnLuuGhiChu_MouseLeave;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormGhiChu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 451);
            Controls.Add(btnLuuGhiChu);
            Controls.Add(cboMucDoUuTien);
            Controls.Add(lblMucDoUuTien);
            Controls.Add(txtNoiDung);
            Controls.Add(lblNoiDung);
            Controls.Add(txtTieuDe);
            Controls.Add(lblTieuDe);
            Controls.Add(lblTieuDeForm);
            KeyPreview = true;
            MinimumSize = new Size(460, 360);
            Name = "FormGhiChu";
            StartPosition = FormStartPosition.Manual;
            Text = "Ghi chú mới";
            KeyDown += FormGhiChu_KeyDown;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTieuDeForm;
        private Label lblTieuDe;
        private TextBox txtTieuDe;
        private Label lblNoiDung;
        private TextBox txtNoiDung;
        private Label lblMucDoUuTien;
        private ComboBox cboMucDoUuTien;
        private Button btnLuuGhiChu;
        private ErrorProvider errorProvider1;
    }
}
