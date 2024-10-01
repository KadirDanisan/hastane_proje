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
using System.Data.SqlTypes;
using Npgsql;
using System.Xml.Linq;

namespace hastane_proje
{
    public partial class frmüyekayit : Form
    {
        public frmüyekayit()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnKayitYap_Click(object sender, EventArgs e)
        {
            // Bağlantıyı sqlbaglantisi sınıfından al
            NpgsqlCommand komut = new NpgsqlCommand("INSERT INTO tbl_patients (ptname, ptlastname, pttc, ptphone, ptpassword, ptgender) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)", bgl.baglanti());


            komut.Parameters.AddWithValue("@p1", TxtAd.Text);      // Name alanı
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);  // Lastname alanı
            komut.Parameters.AddWithValue("@p3", MskTC.Text);        // TC Kimlik numarası
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text);     // Telefon numarası
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text);  // Parola
            komut.Parameters.AddWithValue("@p6", CmbCinsiyet.Text); // Cinsiyet

            // Sorguyu çalıştır
            komut.ExecuteNonQuery();

            // Bağlantıyı kapat
            bgl.baglanti().Close();

            // İşlem sonucunu kullanıcıya bildirmek için bir mesaj
            MessageBox.Show("Kayıt Başarılı, Şifreniz: " + TxtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
