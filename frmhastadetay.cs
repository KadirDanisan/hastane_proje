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
    public partial class frmhastadetay : Form
    {
        public frmhastadetay()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void frmhastadetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            // AD SOYAD ÇEKME

            NpgsqlCommand komut = new NpgsqlCommand("SELECT ptname, ptlastname FROM tbl_patients where pttc=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", LblTC.Text);

            NpgsqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //RANDEVU GEÇMİŞİ 

            DataTable dt = new DataTable();

            // Parametreli sorgu kullanarak SQL injection'ı önleyin
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM tbl_meeting WHERE mtsicktc = @p1", bgl.baglanti());

            // Parametre ekleme
            da.SelectCommand.Parameters.AddWithValue("@p1", tc);

            // DataTable'a verileri doldurma
            da.Fill(dt);

            // Verileri DataGridView'e bağlama
            dataGridView1.DataSource = dt;

            //BRANŞLARI ÇEKME

            NpgsqlCommand komut2 = new NpgsqlCommand("SELECT brname FROM tbl_branch", bgl.baglanti());

            NpgsqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            NpgsqlCommand komut3 = new NpgsqlCommand("SELECT dcname, dclastname FROM tbl_doctor WHERE dcbranch = @p1", bgl.baglanti());

            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            NpgsqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM tbl_meeting WHERE mtbranch='" + CmbBrans.Text + "'" + "AND mtdoctor = '" + CmbDoktor.Text + "' AND mtsituation = false", bgl.baglanti());

            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmbilgiduzenle fr = new frmbilgiduzenle();

            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            //BURAYA BAKILCAK
            // Txtid'in boş olup olmadığını kontrol et
            if (string.IsNullOrWhiteSpace(Txtid.Text))
            {
                MessageBox.Show("Lütfen geçerli bir ID girin.");
                return; // İşlemi sonlandır
            }

            NpgsqlCommand komut3 = new NpgsqlCommand("UPDATE tbl_meeting SET mtsituation = true, mtsicktc = @p1, mtsituation = @p2 WHERE id = @p3", bgl.baglanti());

            komut3.Parameters.AddWithValue("@p1", LblTC.Text);
            komut3.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut3.Parameters.AddWithValue("@p3", int.Parse(Txtid.Text));

            komut3.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı ");

        }
    }
}
