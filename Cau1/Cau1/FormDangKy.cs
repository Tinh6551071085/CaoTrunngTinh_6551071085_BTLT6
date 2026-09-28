using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cau1
{
    public partial class FormDangKy : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool DestroyIcon(IntPtr handle);

        private Icon? _customErrorIcon;
        private IntPtr _hIcon = IntPtr.Zero;

        public FormDangKy()
        {
            InitializeComponent();
            KhoiTaoGiaoDienLoi();
        }

        /// <summary>
        /// Cấu hình icon dấu chấm than đỏ (!) và khoảng cách icon giống 100% ảnh mẫu
        /// </summary>
        private void KhoiTaoGiaoDienLoi()
        {
            // Tạo icon tròn đỏ 3D có dấu chấm than ! màu trắng bên trong
            _customErrorIcon = TaoIconChamThanDo();
            if (_customErrorIcon != null)
            {
                errorProvider1.Icon = _customErrorIcon;
            }

            // Tắt nháy liên tục để icon xuất hiện ngay lập tức
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            // Đặt khoảng cách icon cách TextBox 6px như ảnh mẫu
            errorProvider1.SetIconPadding(txtHoTen, 6);
            errorProvider1.SetIconPadding(txtSDT, 6);
            errorProvider1.SetIconPadding(txtEmail, 6);
            errorProvider1.SetIconPadding(txtMatKhau, 6);
            errorProvider1.SetIconPadding(txtXacNhanMK, 6);
        }

        /// <summary>
        /// Vẽ icon hình tròn đỏ bóng 3D với dấu chấm than (!) màu trắng ở giữa
        /// </summary>
        private Icon TaoIconChamThanDo()
        {
            using Bitmap bmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

                // 1. Vẽ nền tròn đỏ có chuyển sắc 3D nổi bóng
                using (var path = new GraphicsPath())
                {
                    path.AddEllipse(0.5f, 0.5f, 15f, 15f);
                    using (var pbr = new PathGradientBrush(path))
                    {
                        pbr.CenterColor = Color.FromArgb(255, 90, 90);
                        pbr.SurroundColors = new Color[] { Color.FromArgb(195, 20, 20) };
                        g.FillPath(pbr, path);
                    }
                }

                // 2. Viền đỏ sẫm xung quanh
                using (Pen pen = new Pen(Color.FromArgb(160, 10, 10), 1f))
                {
                    g.DrawEllipse(pen, 0.5f, 0.5f, 14.5f, 14.5f);
                }

                // 3. Vẽ dấu chấm than ! màu trắng ở chính giữa
                using (Font font = new Font("Arial", 10.5f, FontStyle.Bold, GraphicsUnit.Pixel))
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center,
                        LineAlignment = StringAlignment.Center
                    };
                    g.DrawString("!", font, textBrush, new RectangleF(0.5f, 0.5f, 15f, 15f), sf);
                }
            }

            _hIcon = bmp.GetHicon();
            return Icon.FromHandle(_hIcon);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (_hIcon != IntPtr.Zero)
            {
                DestroyIcon(_hIcon);
                _hIcon = IntPtr.Zero;
            }
            _customErrorIcon?.Dispose();
        }

        /// <summary>
        /// Hàm kiểm tra tính hợp lệ của toàn bộ thông tin đăng ký
        /// </summary>
        /// <returns>True nếu tất cả hợp lệ, ngược lại False</returns>
        private bool KiemTraHopLe()
        {
            bool hopLe = true;

            // 1. Kiểm tra txtHoTen: không để trống và tối thiểu 3 ký tự
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống");
                hopLe = false;
            }
            else if (hoTen.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên phải có tối thiểu 3 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            // 2. Kiểm tra txtSDT: đúng 10 chữ số, bắt đầu bằng "0"
            string sdt = txtSDT.Text.Trim();
            if (string.IsNullOrEmpty(sdt))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại không được để trống");
                hopLe = false;
            }
            else if (sdt.Length != 10 || !sdt.StartsWith("0") || !sdt.All(char.IsDigit))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải đúng 10 chữ số và bắt đầu bằng số 0");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            // 3. Kiểm tra txtEmail: chứa "@" và "." phía sau "@"
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(email))
            {
                errorProvider1.SetError(txtEmail, "Email không được để trống");
                hopLe = false;
            }
            else
            {
                int atIndex = email.IndexOf('@');
                int dotIndex = email.LastIndexOf('.');

                // '@' không ở đầu, '.' xuất hiện sau '@' ít nhất 1 ký tự, và '.' không ở cuối chuỗi
                if (atIndex <= 0 || dotIndex <= atIndex + 1 || dotIndex >= email.Length - 1)
                {
                    errorProvider1.SetError(txtEmail, "Email không đúng định dạng");
                    hopLe = false;
                }
                else
                {
                    errorProvider1.SetError(txtEmail, "");
                }
            }

            // 4. Kiểm tra txtMatKhau: tối thiểu 6 ký tự
            string matKhau = txtMatKhau.Text;
            if (string.IsNullOrEmpty(matKhau))
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu không được để trống");
                hopLe = false;
            }
            else if (matKhau.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            // 5. Kiểm tra txtXacNhanMK: phải khớp với txtMatKhau
            string xacNhanMK = txtXacNhanMK.Text;
            if (string.IsNullOrEmpty(xacNhanMK))
            {
                errorProvider1.SetError(txtXacNhanMK, "Vui lòng xác nhận mật khẩu");
                hopLe = false;
            }
            else if (xacNhanMK != matKhau)
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text.Trim(),
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnHuy.CausesValidation = false;
            errorProvider1.Clear();
            this.Close();
        }
    }
}
