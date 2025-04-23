namespace SleepTrackingSystem
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            lab_auth = new Label();
            lab_login = new Label();
            textBox_login = new TextBox();
            lab_password = new Label();
            textBox_password = new TextBox();
            but_logIn = new Button();
            lab_reg = new Label();
            lab_guestLogin = new Label();
            SuspendLayout();
            // 
            // lab_auth
            // 
            lab_auth.AutoSize = true;
            lab_auth.BackColor = Color.Transparent;
            lab_auth.ForeColor = Color.White;
            lab_auth.Location = new Point(155, 8);
            lab_auth.Name = "lab_auth";
            lab_auth.Size = new Size(101, 20);
            lab_auth.TabIndex = 0;
            lab_auth.Text = "Авторизация";
            // 
            // lab_login
            // 
            lab_login.AutoSize = true;
            lab_login.BackColor = Color.Transparent;
            lab_login.ForeColor = Color.White;
            lab_login.Location = new Point(53, 49);
            lab_login.Name = "lab_login";
            lab_login.Size = new Size(52, 20);
            lab_login.TabIndex = 1;
            lab_login.Text = "Логин";
            // 
            // textBox_login
            // 
            textBox_login.BackColor = Color.White;
            textBox_login.ForeColor = Color.Black;
            textBox_login.Location = new Point(159, 49);
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(125, 27);
            textBox_login.TabIndex = 2;
            // 
            // lab_password
            // 
            lab_password.AutoSize = true;
            lab_password.BackColor = Color.Transparent;
            lab_password.ForeColor = Color.White;
            lab_password.Location = new Point(55, 97);
            lab_password.Name = "lab_password";
            lab_password.Size = new Size(62, 20);
            lab_password.TabIndex = 3;
            lab_password.Text = "Пароль";
            // 
            // textBox_password
            // 
            textBox_password.BackColor = Color.White;
            textBox_password.ForeColor = Color.Black;
            textBox_password.Location = new Point(159, 97);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.Size = new Size(125, 27);
            textBox_password.TabIndex = 4;
            // 
            // but_logIn
            // 
            but_logIn.BackColor = Color.MediumPurple;
            but_logIn.ForeColor = Color.White;
            but_logIn.Location = new Point(155, 148);
            but_logIn.Name = "but_logIn";
            but_logIn.Size = new Size(98, 38);
            but_logIn.TabIndex = 5;
            but_logIn.Text = "Войти";
            but_logIn.UseVisualStyleBackColor = false;
            but_logIn.Click += but_logIn_Click;
            // 
            // lab_reg
            // 
            lab_reg.AutoSize = true;
            lab_reg.BackColor = Color.MediumPurple;
            lab_reg.BorderStyle = BorderStyle.Fixed3D;
            lab_reg.ForeColor = Color.White;
            lab_reg.Location = new Point(133, 199);
            lab_reg.Name = "lab_reg";
            lab_reg.Size = new Size(153, 22);
            lab_reg.TabIndex = 6;
            lab_reg.Text = "Зарегистрироваться";
            lab_reg.Click += lab_reg_Click;
            // 
            // lab_guestLogin
            // 
            lab_guestLogin.AutoSize = true;
            lab_guestLogin.BackColor = Color.Transparent;
            lab_guestLogin.Location = new Point(155, 253);
            lab_guestLogin.Name = "lab_guestLogin";
            lab_guestLogin.Size = new Size(117, 20);
            lab_guestLogin.TabIndex = 7;
            lab_guestLogin.Text = "Войти как гость";
            lab_guestLogin.Click += lab_guestLogin_Click;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(382, 282);
            Controls.Add(lab_guestLogin);
            Controls.Add(lab_reg);
            Controls.Add(but_logIn);
            Controls.Add(textBox_password);
            Controls.Add(lab_password);
            Controls.Add(textBox_login);
            Controls.Add(lab_login);
            Controls.Add(lab_auth);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Authorization";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SleepFlux";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_auth;
        private Label lab_login;
        private TextBox textBox_login;
        private Label lab_password;
        private TextBox textBox_password;
        private Button but_logIn;
        private Label lab_reg;
        private Label lab_guestLogin;
    }
}