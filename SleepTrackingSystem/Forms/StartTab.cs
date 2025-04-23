using Microsoft.VisualBasic.Logging;
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
    public partial class StartTab : Form
    {
        private Authorization? authorization;
        private Registration? registration;
        public StartTab()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Size = new Size(800, 600);
            InitializingElements();
        }

        private void InitializingElements()
        {
            ToolTip toolTip = new ToolTip()
            {
                AutoPopDelay = 5000,
                InitialDelay = 500,
                ReshowDelay = 200,
                ShowAlways = true
            };
            pictureBox_logo.Location = new Point((this.ClientSize.Width - pictureBox_logo.Width) / 2, 20);

            lab_welc.Font = new Font("Arial", 28);
            lab_welc.AutoSize = true;
            lab_welc.Location = new Point((this.ClientSize.Width - lab_welc.Width) / 2, 220);

            label_description.Font = new Font("Arial", 16);
            label_description.AutoSize = true;
            label_description.Location = new Point((this.ClientSize.Width - label_description.Width) / 2, 270);

            but_start.Font = new Font("Arial", 16);
            but_start.Location = new Point((this.ClientSize.Width - but_start.Width) / 2, 400);
            but_start.Cursor = Cursors.Hand;
            toolTip.SetToolTip(but_start, "Нажмите, чтобы перейти к авторизации");

            label_exit.Font = new Font("Arial", 12);
            label_exit.AutoSize = true;
            label_exit.Location = new Point((this.ClientSize.Width - label_exit.Width) / 2, 500);
            label_exit.Cursor = Cursors.Hand;
            toolTip.SetToolTip(label_exit, "Нажмите, чтобы выйти из приложения");

        }
        // Метод для закрытия форм "Registration" и "Authorization", если они уже открыты.
        private void CloseFormIfExists()
        {
            registration = Application.OpenForms["Registration"] as Registration;
            if (registration != null)
            {
                registration.Close();
            }
            authorization = Application.OpenForms["Authorization"] as Authorization;
            if (authorization != null)
            {
                authorization.Close();
            }
        }
        private void but_start_Click(object sender, EventArgs e)
        {
            try
            {
                // Вызов метода для проверки открытия форм
                CloseFormIfExists();
                // Если форма авторизации ещё не была создана или была закрыта, создаём её заново.
                if (authorization == null || authorization.IsDisposed)
                {
                    authorization = new Authorization();
                    authorization.FormClosed += (s, args) => authorization = null;
                    authorization.Show();
                }
                else
                {
                    authorization.Refresh();
                    authorization.Activate();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label_exit_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LockedButton()
        {
            Authorization authorization = new Authorization();
            authorization.Show();
        }
    }
}
