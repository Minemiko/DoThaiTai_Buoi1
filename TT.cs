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
    public partial class TT : Form
    {
        public TT()
        {
            InitializeComponent();
        }

        List<int> arrDayso = new List<int>();

        private void btnN_Click(object sender, EventArgs e)
        {
            int soNhap = int.Parse(txtNS.Text);
            int tong = 0;
            int tongL = 0;
            int tongC = 0;
            arrDayso.Add(soNhap);
            txtDS.Text = "";
            foreach (int i in arrDayso)
            {
                txtDS.Text += i + " ";
                tong += i;
                txtT.Text = tong.ToString();
                if (i % 2 != 0)
                {
                    tongL += i;
                }
                else
                {
                    tongC += i;
                }
                txtTC.Text = tongC.ToString();
                txtTL.Text = tongL.ToString();
            }
            txtNS.Text = "";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            txtNS.Clear();
            txtDS.Clear();
            txtT.Clear();
            txtTC.Clear();
            txtTL.Clear();
        }
    }
}
