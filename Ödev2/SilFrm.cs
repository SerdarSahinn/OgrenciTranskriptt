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
using static System.Net.Mime.MediaTypeNames;

namespace Ödev2
{
    public partial class SilFrm : Form
    {
        public SilFrm()
        {
            InitializeComponent();
        }

        private void SilFrm_Load(object sender, EventArgs e)
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
        NpgsqlConnection baglan = new NpgsqlConnection("Server=localhost; port=5432; Database=database2;user Id=postgres;password=12345");
        public void VerileriGoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand("select *from liste where ders_kodu like '%" + sil_txt.Text + "%'", baglan);
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

        //
        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGoster();
             groupBox1.Visible = true;

              dataGridView1.Visible = false;
           
            
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
            listView1.Visible = false;
            sil_btn.Visible = false;
            iptal_btn.Visible=false;
            conn.Open();
            NpgsqlCommand komut_sil = new NpgsqlCommand();
            komut_sil.Connection = conn;
            komut_sil.Parameters.AddWithValue("@ders_koduu", sil_txt.Text);

            komut_sil.CommandType = CommandType.Text;
            komut_sil.CommandText = "delete from liste where ders_kodu = @ders_koduu";

            NpgsqlDataReader dr = komut_sil.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }
            komut_sil.Dispose();
            conn.Close();
            MessageBox.Show("Ders silme işlemi başarılı bir şekilde gerçekleşti ");
            verileri_goster("select * from liste");



        }

        private void iptal_btn_Click(object sender, EventArgs e)
        {
            Form1 silfrm = new Form1();
            silfrm.Show();
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
