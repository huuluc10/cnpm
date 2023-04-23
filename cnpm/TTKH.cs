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
        string quyen;
        public TTKH(string quyen)
        {
            InitializeComponent();
            this.quyen = quyen;
            buttonEnabled();
        }

        private void buttonEnabled()
        {
            if(quyen == "xem")
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            } else if (quyen == "sua")
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = false;
            } else
            {
                button4.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
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

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
