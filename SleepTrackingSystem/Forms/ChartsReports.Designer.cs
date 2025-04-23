namespace SleepTrackingSystem
{
    partial class ChartsReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartsReports));
            panel_reports = new Panel();
            label_lastDateRecord = new Label();
            label_avgDuration = new Label();
            label_totalRecording = new Label();
            dateTimePicker_start = new DateTimePicker();
            dateTimePicker_end = new DateTimePicker();
            but_apply = new Button();
            lab_title = new Label();
            plotView_chartSleep = new OxyPlot.WindowsForms.PlotView();
            but_back = new Button();
            panel_reports.SuspendLayout();
            SuspendLayout();
            // 
            // panel_reports
            // 
            panel_reports.BackgroundImage = (Image)resources.GetObject("panel_reports.BackgroundImage");
            panel_reports.Controls.Add(label_lastDateRecord);
            panel_reports.Controls.Add(label_avgDuration);
            panel_reports.Controls.Add(label_totalRecording);
            panel_reports.Location = new Point(71, 444);
            panel_reports.Name = "panel_reports";
            panel_reports.Size = new Size(819, 217);
            panel_reports.TabIndex = 1;
            // 
            // label_lastDateRecord
            // 
            label_lastDateRecord.AutoSize = true;
            label_lastDateRecord.BackColor = Color.Transparent;
            label_lastDateRecord.ForeColor = Color.Transparent;
            label_lastDateRecord.Location = new Point(50, 93);
            label_lastDateRecord.Name = "label_lastDateRecord";
            label_lastDateRecord.Size = new Size(50, 20);
            label_lastDateRecord.TabIndex = 3;
            label_lastDateRecord.Text = "label4";
            // 
            // label_avgDuration
            // 
            label_avgDuration.AutoSize = true;
            label_avgDuration.BackColor = Color.Transparent;
            label_avgDuration.ForeColor = Color.White;
            label_avgDuration.Location = new Point(50, 53);
            label_avgDuration.Name = "label_avgDuration";
            label_avgDuration.Size = new Size(50, 20);
            label_avgDuration.TabIndex = 1;
            label_avgDuration.Text = "label2";
            // 
            // label_totalRecording
            // 
            label_totalRecording.AutoSize = true;
            label_totalRecording.BackColor = Color.Transparent;
            label_totalRecording.ForeColor = Color.White;
            label_totalRecording.Location = new Point(50, 33);
            label_totalRecording.Name = "label_totalRecording";
            label_totalRecording.Size = new Size(50, 20);
            label_totalRecording.TabIndex = 0;
            label_totalRecording.Text = "label1";
            // 
            // dateTimePicker_start
            // 
            dateTimePicker_start.Location = new Point(239, 55);
            dateTimePicker_start.Name = "dateTimePicker_start";
            dateTimePicker_start.Size = new Size(167, 27);
            dateTimePicker_start.TabIndex = 1;
            // 
            // dateTimePicker_end
            // 
            dateTimePicker_end.Location = new Point(412, 55);
            dateTimePicker_end.Name = "dateTimePicker_end";
            dateTimePicker_end.Size = new Size(167, 27);
            dateTimePicker_end.TabIndex = 2;
            // 
            // but_apply
            // 
            but_apply.Location = new Point(585, 56);
            but_apply.Name = "but_apply";
            but_apply.Size = new Size(114, 29);
            but_apply.TabIndex = 3;
            but_apply.Text = "Применить";
            but_apply.UseVisualStyleBackColor = true;
            but_apply.Click += but_apply_Click;
            // 
            // lab_title
            // 
            lab_title.AutoSize = true;
            lab_title.BackColor = Color.Transparent;
            lab_title.ForeColor = Color.Transparent;
            lab_title.Location = new Point(491, 9);
            lab_title.Name = "lab_title";
            lab_title.Size = new Size(59, 20);
            lab_title.TabIndex = 4;
            lab_title.Text = "График";
            // 
            // plotView_chartSleep
            // 
            plotView_chartSleep.Location = new Point(239, 100);
            plotView_chartSleep.Name = "plotView_chartSleep";
            plotView_chartSleep.PanCursor = Cursors.Hand;
            plotView_chartSleep.Size = new Size(534, 300);
            plotView_chartSleep.TabIndex = 5;
            plotView_chartSleep.Text = "plotView1";
            plotView_chartSleep.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView_chartSleep.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView_chartSleep.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // but_back
            // 
            but_back.BackColor = SystemColors.Control;
            but_back.ForeColor = Color.Black;
            but_back.Location = new Point(705, 56);
            but_back.Name = "but_back";
            but_back.Size = new Size(94, 29);
            but_back.TabIndex = 6;
            but_back.Text = "Вернуться назад";
            but_back.UseVisualStyleBackColor = false;
            but_back.Click += but_back_Click;
            // 
            // ChartsReports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 673);
            Controls.Add(but_back);
            Controls.Add(plotView_chartSleep);
            Controls.Add(panel_reports);
            Controls.Add(lab_title);
            Controls.Add(but_apply);
            Controls.Add(dateTimePicker_end);
            Controls.Add(dateTimePicker_start);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ChartsReports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SleepFlux";
            panel_reports.ResumeLayout(false);
            panel_reports.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel_reports;
        private DateTimePicker dateTimePicker_start;
        private DateTimePicker dateTimePicker_end;
        private Button but_apply;
        private Label lab_title;
        private OxyPlot.WindowsForms.PlotView plotView_chartSleep;
        private Label label_lastDateRecord;
        private Label label_avgDuration;
        private Label label_totalRecording;
        private Button but_back;
    }
}