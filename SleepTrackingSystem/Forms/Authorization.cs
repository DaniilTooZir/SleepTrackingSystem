using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing;
using SleepTrackingSystem.Models;
using System.Net;

namespace SleepTrackingSystem
{
    public partial class Authorization : Form
    {
        bool isStHide;
        public Authorization()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            InitializingInterfaceElements();
        }
        private void InitializingInterfaceElements()
        {
            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip()
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 200,
                ShowAlways = true
            };

            lab_auth.Font = new Font("Arial", 20, FontStyle.Bold);
            lab_auth.AutoSize = true;
            lab_auth.Location = new Point((this.ClientSize.Width - lab_auth.Width) / 2, 20);

            lab_login.Font = new Font("Arial", 15);
            lab_login.Location = new Point(50, 80);

            textBox_login.Font = new Font("Arial", 8);
            textBox_login.Location = new Point(150, 80);
            textBox_login.Width = 200;
            toolTip.SetToolTip(textBox_login, "Введите ваш логин.");

            lab_password.Font = new Font("Arial", 15);
            lab_password.Location = new Point(50, 120);

            textBox_login.Font = new Font("Arial", 14);
            textBox_password.Location = new Point(150, 120);
            textBox_password.Width = 200;
            toolTip.SetToolTip(textBox_password, "Введите ваш пароль.");

            but_logIn.Font = new Font("Arial", 14, FontStyle.Bold);
            but_logIn.Location = new Point((this.ClientSize.Width - but_logIn.Width) / 2, 160);
            but_logIn.Cursor = Cursors.Hand;
            toolTip.SetToolTip(but_logIn, "Нажмите, чтобы войти.");

            lab_reg.Font = new Font("Arial", 14, FontStyle.Bold);
            lab_reg.AutoSize = true;
            lab_reg.Location = new Point((this.ClientSize.Width - lab_reg.Width) / 2, 210);
            lab_reg.Cursor = Cursors.Hand;
            toolTip.SetToolTip(lab_reg, "Нажмите, чтобы перейти к регистрации.");

            lab_guestLogin.Font = new Font("Arial", 12);
            lab_guestLogin.AutoSize = true;
            lab_guestLogin.Location = new Point((this.ClientSize.Width - lab_guestLogin.Width) / 2, 250);
            lab_guestLogin.Cursor = Cursors.Hand;
            lab_guestLogin.ForeColor = Color.Gray;
            toolTip.SetToolTip(lab_guestLogin, "Нажмите, чтобы войти как гость.");
        }
        private void but_logIn_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка, заполнены ли поля логина и пароля
                if (string.IsNullOrWhiteSpace(textBox_login.Text) || string.IsNullOrWhiteSpace(textBox_password.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                using (var context = new ApplicationContext())
                {
                    // Поиск пользователя, чьи логин и пароль совпадают с введенными, в базе данных 
                    var user = context.Users.FirstOrDefault(u => u.Login == textBox_login.Text && u.Password == textBox_password.Text);
                    if (user != null)
                    {
                        // Сохранение ID текущего пользователя и переход в главное меню
                        CurrentUser.UserId = user.Id;
                        MessageBox.Show("Авторизация успешна!");
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        StartTab? startTab = (Application.OpenForms["StartTab"] as StartTab);
                        if (startTab != null)
                        {
                            startTab.Hide();
                        }
                        this.Hide();
                    }
                    else
                    {
                        Authorization authorization = new Authorization();
                        MessageBox.Show("Логин или пароль введены неверно. Проверьте данные и попробуйте снова.", "Ошибка авторизации",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Dispose();
                        authorization.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при авторизации: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lab_reg_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
        // Раализация функции гостевого входа в систему
        private void lab_guestLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using(var context = new ApplicationContext())
                {
                    var guestUser = new User
                    {
                        Login = $"Guest_{Guid.NewGuid().ToString().Substring(0, 8)}",
                        Password = Guid.NewGuid().ToString(),
                        Email = null,
                        IsGuest = true
                    };
                    context.Users.Add(guestUser);
                    context.SaveChanges();
                    CurrentUser.UserId = guestUser.Id;
                    MessageBox.Show("Вход выполнен как гость!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    StartTab? startTab = (Application.OpenForms["StartTab"] as StartTab);
                    if (startTab != null)
                    {
                        startTab.Hide();
                    }
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
