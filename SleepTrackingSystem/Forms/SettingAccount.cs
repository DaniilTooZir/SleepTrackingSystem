using SleepTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepTrackingSystem.Forms
{
    public partial class SettingAccount : Form
    {
        private PersonalAccount? personalAccount;
        private MainMenu? mainMenu;
        private int userId;
        public SettingAccount()
        {
            InitializeComponent();
            userId = CurrentUser.UserId;
            InitializingInterfaceElements();
            LoadUserData();
        }
        private void InitializingInterfaceElements()
        {
            lab_settingAcc.Font = new Font("Arial", 24, FontStyle.Bold);
            lab_settingAcc.Location = new Point((ClientSize.Width - lab_settingAcc.Width) / 2, 20);
            lab_settingAcc.ForeColor = Color.White;

            lab_login.Font = new Font("Arial", 16);
            lab_login.Location = new Point(30, 120);
            lab_login.ForeColor = Color.White;

            lab_showLogin.Font = new Font("Arial", 16);
            lab_showLogin.Location = new Point(160, 120);
            lab_showLogin.ForeColor = Color.White;

            textBox_login.Font = new Font("Arial", 16);
            textBox_login.Location = new Point(160, 120);
            textBox_login.Width = 200;
            textBox_login.Visible = false;

            lab_email.Font = new Font("Arial", 16);
            lab_email.Location = new Point(30, 170);
            lab_email.ForeColor = Color.White;

            lab_showEmail.Font = new Font("Arial", 16);
            lab_showEmail.Location = new Point(160, 170);
            lab_showEmail.ForeColor = Color.White;

            textBox_email.Font = new Font("Arial", 16);
            textBox_email.Location = new Point(160, 170);
            textBox_email.Width = 200;
            textBox_email.Visible = false;

            lab_password.Font = new Font("Arial", 16);
            lab_password.Location = new Point(30, 220);
            lab_password.ForeColor = Color.White;

            textBox_password.Font = new Font("Arial", 16);
            textBox_password.Location = new Point(160, 220);
            textBox_password.Width = 200;
            textBox_password.Visible = false;

            but_changeLogin.Font = new Font("Arial", 16);
            but_changeLogin.Location = new Point(150, 300);
            but_changeLogin.Text = "Изменить логин";
            but_changeLogin.ForeColor = Color.White;
            but_changeLogin.BackColor = Color.MediumPurple;
            but_changeLogin.Cursor = Cursors.Hand;

            but_changeEmail.Font = new Font("Arial", 16);
            but_changeEmail.Location = new Point(150, 340);
            but_changeEmail.Text = "Изменить почту";
            but_changeEmail.ForeColor = Color.White;
            but_changeEmail.BackColor = Color.MediumPurple;
            but_changeEmail.Cursor = Cursors.Hand;

            but_changePassword.Font = new Font("Arial", 16);
            but_changePassword.Location = new Point(150, 380);
            but_changePassword.Text = "Изменить пароль";
            but_changePassword.ForeColor = Color.White;
            but_changePassword.BackColor = Color.MediumPurple;
            but_changePassword.Cursor = Cursors.Hand;

            but_logOut.Font = new Font("Arial", 16);
            but_logOut.Location = new Point(150, 420);
            but_logOut.Text = "Выйти";
            but_logOut.ForeColor = Color.White;
            but_logOut.BackColor = Color.MediumPurple;
            but_logOut.Cursor = Cursors.Hand;

            but_deleteAccount.Font = new Font("Arial", 16);
            but_deleteAccount.Location = new Point(150, 460);
            but_deleteAccount.Text = "Удалить учетную\nзапись";
            but_deleteAccount.ForeColor = Color.White;
            but_deleteAccount.BackColor = Color.Red;
            but_deleteAccount.Cursor = Cursors.Hand;

            but_save.Font = new Font("Arial", 16);
            but_save.Location = new Point(450, 320);
            but_save.Text = "Сохранить\nизменения";
            but_save.ForeColor = Color.White;
            but_save.BackColor = Color.MediumPurple;
            but_save.Cursor = Cursors.Hand;

            but_cancel.Font = new Font("Arial", 16);
            but_cancel.Location = new Point(450, 400);
            but_cancel.Text = "Отмена";
            but_cancel.ForeColor = Color.White;
            but_cancel.BackColor = Color.MediumPurple;
            but_cancel.Cursor = Cursors.Hand;
        }
        // Метод загружает данные пользователя (логин и email) из базы данных и отображает их на форме
        private void LoadUserData()
        {
            using (var context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                {
                    lab_showLogin.Text = user.Login;
                    lab_showEmail.Text = user.Email;
                }
            }
        }
        // Метод, который делает поле для ввода логина видимым
        private void but_changeLogin_Click(object sender, EventArgs e)
        {
            textBox_login.Visible = true;
            textBox_login.Text = lab_showLogin.Text;
            lab_showLogin.Visible = false;
            but_changeLogin.Visible = false;
        }
        // Метод, который делает поле для ввода почты видимым
        private void but_changeEmail_Click(object sender, EventArgs e)
        {
            textBox_email.Visible = true;
            textBox_email.Text = lab_showEmail.Text;
            lab_showEmail.Visible = false;
            but_changeEmail.Visible = false;
        }

        private void but_changePassword_Click(object sender, EventArgs e)
        {
            textBox_password.Visible = true;
            but_changePassword.Visible = false;
        }
        // Выход из учетной записи
        private void but_logOut_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите выйти из учетной записи?", "Выйти?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
                Application.Restart();
        }
        // Удаление учетной записи
        private void but_deleteAccount_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить учетную запись?", "Удаление учетной записи", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                using (var context = new ApplicationContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.Id == userId);
                    if (user != null)
                    {
                        context.Users.Remove(user);
                        context.SaveChanges();
                        MessageBox.Show("Ваша учетная запись была удалена.");
                        Application.Restart();
                    }
                }
            }
        }
        // Сохранение введеных данных
        private void SaveChanges()
        {
            if (!Processing(textBox_login.Text, textBox_email.Text, textBox_password.Text))
                return;
            using (var context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                if (user != null)
                {
                    if (!string.IsNullOrWhiteSpace(textBox_login.Text))
                        user.Login = textBox_login.Text;
                    if (!string.IsNullOrWhiteSpace(textBox_email.Text))
                        user.Email = textBox_email.Text;
                    if (!string.IsNullOrWhiteSpace(textBox_password.Text))
                        user.Password = textBox_password.Text;
                    context.SaveChanges();
                    MessageBox.Show("Изменения успешно сохранены.");
                }
            }
            UpdatePersonalAccount();
        }
        private void UpdatePersonalAccount()
        {
            personalAccount = Application.OpenForms["PersonalAccount"] as PersonalAccount;
            if (personalAccount != null)
            {
                personalAccount.Close();
                personalAccount = new PersonalAccount();
                personalAccount.Show();
            }
            mainMenu = Application.OpenForms["MainMenu"] as MainMenu;
            if (mainMenu != null)
            {
                mainMenu.Hide();
            }
        }
        private void but_save_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
        private bool Processing(string login, string email, string password)
        {
            if (!string.IsNullOrWhiteSpace(login) && !IsValidLogin(login))
            {
                MessageBox.Show("Логин должен содержать не менее 3 символов и состоять только из букв и цифр.");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(email) && !IsValidEmail(email))
            {
                MessageBox.Show("Введите корректный адрес электронной почты.");
                return false;
            }
            if (!string.IsNullOrWhiteSpace(password) && !IsValidPassword(password))
            {
                MessageBox.Show("Пароль должен содержать не менее 3 символов.");
                return false;
            }
            return true;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                string emailPattern = @"^[a-zA-Z0-9]+(\.[a-zA-Z0-9]+)*@[a-zA-Z]+\.[a-zA-Z]+$";
                if (!Regex.IsMatch(email, emailPattern))
                    return false;
                var addr = new System.Net.Mail.MailAddress(email);
                if (addr.Address != email)
                    return false;

                string domain = email.Split('@')[1];
                return DomainExists(domain);
            }
            catch
            {
                return false;
            }
        }
        private bool IsValidLogin(string login)
        {
            return login.Length >= 3 && login.All(c => char.IsLetterOrDigit(c));
        }
        private bool IsValidPassword(string password)
        {
            return password.Length >= 3;
        }
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

        private void but_cancel_Click(object sender, EventArgs e)
        {
            ResetChanges();
        }
        private void ResetChanges()
        {
            textBox_login.Visible = false;
            textBox_email.Visible = false;
            textBox_password.Visible = false;

            lab_showLogin.Visible = true;
            lab_showEmail.Visible = true;
            but_changeLogin.Visible = true;
            but_changeEmail.Visible = true;
            but_changePassword.Visible = true;

            textBox_login.Text = string.Empty;
            textBox_email.Text = string.Empty;
            textBox_password.Text = string.Empty;

            LoadUserData();
        }
    }
}
