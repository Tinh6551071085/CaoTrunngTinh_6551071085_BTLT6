namespace Cau5
{
    partial class FormChonGhe
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
            lstGhe = new ListBox();
            lblGheDaChon = new Label();
            btnXacNhan = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // lstGhe
            // 
            lstGhe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lstGhe.FormattingEnabled = true;
            lstGhe.ItemHeight = 28;
            lstGhe.Location = new Point(24, 20);
            lstGhe.MultiColumn = true;
            lstGhe.Name = "lstGhe";
            lstGhe.Size = new Size(255, 88);
            lstGhe.TabIndex = 0;
            lstGhe.SelectedIndexChanged += lstGhe_SelectedIndexChanged;
            // 
            // lblGheDaChon
            // 
            lblGheDaChon.AutoSize = true;
            lblGheDaChon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblGheDaChon.Location = new Point(24, 120);
            lblGheDaChon.Name = "lblGheDaChon";
            lblGheDaChon.Size = new Size(87, 23);
            lblGheDaChon.TabIndex = 1;
            lblGheDaChon.Text = "Đang chọn: ";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = SystemColors.ButtonFace;
            btnXacNhan.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnXacNhan.Location = new Point(78, 155);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(95, 34);
            btnXacNhan.TabIndex = 2;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = true;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.BackColor = SystemColors.ButtonFace;
            btnBoQua.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnBoQua.Location = new Point(184, 155);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(95, 34);
            btnBoQua.TabIndex = 3;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // FormChonGhe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnBoQua;
            ClientSize = new Size(304, 210);
            Controls.Add(btnBoQua);
            Controls.Add(btnXacNhan);
            Controls.Add(lblGheDaChon);
            Controls.Add(lstGhe);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormChonGhe";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chọn ghế";
            Load += FormChonGhe_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstGhe;
        private Label lblGheDaChon;
        private Button btnXacNhan;
        private Button btnBoQua;
    }
}
