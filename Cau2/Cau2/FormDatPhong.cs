using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Cau2
{
    public partial class FormDatPhong : Form
    {
        public FormDatPhong()
        {
            InitializeComponent();
        }

        #region Xử lý sự kiện Validating

        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            // txtHoTen: không để trống
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống");
                txtHoTen.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
                txtHoTen.BackColor = Color.Honeydew;
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            // txtCCCD: đúng 12 chữ số
            string cccd = txtCCCD.Text.Trim();
            if (cccd.Length != 12 || !cccd.All(char.IsDigit))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCCCD, "Số CCCD phải gồm đúng 12 chữ số");
                txtCCCD.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtCCCD, "");
                txtCCCD.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            // txtNgayNhan: parse được "dd/MM/yyyy" và >= hôm nay
            if (!DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phòng không đúng định dạng dd/MM/yyyy");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayNhan, "Ngày nhận phòng phải từ ngày hôm nay trở đi");
                txtNgayNhan.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtNgayNhan, "");
                txtNgayNhan.BackColor = Color.Honeydew;
            }
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            // txtNgayTra: parse được "dd/MM/yyyy" và lớn hơn ngày nhận
            if (!DateTime.TryParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTra))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNgayTra, "Ngày trả phòng không đúng định dạng dd/MM/yyyy");
                txtNgayTra.BackColor = Color.MistyRose;
            }
            else
            {
                bool hasNgayNhan = DateTime.TryParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan);

                if (hasNgayNhan && ngayTra.Date <= ngayNhan.Date)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNgayTra, "Ngày trả phải sau ngày nhận");
                    txtNgayTra.BackColor = Color.MistyRose;
                }
                else if (!hasNgayNhan && ngayTra.Date <= DateTime.Today)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtNgayTra, "Ngày trả phải sau ngày nhận");
                    txtNgayTra.BackColor = Color.MistyRose;
                }
                else
                {
                    errorProvider1.SetError(txtNgayTra, "");
                    txtNgayTra.BackColor = Color.Honeydew;
                }
            }
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            // txtSoNguoiLon: là số nguyên 1–4
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out int soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4");
                txtSoNguoiLon.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoNguoiLon, "");
                txtSoNguoiLon.BackColor = Color.Honeydew;
            }
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            // txtSoTreEm: là số nguyên 0–3
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out int soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3");
                txtSoTreEm.BackColor = Color.MistyRose;
            }
            else
            {
                errorProvider1.SetError(txtSoTreEm, "");
                txtSoTreEm.BackColor = Color.Honeydew;
            }
        }

        #endregion

        #region Xử lý sự kiện Validated

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            txtHoTen.BackColor = Color.Honeydew;
        }

        private void txtCCCD_Validated(object sender, EventArgs e)
        {
            txtCCCD.BackColor = Color.Honeydew;
        }

        private void txtNgayNhan_Validated(object sender, EventArgs e)
        {
            txtNgayNhan.BackColor = Color.Honeydew;
        }

        private void txtNgayTra_Validated(object sender, EventArgs e)
        {
            txtNgayTra.BackColor = Color.Honeydew;
        }

        private void txtSoNguoiLon_Validated(object sender, EventArgs e)
        {
            txtSoNguoiLon.BackColor = Color.Honeydew;
        }

        private void txtSoTreEm_Validated(object sender, EventArgs e)
        {
            txtSoTreEm.BackColor = Color.Honeydew;
        }

        #endregion

        #region Xử lý sự kiện btnDatPhong_Click

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            // Kích hoạt xác thực toàn bộ form
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            // Tính số đêm = (ngày trả - ngày nhận).Days
            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int soDem = (ngayTra.Date - ngayNhan.Date).Days;

            string hoTen = txtHoTen.Text.Trim();
            int soNguoiLon = int.Parse(txtSoNguoiLon.Text.Trim());
            int soTreEm = int.Parse(txtSoTreEm.Text.Trim());

            // Hiện MessageBox thông tin đặt phòng thành công
            string thongTin = $"Đặt phòng thành công!\n\n" +
                              $"Họ tên khách: {hoTen}\n" +
                              $"Số đêm: {soDem} đêm\n" +
                              $"Số người lớn: {soNguoiLon}\n" +
                              $"Số trẻ em: {soTreEm}";

            MessageBox.Show(thongTin, "Thông tin đặt phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // Cho phép đóng form mà không bị chặn bởi validation
            AutoValidate = AutoValidate.Disable;
            base.OnFormClosing(e);
        }
    }
}
