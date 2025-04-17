using System;
using System.Windows.Forms;
 
namespace ClassArabaOrnek
{
    public partial class Form1 : Form
    {
        private Araba benimArabam;
 
        public Form1()
        {
            InitializeComponent();
            benimArabam = new Araba("Nissan", "XTrail", 200);
            GuncelleDurum("Uygulama başlatıldı.");
        }
 
        private void GuncelleDurum(string mesaj)
        {
            lblDurum.Text = $"{mesaj}\n\n" +
                            $"Marka: {benimArabam.Marka}, Model: {benimArabam.Model}\n" +
                            $"Anlık Hız: {benimArabam.AnlikHiz} km/h\n" +
                            $"Durum: {(benimArabam.CalisiyorMu ? "Çalışıyor" : "Kapalı")}";
        }
 
        private void btnCalistir_Click(object sender, EventArgs e)
        {
            string mesaj = benimArabam.ArabayiCalistir();
            GuncelleDurum(mesaj);
        }
 
        private void btnHizlan_Click(object sender, EventArgs e)
        {
            string mesaj = benimArabam.Hizlan(5);
            GuncelleDurum(mesaj);
        }
 
        private void btnYavasla_Click(object sender, EventArgs e)
        {
            string mesaj = benimArabam.Yavasla(5);
            GuncelleDurum(mesaj);
        }
 
        private void btnDurdur_Click(object sender, EventArgs e)
        {
            string mesaj = benimArabam.ArabayiDurdur();
            GuncelleDurum(mesaj);
        }
    }
}
