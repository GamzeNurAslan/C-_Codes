namespace faizHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BtnHesapla_Click_Click(object sender, EventArgs e)
        {
            try
            {
                double anapara = Convert.ToDouble(txtAnapara.Text);
                double faizOrani = Convert.ToDouble(txtFaizOrani.Text) / 100;
                int sure = Convert.ToInt32(txtSure.Text);

                double toplamFaiz = FaizHesapla(anapara, faizOrani, sure);
                double toplamOdenecek = anapara + toplamFaiz;

                lblToplamFaiz.Text = $"Toplam Faiz: {toplamFaiz:C}";
                lblToplamOdenecek.Text = $"Toplam Ödenecek: {toplamOdenecek:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double FaizHesapla(double anapara, double faizOrani, int sure)
        {
            return anapara * faizOrani * sure;
        }
    }
    }
