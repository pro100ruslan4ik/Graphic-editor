using System;
using System.Drawing;
using System.Windows.Forms;

namespace graphicEditor
{

    public enum Modes
    {
        ellipse,
        line,
        triangle,
        rectangle,
        ray,
        curve,
        none
    }

    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        private Bitmap drawingBitmap;

        private Pen pen;

        private int xCurrent;
        private int yCurrent;

        private int xPressed;
        private int yPressed;

        private Modes mode;

        private DateTime startDrawTime;

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(1300, 650);
            drawingBitmap = new Bitmap(1300, 650);

            widthTrackBar.Minimum = 1;
            widthLabel.Text = widthTrackBar.Value.ToString();

            pen = new Pen(currentColorButton1.BackColor, widthTrackBar.Value);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            xCurrent = 0;
            yCurrent = 0;

            startDrawTime = DateTime.Now;

            mode = Modes.curve;
            modeLabel.Text = "curve";


            saveFileDialog.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openFileDialog.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            openFileDialog.FileName = "";
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
                DrawOnMouseMove(e);

            }

            xCurrent = e.X;
            yCurrent = e.Y;
        }

        private void DrawOnMouseMove(MouseEventArgs e)
        {
            if (mode == Modes.curve || mode == Modes.ray)
                DrawCurveOrRay(e);
            else if ((DateTime.Now - startDrawTime).TotalMilliseconds > 1)
            {
                DrawTempShape(e);
                startDrawTime = DateTime.Now;
            }
        }

        private void DrawCurveOrRay(MouseEventArgs e)
        {
            if (mode == Modes.curve)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawLine(pen, xCurrent, yCurrent, e.X, e.Y);
            }

            if (mode == Modes.ray)
            {
                Graphics graphics = Graphics.FromImage(bitmap);
                graphics.DrawLine(pen, xPressed, yPressed, e.X, e.Y);
            }

            pictureBox.Image = bitmap;
        }

        private void DrawTempShape(MouseEventArgs e)
        {
            Graphics drawingGraphics = Graphics.FromImage(drawingBitmap);

            if (mode == Modes.rectangle)
            {
                DrawAnyRectangle(pen, e, drawingGraphics);
            }

            if (mode == Modes.ellipse)
            {
                DrawAnyEllipse(pen, e, drawingGraphics);
            }

            if (mode == Modes.triangle)
            {
                DrawAnyTriangle(pen, e, drawingGraphics);
            }
            if (mode == Modes.line)
            {
                drawingGraphics.DrawLine(pen, xPressed, yPressed, e.X, e.Y);
            }

            pictureBox.Image = drawingBitmap;
            drawingBitmap = (Bitmap)bitmap.Clone();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics graphics = Graphics.FromImage(bitmap);

            if (mode == Modes.rectangle)
                DrawAnyRectangle(pen, e, graphics);

            if (mode == Modes.ellipse)
                DrawAnyEllipse(pen, e, graphics);

            if (mode == Modes.triangle)
                DrawAnyTriangle(pen, e, graphics);

            if (mode == Modes.line)
                graphics.DrawLine(pen, xPressed, yPressed, e.X, e.Y);

            graphics.DrawImage(bitmap, 0, 0);
        }


        private void currentColorButton1_Click(object sender, EventArgs e)
        {

        }

        private void colorButton2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentColorButton1.BackColor = button.BackColor;
            pen.Color = button.BackColor;
        }

        private void colorButton3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentColorButton1.BackColor = button.BackColor;
            pen.Color = button.BackColor;
        }

        private void colorButton4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentColorButton1.BackColor = button.BackColor;
            pen.Color = button.BackColor;
        }

        private void colorButton5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentColorButton1.BackColor = button.BackColor;
            pen.Color = button.BackColor;
        }

        private void colorBbutton6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentColorButton1.BackColor = button.BackColor;
            pen.Color = button.BackColor;
        }

        private void colorButton7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentColorButton1.BackColor = button.BackColor;
            pen.Color = button.BackColor;
        }

        private void colorButton8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentColorButton1.BackColor = button.BackColor;
            pen.Color = button.BackColor;
        }

        private void colorButton9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentColorButton1.BackColor = button.BackColor;
            pen.Color = button.BackColor;
        }

        private void colorButton10_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentColorButton1.BackColor = button.BackColor;
            pen.Color = button.BackColor;
        }

        private void shapeButton11_Click(object sender, EventArgs e)
        {
            mode = Modes.ellipse;
            modeLabel.Text = "ellipse";
        }

        private void shapeButton12_Click(object sender, EventArgs e)
        {
            mode = Modes.line;
            modeLabel.Text = "line";
        }

        private void shapeButton13_Click(object sender, EventArgs e)
        {
            mode = Modes.triangle;
            modeLabel.Text = "triangle";
        }

        private void shapeButton14_Click(object sender, EventArgs e)
        {
            mode = Modes.rectangle;
            modeLabel.Text = "rectangle";
        }

        private void shapeButton15_Click(object sender, EventArgs e)
        {
            mode = Modes.ray;
            modeLabel.Text = "ray";
        }

        private void shapeButton16_Click(object sender, EventArgs e)
        {
            mode = Modes.curve;
            modeLabel.Text = "curve";

        }

        private void deleteButton17_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(1300, 650);
            drawingBitmap = new Bitmap(1300, 650);
            pictureBox.Image = bitmap;
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


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "";
            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
            {
                bitmap.Save(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.CheckFileExists)
            {
                bitmap = (Bitmap)Image.FromFile(openFileDialog.FileName);

                pictureBox.Image = bitmap;

                drawingBitmap = new Bitmap(1300, 650);

                mode = Modes.none;
                modeLabel.Text = "none";
            }
        }



        private void widthTrackBar_Scroll(object sender, EventArgs e)
        {
            widthLabel.Text = widthTrackBar.Value.ToString();
            pen.Width = widthTrackBar.Value;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
