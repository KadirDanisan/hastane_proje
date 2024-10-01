namespace hastane_proje
{
    public partial class frmgirisler : Form
    {
        public frmgirisler()
        {
            InitializeComponent();
        }

        private void BtnHastaGirisi_Click(object sender, EventArgs e)
        {
            frmhastagiris fr = new frmhastagiris();

            fr.Show();
            this.Hide();
        }

        private void BtnDoktorGirisi_Click(object sender, EventArgs e)
        {
            frmdoktorgiris fr = new frmdoktorgiris();

            fr.Show();
            this.Hide();
        }

        private void BtnSekreterGirisi_Click(object sender, EventArgs e)
        {
            frmsekretergiris fr = new frmsekretergiris();

            fr.Show();
            this.Hide();
        }
    }
}
