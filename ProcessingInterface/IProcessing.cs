using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2;

namespace ProcessingInterface
{
    public interface IProcessing
    {
        string Name { get; set; }
        void Transform(List<Figure> figures);
        List<Figure> Restore();
    }
}
