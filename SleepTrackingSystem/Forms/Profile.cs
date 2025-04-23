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
    public partial class Profile : Form
    {
        //На этапе разработки
        public Profile()
        {
            InitializeComponent();
            InitializingInterfaceElements();
        }
        private void InitializingInterfaceElements()
        {
            lab_title.Font = new Font("Arial", 24, FontStyle.Bold);
            lab_title.Location = new Point((ClientSize.Width - lab_title.Width) / 2, 20);
            lab_title.ForeColor = Color.White;

            lab_login.Font = new Font("Arial", 16);
            lab_login.Location = new Point(30, 80);
            lab_login.ForeColor = Color.White;

            lab_showLogin.Font = new Font("Arial", 16);
            lab_showLogin.Location = new Point(120, 80);
            lab_showLogin.ForeColor = Color.White;

            but_editLogin.Font = new Font("Arial", 12);
            but_editLogin.Text = "Изменить";
            but_editLogin.Location = new Point(350, 80);
            but_editLogin.ForeColor = Color.White;
            but_editLogin.BackColor = Color.MediumPurple;
            but_editLogin.Cursor = Cursors.Hand;

            lab_description.Font = new Font("Arial", 16);
            lab_description.Location = new Point(30, 360);
            lab_description.ForeColor = Color.White;

            txtBox_description.Font = new Font("Arial", 12);
            txtBox_description.Location = new Point(150, 360);
            txtBox_description.Size = new Size(300, 100);
            txtBox_description.Multiline = true;
        }
    }
}
