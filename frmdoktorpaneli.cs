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
    public partial class frmdoktorpaneli : Form
    {
        public frmdoktorpaneli()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmdoktorpaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();

            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM tbl_doctor\r\n", bgl.baglanti());

            da.Fill(dt1);

            dataGridView1.DataSource = dt1;

            //Branş aktarma

            NpgsqlCommand komut2 = new NpgsqlCommand("SELECT brname FROM tbl_branch", bgl.baglanti());
            NpgsqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }

            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO tbl_doctor (dcname, dclastname, dctc, dcbranch, dcpassword) VALUES (@d1, @d2, @d3, @d4, @d5)", bgl.baglanti());

            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", MskTC.Text);
            komut.Parameters.AddWithValue("@d4", CmbBrans.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("EKLEDİNİZ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex; // Seçili satırın indeksi

            // Sütun sıraları doğru olmalı
            TxtAd.Text = dataGridView1.Rows[secilen].Cells["dcname"].Value.ToString();      // İsim
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells["dclastname"].Value.ToString(); // Soyisim
            MskTC.Text = dataGridView1.Rows[secilen].Cells["dctc"].Value.ToString();        // TC
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells["dcbranch"].Value.ToString();  // Branş
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells["dcpassword"].Value.ToString(); // Şifre
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut1 = new NpgsqlCommand("DELETE FROM tbl_doctor WHERE dctc = @p1", bgl.baglanti());

            komut1.Parameters.AddWithValue("@p1", MskTC.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi");
        }

       

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
           

                NpgsqlCommand komut = new NpgsqlCommand("UPDATE tbl_doctor SET dcname= @d1, dclastname= @d2, dcbranch= @d4, dcpassword= @d5 WHERE dctc= @d3", bgl.baglanti());

                komut.Parameters.AddWithValue("@d1", TxtAd.Text);
                komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@d3", MskTC.Text);  // Seçili TC'yi kullan
                komut.Parameters.AddWithValue("@d4", CmbBrans.Text);
                komut.Parameters.AddWithValue("@d5", TxtSifre.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Güncellendi");          
        }
    }
}
