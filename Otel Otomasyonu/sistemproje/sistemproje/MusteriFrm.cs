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
    public partial class MusteriFrm : Form
    {
        public MusteriFrm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-S657VTM\SQLEXPRESS;Initial Catalog=OtelOtomasyon2;Integrated Security=True");

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtisim.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyisim.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cboxcinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            msktxttelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtemail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txttc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtoda.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpgiris.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtpcıkıs.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE MüsteriEkle SET Adi='" + txtisim.Text + "',Soyadi='" + txtsoyisim.Text + "',Cinsiyet='" + cboxcinsiyet.Text + "',Telefon='" + msktxttelefon.Text + "',Mail='" + txtemail.Text + "',TC='" + txttc.Text + "',OdaNo='" + txtoda.Text + "',Ucret='" + txtucret.Text + "',GirisTarihi='" + dtpgiris.Value.ToString("yyyy-MM-dd") + "',CikisTarihi='" + dtpcıkıs.Value.ToString("yyyy-MM-dd") + "' where Musteriid=" + id+"", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (txtoda.Text == "1")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda1",baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtoda.Text == "2")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda2", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtoda.Text == "3")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda3", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtoda.Text == "4")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda4", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtoda.Text == "5")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda5", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtoda.Text == "6")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda6", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtoda.Text == "7")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda7", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtoda.Text == "8")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda8", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
            if (txtoda.Text == "9")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda9", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }

        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            //hatalı buton
        }

        private void Btntemizle_Click_1(object sender, EventArgs e)
        {
            txtisim.Clear();
            txtsoyisim.Clear();
            cboxcinsiyet.Text = "";
            msktxttelefon.Clear();
            txtemail.Text = "";
            txttc.Clear();
            txtoda.Clear();
            txtucret.Clear();
            dtpgiris.Text = "";
            dtpcıkıs.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MüsteriEkle where Adi like '%" + Txtara.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnasayfaFrm anafrm = new AnasayfaFrm();
            anafrm.Show();
            this.Hide();
        }
    }
}
