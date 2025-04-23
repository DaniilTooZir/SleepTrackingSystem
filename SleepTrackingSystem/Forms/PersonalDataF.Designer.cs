namespace SleepTrackingSystem.Forms
{
    partial class PersonalDataF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalDataF));
            lab_title = new Label();
            lab_basicData = new Label();
            lab_name = new Label();
            lab_gender = new Label();
            lab_dateBirth = new Label();
            lab_contact = new Label();
            lab_email = new Label();
            lab_showName = new Label();
            lab_showGender = new Label();
            lab_showDateBirth = new Label();
            lab_showEmail = new Label();
            lab_info = new Label();
            but_addData = new Button();
            SuspendLayout();
            // 
            // lab_title
            // 
            lab_title.AutoSize = true;
            lab_title.BackColor = Color.Transparent;
            lab_title.ForeColor = SystemColors.ControlText;
            lab_title.Location = new Point(273, 18);
            lab_title.Name = "lab_title";
            lab_title.Size = new Size(121, 20);
            lab_title.TabIndex = 0;
            lab_title.Text = "Личные данные";
            // 
            // lab_basicData
            // 
            lab_basicData.AutoSize = true;
            lab_basicData.BackColor = Color.Transparent;
            lab_basicData.Location = new Point(74, 67);
            lab_basicData.Name = "lab_basicData";
            lab_basicData.Size = new Size(138, 20);
            lab_basicData.TabIndex = 1;
            lab_basicData.Text = "Основные данные";
            // 
            // lab_name
            // 
            lab_name.AutoSize = true;
            lab_name.BackColor = Color.Transparent;
            lab_name.Location = new Point(74, 112);
            lab_name.Name = "lab_name";
            lab_name.Size = new Size(39, 20);
            lab_name.TabIndex = 2;
            lab_name.Text = "Имя";
            // 
            // lab_gender
            // 
            lab_gender.AutoSize = true;
            lab_gender.BackColor = Color.Transparent;
            lab_gender.Location = new Point(76, 152);
            lab_gender.Name = "lab_gender";
            lab_gender.Size = new Size(37, 20);
            lab_gender.TabIndex = 3;
            lab_gender.Text = "Пол";
            // 
            // lab_dateBirth
            // 
            lab_dateBirth.AutoSize = true;
            lab_dateBirth.BackColor = Color.Transparent;
            lab_dateBirth.Location = new Point(76, 191);
            lab_dateBirth.Name = "lab_dateBirth";
            lab_dateBirth.Size = new Size(116, 20);
            lab_dateBirth.TabIndex = 4;
            lab_dateBirth.Text = "Дата рождения";
            // 
            // lab_contact
            // 
            lab_contact.AutoSize = true;
            lab_contact.BackColor = Color.Transparent;
            lab_contact.Location = new Point(76, 236);
            lab_contact.Name = "lab_contact";
            lab_contact.Size = new Size(183, 20);
            lab_contact.TabIndex = 5;
            lab_contact.Text = "Контактная информация";
            // 
            // lab_email
            // 
            lab_email.AutoSize = true;
            lab_email.BackColor = Color.Transparent;
            lab_email.Location = new Point(76, 277);
            lab_email.Name = "lab_email";
            lab_email.Size = new Size(73, 20);
            lab_email.TabIndex = 6;
            lab_email.Text = "Эл. почта";
            // 
            // lab_showName
            // 
            lab_showName.AutoSize = true;
            lab_showName.BackColor = Color.Transparent;
            lab_showName.Location = new Point(162, 112);
            lab_showName.Name = "lab_showName";
            lab_showName.Size = new Size(0, 20);
            lab_showName.TabIndex = 7;
            // 
            // lab_showGender
            // 
            lab_showGender.AutoSize = true;
            lab_showGender.BackColor = Color.Transparent;
            lab_showGender.Location = new Point(161, 156);
            lab_showGender.Name = "lab_showGender";
            lab_showGender.Size = new Size(0, 20);
            lab_showGender.TabIndex = 8;
            // 
            // lab_showDateBirth
            // 
            lab_showDateBirth.AutoSize = true;
            lab_showDateBirth.BackColor = Color.Transparent;
            lab_showDateBirth.Location = new Point(209, 191);
            lab_showDateBirth.Name = "lab_showDateBirth";
            lab_showDateBirth.Size = new Size(0, 20);
            lab_showDateBirth.TabIndex = 9;
            // 
            // lab_showEmail
            // 
            lab_showEmail.AutoSize = true;
            lab_showEmail.BackColor = Color.Transparent;
            lab_showEmail.Location = new Point(164, 278);
            lab_showEmail.Name = "lab_showEmail";
            lab_showEmail.Size = new Size(0, 20);
            lab_showEmail.TabIndex = 10;
            // 
            // lab_info
            // 
            lab_info.AutoSize = true;
            lab_info.BackColor = Color.Transparent;
            lab_info.Location = new Point(64, 429);
            lab_info.Name = "lab_info";
            lab_info.Size = new Size(0, 20);
            lab_info.TabIndex = 11;
            // 
            // but_addData
            // 
            but_addData.BackColor = Color.MediumPurple;
            but_addData.Location = new Point(55, 487);
            but_addData.Name = "but_addData";
            but_addData.Size = new Size(176, 65);
            but_addData.TabIndex = 12;
            but_addData.Text = "Изменить";
            but_addData.UseVisualStyleBackColor = false;
            but_addData.Click += but_addData_Click;
            // 
            // PersonalData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(652, 603);
            Controls.Add(but_addData);
            Controls.Add(lab_info);
            Controls.Add(lab_showEmail);
            Controls.Add(lab_showDateBirth);
            Controls.Add(lab_showGender);
            Controls.Add(lab_showName);
            Controls.Add(lab_email);
            Controls.Add(lab_contact);
            Controls.Add(lab_dateBirth);
            Controls.Add(lab_gender);
            Controls.Add(lab_name);
            Controls.Add(lab_basicData);
            Controls.Add(lab_title);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalData";
            Text = "PersonalData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_title;
        private Label lab_basicData;
        private Label lab_name;
        private Label lab_gender;
        private Label lab_dateBirth;
        private Label lab_contact;
        private Label lab_email;
        private Label lab_showName;
        private Label lab_showGender;
        private Label lab_showDateBirth;
        private Label lab_showEmail;
        private Label lab_info;
        private Button but_addData;
    }
}