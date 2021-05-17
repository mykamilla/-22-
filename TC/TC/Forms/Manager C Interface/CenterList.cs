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
    public partial class CenterList : Form
    {

        TCADO db = new TCADO();
        public CenterList()
        {
            InitializeComponent();
        }

        private void CenterList_Load(object sender, EventArgs e)
        {
            арендаBindingSource.DataSource = db.Аренда.ToList();
            //арендаBindingSource.Sort = "Адрес Desc";
            //арендаBindingSource.Sort = "Статус Desc";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // находим объект для записи, которую выбрал пользователь
            Аренда аренда = (Аренда)арендаBindingSource.Current;
            // показываем диалоговое окно с кнопками Yes и No
            DialogResult dr = MessageBox.Show(" Вы действительно хотите удалить торговый центр под номером - " + аренда.ID_Аренды,
            " Удаление ТЦ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // если пользователь нажал кнопку «Да», то удаляем данные из БД
            if (dr == DialogResult.Yes)
            {
                // удаление записи из базы данных
                db.Аренда.Remove(аренда);

                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                арендаBindingSource.DataSource = db.Аренда.ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // создаем новую объект формы для изменения данных
            CenterInteface ci = new CenterInteface();
            // Находим объект, который выбрал пользователь (текущий)
            Аренда аренда = (Аренда)арендаBindingSource.Current;
            // передаем данные в форму
            ci.db = db;
            ci.аренда = аренда;
            // Показываем форму в диалоговом режиме
            DialogResult dr = ci.ShowDialog();
            // если измененные данные сохранены в БД, то таблицу обновим
            if (dr == DialogResult.OK)
            {
                арендаBindingSource.DataSource = db.Аренда.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // создаем новый объект формы для добавления данных
            AddCenter ad = new AddCenter();
            // передаем в новую форму объект модели DB
            ad.db = db;
            // показываем форму в диалоговом режиме
            DialogResult dr = ad.ShowDialog();
            if (dr == DialogResult.OK)
            { // если данные были добавлены к БД, то обновляем содержание
              // промежуточного объекта!
                арендаBindingSource.DataSource = db.Аренда.ToList();
            }
        }
    }
}
