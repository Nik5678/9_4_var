using System;
using System.Drawing;
using System.Windows.Forms;

namespace _9_4_вариант
{
    public partial class Form1 : Form
    {
        private const double a = 1.35;
        private const double b = -6.25;
        private const double x0 = 5.3;
        private const double xk = 10.3;
        private const double dx = 0.25;

        public Form1()
        {
            InitializeComponent();
            this.Text = "График функции и её производной";
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.MinimumSize = new Size(800, 600); // Увеличено для наглядности
            DrawGraphs(); // Отрисовка при запуске
        }

        private void DrawGraphs()
        {
            if (pictureBox1.Width == 0 || pictureBox1.Height == 0) return;

            // Создаем новое изображение
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Находим диапазоны значений
                double minX = x0, maxX = xk;
                double minY = double.MaxValue, maxY = double.MinValue;

                // Предварительный расчет для масштабирования
                for (double x = x0; x <= xk; x += dx)
                {
                    double y = FunctionY(x);
                    double dy = DerivativeFunction(x);
                    minY = Math.Min(minY, Math.Min(y, dy));
                    maxY = Math.Max(maxY, Math.Max(y, dy));
                }

                // Настройка масштаба
                double scaleX = pictureBox1.Width / (maxX - minX);
                double scaleY = pictureBox1.Height / (maxY - minY) * 0.8; // Запас 20%

                // Рисуем оси
                Pen axisPen = new Pen(Color.Black, 2);
                g.DrawLine(axisPen, 0, (float)(pictureBox1.Height - minY * scaleY),
                    pictureBox1.Width, (float)(pictureBox1.Height - minY * scaleY)); // Ось X
                g.DrawLine(axisPen, (float)(-minX * scaleX), 0,
                    (float)(-minX * scaleX), pictureBox1.Height); // Ось Y

                // Рисуем графики
                DrawFunction(g, minX, maxX, minY, maxY, Color.Blue, FunctionY);
                DrawFunction(g, minX, maxX, minY, maxY, Color.Red, DerivativeFunction);
            }

            pictureBox1.Image?.Dispose();
            pictureBox1.Image = bmp;
        }

        private void DrawFunction(Graphics g, double minX, double maxX, double minY, double maxY, Color color, Func<double, double> function)
        {
            Pen pen = new Pen(color, 2);
            double prevX = x0;
            double prevY = function(prevX);

            for (double x = x0 + dx; x <= xk; x += dx)
            {
                double y = function(x);

                // Преобразование координат
                int x1 = (int)((prevX - minX) * (pictureBox1.Width / (maxX - minX)));
                int y1 = (int)(pictureBox1.Height - (prevY - minY) * (pictureBox1.Height / (maxY - minY)));
                int x2 = (int)((x - minX) * (pictureBox1.Width / (maxX - minX)));
                int y2 = (int)(pictureBox1.Height - (y - minY) * (pictureBox1.Height / (maxY - minY)));

                // Ограничение координат
                x1 = Math.Max(0, Math.Min(pictureBox1.Width, x1));
                y1 = Math.Max(0, Math.Min(pictureBox1.Height, y1));
                x2 = Math.Max(0, Math.Min(pictureBox1.Width, x2));
                y2 = Math.Max(0, Math.Min(pictureBox1.Height, y2));

                g.DrawLine(pen, x1, y1, x2, y2);

                prevX = x;
                prevY = y;
            }
        }

        private double FunctionY(double x)
        {
            return a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
        }

        private double DerivativeFunction(double x)
        {
            double term1 = 3 * a * Math.Pow(x, 2);
            double term2 = -6 * Math.Pow(x, 2) * Math.Cos(Math.Pow(x, 3) - b) * Math.Sin(Math.Pow(x, 3) - b);
            return term1 + term2;
        }
    }
}