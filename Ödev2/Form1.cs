using Npgsql;
using System.Data;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
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


        private void ekle_btn_Click(object sender, EventArgs e)
        {
            EkleFrm ekleFrm = new EkleFrm();
            ekleFrm.Show();
            this.Hide();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            GüncelleFrm güncelleFrm = new GüncelleFrm();
            güncelleFrm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void listele_btn_Click(object sender, EventArgs e)
        {
            VerileriGoster("select ders_kodu,ders_adı,ders_kredi,ders_akts,ders_ogretmen,ders_donem,ders_notu from liste");
        }

        private void güncelle_btn_Click(object sender, EventArgs e)
        {
            SilFrm silFrm=new SilFrm();
            silFrm.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void agno_btn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TranskriptFrm transkriptFrm = new TranskriptFrm();
            transkriptFrm.Show();
            this.Hide();
        }

        private void agno_btn_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void resim_bx_Click(object sender, EventArgs e)
        {

        }
    }
}