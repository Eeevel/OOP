using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessingInterface;
using Encryption;

namespace Laba2
{
    class Adapter : IProcessing
    {
        private ColumnEncryption _encryptor;

        public string Name { get; set; }

        public Adapter(ColumnEncryption encryptor)
        {
            _encryptor = encryptor;
            Name = _encryptor.Name;
        }
        
        public void Transform(List<Figure> figures)
        {
            _encryptor.Save(figures, "Files\\ColumnEncryptedFigures.txt");
        }
        public List<Figure> Restore()
        {
            return _encryptor.Load("Files\\ColumnEncryptedFigures.txt");
        }
    }
}
