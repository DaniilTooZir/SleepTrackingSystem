namespace SleepTrackingSystem.Forms
{
    partial class SettingAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingAccount));
            lab_settingAcc = new Label();
            lab_login = new Label();
            lab_showLogin = new Label();
            textBox_login = new TextBox();
            lab_email = new Label();
            lab_showEmail = new Label();
            textBox_email = new TextBox();
            lab_password = new Label();
            textBox_password = new TextBox();
            but_changeLogin = new Button();
            but_changeEmail = new Button();
            but_changePassword = new Button();
            but_logOut = new Button();
            but_deleteAccount = new Button();
            but_save = new Button();
            but_cancel = new Button();
            SuspendLayout();
            // 
            // lab_settingAcc
            // 
            lab_settingAcc.AutoSize = true;
            lab_settingAcc.BackColor = Color.Transparent;
            lab_settingAcc.Location = new Point(264, 28);
            lab_settingAcc.Name = "lab_settingAcc";
            lab_settingAcc.Size = new Size(148, 20);
            lab_settingAcc.TabIndex = 0;
            lab_settingAcc.Text = "Настройки аккаунта";
            // 
            // lab_login
            // 
            lab_login.AutoSize = true;
            lab_login.BackColor = Color.Transparent;
            lab_login.Location = new Point(97, 109);
            lab_login.Name = "lab_login";
            lab_login.Size = new Size(52, 20);
            lab_login.TabIndex = 1;
            lab_login.Text = "Логин";
            // 
            // lab_showLogin
            // 
            lab_showLogin.AutoSize = true;
            lab_showLogin.BackColor = Color.Transparent;
            lab_showLogin.Location = new Point(211, 108);
            lab_showLogin.Name = "lab_showLogin";
            lab_showLogin.Size = new Size(0, 20);
            lab_showLogin.TabIndex = 2;
            // 
            // textBox_login
            // 
            textBox_login.Location = new Point(313, 109);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(125, 27);
            textBox_login.TabIndex = 3;
            // 
            // lab_email
            // 
            lab_email.AutoSize = true;
            lab_email.BackColor = Color.Transparent;
            lab_email.Location = new Point(89, 190);
            lab_email.Name = "lab_email";
            lab_email.Size = new Size(69, 20);
            lab_email.TabIndex = 4;
            lab_email.Text = "Эл.почта";
            // 
            // lab_showEmail
            // 
            lab_showEmail.AutoSize = true;
            lab_showEmail.BackColor = Color.Transparent;
            lab_showEmail.Location = new Point(198, 189);
            lab_showEmail.Name = "lab_showEmail";
            lab_showEmail.Size = new Size(0, 20);
            lab_showEmail.TabIndex = 5;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(331, 189);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(125, 27);
            textBox_email.TabIndex = 6;
            // 
            // lab_password
            // 
            lab_password.AutoSize = true;
            lab_password.BackColor = Color.Transparent;
            lab_password.Location = new Point(105, 262);
            lab_password.Name = "lab_password";
            lab_password.Size = new Size(62, 20);
            lab_password.TabIndex = 7;
            lab_password.Text = "Пароль";
            // 
            // textBox_password
            // 
            textBox_password.Location = new Point(264, 262);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(125, 27);
            textBox_password.TabIndex = 8;
            // 
            // but_changeLogin
            // 
            but_changeLogin.Location = new Point(25, 315);
            but_changeLogin.Name = "but_changeLogin";
            but_changeLogin.Size = new Size(279, 44);
            but_changeLogin.TabIndex = 9;
            but_changeLogin.Text = "Изменить логин";
            but_changeLogin.UseVisualStyleBackColor = true;
            but_changeLogin.Click += but_changeLogin_Click;
            // 
            // but_changeEmail
            // 
            but_changeEmail.Location = new Point(25, 365);
            but_changeEmail.Name = "but_changeEmail";
            but_changeEmail.Size = new Size(279, 44);
            but_changeEmail.TabIndex = 10;
            but_changeEmail.Text = "Изменить почту";
            but_changeEmail.UseVisualStyleBackColor = true;
            but_changeEmail.Click += but_changeEmail_Click;
            // 
            // but_changePassword
            // 
            but_changePassword.Location = new Point(25, 415);
            but_changePassword.Name = "but_changePassword";
            but_changePassword.Size = new Size(279, 44);
            but_changePassword.TabIndex = 11;
            but_changePassword.Text = "Изменить пароль";
            but_changePassword.UseVisualStyleBackColor = true;
            but_changePassword.Click += but_changePassword_Click;
            // 
            // but_logOut
            // 
            but_logOut.Location = new Point(25, 465);
            but_logOut.Name = "but_logOut";
            but_logOut.Size = new Size(279, 44);
            but_logOut.TabIndex = 12;
            but_logOut.Text = "Выйти";
            but_logOut.UseVisualStyleBackColor = true;
            but_logOut.Click += but_logOut_Click;
            // 
            // but_deleteAccount
            // 
            but_deleteAccount.Location = new Point(25, 515);
            but_deleteAccount.Name = "but_deleteAccount";
            but_deleteAccount.Size = new Size(279, 76);
            but_deleteAccount.TabIndex = 13;
            but_deleteAccount.Text = "Удалить";
            but_deleteAccount.UseVisualStyleBackColor = true;
            but_deleteAccount.Click += but_deleteAccount_Click;
            // 
            // but_save
            // 
            but_save.Location = new Point(435, 399);
            but_save.Name = "but_save";
            but_save.Size = new Size(156, 81);
            but_save.TabIndex = 14;
            but_save.Text = "Сохранить";
            but_save.UseVisualStyleBackColor = true;
            but_save.Click += but_save_Click;
            // 
            // but_cancel
            // 
            but_cancel.Location = new Point(435, 503);
            but_cancel.Name = "but_cancel";
            but_cancel.Size = new Size(156, 44);
            but_cancel.TabIndex = 15;
            but_cancel.Text = "Отмена";
            but_cancel.UseVisualStyleBackColor = true;
            but_cancel.Click += but_cancel_Click;
            // 
            // SettingAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(652, 603);
            Controls.Add(but_cancel);
            Controls.Add(but_save);
            Controls.Add(but_deleteAccount);
            Controls.Add(but_logOut);
            Controls.Add(but_changePassword);
            Controls.Add(but_changeEmail);
            Controls.Add(but_changeLogin);
            Controls.Add(textBox_password);
            Controls.Add(lab_password);
            Controls.Add(textBox_email);
            Controls.Add(lab_showEmail);
            Controls.Add(lab_email);
            Controls.Add(textBox_login);
            Controls.Add(lab_showLogin);
            Controls.Add(lab_login);
            Controls.Add(lab_settingAcc);
            DoubleBuffered = true;
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingAccount";
            Text = "SettingAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_settingAcc;
        private Label lab_login;
        private Label lab_showLogin;
        private TextBox textBox_login;
        private Label lab_email;
        private Label lab_showEmail;
        private TextBox textBox_email;
        private Label lab_password;
        private TextBox textBox_password;
        private Button but_changeLogin;
        private Button but_changeEmail;
        private Button but_changePassword;
        private Button but_logOut;
        private Button but_deleteAccount;
        private Button but_save;
        private Button but_cancel;
    }
}