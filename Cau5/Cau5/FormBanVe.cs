namespace Cau5
{
    public partial class FormBanVe : Form
    {
        private const int GiaVe = 75_000;

        public FormBanVe()
        {
            InitializeComponent();
        }

        private void FormBanVe_Load(object? sender, EventArgs e)
        {
            cboPhim.Items.AddRange(new object[]
            {
                "Chiến binh cuối cùng",
                "Avatar: Dòng chảy của nước",
                "Mai",
                "Lật Mặt 7: Một Điều Ước",
                "Dune: Hành tinh cát - Phần 2",
                "Kẻ Trộm Mặt Trăng 4"
            });
            cboPhim.SelectedIndex = 0;

            cboSuatChieu.Items.AddRange(new object[]
            {
                "09:00", "11:30", "14:15", "16:45", "19:00", "21:30"
            });
            cboSuatChieu.SelectedItem = "19:00";
        }

        private void btnChonGhe_Click(object? sender, EventArgs e)
        {
            using (FormChonGhe dlg = new(txtGheDaChon.Text))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhach.Text))
            {
                HienThiCanhBao("Vui lòng nhập tên khách hàng!");
                txtTenKhach.Focus();
                return;
            }

            if (cboPhim.SelectedIndex < 0)
            {
                HienThiCanhBao("Vui lòng chọn phim!");
                cboPhim.Focus();
                return;
            }

            if (cboSuatChieu.SelectedIndex < 0)
            {
                HienThiCanhBao("Vui lòng chọn suất chiếu!");
                cboSuatChieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGheDaChon.Text))
            {
                HienThiCanhBao("Vui lòng chọn ghế trước khi đặt vé!");
                btnChonGhe.Focus();
                return;
            }

            string thongTin =
                $"Tên khách: {txtTenKhach.Text.Trim()}\n" +
                $"Phim: {cboPhim.Text}\n" +
                $"Suất chiếu: {cboSuatChieu.Text}\n" +
                $"Ghế: {txtGheDaChon.Text}\n" +
                $"Giá vé: {GiaVe:N0}đ/vé";

            MessageBox.Show(thongTin, "Xác nhận đặt vé",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void HienThiCanhBao(string noiDung)
        {
            MessageBox.Show(noiDung, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnHuy_Click(object? sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = cboPhim.Items.Count > 0 ? 0 : -1;
            cboSuatChieu.SelectedItem = "19:00";
            txtGheDaChon.Clear();
            txtTenKhach.Focus();
        }
    }
}
