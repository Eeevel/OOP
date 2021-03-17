using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba2
{
    // Абстрактный класс фабрики
    abstract class Factory
    {
        // Создание фигуры
        public abstract Figure CreateFigure(string name, double width, 
                                            double height, int x, int y, 
                                            Color color);
        // Рисование фигуры
        public abstract void DrawFigure(MainForm form, Figure figure);
    }
}
