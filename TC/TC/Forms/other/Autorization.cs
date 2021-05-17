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
    public partial class Autorization : Form
    {
        public static Autorization AUT { get; set; }
        // открытое статическое свойство для хранения объекта класса USER 
        // для передачи данных о пользователе другим формам
        public static Сотрудники USER { get; set; }

        // закрытое поле хранит объект модели 
        // для использования данных о пользователях в методах класса
        TCADO db = new TCADO();
        int captha = 0;
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            // проверяем, что в текстовые поля введены данные
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пароль!");
                return;
            }

            // ищем в коллекции с именем Users, объект типа Users 
            // с введенным логином – первичным ключем
            Сотрудники usr = db.Сотрудники.Find(textBox1.Text);

            // если такой пользователь есть (не равен null) 
            // и его пароль совпадает с введенным значением
            if ((usr != null) && (usr.Пароль == textBox2.Text))
            {
                // сохраняем данные пользователя в статической переменной
                // для использования данных пользователя в других формах
                USER = usr;

                // сохраняем ссылку на данную форму в статической переменной
                // для возврата к этой форме      
                AUT = this;

                // проверяем роль пользователя
                // если роль = «Директор», то вызываем форму Директора
                if (usr.Роль == "Администратор")
                {
                    // создаем форму директора
                    Admin frm = new Admin();
                    // показываем форму директора
                    frm.Show();
                    //  форму подключения скрываем (но не закрываем!)
                    this.Hide();
                }
                // если роль = «Менеджер», то вызываем форму Менеджера
                else if (usr.Роль == "Менеджер А")
                {
                    // создаем форму менеджера
                    ManagerA frm = new ManagerA();
                    // показываем форму менеджера
                    frm.Show();
                    // начальную форму подключения скрываем (но не закрываем!)
                    this.Hide();
                }
                // если роль = «Администратор», то вызываем форму Администратора
                else if (usr.Роль == "Менеджер С")
                {
                    // создаем форму администратора
                    ManagerC frm = new ManagerC();
                    // показываем форму администратора
                    frm.Show();
                    // начальную форму подключения скрываем (но не закрываем!)
                    this.Hide();
                }
                else if (usr.Роль == "Удален")
                {
                    MessageBox.Show($"Роль {usr.Роль} удалена!");
                    return;
                }
                else // если такой роли нет
                {
                    // если данные введены неправильно, то показываем сообщение
                    MessageBox.Show("Вы удалены из системы!");
                    return;
                }
            }
            else
            {
                // если данные введены неправильно, то показываем сообщение
                MessageBox.Show("Пользователя с таким логином и паролем нет!");
                captha++;
                if (captha >= 3)
                {
                    MessageBox.Show("Введите капчу");
                    Captcha cpt = new Captcha();
                    cpt.Show();
                    this.Hide();
                }
                return;               
            }
            

            }

        private void Autorization_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
