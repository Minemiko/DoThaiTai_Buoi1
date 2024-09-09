using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DoThaiTai_Buoi1
{
    public partial class SNT : Form
    {
        public SNT()
        {
            InitializeComponent();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ktSNT(int n)
        {
            int dem = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    dem++;
            }
            if (dem == 2) return true; return false;
        }

        private void txtS_TextChanged(object sender, EventArgs e)
        {
            string kq = string.Empty;
            if (txtS.Text != string.Empty)
            {
                if (ktSNT(int.Parse(txtS.Text)))
                {
                    txtKT.Text = int.Parse(txtS.Text) + " là số nguyên tố";
                }
                else
                {
                    txtKT.Text = int.Parse(txtS.Text) + " không phải là số nguyên tố";
                }

                for (int i = 2; i < int.Parse(txtS.Text); i++)
                {
                    if (ktSNT(i))
                    {
                        kq += i + " ";
                    }
                }
                txtSNT.Text = kq;
            }
        }
    }
}
