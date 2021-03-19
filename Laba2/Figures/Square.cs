using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laba2
{
    [Serializable]
    public class Square : Rectangle
    {
        private Square() { }
        public Square(string name, double side, int x, int y, Color color)
        {
            Title = "Квадрат";
            Name = name;
            Width = side;
            Height = side;
            X = x;
            Y = y;
            Color = color;
        }

        // Переопределение нахождения периметра
        public override double Perimeter()
        {
            return 4 * Width;
        }

        // Переопрелеление нахождения площади
        public override double Area()
        {
            return Width * Width;
        }
    }
}
