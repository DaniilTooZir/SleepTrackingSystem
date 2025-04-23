namespace SleepTrackingSystem.Forms
{
    partial class SleepTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SleepTracking));
            lab_sleepTracking = new Label();
            but_addRecord = new Button();
            dataGridView_show = new DataGridView();
            Column_dateRecord = new DataGridViewTextBoxColumn();
            Column_timeStart = new DataGridViewTextBoxColumn();
            Column_timeEnd = new DataGridViewTextBoxColumn();
            Column_sleepDuration = new DataGridViewTextBoxColumn();
            Column_sleepQuality = new DataGridViewTextBoxColumn();
            but_back = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_show).BeginInit();
            SuspendLayout();
            // 
            // lab_sleepTracking
            // 
            lab_sleepTracking.AutoSize = true;
            lab_sleepTracking.BackColor = Color.Transparent;
            lab_sleepTracking.ForeColor = Color.White;
            lab_sleepTracking.Location = new Point(344, 14);
            lab_sleepTracking.Name = "lab_sleepTracking";
            lab_sleepTracking.Size = new Size(130, 20);
            lab_sleepTracking.TabIndex = 0;
            lab_sleepTracking.Text = "Отслежвание сна";
            // 
            // but_addRecord
            // 
            but_addRecord.BackColor = Color.MediumPurple;
            but_addRecord.ForeColor = Color.White;
            but_addRecord.Location = new Point(94, 60);
            but_addRecord.Name = "but_addRecord";
            but_addRecord.Size = new Size(150, 30);
            but_addRecord.TabIndex = 1;
            but_addRecord.Text = "Добавить запись";
            but_addRecord.UseVisualStyleBackColor = false;
            but_addRecord.Click += but_addRecord_Click;
            // 
            // dataGridView_show
            // 
            dataGridView_show.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_show.Columns.AddRange(new DataGridViewColumn[] { Column_dateRecord, Column_timeStart, Column_timeEnd, Column_sleepDuration, Column_sleepQuality });
            dataGridView_show.Location = new Point(12, 145);
            dataGridView_show.Name = "dataGridView_show";
            dataGridView_show.RowHeadersWidth = 51;
            dataGridView_show.Size = new Size(776, 293);
            dataGridView_show.TabIndex = 2;
            // 
            // Column_dateRecord
            // 
            Column_dateRecord.HeaderText = "Дата записи";
            Column_dateRecord.MinimumWidth = 6;
            Column_dateRecord.Name = "Column_dateRecord";
            Column_dateRecord.Width = 125;
            // 
            // Column_timeStart
            // 
            Column_timeStart.HeaderText = "Время начала сна";
            Column_timeStart.MinimumWidth = 6;
            Column_timeStart.Name = "Column_timeStart";
            Column_timeStart.Width = 125;
            // 
            // Column_timeEnd
            // 
            Column_timeEnd.HeaderText = "Время конца сна";
            Column_timeEnd.MinimumWidth = 6;
            Column_timeEnd.Name = "Column_timeEnd";
            Column_timeEnd.Width = 125;
            // 
            // Column_sleepDuration
            // 
            Column_sleepDuration.HeaderText = "Продолжительность сна(ч)";
            Column_sleepDuration.MinimumWidth = 6;
            Column_sleepDuration.Name = "Column_sleepDuration";
            Column_sleepDuration.Width = 125;
            // 
            // Column_sleepQuality
            // 
            Column_sleepQuality.HeaderText = "Качество сна";
            Column_sleepQuality.MinimumWidth = 6;
            Column_sleepQuality.Name = "Column_sleepQuality";
            Column_sleepQuality.Width = 125;
            // 
            // but_back
            // 
            but_back.BackColor = Color.MediumPurple;
            but_back.ForeColor = Color.White;
            but_back.Location = new Point(625, 61);
            but_back.Name = "but_back";
            but_back.Size = new Size(163, 29);
            but_back.TabIndex = 3;
            but_back.Text = "Вернуться назад";
            but_back.UseVisualStyleBackColor = false;
            but_back.Click += but_back_Click;
            // 
            // SleepTracking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(but_back);
            Controls.Add(dataGridView_show);
            Controls.Add(but_addRecord);
            Controls.Add(lab_sleepTracking);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SleepTracking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SleepFlux";
            FormClosing += SleepTracking_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView_show).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lab_sleepTracking;
        private Button but_addRecord;
        private DataGridView dataGridView_show;
        private DataGridViewTextBoxColumn Column_dateRecord;
        private DataGridViewTextBoxColumn Column_timeStart;
        private DataGridViewTextBoxColumn Column_timeEnd;
        private DataGridViewTextBoxColumn Column_sleepDuration;
        private DataGridViewTextBoxColumn Column_sleepQuality;
        private Button but_back;
    }
}