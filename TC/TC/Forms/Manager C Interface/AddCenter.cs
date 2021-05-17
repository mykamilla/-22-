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
    public partial class AddCenter : Form
    {
        public TCADO db { get; set; }
        public AddCenter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // проверяем, что имеется минимум необходимых данных
            if (iD_АрендатораTextBox.Text == "")
            {
                MessageBox.Show("Нужно ввести все требуемые данные!");
                return;
            }
            //добавление новой записи в таблицу БД
            // создаем новый объект
            Аренда аренда = new Аренда();
            // задаем свойства объекта
            аренда.ID_Арендатора = iD_АрендатораTextBox.Text;
            аренда.ID_Аренды = iD_АрендыTextBox.Text;
            аренда.ID_Сотрудник = iD_СотрудникTextBox.Text;
            аренда.Адрес = адресTextBox.Text;
            аренда.Название = названиеTextBox.Text;
            аренда.Начало_Аренды = начало_АрендыTextBox.Text;
            аренда.Окончание_Аренды = окончание_АрендыTextBox.Text;
            аренда.Павильона = павильонаTextBox.Text;
            аренда.Статус = статусTextBox.Text;
            аренда.ТЦ = тЦTextBox.Text;

            // добавляем новый объект к коллекции        
            db.Аренда.Add(аренда);
            try
            {
                // сохраняем изменения коллекции в БД
                db.SaveChanges();
                // задаем свойство DialogResult, чтобы закрыть форму
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            { // сложная конструкция для показа сообщений сервера БД
                MessageBox.Show(ex.InnerException.InnerException.Message);
            }
        }
    }
}
