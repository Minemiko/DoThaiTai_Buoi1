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
    public partial class DSTC : Form
    {
        public DSTC()
        {
            InitializeComponent();
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            string[] StC = { "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
            int S = int.Parse(txtS.Text) - 1;
            txtC.Text = StC[S];
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
