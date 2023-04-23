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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
