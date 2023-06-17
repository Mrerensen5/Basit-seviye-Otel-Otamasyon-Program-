using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace sistemproje
{
    public partial class yenimusteri : Form
    {
        public yenimusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S657VTM\\SQLEXPRESS;Initial Catalog=OtelOtomasyon2;Integrated Security=True");


        private void Btnoda1_Click(object sender, EventArgs e)
        {
            txtoda.Text = "1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda1 (Adi,Soyadi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda2_Click(object sender, EventArgs e)
        {
            txtoda.Text = "2";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda2 (Adi,Soyadi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda3_Click(object sender, EventArgs e)
        {
            txtoda.Text = "3";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda3 (Adi,Soyadi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda4_Click(object sender, EventArgs e)
        {
            txtoda.Text = "4";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda4 (Adi,Soyadi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda5_Click(object sender, EventArgs e)
        {
            txtoda.Text = "5";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda5 (Adi,Soyadi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda6_Click(object sender, EventArgs e)
        {
            txtoda.Text = "6";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda6 (Adi,Soyadi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda7_Click(object sender, EventArgs e)
        {
            txtoda.Text = "7";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda7 (Adi,Soyadi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda8_Click(object sender, EventArgs e)
        {
            txtoda.Text = "8";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda8 (Adi,Soyadi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btnoda9_Click(object sender, EventArgs e)
        {
            txtoda.Text = "9";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda9 (Adi,Soyadi) values ('" + txtisim.Text + "','" + txtsoyisim.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Btndolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Gösterir");
        }

        private void Btnbos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Gösterir");
        }

        private void dtpcıkıs_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpgiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpcıkıs.Text);

            TimeSpan sonuc;
            sonuc = BuyukTarih - KucukTarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 50;
            txtucret.Text = ucret.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnasayfaFrm anafrm = new AnasayfaFrm();
            anafrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO MüsteriEkle (Adi,Soyadi,Cinsiyet,Telefon,Mail,TC,OdaNo,Ucret,GirisTarihi,CikisTarihi) values('" + txtisim.Text + "','" + txtsoyisim.Text + "','" + cboxcinsiyet.Text + "','" + msktxttelefon.Text + "','" + txtemail.Text + "','" + txttc.Text + "','" + txtoda.Text + "','" + txtucret.Text + "','" + dtpgiris.Value.ToString("yyyy-MM-dd") + "','" + dtpcıkıs.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void yenimusteri_Load(object sender, EventArgs e)
        {
            //Oda1
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from Oda1", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                Btnoda1.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda1.Text != "1")
            {
                Btnoda1.BackColor = Color.Red;
                Btnoda1.Enabled = false;
            }

            //Oda2
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select *from Oda2", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                Btnoda2.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda2.Text != "2")
            {
                Btnoda2.BackColor = Color.Red;
                Btnoda2.Enabled = false;
            }

            //Oda3
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select *from Oda3", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                Btnoda3.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda3.Text != "3")
            {
                Btnoda3.BackColor = Color.Red;
                Btnoda3.Enabled = false;
            }

            //Oda4
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select *from Oda4", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                Btnoda4.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda4.Text != "4")
            {
                Btnoda4.BackColor = Color.Red;
                Btnoda4.Enabled = false;
            }

            //Oda5
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select *from Oda5", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                Btnoda5.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda5.Text != "5")
            {
                Btnoda5.BackColor = Color.Red;
                Btnoda5.Enabled = false;
            }

            //Oda6
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select *from Oda6", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                Btnoda6.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda6.Text != "6")
            {
                Btnoda6.BackColor = Color.Red;
                Btnoda6.Enabled = false;
            }

            //Oda7
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select *from Oda7", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                Btnoda7.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda7.Text != "7")
            {
                Btnoda7.BackColor = Color.Red;
                Btnoda7.Enabled = false;
            }

            //Oda8
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select *from Oda8", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                Btnoda8.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda8.Text != "8")
            {
                Btnoda8.BackColor = Color.Red;
                Btnoda8.Enabled = false;
            }

            //Oda9
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select *from Oda9", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                Btnoda9.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda9.Text != "9")
            {
                Btnoda9.BackColor = Color.Red;
                Btnoda9.Enabled = false;
            }
        }
    }
}
