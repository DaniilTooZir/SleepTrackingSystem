namespace SleepTrackingSystem.Forms
{
    partial class PersonalAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalAccount));
            panel_tab = new Panel();
            but_save = new Button();
            but_addPhoto = new Button();
            pictureBox_photo = new PictureBox();
            lab_welc = new Label();
            lab_settingAccount = new Label();
            lab_personalData = new Label();
            lab_returnToTheMainMenu = new Label();
            lab_persAcc = new Label();
            panel_openForms = new Panel();
            panel_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_photo).BeginInit();
            SuspendLayout();
            // 
            // panel_tab
            // 
            panel_tab.BackColor = Color.Transparent;
            panel_tab.BackgroundImage = (Image)resources.GetObject("panel_tab.BackgroundImage");
            panel_tab.BackgroundImageLayout = ImageLayout.Stretch;
            panel_tab.BorderStyle = BorderStyle.Fixed3D;
            panel_tab.Controls.Add(but_save);
            panel_tab.Controls.Add(but_addPhoto);
            panel_tab.Controls.Add(pictureBox_photo);
            panel_tab.Controls.Add(lab_welc);
            panel_tab.Controls.Add(lab_settingAccount);
            panel_tab.Controls.Add(lab_personalData);
            panel_tab.Controls.Add(lab_returnToTheMainMenu);
            panel_tab.Controls.Add(lab_persAcc);
            panel_tab.Location = new Point(12, 12);
            panel_tab.Name = "panel_tab";
            panel_tab.Size = new Size(307, 649);
            panel_tab.TabIndex = 0;
            // 
            // but_save
            // 
            but_save.Location = new Point(168, 200);
            but_save.Name = "but_save";
            but_save.Size = new Size(115, 37);
            but_save.TabIndex = 8;
            but_save.Text = "Сохранить";
            but_save.UseVisualStyleBackColor = true;
            but_save.Click += but_save_Click;
            // 
            // but_addPhoto
            // 
            but_addPhoto.Location = new Point(168, 147);
            but_addPhoto.Name = "but_addPhoto";
            but_addPhoto.Size = new Size(115, 38);
            but_addPhoto.TabIndex = 7;
            but_addPhoto.Text = "Добавить фото";
            but_addPhoto.UseVisualStyleBackColor = true;
            but_addPhoto.Click += but_addPhoto_Click;
            // 
            // pictureBox_photo
            // 
            pictureBox_photo.Location = new Point(29, 147);
            pictureBox_photo.Name = "pictureBox_photo";
            pictureBox_photo.Size = new Size(133, 116);
            pictureBox_photo.TabIndex = 6;
            pictureBox_photo.TabStop = false;
            // 
            // lab_welc
            // 
            lab_welc.AutoSize = true;
            lab_welc.Location = new Point(99, 97);
            lab_welc.Name = "lab_welc";
            lab_welc.Size = new Size(20, 20);
            lab_welc.TabIndex = 5;
            lab_welc.Text = "w";
            // 
            // lab_settingAccount
            // 
            lab_settingAccount.AutoSize = true;
            lab_settingAccount.Location = new Point(67, 341);
            lab_settingAccount.Name = "lab_settingAccount";
            lab_settingAccount.Size = new Size(83, 20);
            lab_settingAccount.TabIndex = 3;
            lab_settingAccount.Text = "Настрйока";
            lab_settingAccount.Click += lab_settingAccount_Click;
            // 
            // lab_personalData
            // 
            lab_personalData.AutoSize = true;
            lab_personalData.Location = new Point(65, 288);
            lab_personalData.Name = "lab_personalData";
            lab_personalData.Size = new Size(64, 20);
            lab_personalData.TabIndex = 2;
            lab_personalData.Text = "Личные";
            lab_personalData.Click += lab_personalData_Click;
            // 
            // lab_returnToTheMainMenu
            // 
            lab_returnToTheMainMenu.AutoSize = true;
            lab_returnToTheMainMenu.Location = new Point(99, 604);
            lab_returnToTheMainMenu.Name = "lab_returnToTheMainMenu";
            lab_returnToTheMainMenu.Size = new Size(80, 20);
            lab_returnToTheMainMenu.TabIndex = 1;
            lab_returnToTheMainMenu.Text = "Вернуться";
            lab_returnToTheMainMenu.Click += lab_returnToTheMainMenu_Click;
            // 
            // lab_persAcc
            // 
            lab_persAcc.AutoSize = true;
            lab_persAcc.Location = new Point(76, 28);
            lab_persAcc.Name = "lab_persAcc";
            lab_persAcc.Size = new Size(125, 20);
            lab_persAcc.TabIndex = 0;
            lab_persAcc.Text = "Личный кабинет";
            // 
            // panel_openForms
            // 
            panel_openForms.BackColor = Color.Transparent;
            panel_openForms.BorderStyle = BorderStyle.Fixed3D;
            panel_openForms.ForeColor = SystemColors.ControlText;
            panel_openForms.Location = new Point(325, 12);
            panel_openForms.Name = "panel_openForms";
            panel_openForms.Size = new Size(669, 649);
            panel_openForms.TabIndex = 1;
            // 
            // PersonalAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 673);
            Controls.Add(panel_openForms);
            Controls.Add(panel_tab);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PersonalAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SleepFlux";
            FormClosed += PersonalAccount_FormClosed;
            panel_tab.ResumeLayout(false);
            panel_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_photo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_tab;
        private Label lab_persAcc;
        private Label lab_returnToTheMainMenu;
        private Panel panel_openForms;
        private Label lab_personalData;
        private Label lab_settingAccount;
        private Label lab_welc;
        private PictureBox pictureBox_photo;
        private Button but_save;
        private Button but_addPhoto;
    }
}