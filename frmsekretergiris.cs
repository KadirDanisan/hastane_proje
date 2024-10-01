using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace hastane_proje
{
    public partial class frmsekretergiris : Form
    {
        public frmsekretergiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("SELECT * FROM tbl_secreter WHERE sctc = @p1 and scpassword = @p2", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

            NpgsqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                frmsekreterdetay frs = new frmsekreterdetay();
                frs.Tcnumara = MskTC.Text;
                frs.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
            bgl.baglanti().Close();
        }
    }
}
