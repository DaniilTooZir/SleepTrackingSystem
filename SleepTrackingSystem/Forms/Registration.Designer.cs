namespace SleepTrackingSystem
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            lab_title = new Label();
            lab_login = new Label();
            lab_mail = new Label();
            lab_password = new Label();
            lab_replayPassw = new Label();
            textBox_login = new TextBox();
            textBox_password = new TextBox();
            textBox_replayPassw = new TextBox();
            but_reg = new Button();
            lab_back = new Label();
            textBox_email = new TextBox();
            SuspendLayout();
            // 
            // lab_title
            // 
            lab_title.AutoSize = true;
            lab_title.BackColor = Color.Transparent;
            lab_title.ForeColor = Color.White;
            lab_title.Location = new Point(149, 25);
            lab_title.Name = "lab_title";
            lab_title.Size = new Size(96, 20);
            lab_title.TabIndex = 0;
            lab_title.Text = "Регистрация";
            // 
            // lab_login
            // 
            lab_login.AutoSize = true;
            lab_login.BackColor = Color.Transparent;
            lab_login.ForeColor = Color.White;
            lab_login.Location = new Point(68, 65);
            lab_login.Name = "lab_login";
            lab_login.Size = new Size(52, 20);
            lab_login.TabIndex = 1;
            lab_login.Text = "Логин";
            // 
            // lab_mail
            // 
            lab_mail.AutoSize = true;
            lab_mail.BackColor = Color.Transparent;
            lab_mail.ForeColor = Color.White;
            lab_mail.Location = new Point(68, 109);
            lab_mail.Name = "lab_mail";
            lab_mail.Size = new Size(73, 20);
            lab_mail.TabIndex = 2;
            lab_mail.Text = "Эл. почта";
            // 
            // lab_password
            // 
            lab_password.AutoSize = true;
            lab_password.BackColor = Color.Transparent;
            lab_password.ForeColor = Color.White;
            lab_password.Location = new Point(68, 142);
            lab_password.Name = "lab_password";
            lab_password.Size = new Size(62, 20);
            lab_password.TabIndex = 3;
            lab_password.Text = "Пароль";
            // 
            // lab_replayPassw
            // 
            lab_replayPassw.AutoSize = true;
            lab_replayPassw.BackColor = Color.Transparent;
            lab_replayPassw.ForeColor = Color.White;
            lab_replayPassw.Location = new Point(68, 172);
            lab_replayPassw.Name = "lab_replayPassw";
            lab_replayPassw.Size = new Size(116, 20);
            lab_replayPassw.TabIndex = 4;
            lab_replayPassw.Text = "Повтор пароля";
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(180, 65);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(125, 27);
            textBox_login.TabIndex = 5;
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(180, 142);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(125, 27);
            textBox_password.TabIndex = 7;
            // 
            // textBox_replayPassw
            // 
            textBox_replayPassw.Location = new Point(180, 175);
            textBox_replayPassw.Name = "textBox_replayPassw";
            textBox_replayPassw.Size = new Size(125, 27);
            textBox_replayPassw.TabIndex = 8;
            // 
            // but_reg
            // 
            but_reg.BackColor = Color.MediumPurple;
            but_reg.ForeColor = Color.White;
            but_reg.Location = new Point(80, 232);
            but_reg.Name = "but_reg";
            but_reg.Size = new Size(245, 35);
            but_reg.TabIndex = 9;
            but_reg.Text = "Зарегистрироваться";
            but_reg.UseVisualStyleBackColor = false;
            but_reg.Click += but_reg_Click;
            // 
            // lab_back
            // 
            lab_back.AutoSize = true;
            lab_back.BackColor = Color.MediumPurple;
            lab_back.BorderStyle = BorderStyle.Fixed3D;
            lab_back.ForeColor = Color.White;
            lab_back.Location = new Point(117, 280);
            lab_back.Name = "lab_back";
            lab_back.Size = new Size(188, 22);
            lab_back.TabIndex = 10;
            lab_back.Text = "Вернуться к авторизации";
            lab_back.Click += lab_back_Click;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(180, 106);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(125, 27);
            textBox_email.TabIndex = 11;
            textBox_email.KeyPress += textBox_email_KeyPress;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(382, 353);
            Controls.Add(textBox_email);
            Controls.Add(lab_back);
            Controls.Add(but_reg);
            Controls.Add(textBox_replayPassw);
            Controls.Add(textBox_password);
            Controls.Add(textBox_login);
            Controls.Add(lab_replayPassw);
            Controls.Add(lab_password);
            Controls.Add(lab_mail);
            Controls.Add(lab_login);
            Controls.Add(lab_title);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SleepFlux";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_title;
        private Label lab_login;
        private Label lab_mail;
        private Label lab_password;
        private Label lab_replayPassw;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private TextBox textBox_replayPassw;
        private Button but_reg;
        private Label lab_back;
        private TextBox textBox_email;
    }
}