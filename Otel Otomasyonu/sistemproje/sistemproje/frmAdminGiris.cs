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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnasayfaFrm anafrm = new AnasayfaFrm();
            anafrm.Show();
            this.Hide();
        }

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "admin" && txtsifre.Text == "12345")
            {
                AnasayfaFrm anafrm = new AnasayfaFrm();
                anafrm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya Şifre hatalı");
            }
        }
    }
}
