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
    public partial class GPTB2 : Form
    {
        public GPTB2()
        {
            InitializeComponent();
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c != 0)
                    {
                        txtKQ.Text = "Phương trình vô nghiệm";
                    }
                    else
                    {
                        txtKQ.Text = "Phương trình vô số nghiệm";
                    }
                }
                else
                {
                    txtKQ.Text = "Nghiệm của phương trình x là " + (-c / b);
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    txtKQ.Text = "Phương trình vô nghiệm";
                }
                else
                {
                    txtKQ.Text = ("x1 = " + (-b + (Math.Sqrt(delta)) / (2 * a)));
                    txtKQ2.Text = ("x2 = " + (-b - (Math.Sqrt(delta)) / (2 * a)));
                }
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtKQ.Clear();
            txtKQ2.Clear();
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
