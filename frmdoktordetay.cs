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
    public partial class frmdoktordetay : Form
    {
        public frmdoktordetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;

        private void frmdoktordetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            //DOKTOR AD SOYAD

            NpgsqlCommand komut = new NpgsqlCommand("SELECT  dcname, dclastname FROM  tbl_doctor WHERE dctc =@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", LblTC.Text);

            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular 
            DataTable dt = new DataTable();
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("SELECT * FROM tbl_meeting WHERE mtdoctor='" + LblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            frmdoktorbilgiduzenle fr = new frmdoktorbilgiduzenle();
            fr.TC = LblTC.Text;
            fr.Show();
        }

        private void BtnDuyrular_Click(object sender, EventArgs e)
        {
            frmduyrular fr = new frmduyrular();
            fr.Show();

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
