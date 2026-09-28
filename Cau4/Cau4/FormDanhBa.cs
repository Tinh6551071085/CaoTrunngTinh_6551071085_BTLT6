namespace Cau4
{
    public partial class FormDanhBa : Form
    {
        // Biến theo dõi index của liên hệ đang được sửa
        private int _indexDangSua = -1;

        public FormDanhBa()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 2. btnThem_Click: kiểm tra txtTen, txtSDT không rỗng.
        /// Hợp lệ → thêm "[Ten] - [SDT]" vào lstLienHe, xóa TextBox, hiện MessageBox Information "Thêm thành công".
        /// Hoặc cập nhật liên hệ đang sửa nếu _indexDangSua != -1.
        /// </summary>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            // Kiểm tra không để trống
            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên và số điện thoại!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string item = $"{ten} - {sdt}";

            // Kiểm tra xem đang cập nhật hay thêm mới
            if (_indexDangSua >= 0 && _indexDangSua < lstLienHe.Items.Count)
            {
                lstLienHe.Items[_indexDangSua] = item;
                _indexDangSua = -1;
                btnThem.Text = "Thêm";
                txtTen.Clear();
                txtSDT.Clear();
                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                lstLienHe.Items.Add(item);
                txtTen.Clear();
                txtSDT.Clear();
                MessageBox.Show(
                    "Thêm thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 4. btnSua_Click: điền thông tin item đang chọn vào 2 TextBox để sửa;
        /// bấm lại btnThem để cập nhật (dùng biến _indexDangSua theo dõi index).
        /// </summary>
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;
            string selectedItem = lstLienHe.SelectedItem?.ToString() ?? "";

            // Tách chuỗi theo định dạng "[Ten] - [SDT]"
            int dashIndex = selectedItem.IndexOf(" - ");
            if (dashIndex >= 0)
            {
                txtTen.Text = selectedItem.Substring(0, dashIndex).Trim();
                txtSDT.Text = selectedItem.Substring(dashIndex + 3).Trim();
            }
            else
            {
                txtTen.Text = selectedItem.Trim();
                txtSDT.Text = "";
            }

            btnThem.Text = "Cập nhật";
            txtTen.Focus();
        }

        /// <summary>
        /// 3. btnXoa_Click: chưa chọn item → MessageBox Warning "Vui lòng chọn một liên hệ để xóa" (button OK).
        /// Đã chọn → MessageBox Question "Bạn có chắc muốn xóa liên hệ [Ten]? Thao tác này không thể hoàn tác!" (button YesNo).
        /// Yes → xóa khỏi ListBox + thông báo thành công.
        /// </summary>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = lstLienHe.SelectedItem?.ToString() ?? "";
            string ten = selectedItem;
            int dashIndex = selectedItem.IndexOf(" - ");
            if (dashIndex >= 0)
            {
                ten = selectedItem.Substring(0, dashIndex).Trim();
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa liên hệ {ten}?\nThao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int indexToDelete = lstLienHe.SelectedIndex;

                // Nếu đang sửa item này thì reset trạng thái sửa
                if (_indexDangSua == indexToDelete)
                {
                    _indexDangSua = -1;
                    btnThem.Text = "Thêm";
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                else if (_indexDangSua > indexToDelete)
                {
                    _indexDangSua--;
                }

                lstLienHe.Items.RemoveAt(indexToDelete);
                MessageBox.Show(
                    "Xóa thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Nút Thoát: gọi Close() để kích hoạt FormClosing
        /// </summary>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 5. FormClosing event: nếu txtTen hoặc txtSDT còn nội dung chưa lưu →
        /// MessageBox "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?" (YesNoCancel, Warning).
        /// Yes → thoát; No → xóa TextBox rồi thoát; Cancel → e.Cancel = true.
        /// </summary>
        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTen.Text.Trim()) || !string.IsNullOrEmpty(txtSDT.Text.Trim()))
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Yes → thoát: cho phép form đóng bình thường
                }
                else if (result == DialogResult.No)
                {
                    // No → xóa TextBox rồi thoát
                    txtTen.Clear();
                    txtSDT.Clear();
                }
                else // Cancel hoặc đóng hộp thoại
                {
                    // Cancel → e.Cancel = true: hủy đóng form
                    e.Cancel = true;
                }
            }
        }
    }
}
