using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev2
{
    public partial class GüncelleFrm : Form
    {
        public GüncelleFrm()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglan = new NpgsqlConnection("Server=localhost; port=5432; Database=database2;user Id=postgres;password=12345");
        public void VerileriGoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from liste where ders_kodu like '%" + txt.Text + "%'", baglan);
            NpgsqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = rd["ders_kodu"].ToString();
                ekle.SubItems.Add(rd["ders_adı"].ToString());
                ekle.SubItems.Add(rd["ders_kredi"].ToString());
                ekle.SubItems.Add(rd["ders_akts"].ToString());
                ekle.SubItems.Add(rd["ders_ogretmen"].ToString());
                ekle.SubItems.Add(rd["ders_donem"].ToString());
                ekle.SubItems.Add(rd["ders_notu"].ToString());
                listView1.Items.Add(ekle);
            }
            baglan.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
            groupBox1.Visible = true;
            dataGridView1.Visible = false;
        }

        private void GüncelleFrm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            listView1.Columns.Add("ders_kodu", 100);
            listView1.Columns.Add("ders_adı", 150);
            listView1.Columns.Add("ders_kredi", 100);
            listView1.Columns.Add("ders_akts", 100);
            listView1.Columns.Add("ders_ogretmen", 150);
            listView1.Columns.Add("ders_donem", 100);
            listView1.Columns.Add("ders_notu", 100);

        }
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; port=5432; Database=database2;user Id=postgres;password=12345");
        public void verileri_goster(string txt)
        {
            conn.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.Text;
            komut.CommandText = txt;
            NpgsqlDataReader dr = komut.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut.Dispose();
            conn.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            conn.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = conn;

            komut_guncelle.Parameters.AddWithValue("@derskodu", txtDerskodu.Text);
            komut_guncelle.Parameters.AddWithValue("@dersadı", txtdersadı.Text);
            komut_guncelle.Parameters.AddWithValue("@derskredi", Convert.ToInt32(txtderskredi.Text));
            komut_guncelle.Parameters.AddWithValue("@dersakts", Convert.ToInt32(txtdersakts.Text));
            komut_guncelle.Parameters.AddWithValue("@dersogretmen", txtdersogretmen.Text);
            komut_guncelle.Parameters.AddWithValue("@dersdonem", txtdonem.Text);
            komut_guncelle.Parameters.AddWithValue("@dersnot", txtnotu.Text);
            komut_guncelle.CommandType = CommandType.Text;
            komut_guncelle.CommandText = "update liste set ders_kodu=@derskodu,ders_adı=@dersadı,ders_kredi=@derskredi,ders_akts=@dersakts,ders_ogretmen=@dersogretmen,ders_donem=@dersdonem,ders_notu=@dersnot where ders_kodu=@derskodu";
            NpgsqlDataReader dr = komut_guncelle.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_guncelle.Dispose();
            conn.Close();

            verileri_goster("select *from liste");

            listView1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 FRM = new Form1();
            FRM.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }
    }
}
