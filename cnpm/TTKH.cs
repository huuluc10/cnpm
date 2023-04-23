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
    public partial class TTKH : Form
    {
        string mssv;
        public TTKH(string mssv)
        {
            InitializeComponent();
            this.mssv = mssv;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng này khỏi hệ thống?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Code để xóa khách hàng
                this.Close();
            }
            else
            {
                // Code để không xóa khách hàng
            }

        }
    }
}
