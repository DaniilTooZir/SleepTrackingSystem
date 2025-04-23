namespace SleepTrackingSystem
{
    partial class AddingSleepRecording
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingSleepRecording));
            lab_addRecord = new Label();
            lab_date = new Label();
            lab_timeStart = new Label();
            lab_timeEnd = new Label();
            lab_sleepQuality = new Label();
            but_save = new Button();
            but_back = new Button();
            dateTimePicker_date = new DateTimePicker();
            dateTimePicker_tStart = new DateTimePicker();
            dateTimePicker_tEnd = new DateTimePicker();
            comboBox_quality = new ComboBox();
            SuspendLayout();
            // 
            // lab_addRecord
            // 
            lab_addRecord.AutoSize = true;
            lab_addRecord.BackColor = Color.Transparent;
            lab_addRecord.ForeColor = Color.White;
            lab_addRecord.Location = new Point(109, 9);
            lab_addRecord.Name = "lab_addRecord";
            lab_addRecord.Size = new Size(176, 20);
            lab_addRecord.TabIndex = 0;
            lab_addRecord.Text = "Добавление записи сна";
            // 
            // lab_date
            // 
            lab_date.AutoSize = true;
            lab_date.BackColor = Color.Transparent;
            lab_date.ForeColor = Color.White;
            lab_date.Location = new Point(41, 52);
            lab_date.Name = "lab_date";
            lab_date.Size = new Size(41, 20);
            lab_date.TabIndex = 1;
            lab_date.Text = "Дата";
            // 
            // lab_timeStart
            // 
            lab_timeStart.AutoSize = true;
            lab_timeStart.BackColor = Color.Transparent;
            lab_timeStart.ForeColor = Color.White;
            lab_timeStart.Location = new Point(41, 83);
            lab_timeStart.Name = "lab_timeStart";
            lab_timeStart.Size = new Size(107, 20);
            lab_timeStart.TabIndex = 2;
            lab_timeStart.Text = "Время начала";
            // 
            // lab_timeEnd
            // 
            lab_timeEnd.AutoSize = true;
            lab_timeEnd.BackColor = Color.Transparent;
            lab_timeEnd.ForeColor = Color.White;
            lab_timeEnd.Location = new Point(41, 114);
            lab_timeEnd.Name = "lab_timeEnd";
            lab_timeEnd.Size = new Size(100, 20);
            lab_timeEnd.TabIndex = 3;
            lab_timeEnd.Text = "Время конца";
            // 
            // lab_sleepQuality
            // 
            lab_sleepQuality.AutoSize = true;
            lab_sleepQuality.BackColor = Color.Transparent;
            lab_sleepQuality.ForeColor = Color.White;
            lab_sleepQuality.Location = new Point(41, 145);
            lab_sleepQuality.Name = "lab_sleepQuality";
            lab_sleepQuality.Size = new Size(100, 20);
            lab_sleepQuality.TabIndex = 5;
            lab_sleepQuality.Text = "Качество сна";
            // 
            // but_save
            // 
            but_save.Location = new Point(59, 202);
            but_save.Name = "but_save";
            but_save.Size = new Size(128, 29);
            but_save.TabIndex = 6;
            but_save.Text = "Сохранить";
            but_save.UseVisualStyleBackColor = true;
            but_save.Click += but_save_Click;
            // 
            // but_back
            // 
            but_back.Location = new Point(204, 202);
            but_back.Name = "but_back";
            but_back.Size = new Size(94, 29);
            but_back.TabIndex = 7;
            but_back.Text = "Отмена";
            but_back.UseVisualStyleBackColor = true;
            but_back.Click += but_back_Click;
            // 
            // dateTimePicker_date
            // 
            dateTimePicker_date.Location = new Point(168, 47);
            dateTimePicker_date.Name = "dateTimePicker_date";
            dateTimePicker_date.Size = new Size(186, 27);
            dateTimePicker_date.TabIndex = 8;
            // 
            // dateTimePicker_tStart
            // 
            dateTimePicker_tStart.Format = DateTimePickerFormat.Time;
            dateTimePicker_tStart.Location = new Point(168, 83);
            dateTimePicker_tStart.Name = "dateTimePicker_tStart";
            dateTimePicker_tStart.Size = new Size(186, 27);
            dateTimePicker_tStart.TabIndex = 9;
            // 
            // dateTimePicker_tEnd
            // 
            dateTimePicker_tEnd.Format = DateTimePickerFormat.Time;
            dateTimePicker_tEnd.Location = new Point(168, 116);
            dateTimePicker_tEnd.Name = "dateTimePicker_tEnd";
            dateTimePicker_tEnd.Size = new Size(186, 27);
            dateTimePicker_tEnd.TabIndex = 10;
            // 
            // comboBox_quality
            // 
            comboBox_quality.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_quality.FormattingEnabled = true;
            comboBox_quality.Items.AddRange(new object[] { "Отличное", "Хорошее", "Среднее", "Плохое", "Ужасное" });
            comboBox_quality.Location = new Point(168, 149);
            comboBox_quality.Name = "comboBox_quality";
            comboBox_quality.Size = new Size(186, 28);
            comboBox_quality.TabIndex = 11;
            // 
            // AddingSleepRecording
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(382, 253);
            Controls.Add(comboBox_quality);
            Controls.Add(dateTimePicker_tEnd);
            Controls.Add(dateTimePicker_tStart);
            Controls.Add(dateTimePicker_date);
            Controls.Add(but_back);
            Controls.Add(but_save);
            Controls.Add(lab_sleepQuality);
            Controls.Add(lab_timeEnd);
            Controls.Add(lab_timeStart);
            Controls.Add(lab_date);
            Controls.Add(lab_addRecord);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddingSleepRecording";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление записи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_addRecord;
        private Label lab_date;
        private Label lab_timeStart;
        private Label lab_timeEnd;
        private Label lab_sleepQuality;
        private Button but_save;
        private Button but_back;
        private DateTimePicker dateTimePicker_date;
        private DateTimePicker dateTimePicker_tStart;
        private DateTimePicker dateTimePicker_tEnd;
        private ComboBox comboBox_quality;
    }
}