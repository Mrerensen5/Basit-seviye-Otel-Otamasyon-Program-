using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemproje
{
    public partial class AnasayfaFrm : Form
    {
        public AnasayfaFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdminGiris fr = new frmAdminGiris();
            fr.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            yenimusteri fr2 = new yenimusteri();
            fr2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar odafrm = new Odalar();
            odafrm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriFrm msfrm = new MusteriFrm();
            msfrm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Otomasyon Eren Şen tarafından hazırlanmıştır/2022 Sistem Analizi Projesi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("112 Acil Servis" + "\n" + "155 Polis" + "\n" + "110 İtfaiye" + "\n" + "555 Oda Servisi");
        }
    }
}
