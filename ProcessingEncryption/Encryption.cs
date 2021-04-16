using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2;
using ProcessingInterface;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProcessingEncryption
{
    public class Encryption : IProcessing
    {
        public string Name { get; set; } = "Шифрование";
        public void Transform(List<Figure> figures)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("Files\\EncryptedFigures.txt", FileMode.OpenOrCreate))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    formatter.Serialize(memoryStream, figures);
                    string str = Convert.ToBase64String(memoryStream.ToArray());

                    //Шифрование
                    str = Encrypt(str, 3);

                    byte[] buffer = Encoding.Default.GetBytes(str);
                    fileStream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        public List<Figure> Restore()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            string str;
            using (FileStream fileStream = new FileStream("Files\\EncryptedFigures.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                str = Encoding.Default.GetString(buffer);
            }

            // Расшифровка
            str = Decrypt(str, 3);

            byte[] bytes = Convert.FromBase64String(str);
            using (MemoryStream memoryStream = new MemoryStream(bytes, 0, bytes.Length))
            {
                memoryStream.Write(bytes, 0, bytes.Length);
                memoryStream.Position = 0;
                List<Figure> figures = (List<Figure>)formatter.Deserialize(memoryStream);
                return figures;
            }
        }

        private static string Encrypt(string plainText, int key)
        {
            char[,] matrix = new char[key, plainText.Length];
            bool direction = true;
            int row = 0, column = 0;

            for (int i = 0; i < plainText.Length; i++)
            {
                matrix[row, column] = plainText[i];
                column++;

                if (direction)
                    row++;
                else
                    row--;

                if (row == 0 || row == key - 1)
                    direction = !direction;
            }

            string cipherText = "";
            foreach (char c in matrix)
                if (c != 0)
                    cipherText += c;

            return cipherText;
        }

        private static string Decrypt(string cipherText, int key)
        {
            char[,] matrix = new char[key, cipherText.Length];
            bool direction = true;
            int row = 0, column = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                matrix[row, column] = 'a';
                column++;

                if (direction)
                    row++;
                else
                    row--;

                if (row == 0 || row == key - 1)
                    direction = !direction;
            }

            int index = 0;
            for (int i = 0; i < key; i++)
                for (int j = 0; j < cipherText.Length; j++)
                    if (matrix[i, j] == 'a')
                        matrix[i, j] = cipherText[index++];

            string plainText = "";
            direction = true;
            row = 0;
            column = 0;

            for (int i = 0; i < cipherText.Length; i++)
            {
                plainText += matrix[row, column];
                column++;

                if (direction)
                    row++;
                else
                    row--;

                if (row == 0 || row == key - 1)
                    direction = !direction;
            }

            return plainText;
        }
    }
}
