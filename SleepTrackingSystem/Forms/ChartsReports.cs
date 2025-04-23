using Microsoft.VisualBasic.ApplicationServices;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SleepTrackingSystem
{
    public partial class ChartsReports : Form
    {
        private ApplicationContext Context;
        private int userID;

        public ChartsReports(int idUser)
        {
            InitializeComponent();
            InitializeToolTip();
            userID = idUser;
            Context = new ApplicationContext();
            this.MaximizeBox = false;
            LoadSleepData();
        }
        private void InitializeElement()
        {
            lab_title.Location = new Point((this.ClientSize.Width - lab_title.Width) / 2, 10);

            dateTimePicker_start.Location = new Point(20, 40);
            dateTimePicker_end.Location = new Point(200, 40);

            but_apply.Location = new Point(380, 40);
            but_apply.Cursor = Cursors.Hand;

            but_back.Location = new Point(720, 40);
            but_back.Cursor = Cursors.Hand;
        }
        private void InitializeToolTip()
        {
            ToolTip toolTip = new ToolTip()
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 200,
                ShowAlways = true
            };

            toolTip.SetToolTip(but_apply, "Применить выбранные фильтры для графика");
            toolTip.SetToolTip(but_back, "Нажмите, чтобы вернуться в главное меню");
            toolTip.SetToolTip(dateTimePicker_start, "Выберите дату начала периода");
            toolTip.SetToolTip(dateTimePicker_end, "Выберите дату окончания периода");

            toolTip.SetToolTip(label_totalRecording, "Общее количество записей о сне");
            toolTip.SetToolTip(label_avgDuration, "Средняя продолжительность сна за выбранный период");
            toolTip.SetToolTip(label_lastDateRecord, "Дата последней записи о сне");

            toolTip.BackColor = Color.LightYellow;
            toolTip.ForeColor = Color.Black;
        }
        private void LoadSleepData()
        {
            List<dynamic> sleepData = new List<dynamic>();

            foreach (var record in Context.SleepRecording)
            {
                
                if (record.UserId == userID)
                {
                    SleepRecording sleepRecording = new SleepRecording
                    {
                        Date = record.Date,
                        SleepStart = record.SleepStart,
                        SleepEnd = record.SleepEnd,
                        SleepDuration = record.SleepDuration,
                        SleepQuality = record.SleepQuality
                    };

                    sleepData.Add(sleepRecording);
                }
            }
            ChangeFilters(); 
            InitializeReports(sleepData);
            InitializeElement();
        }
        private void ChangeFilters()
        {
            List<dynamic> sleepData = new List<dynamic>();
            foreach (var record in Context.SleepRecording)
            {
                if (record.UserId == userID)
                {
                    SleepRecording sleepRecording = new SleepRecording
                    {
                        Date = record.Date,
                        SleepStart = record.SleepStart,
                        SleepEnd = record.SleepEnd,
                        SleepDuration = record.SleepDuration,
                        SleepQuality = record.SleepQuality
                    };
                    sleepData.Add(sleepRecording);
                }
            }

            //var dataFilt = from data in sleepData
            //             where data.Date >= dateTimePicker_start.Value.Date && data.Date <= dateTimePicker_end.Value.Date
            //             select data;

            // Фильтрация данных по дате
            var dataFilt = sleepData.Where(data => data.Date >= dateTimePicker_start.Value.Date &&
                data.Date <= dateTimePicker_end.Value.Date).OrderBy(data => data.Date).ToList();

            InitializeChart(dataFilt);
        }
        private void InitializeChart(List<dynamic> sleepData)
        {
            plotView_chartSleep.Size = new Size(900, 400);
            plotView_chartSleep.Location = new Point((this.ClientSize.Width - plotView_chartSleep.Width) / 2, 100);

            PlotModel plotModel = new PlotModel
            {
                Title = "График сна",
            };

            var xAxis = new DateTimeAxis
            {
                Position = AxisPosition.Bottom,
                StringFormat = "dd.MM.yy",
                Title = "Дата",
                IsZoomEnabled = true,
                IsPanEnabled = true
            };
            // Создание оси Y для графика с использованием линейной шкалы.
            var yAxis = new LinearAxis
            {
                Position = AxisPosition.Left,
                Minimum = 0,
                Maximum = 24,
                Title = "Продолжительность сна (часы)",
                MajorStep = 2,
                IsZoomEnabled = false,
                IsPanEnabled = false
            };
            plotModel.Axes.Add(xAxis);
            plotModel.Axes.Add(yAxis);

            AreaSeries areaSeries = new AreaSeries
            {
                Title = "Продолжительность сна",
                MarkerType = MarkerType.Circle, 
                Color = OxyColors.MediumPurple, 
                BrokenLineColor = OxyColors.MediumPurple,
            };

            foreach (var data in sleepData)
            {
                if (data.Date >= dateTimePicker_start.Value && data.Date <= dateTimePicker_end.Value)
                {
                    DateTime date = data.Date;
                    double duration = data.SleepDuration;
                    areaSeries.Points.Add(new DataPoint(DateTimeAxis.ToDouble(date), duration));
                }
            }
            plotModel.Series.Add(areaSeries);
            plotView_chartSleep.Model = plotModel;
        }
        private void InitializeReports(List<dynamic> sleepData)
        {
            panel_reports.Location = new Point(20, 530);
            panel_reports.Size = new Size(965, 150);

            int totalRecords = sleepData.Count;
            label_totalRecording.ForeColor = Color.White;
            label_totalRecording.Text = $"Общее количество записей: {totalRecords}";
            label_totalRecording.Location = new Point(20, 20);

            label_avgDuration.ForeColor = Color.White;
            label_avgDuration.Text = $"Средняя продолжительность сна: {AvgDuration(sleepData):F2}";
            label_avgDuration.Location = new Point(20, 50);

            label_lastDateRecord.ForeColor = Color.White;
            label_lastDateRecord.Text = $"Дата последней записи: {LastDate(sleepData)}";
            label_lastDateRecord.Location = new Point(20, 110);
        }
        private double AvgDuration(List<dynamic> sleepData)
        {
            double avgDuration = 0;
            double sum = 0;
            foreach (var duration in sleepData)
            {
                sum += duration.SleepDuration;
            }
            avgDuration = (sum / sleepData.Count);
            return avgDuration;
        }
        private DateTime LastDate(List<dynamic> sleepData)
        {
            DateTime lastDate = new DateTime();
            foreach (var date in sleepData)
            {
                if (date.Date > lastDate)
                {
                    lastDate = date.Date;
                }
            }
            return lastDate;
        }
        private void but_apply_Click(object sender, EventArgs e)
        {
            ChangeFilters();
            MessageBox.Show("График обновлен!");
        }
        private void but_back_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
