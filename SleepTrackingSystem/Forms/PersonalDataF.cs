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
    public partial class PersonalDataF : Form
    {
        private int userId;
        public PersonalDataF()
        {
            InitializeComponent();
            userId = CurrentUser.UserId;
            InitializingInterfaceElements();
        }
        private void InitializingInterfaceElements()
        {
            lab_title.Font = new Font("Arial", 24, FontStyle.Bold);
            lab_title.Location = new Point((ClientSize.Width - lab_title.Width) / 2, 20);
            lab_title.ForeColor = Color.White;

            lab_basicData.Font = new Font("Arial", 24);
            lab_basicData.Location = new Point(30, 70);
            lab_basicData.ForeColor = Color.White;

            lab_name.Font = new Font("Arial", 16);
            lab_name.Location = new Point(30, 120);
            lab_name.ForeColor = Color.White;

            lab_showName.Font = new Font("Arial", 16);
            lab_showName.Location = new Point(120, 120);
            lab_showName.ForeColor = Color.White;

            lab_gender.Font = new Font("Arial", 16);
            lab_gender.Location = new Point(30, 170);
            lab_gender.ForeColor = Color.White;

            lab_showGender.Font = new Font("Arial", 16);
            lab_showGender.Location = new Point(120, 170);
            lab_showGender.ForeColor = Color.White;

            lab_dateBirth.Font = new Font("Arial", 16);
            lab_dateBirth.Location = new Point(30, 220);
            lab_dateBirth.ForeColor = Color.White;

            lab_showDateBirth.Font = new Font("Arial", 16);
            lab_showDateBirth.Location = new Point(250, 220);
            lab_showDateBirth.ForeColor = Color.White;

            lab_contact.Font = new Font("Arial", 24);
            lab_contact.Location = new Point(30, 290);
            lab_contact.ForeColor = Color.White;

            lab_email.Font = new Font("Arial", 16);
            lab_email.Location = new Point(30, 340);
            lab_email.ForeColor = Color.White;

            lab_showEmail.Font = new Font("Arial", 16);
            lab_showEmail.Location = new Point(180, 340);
            lab_showEmail.ForeColor = Color.White;

            lab_info.Font = new Font("Arial", 12);
            lab_info.Text = "Здесь отображается ваши данные, они не обязательны, но все же.\nЕсли захотите их добавить, то пути назад уже не будет\nДобавить или изменить их можно нажав на кнопку ниже.";
            lab_info.Location = new Point(30, 430);
            lab_info.ForeColor = Color.White;

            but_addData.Font = new Font("Arial", 16);
            but_addData.Location = new Point(110, 510);
            but_addData.ForeColor = Color.White;
            but_addData.Cursor = Cursors.Hand;

            LoadEmail();
            LoadPersonalData();
        }
        // ЗАкрузка почты и ее вывод
        private void LoadEmail()
        {
            using (var context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == CurrentUser.UserId);
                if (user != null)
                {
                    lab_showEmail.Text = user.Email;
                }
                else
                {
                    lab_showEmail.Text = "Не указано";
                }
            }
        }
        private void but_addData_Click(object sender, EventArgs e)
        {
            AddPersonalData addPersonalData = new AddPersonalData();
            addPersonalData.ShowDialog();
            LoadPersonalData();
        }
       //Выводит личные данные из базы данных
        private void LoadPersonalData()
        {
            using (var context = new ApplicationContext())
            {
                var persData = context.PersonalData.FirstOrDefault(u => u.UserId == CurrentUser.UserId);
                if(persData != null)
                {
                    lab_showName.Text = persData.Name;
                    lab_showGender.Text = persData.Gender;
                    lab_showDateBirth.Text = $"{persData.BirthDate:dd.MM.yyyy}";
                }
                else
                {
                    lab_showName.Text = "Не указано";
                    lab_showGender.Text = "Не указано";
                    lab_showDateBirth.Text = "Не указано";
                }
            }
        }
    }
}
