using System;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{

    //На будущее
    //сделать ярлык показывающий текущие координаты, сделать возможность переходить вперед, назад (думаю контейнером)
    //сделать реализацию ui через код, 
    //также можно вынести код в отдельный файл, 
    //сделать реализацию сплошного (заливки) рисования фигур, 


    //Изменения
    //сделал треугольник, сделал нормальную рисовку во все стороны, enum Modes, 
    //сделал ярлыки показывающие текущие режим и толщину линии, переименовал некоторые компоненты
    //сделал перо полем класса, чтобы постоянно его не пересоздавать,
    //закоментил одну строчку - получил моментальную рисовку в режиме линии 
    //сделал отображение фигуры перед рисовкой

    public enum Modes
    {
        ellipse,
        line,
        triangle,
        rectangle,
        ray,
        none
    }

    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Bitmap drawingBitmap;

        private Pen pen;

        private int x1;
        private int y1;
        private int xPressed;
        private int yPressed;

        private Modes mode;

        private bool flagToImprovePerformance;
        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(1300, 650);
            drawingBitmap = new Bitmap(1300, 650);

            pen = new Pen(currColButton1.BackColor, widthTrackBar1.Value);
            x1 = 0;
            y1 = 0;

            flagToImprovePerformance = true;

            mode = Modes.line;
            modeLabel.Text = "line";

            widthLabel.Text = widthTrackBar1.Value.ToString();

            saveFileDialog1.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openFileDialog1.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openFileDialog1.FileName = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            xPressed = e.X;
            yPressed = e.Y;
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                pen.Color = currColButton1.BackColor;


                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


                if (mode == Modes.line)
                {
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.DrawLine(pen, x1, y1, e.X, e.Y); 
                }

                if (mode == Modes.ray)
                {
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.DrawLine(pen, xPressed, yPressed, e.X, e.Y);
                }

                if (mode == Modes.rectangle)
                {
                    Graphics drawingGraphics = Graphics.FromImage(drawingBitmap);
                    DrawAnyRectangle(pen, e, drawingGraphics);
                    pictureBox.Image = drawingBitmap;

                    flagToImprovePerformance = !flagToImprovePerformance;

                    if (flagToImprovePerformance)
                        drawingBitmap = (Bitmap)bitmap.Clone();

                    return;
                }

                if (mode == Modes.ellipse)
                {
                    Graphics drawingGraphics = Graphics.FromImage(drawingBitmap);
                    DrawAnyEllipse(pen, e, drawingGraphics);
                    pictureBox.Image = drawingBitmap;

                    flagToImprovePerformance = !flagToImprovePerformance;

                    if (flagToImprovePerformance)
                        drawingBitmap = (Bitmap)bitmap.Clone();

                    return;
                }

                if (mode == Modes.triangle)
                {
                    Graphics drawingGraphics = Graphics.FromImage(drawingBitmap);
                    DrawAnyTriangle(pen, e, drawingGraphics);
                    pictureBox.Image = drawingBitmap;

                    flagToImprovePerformance = !flagToImprovePerformance;

                    if (flagToImprovePerformance)
                        drawingBitmap = (Bitmap)bitmap.Clone();

                    return;
                }

            }
            pictureBox.Image = bitmap;

            x1 = e.X;
            y1 = e.Y;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            pen.Color = currColButton1.BackColor;

            Graphics graphics = Graphics.FromImage(bitmap);

            if (mode == Modes.rectangle)
                DrawAnyRectangle(pen, e, graphics);

            if (mode == Modes.ellipse)
                DrawAnyEllipse(pen, e, graphics);

            if (mode == Modes.triangle)
                DrawAnyTriangle(pen, e, graphics);

            graphics.DrawImage(bitmap, 0, 0);
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColButton1.BackColor = button.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColButton1.BackColor = button.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColButton1.BackColor = button.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColButton1.BackColor = button.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColButton1.BackColor = button.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColButton1.BackColor = button.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColButton1.BackColor = button.BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColButton1.BackColor = button.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currColButton1.BackColor = button.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            mode = Modes.ellipse;
            modeLabel.Text = "ellipse";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mode = Modes.line;
            modeLabel.Text = "line";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mode = Modes.triangle;
            modeLabel.Text = "triangle";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            mode = Modes.rectangle;
            modeLabel.Text = "rectangle";
        }
        private void shapeButton15_Click(object sender, EventArgs e)
        {
            mode = Modes.ray;
            modeLabel.Text = "ray";
        }


        private void button14_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void button11_MouseUp(object sender, MouseEventArgs e)
        {

        }


        private void DrawAnyRectangle(Pen pen, MouseEventArgs e, Graphics graphics)
        {
            if (xPressed > e.X && yPressed > e.Y)
                graphics.DrawRectangle(pen, e.X, e.Y, xPressed - e.X, yPressed - e.Y);

            if (xPressed > e.X && yPressed < e.Y)
                graphics.DrawRectangle(pen, e.X, yPressed, xPressed - e.X, e.Y - yPressed);

            if (xPressed < e.X && yPressed > e.Y)
                graphics.DrawRectangle(pen, xPressed, e.Y, e.X - xPressed, yPressed - e.Y);

            if (xPressed < e.X && yPressed < e.Y)
                graphics.DrawRectangle(pen, xPressed, yPressed, e.X - xPressed, e.Y - yPressed);
        }
        private void DrawAnyEllipse(Pen pen, MouseEventArgs e, Graphics graphics)
        {
            if (xPressed > e.X && yPressed > e.Y)
                graphics.DrawEllipse(pen, e.X, e.Y, xPressed - e.X, yPressed - e.Y);

            if (xPressed > e.X && yPressed < e.Y)
                graphics.DrawEllipse(pen, e.X, yPressed, xPressed - e.X, e.Y - yPressed);

            if (xPressed < e.X && yPressed > e.Y)
                graphics.DrawEllipse(pen, xPressed, e.Y, e.X - xPressed, yPressed - e.Y);

            if (xPressed < e.X && yPressed < e.Y)
                graphics.DrawEllipse(pen, xPressed, yPressed, e.X - xPressed, e.Y - yPressed);
        }
        private void DrawAnyTriangle(Pen pen, MouseEventArgs e, Graphics graphics)
        {
            graphics.DrawLine(pen, e.X, e.Y, xPressed, e.Y);
            graphics.DrawLine(pen, xPressed, e.Y, xPressed + (e.X - xPressed) / 2, yPressed);
            graphics.DrawLine(pen, xPressed + (e.X - xPressed) / 2, yPressed, e.X, e.Y);
        }


        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void widthLabel_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK && saveFileDialog1.FileName != "")
            {
                bitmap.Save(saveFileDialog1.FileName);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.CheckFileExists)
            {
                bitmap = (Bitmap)Image.FromFile(openFileDialog1.FileName);

                pictureBox.Image = bitmap;

                drawingBitmap = new Bitmap(1300, 650);

                mode = Modes.none;
                modeLabel.Text = "none";
            }
        }



        private void widthTrackBar1_Scroll(object sender, EventArgs e)
        {
            widthLabel.Text = widthTrackBar1.Value.ToString();
            pen.Width = widthTrackBar1.Value;

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
