using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC
{
    public partial class Captcha : Form
    {
        public Captcha()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1.Text == "яебу")
            {
                MessageBox.Show("Капча успешно введена");
                Autorization au = new Autorization();
                au.Show();
                this.Close();
            }
           else
            {
                MessageBox.Show("Долбоеб попробуй еще раз");
            }
        }
    }
}
