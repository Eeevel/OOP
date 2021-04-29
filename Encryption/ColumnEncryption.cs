using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Encryption
{
    public class ColumnEncryption
    {
        public string Name { get; set; } = "Шифрование столбцовым методом";

        public void Save(List<Figure> figures) 
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("Files\\ColumnEncryptedFigures.txt", FileMode.OpenOrCreate))
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    formatter.Serialize(memoryStream, figures);
                    string str = Convert.ToBase64String(memoryStream.ToArray());

                    // Шифрование
                    str = Encrypt(str, "3-2-5-1-6-9-7-8-4");

                    byte[] buffer = Encoding.Default.GetBytes(str);
                    fileStream.Write(buffer, 0, buffer.Length);
                }
            }
        }

        public List<Figure> Load()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            string str;
            using (FileStream fileStream = new FileStream("Files\\ColumnEncryptedFigures.txt", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                str = Encoding.Default.GetString(buffer);
            }

            // Расшифровка
            str = Decrypt(str, "3-2-5-1-6-9-7-8-4");

            byte[] bytes = Convert.FromBase64String(str);
            using (MemoryStream memoryStream = new MemoryStream(bytes, 0, bytes.Length))
            {
                memoryStream.Write(bytes, 0, bytes.Length);
                memoryStream.Position = 0;
                List<Figure> figures = (List<Figure>)formatter.Deserialize(memoryStream);
                return figures;
            }
        }

        private string Encrypt(string plainText, string key)
        {
            string cipherText = "";

            char[] delimiterChars = { ' ', ',', '.', ':', '-' };
            string[] sNumbers = key.Split(delimiterChars);
            int[] numbers;
            try
            {
                numbers = Array.ConvertAll(sNumbers, int.Parse);
            }
            catch
            {
                cipherText = "Неверный ключ";
                return cipherText;
            }

            int columnCount = numbers.Length;
            int rowsCount = (int)Math.Ceiling((double)plainText.Length / columnCount);
            char[,] matrix = new char[rowsCount, columnCount];

            // Заполнение матрицы символами текста
            int index = 0;
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnCount; j++)
                    if (index < plainText.Length)
                        matrix[i, j] = plainText[index++];
                    else
                        matrix[i, j] = '\r';

            // Чтение столбцов по ключу
            int column;
            index = 0;
            for (int i = 0; i < columnCount; i++)
            {
                column = numbers[index++] - 1;
                for (int j = 0; j < rowsCount; j++)
                    cipherText += matrix[j, column];
            }

            // Удаление лишних символов
            index = cipherText.Length;
            for (int i = 0; i < index; i++)
            {
                if (cipherText[i] == '\r')
                {
                    cipherText = cipherText.Remove(i, 1);
                    index--;
                }

            }

            return cipherText;
        }

        private string Decrypt(string cipherText, string key)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '-' };
            string[] sNumbers = key.Split(delimiterChars);
            int[] numbers;
            try
            {
                numbers = Array.ConvertAll(sNumbers, int.Parse);
            }
            catch
            {
                cipherText = "Неверный ключ";
                return cipherText;
            }

            int columnCount = numbers.Length;
            int rowsCount = (int)Math.Ceiling((double)cipherText.Length / columnCount);
            char[,] matrix = new char[rowsCount, columnCount];

            // Заполняем лишние ячейки
            int freeCells = columnCount * rowsCount - cipherText.Length;
            for (int i = freeCells; i > 0; i--)
                matrix[rowsCount - 1, columnCount - i] = '\r';

            // Запись столбцов по ключу
            int column;
            int index = 0;
            int indexText = 0;
            for (int i = 0; i < columnCount; i++)
            {
                column = numbers[index++] - 1;
                for (int j = 0; j < rowsCount; j++)
                    if (matrix[j, column] != '\r')
                        matrix[j, column] = cipherText[indexText++];
            }

            // Получение текста из матрицы
            string plainText = "";
            for (int i = 0; i < rowsCount; i++)
                for (int j = 0; j < columnCount; j++)
                    if (matrix[i, j] != '\r')
                        plainText += matrix[i, j];

            return plainText;
        }
    }
}
