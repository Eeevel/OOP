using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba2
{
    // Класс для рисования фигур
    static class Drawing
    {
        private static Bitmap bmp;
        private static Graphics graph;

        // Создание области для рисования
        public static void Initialize(MainForm form)
        {
            bmp = new Bitmap(form.GetPictureBox().Width, form.GetPictureBox().Height);
            graph = Graphics.FromImage(bmp);
        }

        // Рисование прямоугольника
        public static void Rectangle(MainForm form, Figure figure)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(figure.Color);

            Rectangle rectangle = (Rectangle)figure;

            graph.FillRectangle(brush, rectangle.X, rectangle.Y, (float)rectangle.Width, (float)rectangle.Height);
            graph.DrawRectangle(pen, rectangle.X, rectangle.Y, (float)rectangle.Width, (float)rectangle.Height);

            form.GetPictureBox().Image = bmp;
        }

        // Рисование квадрата
        public static void Square(MainForm form, Figure figure)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(figure.Color);

            Square square = (Square)figure;

            graph.FillRectangle(brush, square.X, square.Y, (float)square.Width, (float)square.Height);
            graph.DrawRectangle(pen, square.X, square.Y, (float)square.Width, (float)square.Height);

            form.GetPictureBox().Image = bmp;
        }

        // Рисование эллипса
        public static void Ellipse(MainForm form, Figure figure)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(figure.Color);

            Ellipse ellipse = (Ellipse)figure;

            graph.FillEllipse(brush, ellipse.X, ellipse.Y, (float)ellipse.Width, (float)ellipse.Height);
            graph.DrawEllipse(pen, ellipse.X, ellipse.Y, (float)ellipse.Width, (float)ellipse.Height);

            form.GetPictureBox().Image = bmp;
        }

        // Рисование круга
        public static void Circle(MainForm form, Figure figure)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(figure.Color);

            Circle circle = (Circle)figure;

            graph.FillEllipse(brush, circle.X, circle.Y, (float)circle.Width, (float)circle.Height);
            graph.DrawEllipse(pen, circle.X, circle.Y, (float)circle.Width, (float)circle.Height);

            form.GetPictureBox().Image = bmp;
        }

        // Рисование треугольника
        public static void Triangle(MainForm form, Figure figure)
        {
            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(figure.Color);

            Triangle triangle = (Triangle)figure;

            Point[] points =
             {
                 new Point(triangle.X, triangle.Y),
                 new Point(triangle.X + (int)triangle.Width, triangle.Y),
                 new Point(triangle.X + (int)triangle.Width / 2, triangle.Y + (int)triangle.Height)
             };

            graph.FillPolygon(brush, points);
            graph.DrawPolygon(pen, points);

            form.GetPictureBox().Image = bmp;
        }
        
        // Очистка экрана
        public static void Clear(MainForm form)
        {
            graph.Clear(Color.White);
            form.GetPictureBox().Image = bmp;
        }
    }
}
