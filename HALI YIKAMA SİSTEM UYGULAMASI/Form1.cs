using System;

namespace Halı_Yıkama_Fabrikası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Musteri> musterix = new List<Musteri>();
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri
            {
                Ad = txtAd.Text,
                Numara = txtNo.Text,
                Adres = txtAdres.Text
            };
            musterix.Add(m);
            lstMusteriler.Items.Add(m);
            MessageBox.Show("Müşteri eklendi ✅");
        }

        private void btnHaliEkle_Click(object sender, EventArgs e)
        {
            if (lstMusteriler.SelectedItem is Musteri secili)
            {
                bool alim = DateTime.TryParse(txtAlim.Text, out DateTime alimTarihi);
                bool teslim = DateTime.TryParse(txtTeslim.Text, out DateTime teslimTarihi);

                if (!alim || !teslim)
                {
                    MessageBox.Show("Yanlış gg.aa.yyyy girildi. Tekrar girin ❌");
                    return;
                }
                double metrekare;
                if (!double.TryParse(txtMetre.Text, out metrekare))
                {
                    MessageBox.Show("Metrekareyi doğru giriniz 🌸");
                    return;
                }

                Hali h = new Hali
                {
                    Metrekare = metrekare,
                    AlimTarihi = alimTarihi,
                    TeslimTarihi = teslimTarihi
                };

                secili.Halilar.Add(h);
                MessageBox.Show("Halı eklendi ✅");
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri seçin 🌸");
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            lstHalilar.Items.Clear();
            foreach (var m in musterix)
            {
                foreach (var h in m.Halilar.Where(x => x.Durum == YikamaDurumu.Yıkamada))
                {
                    lstHalilar.Items.Add(new ListItem(h, m));
                }
            }
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            if (lstHalilar.SelectedItem is ListItem item)
            {
                if (item.Hali.Durum == YikamaDurumu.TeslimEdildi)
                {
                    MessageBox.Show("Bu halı zaten teslim edilmiş.");
                    return;
                }

                item.Hali.Durum = YikamaDurumu.TeslimEdildi;

                btnListele.PerformClick();

                MessageBox.Show("Halı teslim edildi ✅");
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir halı seçin.");
            }
        }
        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
