using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterface;
using Laba2;

namespace PluginArea
{
    public class AreaSearch : IPlugin
    {
        public string Name { get; set; } = "Вычисление площади";
    public string Calculate(Figure figure)
        {
            string result;

            double area = figure.Area();
            result = "Площадь " + figure.Name + " равна " + area.ToString();

            return result;
        }
    }
}
