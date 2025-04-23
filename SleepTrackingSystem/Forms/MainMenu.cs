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
    public partial class MainMenu : Form
    {
        private SleepTracking? sleepTracking;
        private AddingSleepRecording? addingSleepRecording;
        private ChartsReports? chartsReports;
        private Recommendations? recommendations;
        private bool isExiting = false;
        private int userId; // Идентификатор текущего пользователя
        public MainMenu()
        {
            InitializeComponent();
            userId = CurrentUser.UserId; // Получаем ID текущего пользователя
            this.MaximizeBox = false;

            InitializingInterfaceElements();
        }
        private void InitializingInterfaceElements()
        {
            ToolTip toolTip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 200,
                ShowAlways = true
            };

            lab_naviga.Font = new Font("Arial", 20, FontStyle.Bold);
            lab_naviga.Location = new Point(20, 180);
            lab_naviga.ForeColor = Color.White;

            lab_sleepTracking.Font = new Font("Arial", 16);
            lab_sleepTracking.Location = new Point(20, 230);
            lab_sleepTracking.Cursor = Cursors.Hand;
            lab_sleepTracking.ForeColor = Color.White;
            toolTip.SetToolTip(lab_sleepTracking, "Перейти к отслеживанию сна");

            lab_chartAndReports.Font = new Font("Arial", 16);
            lab_chartAndReports.Location = new Point(20, 270);
            lab_chartAndReports.Cursor = Cursors.Hand;
            lab_chartAndReports.ForeColor = Color.White;
            toolTip.SetToolTip(lab_chartAndReports, "Просмотр графиков и отчётов");

            lab_recommend.Font = new Font("Arial", 16);
            lab_recommend.Location = new Point(20, 310);
            lab_recommend.Cursor = Cursors.Hand;
            lab_recommend.ForeColor = Color.White;
            toolTip.SetToolTip(lab_recommend, "Открыть рекомендации для улучшения сна");

            but_exit.Font = new Font("Arial", 14);
            but_exit.Location = new Point((panel_navigator.Width - but_exit.Width) / 2, 600);
            but_exit.Cursor = Cursors.Hand;
            toolTip.SetToolTip(but_exit, "Выйти из приложения");

            label_personalAccount.Font = new Font("Arial", 16, FontStyle.Bold);
            label_personalAccount.Cursor = Cursors.Hand;
            label_personalAccount.ForeColor = Color.White;
            label_personalAccount.Location = new Point(415, (panel_tab.Height - label_personalAccount.Height) / 2);

        }
        // Открывает форму с графиками и отчетами
        private void lab_chartAndReports_Click(object sender, EventArgs e)
        {
            OpenSingleForm();
            if (chartsReports == null || chartsReports.IsDisposed)
            {
                chartsReports = new ChartsReports(userId);
                chartsReports.Show();
            }
            else
            {
                chartsReports.Refresh();
                chartsReports.Activate();
            }
        }
        // Открывает форму с рекомендациями
        private void lab_recommend_Click(object sender, EventArgs e)
        {
            OpenSingleForm();
            if (recommendations == null || recommendations.IsDisposed)
            {
                recommendations = new Recommendations();
                recommendations.Show();
            }
            else
            {
                recommendations.Refresh();
                recommendations.Activate();
            }
        }
        // Открывает форму отслеживания сна
        private void lab_sleepTracking_Click(object sender, EventArgs e)
        {
            try
            {
                OpenSingleForm();
                if (sleepTracking == null || sleepTracking.IsDisposed)
                {
                    sleepTracking = new SleepTracking(userId);
                    sleepTracking.Show();
                }
                else
                {
                    sleepTracking.Refresh();
                    sleepTracking.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ой, немного забаговалось заполнение таблицы, не пугайтесь. Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void but_exit_Click(object sender, EventArgs e)
        {
            if (!isExiting)
            {
                var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (IsGuestUser(CurrentUser.UserId))
                    {
                        DeleteGuestUser(CurrentUser.UserId);
                    }
                    isExiting = true;
                    Application.Exit();
                }
            }
        }
        // Метод закрывает все открытые формы, чтобы оставалась только одна
        private void OpenSingleForm()
        {
            sleepTracking = Application.OpenForms["SleepTracking"] as SleepTracking;
            if (sleepTracking != null)
            {
                sleepTracking.Close();
            }
            addingSleepRecording = Application.OpenForms["addingSleepRecording"] as AddingSleepRecording;
            if (addingSleepRecording != null)
            {
                addingSleepRecording.Close();
            }
            chartsReports = Application.OpenForms["ChartsReports"] as ChartsReports;
            if (chartsReports != null)
            {
                chartsReports.Close();
            }
            recommendations = Application.OpenForms["Recommendations"] as Recommendations;
            if (recommendations != null)
            {
                recommendations.Close();
            }
        }
        // При закрытии удаляет гостевого пользователя, если он существует, и завершает работу программы.
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsGuestUser(CurrentUser.UserId))
            {
                DeleteGuestUser(CurrentUser.UserId);
            }
            isExiting = true;
            Application.Exit();
        }
        // Метод открыват форму Личный кабинет
        // Если пользователь гость, показывает сообщение с просьбой авторизоваться. В противном случае открывает форму личного кабинета.
        private void label_personalAccount_Click(object sender, EventArgs e)
        {
            if (IsGuestUser(CurrentUser.UserId))
            {
                MessageBox.Show("Эта функция недоступна для гостя. Пожалуйста, авторизуйтесь.", "Доступ запрещен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Authorization authorization = new Authorization();
                authorization.FormClosed += (s, args) =>
                {
                    this.Show();
                };
                authorization.Show();
                this.Hide();
            }
            else
            {
                OpenSingleForm();
                PersonalAccount account = new PersonalAccount();
                account.Show();
                this.Hide();
            }
        }
        // Метод проверяет, является ли пользователь гостем, по его ID.
        private bool IsGuestUser(int userId)
        {
            using (var context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == userId);
                return user?.IsGuest ?? false;
            }
        }
        // Метод удаляет гостевого пользователя из базы данных.
        private void DeleteGuestUser(int userId)
        {
            using (var context = new ApplicationContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == userId && u.IsGuest);
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
            }
        }
    }
}
