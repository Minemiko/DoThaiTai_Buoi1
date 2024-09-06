namespace DoThaiTai_Buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GPTB2 gPTB2 = new GPTB2();
            gPTB2.Show();
        }

        private void nhậpDãySốVàTínhTổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TT tT = new TT();
            tT.Show();
        }

        private void kiểmTraVàTìmSốNguyênTốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SNT sNT = new SNT();
            sNT.Show();
        }
    }
}
