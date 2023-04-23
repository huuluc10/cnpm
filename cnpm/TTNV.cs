using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnpm
{
    public partial class TTNV : Form
    {
        string maquyen;
        string tenDangNhap;
        public TTNV(string maquyen, string tenDangNhap)
        {
            InitializeComponent();
            this.maquyen = maquyen;
            this.tenDangNhap = tenDangNhap;
            if (maquyen == "0")
            {
                this.Text = "Thông tin nhân viên";
            } else
            {
                this.Text = "Thông tin quản trị viên";
            }
        }
    }
}
