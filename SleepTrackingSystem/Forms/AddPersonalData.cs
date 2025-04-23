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
using System.Xml.Linq;

namespace SleepTrackingSystem.Forms
{
    public partial class AddPersonalData : Form
    {
        private PersonalDataF? personalData;
        public AddPersonalData()
        {
            InitializeComponent();
            InitializingInterfaceElements();
        }

        private void InitializingInterfaceElements()
        {
            lab_title.Font = new Font("Arial", 20, FontStyle.Bold);
            lab_title.AutoSize = true;
            lab_title.Location = new Point((this.ClientSize.Width - lab_title.Width) / 2, 20);
            lab_title.ForeColor = Color.White;

            lab_name.Font = new Font("Arial", 12);
            lab_name.Location = new Point(50, 80);
            lab_name.ForeColor = Color.White;

            textBox_name.Font = new Font("Arial", 12);
            textBox_name.Location = new Point(150, 80);
            textBox_name.Width = 200;

            lab_gender.Font = new Font("Arial", 12);
            lab_gender.Location = new Point(50, 120);
            lab_gender.ForeColor = Color.White;

            comboBox_gender.Font = new Font("Arial", 12);
            comboBox_gender.Location = new Point(150, 120);
            comboBox_gender.Width = 200;

            lab_dateBirth.Font = new Font("Arial", 12);
            lab_dateBirth.Text = "Дата\nрождения";
            lab_dateBirth.Location = new Point(50, 160);
            lab_dateBirth.ForeColor = Color.White;

            dateTimePicker_birthDate.Font = new Font("Arial", 12);
            dateTimePicker_birthDate.Location = new Point(150, 160);
            dateTimePicker_birthDate.Width = 200;

            but_apply.Font = new Font("Arial", 16);
            but_apply.Location = new Point(60, 250);
            but_apply.ForeColor = Color.White;
            but_apply.BackColor = Color.MediumPurple;
            but_apply.Cursor = Cursors.Hand;

            but_cancel.Font = new Font("Arial", 16);
            but_cancel.Location = new Point(220, 250);
            but_cancel.ForeColor = Color.White;
            but_cancel.BackColor = Color.MediumPurple;
            but_cancel.Cursor = Cursors.Hand;
        }
        // Добавление личных данных в базу данных, с проверками
        private void but_apply_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_name.Text))
                {
                    MessageBox.Show("Имя не может быть пустым.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (comboBox_gender.SelectedItem == null)
                {
                    MessageBox.Show("Пожалуйста, выберите пол.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dateTimePicker_birthDate.Value > DateTime.Now)
                {
                    MessageBox.Show("Дата рождения не может быть в будущем.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var context = new ApplicationContext())
                {
                    var persData = context.PersonalData.FirstOrDefault(pd => pd.UserId == CurrentUser.UserId);
                    if (persData == null)
                    {

                        persData = new PersonalData
                        {
                            UserId = CurrentUser.UserId,
                            Name = textBox_name.Text,
                            Gender = comboBox_gender.SelectedItem.ToString(),
                            BirthDate = dateTimePicker_birthDate.Value.ToUniversalTime(),
                        };
                        context.Add(persData);
                        MessageBox.Show("Данные успешно добавлены!");
                    }
                    else
                    {
                        persData.Name = textBox_name.Text;
                        persData.Gender = comboBox_gender.SelectedItem.ToString();
                        persData.BirthDate = dateTimePicker_birthDate.Value.ToUniversalTime();
                        MessageBox.Show("Данные успешно обновлены!");
                    }
                    context.SaveChanges();
                    this.Close();
                }

                personalData = Application.OpenForms["PersonalDataF"] as PersonalDataF;
                if (personalData != null)
                {
                    personalData = new PersonalDataF();
                    personalData.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void but_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
