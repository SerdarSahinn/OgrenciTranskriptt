using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Ödev2
{
    public partial class EkleFrm : Form
    {
        public EkleFrm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("Server=localhost; port=5432; Database=database2;user Id=postgres;password=12345");
        public void VerileriGoster(string txt)
        {
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglan;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader rd = komut.ExecuteReader();
            if (rd.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(rd);
                dataGridView1.DataSource = dt;

            }
            komut.Dispose();
            baglan.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglan;

            komut_ekle.Parameters.AddWithValue("@derskodu", txtDerskodu.Text);
            komut_ekle.Parameters.AddWithValue("@dersadı", txtdersadı.Text);
            komut_ekle.Parameters.AddWithValue("@derskredi", int.Parse(txtderskredi.Text));
            komut_ekle.Parameters.AddWithValue("@dersakts", int.Parse(txtdersakts.Text));
            komut_ekle.Parameters.AddWithValue("@dersogretmen", txtdersogretmen.Text);
            komut_ekle.Parameters.AddWithValue("@dersdonem", txtdonem.Text);
            komut_ekle.Parameters.AddWithValue("@dersnot", txtnotu.Text);
            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into liste (ders_kodu,ders_adı,ders_kredi,ders_akts,ders_ogretmen,ders_donem,ders_notu) values(@derskodu,@dersadı,@derskredi,@dersakts,@dersogretmen,@dersdonem,@dersnot)";

            NpgsqlDataReader dr = komut_ekle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_ekle.Dispose();
            baglan.Close();
            MessageBox.Show("ders ekleme işlemi başarılı bir şekilde gerçekleşti");
            VerileriGoster("select * from liste");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formm = new Form1();
            formm.Show();
            this.Hide();
        }
    }
}
