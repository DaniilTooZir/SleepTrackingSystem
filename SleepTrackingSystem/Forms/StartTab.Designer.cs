namespace SleepTrackingSystem
{
    partial class StartTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartTab));
            pictureBox_logo = new PictureBox();
            label_description = new Label();
            but_start = new Button();
            label_exit = new Label();
            lab_welc = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_logo
            // 
            pictureBox_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox_logo.BackColor = Color.Transparent;
            pictureBox_logo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_logo.Image = (Image)resources.GetObject("pictureBox_logo.Image");
            pictureBox_logo.Location = new Point(205, 34);
            pictureBox_logo.Name = "pictureBox_logo";
            pictureBox_logo.Size = new Size(356, 200);
            pictureBox_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_logo.TabIndex = 0;
            pictureBox_logo.TabStop = false;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.BackColor = Color.Transparent;
            label_description.ForeColor = Color.Indigo;
            label_description.Location = new Point(125, 400);
            label_description.Name = "label_description";
            label_description.Size = new Size(436, 20);
            label_description.TabIndex = 2;
            label_description.Text = "Ваш надежный помощник в отслеживании и улучшении сна.";
            // 
            // but_start
            // 
            but_start.BackColor = Color.MediumPurple;
            but_start.ForeColor = Color.White;
            but_start.Location = new Point(247, 440);
            but_start.Name = "but_start";
            but_start.Size = new Size(200, 50);
            but_start.TabIndex = 3;
            but_start.Text = "Войти";
            but_start.UseVisualStyleBackColor = false;
            but_start.Click += but_start_Click;
            // 
            // label_exit
            // 
            label_exit.AutoSize = true;
            label_exit.BackColor = Color.MediumPurple;
            label_exit.BorderStyle = BorderStyle.Fixed3D;
            label_exit.ForeColor = Color.White;
            label_exit.Location = new Point(318, 511);
            label_exit.Name = "label_exit";
            label_exit.Size = new Size(55, 22);
            label_exit.TabIndex = 4;
            label_exit.Text = "Выход";
            label_exit.Click += label_exit_Click;
            // 
            // lab_welc
            // 
            lab_welc.AutoSize = true;
            lab_welc.BackColor = Color.Transparent;
            lab_welc.ForeColor = Color.Indigo;
            lab_welc.Location = new Point(273, 331);
            lab_welc.Name = "lab_welc";
            lab_welc.Size = new Size(226, 20);
            lab_welc.TabIndex = 5;
            lab_welc.Text = "Добро пожаловать в SleepFlux!";
            // 
            // StartTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(782, 553);
            Controls.Add(lab_welc);
            Controls.Add(pictureBox_logo);
            Controls.Add(label_exit);
            Controls.Add(label_description);
            Controls.Add(but_start);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "StartTab";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SleepFlux";
            ((System.ComponentModel.ISupportInitialize)pictureBox_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_logo;
        private Label label_description;
        private Button but_start;
        private Label label_exit;
        private Label lab_welc;
    }
}