using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev2
{
    public partial class TranskriptFrm : Form
    {
        public TranskriptFrm()
        {
            InitializeComponent();
        }

        private void TranskriptFrm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible=false;
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
            groupBox1.Visible = true;
            //2022/1
            VerileriGoster("select ders_adı,ders_kredi,ders_akts,ders_notu," +
             " case  when ders_notu = 'AA' then 4 " +
             " when ders_notu = 'BA' then 3.5" +
             " when ders_notu = 'BB' then 3" +
             " when ders_notu = 'CB' then 2.5" +
             " when ders_notu = 'CC' then 2" +
             " when ders_notu = 'CD' then 1.5" +
             " when ders_notu = 'DD' then 1" +
            " when ders_notu = 'FD' then 0.5" +
            " when ders_notu = 'FF' then 0" +
            " end puan_notu from liste where ders_notu is not null and ders_donem='2022/1'");

            int toplamk4 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplamk4 += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            krdsnc_txt.Text = toplamk4.ToString();


            double d3toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                int notlar = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                int krediler = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

                if (notlar == 4)
                {
                    d3toplam += notlar * krediler;
                }
                else if (notlar == 3.5)
                {
                    d3toplam += notlar * krediler;
                }
                else if (notlar == 3)
                {
                    d3toplam += notlar * krediler;
                }
                else if (notlar == 2.5)
                {
                    d3toplam += notlar * krediler;
                }
                else if (notlar == 2)
                {
                    d3toplam += notlar * krediler;
                }

            }


            donem3_txt.Text = (d3toplam / toplamk4).ToString();


            //2021/2
            VerileriGoster("select ders_adı,ders_kredi,ders_akts,ders_notu," +
         " case  when ders_notu = 'AA' then 4 " +
         " when ders_notu = 'BA' then 3.5" +
         " when ders_notu = 'BB' then 3" +
         " when ders_notu = 'CB' then 2.5" +
         " when ders_notu = 'CC' then 2" +
         " when ders_notu = 'CD' then 1.5" +
         " when ders_notu = 'DD' then 1" +
         " when ders_notu = 'FD' then 0.5" +
         " when ders_notu = 'FF' then 0" +
         " end puan_notu from liste where ders_notu is not null and ders_donem='2021/2'");

            int toplamk3 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplamk3 += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            krdsnc_txt.Text = toplamk3.ToString();


            double d2toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                int notlar = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                int krediler = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

                if (notlar == 4)
                {
                    d2toplam += notlar * krediler;
                }
                else if (notlar == 3.5)
                {
                    d2toplam += notlar * krediler;
                }
                else if (notlar == 3)
                {
                    d2toplam += notlar * krediler;
                }
                else if (notlar == 2.5)
                {
                    d2toplam += notlar * krediler;
                }
                else if (notlar == 2)
                {
                    d2toplam += notlar * krediler;
                }

            }


            donem2_txt.Text = (d2toplam / toplamk3).ToString();

            //2021/1 dönemi

            VerileriGoster("select ders_adı,ders_kredi,ders_akts,ders_notu," +
              " case  when ders_notu = 'AA' then 4 " +
              " when ders_notu = 'BA' then 3.5" +
              " when ders_notu = 'BB' then 3" +
              " when ders_notu = 'CB' then 2.5" +
              " when ders_notu = 'CC' then 2" +
              " when ders_notu = 'CD' then 1.5" +
              " when ders_notu = 'DD' then 1" +
              " when ders_notu = 'FD' then 0.5" +
              " when ders_notu = 'FF' then 0" +
              " end puan_notu from liste where ders_notu is not null and ders_donem='2021/1'");

            int toplamk2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplamk2 += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            krdsnc_txt.Text = toplamk2.ToString();

           
            double dtoplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                int notlar = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                int krediler = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

                if (notlar == 4)
                {
                    dtoplam += notlar * krediler;
                }
                else if (notlar == 3.5)
                {
                    dtoplam += notlar * krediler;
                }
                else if (notlar == 3)
                {
                    dtoplam += notlar * krediler;
                }
                else if (notlar == 2.5)
                {
                    dtoplam += notlar * krediler;
                }
                else if (notlar == 2)
                {
                    dtoplam += notlar * krediler;
                }

            }

          
            donem1_txt.Text = (dtoplam / toplamk2).ToString();



            VerileriGoster("select ders_adı,ders_kredi,ders_akts,ders_notu," +
              " case  when ders_notu = 'AA' then 4 " +
              " when ders_notu = 'BA' then 3.5" +
              " when ders_notu = 'BB' then 3" +
              " when ders_notu = 'CB' then 2.5" +
              " when ders_notu = 'CC' then 2" +
              " when ders_notu = 'CD' then 1.5" +
              " when ders_notu = 'DD' then 1" +
              " when ders_notu = 'FD' then 0.5" +
              " when ders_notu = 'FF' then 0" +
              " end puan_notu from liste where ders_notu is not null ");


            // toplam kredi sayısı
            int toplamk = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplamk += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            krdsnc_txt.Text = toplamk.ToString();

            //GANO
            double heptoplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                int notlar = Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value);
                int krediler = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);

                if (notlar == 4)
                {
                    heptoplam += notlar * krediler;
                }
                else if (notlar == 3.5)
                {
                    heptoplam += notlar * krediler;
                }
                else if (notlar == 3)
                {
                    heptoplam += notlar * krediler;
                }
                else if (notlar == 2.5)
                {
                    heptoplam += notlar * krediler;
                }
                else if (notlar == 2)
                {
                    heptoplam += notlar * krediler;
                }

            }

            
            snc_txt.Text = (heptoplam / toplamk).ToString();

        }

        private void agno_btn_Click(object sender, EventArgs e )
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formm = new Form1();
            formm.Show();
            this.Hide();
        }

        private void snc_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
