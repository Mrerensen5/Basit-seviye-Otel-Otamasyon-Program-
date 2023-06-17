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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-S657VTM\\SQLEXPRESS;Initial Catalog=OtelOtomasyon2;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            AnasayfaFrm anafrm = new AnasayfaFrm();
            anafrm.Show();
            this.Hide();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            //Oda1
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select *from Oda1", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                Btnoda1.Text = oku1["Adi"].ToString() +" "+ oku1["Soyadi"].ToString();
            }
            baglanti.Close();
            if (Btnoda1.Text != "1")
            {
                Btnoda1.BackColor = Color.Red;
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
            }

        }

        private void Btnoda2_Click(object sender, EventArgs e)
        {

        }
    }
}
