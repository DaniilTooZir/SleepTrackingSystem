namespace SleepTrackingSystem
{
    partial class Recommendations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recommendations));
            richTextBox_recommend = new RichTextBox();
            lab_title = new Label();
            but_update = new Button();
            but_close = new Button();
            SuspendLayout();
            // 
            // richTextBox_recommend
            // 
            richTextBox_recommend.BackColor = Color.MediumPurple;
            richTextBox_recommend.ForeColor = Color.White;
            richTextBox_recommend.Location = new Point(12, 51);
            richTextBox_recommend.Name = "richTextBox_recommend";
            richTextBox_recommend.Size = new Size(558, 243);
            richTextBox_recommend.TabIndex = 0;
            richTextBox_recommend.Text = "";
            // 
            // lab_title
            // 
            lab_title.AutoSize = true;
            lab_title.BackColor = Color.Transparent;
            lab_title.Location = new Point(217, 9);
            lab_title.Name = "lab_title";
            lab_title.Size = new Size(112, 20);
            lab_title.TabIndex = 1;
            lab_title.Text = "Рекомендации";
            // 
            // but_update
            // 
            but_update.BackColor = Color.MediumPurple;
            but_update.Location = new Point(235, 312);
            but_update.Name = "but_update";
            but_update.Size = new Size(94, 29);
            but_update.TabIndex = 2;
            but_update.Text = "Обновить";
            but_update.UseVisualStyleBackColor = false;
            but_update.Click += but_update_Click;
            // 
            // but_close
            // 
            but_close.BackColor = Color.MediumPurple;
            but_close.Location = new Point(459, 312);
            but_close.Name = "but_close";
            but_close.Size = new Size(94, 29);
            but_close.TabIndex = 3;
            but_close.Text = "Закрыть";
            but_close.UseVisualStyleBackColor = false;
            but_close.Click += but_close_Click;
            // 
            // Recommendations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(582, 353);
            Controls.Add(but_close);
            Controls.Add(but_update);
            Controls.Add(lab_title);
            Controls.Add(richTextBox_recommend);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Recommendations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SleepFlux";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_recommend;
        private Label lab_title;
        private Button but_update;
        private Button but_close;
    }
}