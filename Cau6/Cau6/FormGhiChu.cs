using System.ComponentModel;

namespace Cau6
{
    public partial class FormGhiChu : Form
    {
        private bool noiDungDaThayDoi;

        public FormGhiChu()
        {
            InitializeComponent();
            cboMucDoUuTien.SelectedIndex = 1;

            txtTieuDe.TextChanged += DuLieu_TextChanged;
            txtNoiDung.TextChanged += DuLieu_TextChanged;
            cboMucDoUuTien.SelectedIndexChanged += DuLieu_TextChanged;
            noiDungDaThayDoi = false;
        }

        private void DuLieu_TextChanged(object? sender, EventArgs e)
        {
            noiDungDaThayDoi = true;
        }

        private void FormGhiChu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                btnLuuGhiChu.PerformClick();
                return;
            }

            if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                DongBangPhimEscape();
            }
        }

        private void DongBangPhimEscape()
        {
            if (!noiDungDaThayDoi)
            {
                Close();
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Ghi chú đã thay đổi nhưng chưa được lưu. Bạn có chắc muốn đóng không?",
                "Xác nhận đóng ghi chú",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                Close();
            }
        }

        private void txtNoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            int doDaiSauKhiNhap = txtNoiDung.TextLength - txtNoiDung.SelectionLength + 1;
            if (doDaiSauKhiNhap > 500)
            {
                e.Handled = true;
            }
        }

        private void lblTieuDeForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = WindowState == FormWindowState.Maximized
                ? FormWindowState.Normal
                : FormWindowState.Maximized;
        }

        private void btnLuuGhiChu_MouseEnter(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = Color.LightGreen;
        }

        private void btnLuuGhiChu_MouseLeave(object sender, EventArgs e)
        {
            btnLuuGhiChu.BackColor = SystemColors.Control;
        }

        private void txtTieuDe_Validating(object sender, CancelEventArgs e)
        {
            string tieuDe = txtTieuDe.Text.Trim();
            string thongBaoLoi = string.Empty;

            if (string.IsNullOrWhiteSpace(tieuDe))
            {
                thongBaoLoi = "Tiêu đề không được để trống.";
            }
            else if (tieuDe.Length > 50)
            {
                thongBaoLoi = "Tiêu đề không được vượt quá 50 ký tự.";
            }

            if (!string.IsNullOrEmpty(thongBaoLoi))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtTieuDe, thongBaoLoi);
                txtTieuDe.BackColor = Color.MistyRose;
            }
        }

        private void txtTieuDe_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTieuDe, string.Empty);
            txtTieuDe.BackColor = Color.White;
        }

        private void btnLuuGhiChu_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            txtTieuDe.Text = txtTieuDe.Text.Trim();
            Text = txtTieuDe.Text;
            noiDungDaThayDoi = false;

            MessageBox.Show(
                "Đã lưu ghi chú",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
