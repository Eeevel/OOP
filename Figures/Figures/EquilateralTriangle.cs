using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laba2
{
    [Serializable]
    public class EquilateralTriangle : Triangle
    {
        private EquilateralTriangle() { }
        public EquilateralTriangle(string name, double side)
        {
            Title = "Равносторонний треугольник";
            Name = name;
            Side1 = side;
        }
        public EquilateralTriangle(string name, double width,
                                   int x, int y, Color color)
        {
            Title = "Равносторонний треугольник";
            Name = name;
            Width = width;
            Height = Math.Sqrt(Math.Pow((width), 2) - Math.Pow((width / 2), 2));
            X = x;
            Y = y;
            Color = color;
        }
            

        // Переопределение нахождения периметра
        public override double Perimeter()
        {
            return Side1 * 3;
        }

        // Переопрелеление нахождения площади
        public override double Area()
        {
            return Side1 * Side1 * Math.Sqrt(3) / 4;
        }
    }
}
