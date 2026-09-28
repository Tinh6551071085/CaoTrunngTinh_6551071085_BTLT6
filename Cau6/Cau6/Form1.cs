namespace Cau6
{
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
            CapNhatSoGhiChu();
        }

        private void moGhiChuMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGhiChu formGhiChu = new() { MdiParent = this };
            formGhiChu.FormClosed += FormGhiChu_FormClosed;
            formGhiChu.Show();
            CapNhatSoGhiChu();
        }

        private void FormGhiChu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            BeginInvoke(new Action(CapNhatSoGhiChu));
        }

        private void sapXepCuaSoToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void xepTangToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);

        private void xepNgangToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);

        private void xepDocToolStripMenuItem_Click(object sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

        private void CapNhatSoGhiChu()
        {
            lblSoGhiChu.Text = $"Số ghi chú đang mở: {MdiChildren.Length}";
        }
    }
}
