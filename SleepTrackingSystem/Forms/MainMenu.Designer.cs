namespace SleepTrackingSystem
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            lab_naviga = new Label();
            lab_sleepTracking = new Label();
            lab_chartAndReports = new Label();
            lab_recommend = new Label();
            panel_navigator = new Panel();
            but_exit = new Button();
            pictureBox1 = new PictureBox();
            panel_tab = new Panel();
            label_personalAccount = new Label();
            panel_navigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_tab.SuspendLayout();
            SuspendLayout();
            // 
            // lab_naviga
            // 
            lab_naviga.AutoSize = true;
            lab_naviga.BackColor = Color.Transparent;
            lab_naviga.Location = new Point(12, 224);
            lab_naviga.Name = "lab_naviga";
            lab_naviga.Size = new Size(85, 20);
            lab_naviga.TabIndex = 0;
            lab_naviga.Text = "Навигация";
            // 
            // lab_sleepTracking
            // 
            lab_sleepTracking.AutoSize = true;
            lab_sleepTracking.BackColor = Color.MediumPurple;
            lab_sleepTracking.BorderStyle = BorderStyle.FixedSingle;
            lab_sleepTracking.Location = new Point(12, 260);
            lab_sleepTracking.Name = "lab_sleepTracking";
            lab_sleepTracking.Size = new Size(141, 22);
            lab_sleepTracking.TabIndex = 1;
            lab_sleepTracking.Text = "Отслеживание сна";
            lab_sleepTracking.Click += lab_sleepTracking_Click;
            // 
            // lab_chartAndReports
            // 
            lab_chartAndReports.AutoSize = true;
            lab_chartAndReports.BackColor = Color.MediumPurple;
            lab_chartAndReports.BorderStyle = BorderStyle.FixedSingle;
            lab_chartAndReports.Location = new Point(12, 299);
            lab_chartAndReports.Name = "lab_chartAndReports";
            lab_chartAndReports.Size = new Size(135, 22);
            lab_chartAndReports.TabIndex = 2;
            lab_chartAndReports.Text = "Графики и отчеты";
            lab_chartAndReports.Click += lab_chartAndReports_Click;
            // 
            // lab_recommend
            // 
            lab_recommend.AutoSize = true;
            lab_recommend.BackColor = Color.MediumPurple;
            lab_recommend.BorderStyle = BorderStyle.FixedSingle;
            lab_recommend.Location = new Point(12, 342);
            lab_recommend.Name = "lab_recommend";
            lab_recommend.Size = new Size(114, 22);
            lab_recommend.TabIndex = 3;
            lab_recommend.Text = "Рекомендации";
            lab_recommend.Click += lab_recommend_Click;
            // 
            // panel_navigator
            // 
            panel_navigator.BackColor = Color.Transparent;
            panel_navigator.BackgroundImage = (Image)resources.GetObject("panel_navigator.BackgroundImage");
            panel_navigator.BackgroundImageLayout = ImageLayout.Stretch;
            panel_navigator.BorderStyle = BorderStyle.Fixed3D;
            panel_navigator.Controls.Add(but_exit);
            panel_navigator.Controls.Add(pictureBox1);
            panel_navigator.Controls.Add(lab_recommend);
            panel_navigator.Controls.Add(lab_sleepTracking);
            panel_navigator.Controls.Add(lab_naviga);
            panel_navigator.Controls.Add(lab_chartAndReports);
            panel_navigator.Location = new Point(12, 12);
            panel_navigator.Name = "panel_navigator";
            panel_navigator.Size = new Size(307, 649);
            panel_navigator.TabIndex = 5;
            // 
            // but_exit
            // 
            but_exit.BackColor = Color.MediumPurple;
            but_exit.ForeColor = Color.White;
            but_exit.Location = new Point(93, 598);
            but_exit.Name = "but_exit";
            but_exit.Size = new Size(111, 44);
            but_exit.TabIndex = 5;
            but_exit.Text = "Выйти";
            but_exit.UseVisualStyleBackColor = false;
            but_exit.Click += but_exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 212);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel_tab
            // 
            panel_tab.BackgroundImage = (Image)resources.GetObject("panel_tab.BackgroundImage");
            panel_tab.BackgroundImageLayout = ImageLayout.Stretch;
            panel_tab.BorderStyle = BorderStyle.Fixed3D;
            panel_tab.Controls.Add(label_personalAccount);
            panel_tab.Location = new Point(325, 12);
            panel_tab.Name = "panel_tab";
            panel_tab.Size = new Size(669, 53);
            panel_tab.TabIndex = 6;
            // 
            // label_personalAccount
            // 
            label_personalAccount.AutoSize = true;
            label_personalAccount.BackColor = Color.MediumPurple;
            label_personalAccount.Location = new Point(411, 9);
            label_personalAccount.Name = "label_personalAccount";
            label_personalAccount.Size = new Size(125, 20);
            label_personalAccount.TabIndex = 0;
            label_personalAccount.Text = "Личный кабинет";
            label_personalAccount.Click += label_personalAccount_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 673);
            Controls.Add(panel_tab);
            Controls.Add(panel_navigator);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SleepFlux";
            FormClosed += MainMenu_FormClosed;
            panel_navigator.ResumeLayout(false);
            panel_navigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_tab.ResumeLayout(false);
            panel_tab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lab_naviga;
        private Label lab_sleepTracking;
        private Label lab_chartAndReports;
        private Label lab_recommend;
        private Panel panel_navigator;
        private PictureBox pictureBox1;
        private Button but_exit;
        private Panel panel_tab;
        private Label label_personalAccount;
    }
}