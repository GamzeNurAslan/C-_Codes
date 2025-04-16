using System;
using System.Windows.Forms;

namespace GirisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullanici.Text;
            string sifre = txtSifre.Text;

            if (kullaniciAdi == "admin" && sifre == "1234")
            {
                lblSonuc.Text = "✅ Giriş başarılı. Hoş geldin!";
                lblSonuc.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblSonuc.Text = "❌ Hatalı kullanıcı adı veya şifre!";
                lblSonuc.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
