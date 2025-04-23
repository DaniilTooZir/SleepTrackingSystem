using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SleepTrackingSystem.Models;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;
using System.Net;

namespace SleepTrackingSystem
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            InitializingInterfaceElements();
        }
        private void InitializingInterfaceElements()
        {
            ToolTip toolTip = new ToolTip();
            lab_title.Font = new Font("Arial", 20, FontStyle.Bold);
            lab_title.AutoSize = true;
            lab_title.Location = new Point((this.ClientSize.Width - lab_title.Width) / 2, 20);

            lab_login.Font = new Font("Arial", 12);
            lab_login.Location = new Point(50, 80);
            textBox_login.Font = new Font("Arial", 12);
            textBox_login.Location = new Point(200, 80);
            textBox_login.Width = 150;
            toolTip.SetToolTip(textBox_login, "Введите ваш логин (только буквы и цифры).");

            lab_mail.Font = new Font("Arial", 12);
            lab_mail.Location = new Point(50, 130);
            textBox_email.Font = new Font("Arial", 12);
            textBox_email.Location = new Point(200, 130);
            textBox_email.Width = 150;
            toolTip.SetToolTip(textBox_email, "Введите ваш email.");

            lab_password.Font = new Font("Arial", 12);
            lab_password.Location = new Point(50, 180);
            textBox_password.Font = new Font("Arial", 12);
            textBox_password.Location = new Point(200, 180);
            textBox_password.Width = 150;
            toolTip.SetToolTip(textBox_password, "Введите ваш пароль.");

            lab_replayPassw.Font = new Font("Arial", 12);
            lab_replayPassw.Location = new Point(50, 230);
            textBox_replayPassw.Font = new Font("Arial", 12);
            textBox_replayPassw.Location = new Point(200, 230);
            textBox_replayPassw.Width = 150;
            toolTip.SetToolTip(textBox_replayPassw, "Повторите ваш пароль.");

            but_reg.Font = new Font("Arial", 13, FontStyle.Bold);
            but_reg.Location = new Point((this.ClientSize.Width - but_reg.Width) / 2, 270);
            but_reg.Cursor = Cursors.Hand;
            toolTip.SetToolTip(but_reg, "Нажмите для того, чтобы зарегестрироваться.");

            lab_back.Font = new Font("Arial", 13, FontStyle.Bold);
            lab_back.Location = new Point((this.ClientSize.Width - lab_back.Width) / 2, 310);
            lab_back.Cursor = Cursors.Hand;
            toolTip.SetToolTip(but_reg, "Нажмите для того, чтобы верунться к авторизации.");
        }
        // Метод на проверку валидност данных
        private bool ProcessingRegistration(string login, string email, string password, string replayPassword)
        {
            // Проверка на пустые поля
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(replayPassword))
            {
                MessageBox.Show("Все поля должны быть заполнены.");
                return false;
            }
            // Проверка на совпадение паролей
            if (password != replayPassword)
            {
                MessageBox.Show("Пароли не совпадают.");
                return false;
            }
            // Проверка на корректность логина
            if (!IsValidLogin(login))
            {
                MessageBox.Show("Логин должен содержать не менее 3 символов и состоять только из букв и цифр.");
                return false;
            }
            // Проверка на корректность email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Введите корректный адрес электронной почты.");
                return false;
            }
            // Проверка на корректность пароля
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Пароль должен содержать не менее 3 символов и состоять только из букв и цифр.");
                return false;
            }
            return true;
        }
        private void but_reg_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ProcessingRegistration(textBox_login.Text, textBox_email.Text, textBox_password.Text, textBox_replayPassw.Text))
                    return;
                using (var context = new ApplicationContext())
                {
                    // Проверка на наличие пользователя с таким же логином
                    if (context.Users.Any(u => u.Login == textBox_login.Text))
                    {
                        MessageBox.Show("Этот логин уже занят.");
                        return;
                    }
                    // Проверка на наличие пользователя с таким же email
                    if (context.Users.Any(u => u.Email == textBox_email.Text))
                    {
                        MessageBox.Show("Этот email уже используется.");
                        return;
                    }
                    var user = new User
                    {
                        Login = textBox_login.Text,
                        Password = textBox_password.Text,
                        Email = textBox_email.Text
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                MessageBox.Show("Регистрациия прошла успешно.");
                this.Close();
                Authorization authorization = new Authorization();
                authorization.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при регистрации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lab_back_Click(object sender, EventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            this.Close();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                string emailPattern = @"^[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*@[a-zA-Z]+\.[a-zA-Z]+$";
                if (!Regex.IsMatch(email, emailPattern)) // Проверка на соответствие шаблону
                    return false;
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email) // Проверка на действительность email
                    return false;

                string domain = email.Split('@')[1]; // Проверка на существование домена
                return DomainExists(domain);
            }
            catch
            {
                return false;
            }
        }
        // Метод для проверки корректности логина
        private bool IsValidLogin(string login)
        {
            // Логин должен быть не менее 3 символов и содержать только буквы и цифры
            return login.Length >= 3 && login.All(c => char.IsLetterOrDigit(c));
        }
        // Метод для проверки корректности пароля
        private bool IsValidPassword(string password)
        {
            // Пароль должен содержать не менее 3 символов
            return password.Length >= 3;
        }
        // Метод для проверки существования домена
        private static bool DomainExists(string domain)
        {
            try
            {
                var hostEntry = Dns.GetHostEntry(domain);
                return hostEntry.AddressList.Length > 0;
            }
            catch
            {
                return false;
            }
        }
        // Обработчик нажатия клавиши в поле email (проверка ввода только букв, цифр, точки и @)
        private void textBox_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
