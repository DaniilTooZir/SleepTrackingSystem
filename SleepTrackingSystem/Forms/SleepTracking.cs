using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SleepTrackingSystem.Forms
{
    public partial class SleepTracking : Form
    {
        private ApplicationContext Context; // Контекст для работы с базой данных
        private int userId;// Идентификатор текущего пользователя
        public SleepTracking(int idUser)
        {
            InitializeComponent();
            Context = new ApplicationContext();
            userId = idUser;

            this.MaximizeBox = false;

            InitializingInterfaceElements();
            ConfigureDataGridView();
            LoadData();
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
            lab_sleepTracking.Font = new Font("Arial", 20, FontStyle.Bold);
            lab_sleepTracking.Location = new Point((this.ClientSize.Width - lab_sleepTracking.Width) / 2, 20);

            but_addRecord.Font = new Font("Arial", 10);
            but_addRecord.Location = new Point(90, 80);
            but_addRecord.Cursor = Cursors.Hand;
            toolTip.SetToolTip(but_addRecord, "Нажмите, чтобы добавить запись сна.");

            but_back.Font = new Font("Arial", 10);
            but_back.Location = new Point(600, 80);
            but_back.Cursor = Cursors.Hand;
            toolTip.SetToolTip(but_back, "Нажмите, чтобы вернуться в главное меню.");
        }
        private void LoadData()
        {
            try
            {
                var records = Context.SleepRecording.ToList();
                foreach (var record in records)
                {
                    if (record.UserId == userId)
                    {
                        string startTime = record.SleepStart.ToString(@"hh\:mm");
                        string endTime = record.SleepEnd.ToString(@"hh\:mm");
                        dataGridView_show.Rows.Add(record.Date.ToString("dd.MM.yyyy"),
                            startTime, endTime,
                            Math.Round((decimal)record.SleepDuration, 2), record.SleepQuality);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void but_addRecord_Click(object sender, EventArgs e)
        {
            AddingSleepRecording addingSleepRecording = new AddingSleepRecording(userId);
            addingSleepRecording.Show();
        }
        private void SleepTracking_FormClosing(object sender, FormClosingEventArgs e)
        {
            Context.Dispose();
        }
        private void ConfigureDataGridView()
        {
            try
            {

                dataGridView_show.Columns[0].DefaultCellStyle.Format = "dd.MM.yyyy";
                dataGridView_show.Columns[1].DefaultCellStyle.Format = "HH:mm";
                dataGridView_show.Columns[2].DefaultCellStyle.Format = "HH:mm";

                dataGridView_show.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView_show.DefaultCellStyle.Font = new Font("Arial", 10);
                dataGridView_show.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dataGridView_show.BackgroundColor = Color.MediumPurple;
                dataGridView_show.GridColor = Color.LightGray;
                dataGridView_show.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ой, немного забаговалось заполнение таблицы, не пугайтесь. Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void but_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
