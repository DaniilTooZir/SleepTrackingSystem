namespace SleepTrackingSystem.Forms
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            lab_title = new Label();
            lab_login = new Label();
            lab_showLogin = new Label();
            but_editLogin = new Button();
            lab_description = new Label();
            txtBox_description = new TextBox();
            SuspendLayout();
            // 
            // lab_title
            // 
            lab_title.AutoSize = true;
            lab_title.BackColor = Color.Transparent;
            lab_title.Location = new Point(164, 19);
            lab_title.Name = "lab_title";
            lab_title.Size = new Size(73, 20);
            lab_title.TabIndex = 0;
            lab_title.Text = "Профиль";
            // 
            // lab_login
            // 
            lab_login.AutoSize = true;
            lab_login.BackColor = Color.Transparent;
            lab_login.Location = new Point(59, 113);
            lab_login.Name = "lab_login";
            lab_login.Size = new Size(52, 20);
            lab_login.TabIndex = 1;
            lab_login.Text = "Логин";
            // 
            // lab_showLogin
            // 
            lab_showLogin.AutoSize = true;
            lab_showLogin.BackColor = Color.Transparent;
            lab_showLogin.Location = new Point(164, 113);
            lab_showLogin.Name = "lab_showLogin";
            lab_showLogin.Size = new Size(0, 20);
            lab_showLogin.TabIndex = 2;
            // 
            // but_editLogin
            // 
            but_editLogin.Location = new Point(275, 104);
            but_editLogin.Name = "but_editLogin";
            but_editLogin.Size = new Size(106, 40);
            but_editLogin.TabIndex = 3;
            but_editLogin.Text = "Изменить";
            but_editLogin.UseVisualStyleBackColor = true;
            // 
            // lab_description
            // 
            lab_description.AutoSize = true;
            lab_description.BackColor = Color.Transparent;
            lab_description.Location = new Point(83, 332);
            lab_description.Name = "lab_description";
            lab_description.Size = new Size(56, 20);
            lab_description.TabIndex = 4;
            lab_description.Text = "О себе";
            // 
            // txtBox_description
            // 
            txtBox_description.Location = new Point(83, 385);
            txtBox_description.Name = "txtBox_description";
            txtBox_description.Size = new Size(125, 27);
            txtBox_description.TabIndex = 5;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(652, 603);
            Controls.Add(txtBox_description);
            Controls.Add(lab_description);
            Controls.Add(but_editLogin);
            Controls.Add(lab_showLogin);
            Controls.Add(lab_login);
            Controls.Add(lab_title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_title;
        private Label lab_login;
        private Label lab_showLogin;
        private Button but_editLogin;
        private Label lab_description;
        private TextBox txtBox_description;
    }
}