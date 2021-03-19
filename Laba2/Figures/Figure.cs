using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laba2
{
    // Абстрактный класс фигуры
    [Serializable]
    public abstract class Figure
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public int Argb { get; set; }

        // Абстрактный метод для нахождения периметра
        public abstract double Perimeter();

        // Абстрактный метод для нахождения площади
        public abstract double Area();
    }
    
}
