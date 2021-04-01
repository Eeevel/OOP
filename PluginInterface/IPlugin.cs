using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2;

namespace PluginInterface
{
    public interface IPlugin
    {
        string Name { get; set; }
        string Calculate(Figure figure);
    }
}
