using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Laba2
{
    class Ellipse : Figure
    {
        public double SemiaxisBig { get; set; }
        public double SemiaxisSmall { get; set; }

        protected Ellipse() { }
        public Ellipse(string name, double semiaxisBig, 
                       double semiaxisSmall, int x, int y,
                       Color color)
        {
            Title = "Эллипс";
            Name = name;
            Width = 2 * semiaxisBig;
            Height = 2 * semiaxisSmall;
            SemiaxisBig = semiaxisBig;
            SemiaxisSmall = semiaxisSmall;
            X = x;
            Y = y;
            Color = color;
        }

        // Переопределение нахождения периметра
        public override double Perimeter()
        {
            return 4 * (3.14 * SemiaxisBig * SemiaxisSmall + (SemiaxisBig - SemiaxisSmall)) / (SemiaxisBig + SemiaxisSmall);
        }

        // Переопрелеление нахождения площади
        public override double Area()
        {
            return 3.14 * SemiaxisBig * SemiaxisSmall;
        }
    }
}
