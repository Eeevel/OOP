using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laba2
{
    // Производный класс прямоугольника
    class Rectangle : Figure
    {
        public Rectangle() { }
        public Rectangle(string name, double width, double height, 
                         int x, int y, Color color) 
        {
            Name = name; 
            Width = width;
            Height = height;
            X = x;
            Y = y;
            Color = color;
        }

        // Переопределение нахождения периметра
        public override double Perimeter()
        {
            return Height * 2 + Width * 2;
        }

        // Переопрелеление нахождения площади
        public override double Area()
        {
            return Height * Width;
        }
    }
}
