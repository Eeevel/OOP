using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba2
{
    // Фабрика для круга
    class FactoryCircle : Factory
    {
        public override Figure CreateFigure(string name, double width,
                                            double height, int x, int y,
                                            Color color)
        {
            return new Circle(name, width / 2, x, y, color);
        }

        public override void DrawFigure(MainForm form, Figure figure)
        {
            Drawing.Circle(form, figure);
        }
    }
}
