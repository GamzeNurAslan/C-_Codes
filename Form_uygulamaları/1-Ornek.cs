namespace uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        string[] dizi = new string[10];

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {

                dizi[i] = txtVeri.Text;

                IstBVeriler.Items.Add(dizi[i]);

                i++;

                txtVeri.Clear();

                txtVeri.Focus();

            }
        }
    }
}
