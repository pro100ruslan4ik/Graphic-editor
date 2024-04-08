namespace graphicEditor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            pictureBox = new PictureBox();
            panel2 = new Panel();
            widthLabel = new Label();
            modeLabel = new Label();
            shapeButton14 = new Button();
            shapeButton13 = new Button();
            shapeButton12 = new Button();
            shapeButton11 = new Button();
            colorButton10 = new Button();
            colorButton9 = new Button();
            colorButton8 = new Button();
            colorButton7 = new Button();
            colorButton6 = new Button();
            colorButton5 = new Button();
            colorButton4 = new Button();
            colorButton3 = new Button();
            widthTrackBar1 = new TrackBar();
            colorButton2 = new Button();
            currColButton1 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            shapeButton15 = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)widthTrackBar1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, оПрограммеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1370, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, открытьToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(133, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(94, 20);
            оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 725);
            panel1.TabIndex = 1;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1370, 725);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.Click += pictureBox_Click;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // panel2
            // 
            panel2.Controls.Add(shapeButton15);
            panel2.Controls.Add(widthLabel);
            panel2.Controls.Add(modeLabel);
            panel2.Controls.Add(shapeButton14);
            panel2.Controls.Add(shapeButton13);
            panel2.Controls.Add(shapeButton12);
            panel2.Controls.Add(shapeButton11);
            panel2.Controls.Add(colorButton10);
            panel2.Controls.Add(colorButton9);
            panel2.Controls.Add(colorButton8);
            panel2.Controls.Add(colorButton7);
            panel2.Controls.Add(colorButton6);
            panel2.Controls.Add(colorButton5);
            panel2.Controls.Add(colorButton4);
            panel2.Controls.Add(colorButton3);
            panel2.Controls.Add(widthTrackBar1);
            panel2.Controls.Add(colorButton2);
            panel2.Controls.Add(currColButton1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 24);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 95);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Location = new Point(26, 62);
            widthLabel.Margin = new Padding(4, 0, 4, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(38, 15);
            widthLabel.TabIndex = 3;
            widthLabel.Text = "label1";
            widthLabel.Click += widthLabel_Click;
            // 
            // modeLabel
            // 
            modeLabel.AutoSize = true;
            modeLabel.Location = new Point(671, 62);
            modeLabel.Margin = new Padding(4, 0, 4, 0);
            modeLabel.Name = "modeLabel";
            modeLabel.Size = new Size(38, 15);
            modeLabel.TabIndex = 15;
            modeLabel.Text = "label2";
            // 
            // shapeButton14
            // 
            shapeButton14.BackgroundImage = (Image)resources.GetObject("shapeButton14.BackgroundImage");
            shapeButton14.BackgroundImageLayout = ImageLayout.Stretch;
            shapeButton14.FlatStyle = FlatStyle.Flat;
            shapeButton14.Location = new Point(806, 12);
            shapeButton14.Margin = new Padding(4, 3, 4, 3);
            shapeButton14.Name = "shapeButton14";
            shapeButton14.Size = new Size(37, 36);
            shapeButton14.TabIndex = 14;
            shapeButton14.UseVisualStyleBackColor = true;
            shapeButton14.Click += button14_Click;
            shapeButton14.MouseDown += button14_MouseDown;
            // 
            // shapeButton13
            // 
            shapeButton13.BackgroundImage = (Image)resources.GetObject("shapeButton13.BackgroundImage");
            shapeButton13.BackgroundImageLayout = ImageLayout.Stretch;
            shapeButton13.FlatStyle = FlatStyle.Flat;
            shapeButton13.Location = new Point(763, 12);
            shapeButton13.Margin = new Padding(4, 3, 4, 3);
            shapeButton13.Name = "shapeButton13";
            shapeButton13.Size = new Size(36, 36);
            shapeButton13.TabIndex = 13;
            shapeButton13.UseVisualStyleBackColor = true;
            shapeButton13.Click += button13_Click;
            // 
            // shapeButton12
            // 
            shapeButton12.BackgroundImage = (Image)resources.GetObject("shapeButton12.BackgroundImage");
            shapeButton12.BackgroundImageLayout = ImageLayout.Stretch;
            shapeButton12.FlatStyle = FlatStyle.Flat;
            shapeButton12.Location = new Point(718, 12);
            shapeButton12.Margin = new Padding(4, 3, 4, 3);
            shapeButton12.Name = "shapeButton12";
            shapeButton12.Size = new Size(38, 36);
            shapeButton12.TabIndex = 12;
            shapeButton12.UseVisualStyleBackColor = true;
            shapeButton12.Click += button12_Click;
            // 
            // shapeButton11
            // 
            shapeButton11.BackgroundImage = (Image)resources.GetObject("shapeButton11.BackgroundImage");
            shapeButton11.BackgroundImageLayout = ImageLayout.Stretch;
            shapeButton11.FlatStyle = FlatStyle.Flat;
            shapeButton11.Location = new Point(674, 12);
            shapeButton11.Margin = new Padding(4, 3, 4, 3);
            shapeButton11.Name = "shapeButton11";
            shapeButton11.Size = new Size(36, 36);
            shapeButton11.TabIndex = 11;
            shapeButton11.UseVisualStyleBackColor = true;
            shapeButton11.Click += button11_Click;
            shapeButton11.MouseUp += button11_MouseUp;
            // 
            // colorButton10
            // 
            colorButton10.BackColor = Color.Black;
            colorButton10.Location = new Point(576, 10);
            colorButton10.Margin = new Padding(4, 3, 4, 3);
            colorButton10.Name = "colorButton10";
            colorButton10.Size = new Size(36, 37);
            colorButton10.TabIndex = 10;
            colorButton10.UseVisualStyleBackColor = false;
            colorButton10.Click += button10_Click;
            // 
            // colorButton9
            // 
            colorButton9.BackColor = Color.Crimson;
            colorButton9.Location = new Point(533, 10);
            colorButton9.Margin = new Padding(4, 3, 4, 3);
            colorButton9.Name = "colorButton9";
            colorButton9.Size = new Size(35, 37);
            colorButton9.TabIndex = 9;
            colorButton9.UseVisualStyleBackColor = false;
            colorButton9.Click += button9_Click;
            // 
            // colorButton8
            // 
            colorButton8.BackColor = Color.Orchid;
            colorButton8.Location = new Point(488, 10);
            colorButton8.Margin = new Padding(4, 3, 4, 3);
            colorButton8.Name = "colorButton8";
            colorButton8.Size = new Size(37, 37);
            colorButton8.TabIndex = 8;
            colorButton8.UseVisualStyleBackColor = false;
            colorButton8.Click += button8_Click;
            // 
            // colorButton7
            // 
            colorButton7.BackColor = Color.MediumBlue;
            colorButton7.Location = new Point(442, 10);
            colorButton7.Margin = new Padding(4, 3, 4, 3);
            colorButton7.Name = "colorButton7";
            colorButton7.Size = new Size(37, 37);
            colorButton7.TabIndex = 7;
            colorButton7.UseVisualStyleBackColor = false;
            colorButton7.Click += button7_Click;
            // 
            // colorButton6
            // 
            colorButton6.BackColor = Color.Turquoise;
            colorButton6.Location = new Point(397, 10);
            colorButton6.Margin = new Padding(4, 3, 4, 3);
            colorButton6.Name = "colorButton6";
            colorButton6.Size = new Size(37, 37);
            colorButton6.TabIndex = 6;
            colorButton6.UseVisualStyleBackColor = false;
            colorButton6.Click += button6_Click;
            // 
            // colorButton5
            // 
            colorButton5.BackColor = Color.GreenYellow;
            colorButton5.Location = new Point(351, 10);
            colorButton5.Margin = new Padding(4, 3, 4, 3);
            colorButton5.Name = "colorButton5";
            colorButton5.Size = new Size(37, 37);
            colorButton5.TabIndex = 5;
            colorButton5.UseVisualStyleBackColor = false;
            colorButton5.Click += button5_Click;
            // 
            // colorButton4
            // 
            colorButton4.BackColor = Color.Gold;
            colorButton4.ForeColor = SystemColors.ControlText;
            colorButton4.Location = new Point(306, 10);
            colorButton4.Margin = new Padding(4, 3, 4, 3);
            colorButton4.Name = "colorButton4";
            colorButton4.Size = new Size(37, 37);
            colorButton4.TabIndex = 4;
            colorButton4.UseVisualStyleBackColor = false;
            colorButton4.Click += button4_Click;
            // 
            // colorButton3
            // 
            colorButton3.BackColor = Color.DarkOrange;
            colorButton3.Location = new Point(259, 10);
            colorButton3.Margin = new Padding(4, 3, 4, 3);
            colorButton3.Name = "colorButton3";
            colorButton3.Size = new Size(38, 37);
            colorButton3.TabIndex = 3;
            colorButton3.UseVisualStyleBackColor = false;
            colorButton3.Click += button3_Click;
            // 
            // widthTrackBar1
            // 
            widthTrackBar1.Location = new Point(14, 10);
            widthTrackBar1.Margin = new Padding(4, 3, 4, 3);
            widthTrackBar1.Name = "widthTrackBar1";
            widthTrackBar1.Size = new Size(121, 45);
            widthTrackBar1.TabIndex = 2;
            widthTrackBar1.Scroll += widthTrackBar1_Scroll;
            // 
            // colorButton2
            // 
            colorButton2.BackColor = Color.Maroon;
            colorButton2.ForeColor = SystemColors.ButtonHighlight;
            colorButton2.Location = new Point(215, 10);
            colorButton2.Margin = new Padding(4, 3, 4, 3);
            colorButton2.Name = "colorButton2";
            colorButton2.Size = new Size(37, 37);
            colorButton2.TabIndex = 1;
            colorButton2.UseVisualStyleBackColor = false;
            colorButton2.Click += button2_Click;
            // 
            // currColButton1
            // 
            currColButton1.BackColor = SystemColors.ActiveCaptionText;
            currColButton1.ForeColor = SystemColors.ButtonHighlight;
            currColButton1.Location = new Point(142, 10);
            currColButton1.Margin = new Padding(4, 3, 4, 3);
            currColButton1.Name = "currColButton1";
            currColButton1.Size = new Size(37, 37);
            currColButton1.TabIndex = 0;
            currColButton1.UseVisualStyleBackColor = false;
            currColButton1.Click += button1_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // shapeButton15
            // 
            shapeButton15.BackgroundImage = (Image)resources.GetObject("shapeButton15.BackgroundImage");
            shapeButton15.BackgroundImageLayout = ImageLayout.Stretch;
            shapeButton15.FlatStyle = FlatStyle.Flat;
            shapeButton15.Location = new Point(851, 12);
            shapeButton15.Margin = new Padding(4, 3, 4, 3);
            shapeButton15.Name = "shapeButton15";
            shapeButton15.Size = new Size(37, 36);
            shapeButton15.TabIndex = 17;
            shapeButton15.UseVisualStyleBackColor = true;
            shapeButton15.Click += shapeButton15_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)widthTrackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox;
        private Button colorButton2;
        private Button currColButton1;
        private TrackBar widthTrackBar1;
        private Button colorButton9;
        private Button colorButton8;
        private Button colorButton7;
        private Button colorButton6;
        private Button colorButton5;
        private Button colorButton4;
        private Button colorButton3;
        private Button colorButton10;
        private Button shapeButton13;
        private Button shapeButton12;
        private Button shapeButton11;
        private Button shapeButton14;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Label widthLabel;
        private Label modeLabel;
        private Button shapeButton15;
    }
}

