using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingInterface
{
    public interface IProcessing
    {
        string Name { get; set; }
        void Transform();
        void Restore();
    }
}
