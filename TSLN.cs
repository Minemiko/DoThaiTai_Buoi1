using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoThaiTai_Buoi1
{
    public partial class TSLN : Form
    {
        public TSLN()
        {
            InitializeComponent();
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtA.Text);
            b = Convert.ToInt32(txtB.Text);
            c = Convert.ToInt32(txtC.Text);
            if (a >= b)
            {
                if (a >= c)
                {
                    txtKQ.Text = a.ToString();
                }
                else
                {
                    txtKQ.Text = c.ToString();
                }
            }
            else if (b > a)
            {
                if (b >= c)
                {
                    txtKQ.Text = b.ToString();
                }
                else
                {
                    txtKQ.Text = c.ToString();
                }
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtKQ.Clear();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
