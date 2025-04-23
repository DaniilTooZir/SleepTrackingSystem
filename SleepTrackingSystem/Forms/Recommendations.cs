using SleepTrackingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SleepTrackingSystem
{
    public partial class Recommendations : Form
    {
        public Recommendations()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.BackColor = Color.AliceBlue;
            InitializeElement();
        }

        private void InitializeElement()
        {

            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip()
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 200,
                ShowAlways = true
            };

            toolTip.SetToolTip(but_update, "Обновить рекомендации на основе данных о сне.");
            toolTip.SetToolTip(but_close, "Закрыть окно рекомендаций.");
            toolTip.SetToolTip(richTextBox_recommend, "Здесь отображаются персональные рекомендации.");
            lab_title.Font = new Font("Arial", 14, FontStyle.Bold);
            lab_title.Location = new Point((ClientSize.Width - lab_title.Width) / 2, 20);
            lab_title.BackColor = Color.Transparent;

            richTextBox_recommend.Font = new Font("Arial", 12);
            richTextBox_recommend.BackColor = Color.MediumPurple;
            richTextBox_recommend.ReadOnly = true;
            richTextBox_recommend.Cursor = Cursors.Default;


            but_update.Font = new Font("Arial", 10, FontStyle.Bold);
            but_update.Size = new Size(150, 40);
            but_update.Location = new Point((ClientSize.Width - but_update.Width) / 2, 300);
            but_update.Cursor = Cursors.Hand;

            but_close.Font = new Font("Arial", 10);
            but_close.Size = new Size(120, 40);
            but_close.Cursor = Cursors.Hand;
        }
        // Вычисление данных и вывод персонализированных рекомендаций по улучшению сна.
        private void but_update_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ApplicationContext())
                {
                    // Извлечение все записи о сне, у которых указано качество сна, и фильтруем по текущему пользователю.
                    // После этого выбираем только поле SleepQuality для каждой записи и сохраняем результат в список.
                    //var sleepData = context.SleepRecording
                    //                    .Where(s => !string.IsNullOrEmpty(s.SleepQuality) && s.UserId == CurrentUser.UserId)
                    //                    .Select(s => s.SleepQuality)
                    //                    .ToList();
                    var sleepData = context.SleepRecording
                                .Where(s => s.UserId == CurrentUser.UserId)
                                .ToList();
                    if (!sleepData.Any())
                    {
                        richTextBox_recommend.Text = "Нет данных о записях сна для формирования рекомендаций.";
                        return;
                    }
                    if (sleepData.Count == 0)
                    {
                        richTextBox_recommend.Text = "Нет данных о записях сна для формирования рекомендаций.";
                        return;
                    }
                    var qualityScores = sleepData.Select(s => MapQualityToScore(s.SleepQuality)).ToList();
                    double averageQuality = qualityScores.Average();
                    double averageDuration = sleepData.Average(s => s.SleepDuration);
                    var recommendations = SleepRecommend.GetRecommendations(averageQuality, averageDuration);
                    if (recommendations.Any())
                    if (recommendations.Any())
                    {
                        richTextBox_recommend.Text = string.Join(Environment.NewLine, recommendations);
                    }
                    else
                    {
                        richTextBox_recommend.Text = "Рекомендации не найдены.";
                    }
                }
            }
            catch (Exception ex)
            {
                richTextBox_recommend.Text = "Произошла ошибка при генерации рекомендаций.";
                Console.WriteLine(ex.Message);
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private int MapQualityToScore(string quality)
        {
            // Метод для преобразования качества сна в баллы
            return quality switch
            {
                "Отличное" => 5,
                "Хорошее" => 4,
                "Среднее" => 3,
                "Плохое" => 2,
                "Ужасное" => 1,
                _ => 0 // Если качество не распознано, возвращаем 0
            };
        }
        private void but_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
