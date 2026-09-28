namespace Cau5
{
    public partial class FormChonGhe : Form
    {
        private readonly string gheHienTai;

        public string GheChon { get; private set; } = string.Empty;

        public FormChonGhe(string gheHienTai = "")
        {
            InitializeComponent();
            this.gheHienTai = gheHienTai.Trim();
        }

        private void FormChonGhe_Load(object? sender, EventArgs e)
        {
            string[] cot = { "1", "2", "3", "4", "5" };
            string[] hang = { "A", "B", "C" };

            foreach (string soCot in cot)
            {
                foreach (string tenHang in hang)
                {
                    lstGhe.Items.Add(tenHang + soCot);
                }
            }

            lstGhe.SelectedIndex = lstGhe.FindStringExact(gheHienTai);
        }

        private void lstGhe_SelectedIndexChanged(object? sender, EventArgs e)
        {
            lblGheDaChon.Text = lstGhe.SelectedItem is null
                ? "Đang chọn:"
                : $"Đang chọn: {lstGhe.SelectedItem}";
        }

        private void btnXacNhan_Click(object? sender, EventArgs e)
        {
            if (lstGhe.SelectedItem is null)
            {
                MessageBox.Show("Vui lòng chọn ghế trước khi xác nhận!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GheChon = lstGhe.SelectedItem.ToString()!;
            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
