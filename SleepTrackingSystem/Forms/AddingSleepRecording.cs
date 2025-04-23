using SleepTrackingSystem.Forms;
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

namespace SleepTrackingSystem
{
    public partial class AddingSleepRecording : Form
    {
        private SleepTracking? sleepTracking;
        private ApplicationContext Context;
        private int userId;
        public AddingSleepRecording(int idUser)
        {
            InitializeComponent();
            Context = new ApplicationContext();
            userId = idUser;
            this.MaximizeBox = false;
            InitializingInterfaceElements();

        }
        private void InitializingInterfaceElements()
        {
            ToolTip toolTip = new ToolTip()
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 200,
                ShowAlways = true
            };

            lab_addRecord.Font = new Font("Arial", 14, FontStyle.Bold);
            lab_addRecord.Location = new Point((this.ClientSize.Width - lab_addRecord.Width) / 2, 20);

            lab_date.Font = new Font("Arial", 10);
            lab_date.Location = new Point(20, 60);
            dateTimePicker_date.Location = new Point(160, 53);
            dateTimePicker_date.MinDate = DateTime.Now.AddYears(-2);

            lab_timeStart.Font = new Font("Arial", 10);
            lab_timeStart.Location = new Point(20, 100);
            dateTimePicker_tStart.Location = new Point(160, 93);

            lab_timeEnd.Font = new Font("Arial", 10);
            lab_timeEnd.Location = new Point(20, 140);
            dateTimePicker_tEnd.Location = new Point(160, 133);

            lab_sleepQuality.Font = new Font("Arial", 10);
            lab_sleepQuality.Location = new Point(20, 180);
            comboBox_quality.Location = new Point(160, 173);

            but_save.Font = new Font("Arial", 10);
            but_save.Location = new Point(60, 210);
            but_save.Cursor = Cursors.Hand;

            but_back.Font = new Font("Arial", 10);
            but_back.Location = new Point(200, 210);
            but_back.Cursor = Cursors.Hand;

            dateTimePicker_date.MaxDate = DateTime.Now;
            dateTimePicker_tStart.Format = DateTimePickerFormat.Time;
            dateTimePicker_tStart.ShowUpDown = true;
            dateTimePicker_tEnd.Format = DateTimePickerFormat.Time;
            dateTimePicker_tEnd.ShowUpDown = true;

            dateTimePicker_tStart.Format = DateTimePickerFormat.Custom;
            dateTimePicker_tStart.CustomFormat = "HH:mm";

            dateTimePicker_tEnd.Format = DateTimePickerFormat.Custom;
            dateTimePicker_tEnd.CustomFormat = "HH:mm";

            toolTip.SetToolTip(dateTimePicker_date, "Выберите дату записи.");
            toolTip.SetToolTip(dateTimePicker_tStart, "Выберите время начала сна.");
            toolTip.SetToolTip(dateTimePicker_tEnd, "Выберите время конца сна.");
            toolTip.SetToolTip(comboBox_quality, "Выберите качество сна.");
            toolTip.SetToolTip(but_save, "Сохранить запись.");
            toolTip.SetToolTip(but_back, "Вернуться назад.");
        }
        private void but_back_Click(object sender, EventArgs e)
        {
            sleepTracking = Application.OpenForms["SleepTracking"] as SleepTracking;
            if (sleepTracking != null)
            {
                sleepTracking.Close();
            }
            if (sleepTracking == null || sleepTracking.IsDisposed)
            {
                sleepTracking = new SleepTracking(userId);
                sleepTracking.Show();
                this.Close();
            }
            else
            {
                sleepTracking.Refresh();
                sleepTracking.Activate();
            }
        }
        // Добавление записи в базу данных
        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date = dateTimePicker_date.Value.ToUniversalTime().Date;
                TimeSpan tStart = dateTimePicker_tStart.Value.ToUniversalTime().TimeOfDay;
                TimeSpan tEnd = dateTimePicker_tEnd.Value.ToUniversalTime().TimeOfDay;
                string? quality = string.Empty;
                if (tStart == tEnd)
                {
                    MessageBox.Show("Время начала и конца сна не может совпадать.");
                    return;
                }
                if (comboBox_quality.SelectedItem != null)
                {
                    quality = comboBox_quality.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите качество сна.");
                    return;
                }
                double duration = (tEnd - tStart).TotalHours;
                if (duration < 0)
                    duration += 24;// Если время прошло через полночь, добавляем 24 часа
                using (var context = new ApplicationContext())
                {
                    var sleepRecording = new SleepRecording
                    {
                        UserId = userId,
                        Date = date,
                        SleepStart = tStart,
                        SleepEnd = tEnd,
                        SleepDuration = duration,
                        SleepQuality = quality,
                    };
                    context.SleepRecording.Add(sleepRecording);
                    context.SaveChanges();
                }
                MessageBox.Show("Запись успешно добавлена!");
                sleepTracking = Application.OpenForms["SleepTracking"] as SleepTracking;
                if (sleepTracking != null)
                {
                    sleepTracking.Close();
                }
                if (sleepTracking == null || sleepTracking.IsDisposed)
                {
                    sleepTracking = new SleepTracking(userId);
                    sleepTracking.Show();
                    this.Close();
                }
                else
                {
                    sleepTracking.Refresh();
                    sleepTracking.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
