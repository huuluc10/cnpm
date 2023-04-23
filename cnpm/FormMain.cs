using System;
using System.Windows.Forms;

namespace cnpm
{
    public partial class FrmMain : Form
    {
        private Form activeForm;
        String maquyen = null;

        public FrmMain(string maquyen)
        {
            InitializeComponent();
            this.maquyen = maquyen;
            menuEnabled();
        }

        private void menuEnabled()
        {
            if (maquyen == "0")
            {
                cấpTàiKhoảnNhânViênToolStripMenuItem.Visible = false;
                đToolStripMenuItem.Visible = false;
                thôngTinGóiCướcToolStripMenuItem.Visible = false;
                thêmGóiCướcToolStripMenuItem.Visible = false;
                báoCáoDoanhThuToolStripMenuItem.Visible = false;
            } else if (maquyen == "1")
            {

            } else
            {
                cấpTàiKhoảnNhânViênToolStripMenuItem.Visible = false;
                đToolStripMenuItem.Visible = false;
                thêmGóiCướcToolStripMenuItem.Visible = false;
                báoCáoDoanhThuToolStripMenuItem.Visible = false;
                cấpTàiKhoảnKháchHàngToolStripMenuItem.Visible = false;
                đổiThôngTinKháchHàngToolStripMenuItem.Visible = false;
                thêmGóiCướcToolStripMenuItem.Visible = false;
                đăngKýGiaHạnToolStripMenuItem.Visible = false;
                báoCáoToolStripMenuItem.Visible = false;
            }
        }

        private void cấpTàiKhoảnKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new DangNhap();
            login.ShowDialog();
            
        }

        private void showform(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }

        private void thôngTinGóiCướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform(new GoiCuoc());
        }

        private void thêmGóiCướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform(new ThemGoiCuoc());
        }

        private void danhSáchKháchHàngHếtHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform(new DSKHHetHan());
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform(new BaoCaoDoanhThu());
        }

        private void cấpTàiKhoảnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void đToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform(new DSNV());
        }

        private void đổiThôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform(new DSKH());
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (maquyen == "0")
            {
                var ttnv = new TTNV("0", "test1");
                ttnv.Show();
            }
            else if (maquyen == "1")
            {
                var ttnv = new TTNV("1", "test2");
                ttnv.Show();
            } else
            {
                var ttkh = new TTKH("xem");
                ttkh.Show();
            }
        }

        private void đăngKýGiaHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform(new DangKyGoiCuoc());
        }
    }
}
