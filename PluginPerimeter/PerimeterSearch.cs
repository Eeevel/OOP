using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterface;
using Laba2;

namespace PluginPerimeter
{
    public class PerimeterSearch : IPlugin
    {
        public string Name { get; set; } = "Вычисление периметра";
        public string Calculate(Figure figure)
        {
            string result;

            double perimeter = figure.Perimeter();
            result = "Периметр " + figure.Name + " равен " + perimeter.ToString();

            return result;
        }
    }
}
