using SleepTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SleepTrackingSystem.Forms
{
    public partial class PersonalAccount : Form
    {
        private int userId;

        public PersonalAccount()
        {
            InitializeComponent();
            userId = CurrentUser.UserId;
            this.MaximizeBox = false;
            InitializingInterfaceElements();
            LoadProfilePhoto();
        }

        private void InitializingInterfaceElements()
        {
            lab_persAcc.Font = new Font("Arial", 20, FontStyle.Bold);
            lab_persAcc.Location = new Point((panel_tab.Width - lab_persAcc.Width) / 2, 20);
            lab_persAcc.ForeColor = Color.White;

            lab_welc.Font = new Font("Arial", 16);
            lab_welc.Location = new Point((panel_tab.Width - lab_welc.Width) / 2, 70);
            lab_welc.ForeColor = Color.White;

            pictureBox_photo.Size = new Size(150, 150);
            pictureBox_photo.Location = new Point(20, 120);
            pictureBox_photo.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_photo.SizeMode = PictureBoxSizeMode.Zoom;

            but_addPhoto.Font = new Font("Arial", 12);
            but_addPhoto.Location = new Point(180, 140);
            but_addPhoto.ForeColor = Color.White;
            but_addPhoto.BackColor = Color.MediumPurple;
            but_addPhoto.Cursor = Cursors.Hand;

            but_save.Font = new Font("Arial", 12);
            but_save.Location = new Point(180, 180);
            but_save.ForeColor = Color.White;
            but_save.BackColor = Color.MediumPurple;
            but_save.Cursor = Cursors.Hand;

            //lab_profile.Font = new Font("Arial", 16);
            //lab_profile.Text = "Профиль";
            //lab_profile.Location = new Point(20, 150);
            //lab_profile.ForeColor = Color.White;
            //lab_profile.Cursor = Cursors.Hand;
            //lab_profile.BackColor = Color.MediumPurple;

            lab_personalData.Font = new Font("Arial", 16);
            lab_personalData.Text = "Личные данные";
            lab_personalData.Location = new Point(20, 320);
            lab_personalData.ForeColor = Color.White;
            lab_personalData.Cursor = Cursors.Hand;
            lab_personalData.BackColor = Color.MediumPurple;

            lab_settingAccount.Font = new Font("Arial", 16);
            lab_settingAccount.Text = "Настройка\nучетной записи";
            lab_settingAccount.Location = new Point(20, 370);
            lab_settingAccount.ForeColor = Color.White;
            lab_settingAccount.Cursor = Cursors.Hand;
            lab_settingAccount.BackColor = Color.MediumPurple;

            lab_returnToTheMainMenu.Font = new Font("Arial", 14);
            lab_returnToTheMainMenu.Text = "Вернуться в\nглавное меню";
            lab_returnToTheMainMenu.Location = new Point((panel_tab.Width - lab_returnToTheMainMenu.Width) / 2, 580);
            lab_returnToTheMainMenu.ForeColor = Color.White;
            lab_returnToTheMainMenu.Cursor = Cursors.Hand;
            lab_returnToTheMainMenu.BackColor = Color.MediumPurple;

            LoadWelcName();
        }
        private void PersonalAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = Application.OpenForms["MainMenu"] as MainMenu;
            if (mainMenu != null)
            {
                mainMenu.Show();

            }
        }
        //private void lab_profile_Click(object sender, EventArgs e)
        //{
        //    Profile profile = new Profile();
        //    OpenFormsInPanel(profile);
        //}
        private void lab_personalData_Click(object sender, EventArgs e)
        {
            PersonalDataF personalData = new PersonalDataF();
            OpenFormsInPanel(personalData);
        }

        private void lab_settingAccount_Click(object sender, EventArgs e)
        {
            SettingAccount settingAccount = new SettingAccount();
            OpenFormsInPanel(settingAccount);
        }
        // Метод открывает форму в панели, закрывая предыдущую, если она есть.
        private void OpenFormsInPanel(Form form)
        {
            if (panel_openForms.Controls.Count > 0)
                panel_openForms.Controls[0].Dispose();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel_openForms.Controls.Add(form);
            panel_openForms.Tag = form;
            form.Show();
        }
        // Метод загружает имя пользователя из базы данных и отображает его
        private void LoadWelcName()
        {
            using (var context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == CurrentUser.UserId);
                if (user != null)
                {
                    lab_welc.Text = user.Login;
                }
                else
                {
                    lab_welc.Text = "Не указано";
                }
            }
        }
        private void lab_returnToTheMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Метод обрабатывает клик по кнопке "Добавить фото".
        // Открывает диалог выбора файла и отображает выбранное изображение в PictureBox
        private void but_addPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox_photo.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
        // Сохраняет выбранное фото в базе данных
        private void but_save_Click(object sender, EventArgs e)
        {
            if (pictureBox_photo.Image != null)
            {
                using (var memoryStream = new MemoryStream())
                {
                    pictureBox_photo.Image.Save(memoryStream, pictureBox_photo.Image.RawFormat);
                    byte[] photoBytes = memoryStream.ToArray();

                    using (var context = new ApplicationContext())
                    {
                        var user = context.Users.FirstOrDefault(u => u.Id == userId);
                        if (user != null)
                        {
                            user.Photo = photoBytes;
                            context.SaveChanges();
                            MessageBox.Show("Фото успешно сохранено.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Выберите фото перед сохранением.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // Метод загружает фото пользователя из базы данных и отображает его
        private void LoadProfilePhoto()
        {
            using (var context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                if (user != null && user.Photo != null)
                {
                    using (var memoryStream = new MemoryStream(user.Photo))
                    {
                        pictureBox_photo.Image = Image.FromStream(memoryStream);
                    }
                }
            }
        }
    }
}
