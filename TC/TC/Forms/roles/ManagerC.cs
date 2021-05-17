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
    public partial class ManagerC : Form
    {
        public ManagerC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // название формы краткое имя (переменная) = new название формы();
            // создаем форму администратора
            CenterList cl = new CenterList();
            // показываем форму администратора
            cl.Show();
            // начальную форму подключения скрываем (но не закрываем!)
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // создаем форму администратора
            PavilionList pl = new PavilionList();
            // показываем форму администратора
            pl.Show();
            // начальную форму подключения скрываем (но не закрываем!)
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // создаем форму администратора
            Autorization au = new Autorization();
            // показываем форму администратора
            au.Show();
            // начальную форму подключения скрываем (но не закрываем!)
            this.Close();
        }
    }
}
