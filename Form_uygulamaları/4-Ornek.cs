using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace if_else_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (radioButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (radioButton3.Checked)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                MessageBox.Show("Renk seçimi yapın.");
            }
 
        }
    }
}
