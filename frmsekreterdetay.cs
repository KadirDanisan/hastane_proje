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
    public partial class frmsekreterdetay : Form
    {
        public frmsekreterdetay()
        {
            InitializeComponent();
        }

        public string Tcnumara;

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frmsekreterdetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = Tcnumara;

            //AD SOYAD
            NpgsqlCommand komut1 = new NpgsqlCommand("SELECT scfullname FROM tbl_secreter WHERE sctc = @p1", bgl.baglanti());

            komut1.Parameters.AddWithValue("@p1", LblTC.Text);

            NpgsqlDataReader dr1 = komut1.ExecuteReader();

            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();

            }
            bgl.baglanti().Close();

            //Branşları Aktarma

            DataTable dt1 = new DataTable();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT brname FROM tbl_branch", bgl.baglanti());

            da.Fill(dt1);

            dataGridView1.DataSource = dt1;

            //Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter("SELECT (dcname || ' ' || dclastname) AS fullname, dcbranch FROM tbl_doctor\r\n", bgl.baglanti());

            da2.Fill(dt2);

            dataGridView2.DataSource = dt2;

            //Branşı aktarma

            NpgsqlCommand komut2 = new NpgsqlCommand("SELECT brname FROM tbl_branch", bgl.baglanti());
            NpgsqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);

            }

            bgl.baglanti().Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komutkaydet = new NpgsqlCommand("INSERT INTO tbl_meeting (mthistory, mthour, mtbranch, mtdoctor) \r\nVALUES (@pr1, @pr2, @pr3, @pr4);\r\n", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@pr1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@pr2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@pr3", CmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@pr4", CmdDoktor.Text);

            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void CmdBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmdDoktor.Items.Clear();

            NpgsqlCommand komut = new NpgsqlCommand("SELECT dcname, dclastname FROM tbl_doctor WHERE dcbranch = @p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", CmbBrans.Text);
            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                CmdDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void RchDuyuru_TextChanged(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO tbl_announcements (announcement) VALUES (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            frmdoktorpaneli drp = new frmdoktorpaneli();
            drp.Show();
        }

        private void BtnBransPanel_Click(object sender, EventArgs e)
        {
            frmbrans frm = new frmbrans();
            frm.Show();
        }

        private void BtnRandevuListesi_Click(object sender, EventArgs e)
        {
            frmrandevulistesi frr = new frmrandevulistesi();
            frr.Show();
        }

        private void BtnDuyrular_Click(object sender, EventArgs e)
        {
            frmduyrular frd = new frmduyrular();
            frd.Show();
        }
    }
}
