namespace SleepTrackingSystem.Forms
{
    partial class AddPersonalData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPersonalData));
            lab_name = new Label();
            lab_gender = new Label();
            lab_dateBirth = new Label();
            but_apply = new Button();
            but_cancel = new Button();
            textBox_name = new TextBox();
            lab_title = new Label();
            comboBox_gender = new ComboBox();
            dateTimePicker_birthDate = new DateTimePicker();
            SuspendLayout();
            // 
            // lab_name
            // 
            lab_name.AutoSize = true;
            lab_name.BackColor = Color.Transparent;
            lab_name.Location = new Point(51, 78);
            lab_name.Name = "lab_name";
            lab_name.Size = new Size(39, 20);
            lab_name.TabIndex = 0;
            lab_name.Text = "Имя";
            // 
            // lab_gender
            // 
            lab_gender.AutoSize = true;
            lab_gender.BackColor = Color.Transparent;
            lab_gender.Location = new Point(51, 116);
            lab_gender.Name = "lab_gender";
            lab_gender.Size = new Size(37, 20);
            lab_gender.TabIndex = 1;
            lab_gender.Text = "Пол";
            // 
            // lab_dateBirth
            // 
            lab_dateBirth.AutoSize = true;
            lab_dateBirth.BackColor = Color.Transparent;
            lab_dateBirth.Location = new Point(51, 154);
            lab_dateBirth.Name = "lab_dateBirth";
            lab_dateBirth.Size = new Size(41, 20);
            lab_dateBirth.TabIndex = 2;
            lab_dateBirth.Text = "Дата";
            // 
            // but_apply
            // 
            but_apply.Location = new Point(51, 276);
            but_apply.Name = "but_apply";
            but_apply.Size = new Size(150, 42);
            but_apply.TabIndex = 3;
            but_apply.Text = "Изменить";
            but_apply.UseVisualStyleBackColor = true;
            but_apply.Click += but_apply_Click;
            // 
            // but_cancel
            // 
            but_cancel.Location = new Point(217, 275);
            but_cancel.Name = "but_cancel";
            but_cancel.Size = new Size(128, 43);
            but_cancel.TabIndex = 4;
            but_cancel.Text = "Отмена";
            but_cancel.UseVisualStyleBackColor = true;
            but_cancel.Click += but_cancel_Click;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(204, 75);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(125, 27);
            textBox_name.TabIndex = 5;
            textBox_name.KeyPress += textBox_name_KeyPress;
            // 
            // lab_title
            // 
            lab_title.AutoSize = true;
            lab_title.BackColor = Color.Transparent;
            lab_title.Location = new Point(150, 32);
            lab_title.Name = "lab_title";
            lab_title.Size = new Size(145, 20);
            lab_title.TabIndex = 8;
            lab_title.Text = "Изменение данных";
            // 
            // comboBox_gender
            // 
            comboBox_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_gender.FormattingEnabled = true;
            comboBox_gender.Items.AddRange(new object[] { "Мужчина", "Женщина", "Не указано" });
            comboBox_gender.Location = new Point(204, 116);
            comboBox_gender.Name = "comboBox_gender";
            comboBox_gender.Size = new Size(125, 28);
            comboBox_gender.TabIndex = 9;
            // 
            // dateTimePicker_birthDate
            // 
            dateTimePicker_birthDate.Location = new Point(176, 154);
            dateTimePicker_birthDate.Name = "dateTimePicker_birthDate";
            dateTimePicker_birthDate.Size = new Size(182, 27);
            dateTimePicker_birthDate.TabIndex = 10;
            // 
            // AddPersonalData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(382, 353);
            Controls.Add(dateTimePicker_birthDate);
            Controls.Add(comboBox_gender);
            Controls.Add(lab_title);
            Controls.Add(textBox_name);
            Controls.Add(but_cancel);
            Controls.Add(but_apply);
            Controls.Add(lab_dateBirth);
            Controls.Add(lab_gender);
            Controls.Add(lab_name);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddPersonalData";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление данных";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_name;
        private Label lab_gender;
        private Label lab_dateBirth;
        private Button but_apply;
        private Button but_cancel;
        private TextBox textBox_name;
        private Label lab_title;
        private ComboBox comboBox_gender;
        private DateTimePicker dateTimePicker_birthDate;
    }
}