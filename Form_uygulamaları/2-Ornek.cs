namespace uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan metni parçala
                string giris = txtSayilar.Text;
                int[] sayilar = giris
                    .Split(',') // Virgül ile ayır
                    .Select(x => int.Parse(x.Trim())) // Her birini tamsayıya dönüştür
                    .ToArray();

                // LINQ ile en küçük ve en büyük sayıları bul
                if (sayilar.Any())
                {
                    int enKucukSayi = sayilar.Min();
                    int enBuyukSayi = sayilar.Max();

                    lblEnKucuk.Text = $"En Küçük Sayı: {enKucukSayi}";
                    lblEnBuyuk.Text = $"En Büyük Sayı: {enBuyukSayi}";
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli sayılar girin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
