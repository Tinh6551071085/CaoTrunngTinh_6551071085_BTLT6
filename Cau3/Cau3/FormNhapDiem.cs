namespace Cau3
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();

            // Yêu cầu 2: Gọi hàm DangKyEnterChuyenField() trong constructor
            DangKyEnterChuyenField();

            // Yêu cầu 3: Xử lý sự kiện Enter (nhận focus) cho txtToan, txtVan, txtAnh
            txtToan.Enter += TxtDiem_Enter;
            txtVan.Enter += TxtDiem_Enter;
            txtAnh.Enter += TxtDiem_Enter;
        }

        /// <summary>
        /// Yêu cầu 2: Duyệt tất cả TextBox trên form, đăng ký KeyPress.
        /// Nếu KeyChar == Enter thì e.Handled = true và gọi SelectNextControl((Control)sender, true, true, true, true).
        /// Riêng txtAnh khi Enter -> gọi btnLuu.PerformClick().
        /// </summary>
        private void DangKyEnterChuyenField()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox txt)
                {
                    txt.KeyPress += (sender, e) =>
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            e.Handled = true;
                            if (txt == txtAnh)
                            {
                                btnLuu.PerformClick();
                            }
                            else
                            {
                                SelectNextControl((Control)sender!, true, true, true, true);
                            }
                        }
                    };
                }
            }
        }

        /// <summary>
        /// Yêu cầu 3: Xử lý sự kiện Enter (nhận focus) cho txtToan, txtVan, txtAnh:
        /// Gọi SelectAll() để bôi xanh toàn bộ nội dung cũ, giúp gõ đè không cần xóa tay.
        /// </summary>
        private void TxtDiem_Enter(object? sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                txt.SelectAll();
            }
        }

        /// <summary>
        /// Yêu cầu 4: btnLuu_Click: kiểm tra 3 điểm số từ 0.0–10.0 (decimal.TryParse).
        /// Hợp lệ -> thêm dòng vào ListBox "[MaHS] | [HoTen] | T:[Toan] V:[Van] A:[Anh]",
        /// xóa trắng form, focus về txtMaHS.
        /// Không hợp lệ -> hiện ErrorProvider.
        /// </summary>
        private void btnLuu_Click(object? sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;
            TextBox? firstErrorBox = null;

            // Kiểm tra Mã học sinh
            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Vui lòng nhập Mã học sinh!");
                hopLe = false;
                firstErrorBox ??= txtMaHS;
            }

            // Kiểm tra Họ tên
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Vui lòng nhập Họ tên!");
                hopLe = false;
                firstErrorBox ??= txtHoTen;
            }

            // Kiểm tra Điểm Toán
            if (!KiemTraDiem(txtToan, "Điểm Toán", out string toanText))
            {
                hopLe = false;
                firstErrorBox ??= txtToan;
            }

            // Kiểm tra Điểm Văn
            if (!KiemTraDiem(txtVan, "Điểm Văn", out string vanText))
            {
                hopLe = false;
                firstErrorBox ??= txtVan;
            }

            // Kiểm tra Điểm Anh
            if (!KiemTraDiem(txtAnh, "Điểm Anh", out string anhText))
            {
                hopLe = false;
                firstErrorBox ??= txtAnh;
            }

            if (!hopLe)
            {
                firstErrorBox?.Focus();
                return;
            }

            // Thêm dòng vào ListBox định dạng: [MaHS] | [HoTen] | T:[Toan] V:[Van] A:[Anh]
            string dongDuLieu = $"{txtMaHS.Text.Trim()} | {txtHoTen.Text.Trim()} | T:{toanText} V:{vanText} A:{anhText}";
            lstDanhSach.Items.Add(dongDuLieu);

            // Xóa trắng form và đưa con trỏ về txtMaHS
            XoaTrangForm();
        }

        /// <summary>
        /// Hàm kiểm tra điểm từ 0.0 đến 10.0 bằng decimal.TryParse
        /// </summary>
        private bool KiemTraDiem(TextBox txt, string tenMon, out string diemNormalized)
        {
            diemNormalized = string.Empty;
            string text = txt.Text.Trim().Replace(',', '.');

            if (decimal.TryParse(text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal diem))
            {
                if (diem >= 0.0m && diem <= 10.0m)
                {
                    errorProvider1.SetError(txt, string.Empty);
                    diemNormalized = text;
                    return true;
                }
            }

            errorProvider1.SetError(txt, $"{tenMon} phải là số từ 0.0 đến 10.0!");
            return false;
        }

        /// <summary>
        /// Xóa trắng các TextBox, xóa lỗi errorProvider và focus vào txtMaHS
        /// </summary>
        private void XoaTrangForm()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
            txtMaHS.Focus();
        }

        /// <summary>
        /// Sự kiện nút Xóa Trắng
        /// </summary>
        private void btnXoaTrang_Click(object? sender, EventArgs e)
        {
            XoaTrangForm();
        }
    }
}
