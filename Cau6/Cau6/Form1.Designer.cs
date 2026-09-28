namespace Cau6
{
    partial class FormChinh
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
            menuStrip1 = new MenuStrip();
            tepToolStripMenuItem = new ToolStripMenuItem();
            moGhiChuMoiToolStripMenuItem = new ToolStripMenuItem();
            sapXepCuaSoToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            cuaSoToolStripMenuItem = new ToolStripMenuItem();
            xepTangToolStripMenuItem = new ToolStripMenuItem();
            xepNgangToolStripMenuItem = new ToolStripMenuItem();
            xepDocToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblSoGhiChu = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tepToolStripMenuItem, cuaSoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1000, 24);
            menuStrip1.TabIndex = 0;
            // 
            // tepToolStripMenuItem
            // 
            tepToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { moGhiChuMoiToolStripMenuItem, sapXepCuaSoToolStripMenuItem, thoatToolStripMenuItem });
            tepToolStripMenuItem.Name = "tepToolStripMenuItem";
            tepToolStripMenuItem.Size = new Size(40, 20);
            tepToolStripMenuItem.Text = "Tệp";
            // 
            // moGhiChuMoiToolStripMenuItem
            // 
            moGhiChuMoiToolStripMenuItem.Name = "moGhiChuMoiToolStripMenuItem";
            moGhiChuMoiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            moGhiChuMoiToolStripMenuItem.Size = new Size(203, 22);
            moGhiChuMoiToolStripMenuItem.Text = "Mở ghi chú mới";
            moGhiChuMoiToolStripMenuItem.Click += moGhiChuMoiToolStripMenuItem_Click;
            // 
            // sapXepCuaSoToolStripMenuItem
            // 
            sapXepCuaSoToolStripMenuItem.Name = "sapXepCuaSoToolStripMenuItem";
            sapXepCuaSoToolStripMenuItem.Size = new Size(203, 22);
            sapXepCuaSoToolStripMenuItem.Text = "Sắp xếp cửa sổ";
            sapXepCuaSoToolStripMenuItem.Click += sapXepCuaSoToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(203, 22);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // cuaSoToolStripMenuItem
            // 
            cuaSoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { xepTangToolStripMenuItem, xepNgangToolStripMenuItem, xepDocToolStripMenuItem });
            cuaSoToolStripMenuItem.Name = "cuaSoToolStripMenuItem";
            cuaSoToolStripMenuItem.Size = new Size(57, 20);
            cuaSoToolStripMenuItem.Text = "Cửa sổ";
            // 
            // xepTangToolStripMenuItem
            // 
            xepTangToolStripMenuItem.Name = "xepTangToolStripMenuItem";
            xepTangToolStripMenuItem.Size = new Size(131, 22);
            xepTangToolStripMenuItem.Text = "Xếp tầng";
            xepTangToolStripMenuItem.Click += xepTangToolStripMenuItem_Click;
            // 
            // xepNgangToolStripMenuItem
            // 
            xepNgangToolStripMenuItem.Name = "xepNgangToolStripMenuItem";
            xepNgangToolStripMenuItem.Size = new Size(131, 22);
            xepNgangToolStripMenuItem.Text = "Xếp ngang";
            xepNgangToolStripMenuItem.Click += xepNgangToolStripMenuItem_Click;
            // 
            // xepDocToolStripMenuItem
            // 
            xepDocToolStripMenuItem.Name = "xepDocToolStripMenuItem";
            xepDocToolStripMenuItem.Size = new Size(131, 22);
            xepDocToolStripMenuItem.Text = "Xếp dọc";
            xepDocToolStripMenuItem.Click += xepDocToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoGhiChu });
            statusStrip1.Location = new Point(0, 576);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1000, 22);
            statusStrip1.TabIndex = 1;
            // 
            // lblSoGhiChu
            // 
            lblSoGhiChu.Name = "lblSoGhiChu";
            lblSoGhiChu.Size = new Size(126, 17);
            lblSoGhiChu.Text = "Số ghi chú đang mở: 0";
            // 
            // FormChinh
            // 
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 598);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(700, 450);
            Name = "FormChinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý ghi chú công việc";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tepToolStripMenuItem;
        private ToolStripMenuItem moGhiChuMoiToolStripMenuItem;
        private ToolStripMenuItem sapXepCuaSoToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem cuaSoToolStripMenuItem;
        private ToolStripMenuItem xepTangToolStripMenuItem;
        private ToolStripMenuItem xepNgangToolStripMenuItem;
        private ToolStripMenuItem xepDocToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoGhiChu;
    }
}
