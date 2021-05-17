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
    public partial class CenterInteface : Form
    {
        public TCADO db { get; set; }
        public Аренда аренда { get; set; }
        public CenterInteface()
        {
            InitializeComponent();
        }

        private void CenterInteface_Load(object sender, EventArgs e)
        {
            iD_АрендыTextBox.Text = аренда.ID_Аренды;
            iD_СотрудникTextBox.Text = аренда.ID_Сотрудник.ToString();
            адресTextBox.Text = аренда.Адрес;
            названиеTextBox.Text = аренда.Название;
            начало_арендыtextBox1.Text = аренда.Начало_Аренды;
            окончание_арендыtextBox2.Text = аренда.Окончание_Аренды;
            павильонаTextBox.Text = аренда.Павильона;
            статусTextBox.Text = аренда.Статус;
            тЦTextBox.Text = аренда.ТЦ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // сохраняем введенное пользователем значение в свойство объекта         
            аренда.ID_Аренды = iD_АрендыTextBox.Text;
            аренда.ID_Сотрудник = iD_СотрудникTextBox.Text;
            аренда.Адрес = адресTextBox.Text;
            аренда.Название = названиеTextBox.Text;
            аренда.Начало_Аренды = начало_арендыtextBox1.Text;
            аренда.Окончание_Аренды = окончание_арендыtextBox2.Text;
            аренда.Павильона = павильонаTextBox.Text;
            аренда.Статус = статусTextBox.Text;
            аренда.ТЦ = тЦTextBox.Text;
            // теперь пытаемся сохранить измененный объект в БД
            try
            {
                // сохраняем изменения, сделанные в объектах коллекции в БД
                db.SaveChanges();
                // задаем свойство DialogResult, чтобы закрыть форму
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            { // если произошла ошибка - сообщаем
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }
    }
}
