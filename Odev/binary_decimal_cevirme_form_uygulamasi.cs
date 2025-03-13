namespace Odev_cuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string binaryString = txtBinaryInput.Text; 
            try
            {

                int decimalNumber = Convert.ToInt32(binaryString, 2);
                lblResult.Text = "Ondalık Sayı: " + decimalNumber.ToString(); 
            }
            catch (FormatException)
            {
                lblResult.Text = "Geçersiz ikili sayı!";
            }
        }
    }
}
