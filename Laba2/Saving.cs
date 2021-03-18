using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Laba2
{
    // Класс для сохранения объектов
    static class Saving
    {
        // Бинарная сериализация
        public static void BinarySerialization(List<Figure> figures)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("BinaryFigures.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, figures);
            }
        }

        // Бинарная десериализация
        public static List<Figure> BinaryDeserialization()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("BinaryFigures.dat", FileMode.OpenOrCreate))
            {
                List<Figure> figures = (List<Figure>)formatter.Deserialize(fileStream);
                return figures;
            }
        }

        // JSON сериализация
        //public static void JsonSerialization((List<Figure> figures)
        //{
        //    using (FileStream fileStream = new FileStream("BinaryFigures.dat", FileMode.OpenOrCreate))
        //    {
        //        JsonSerializer.Serialize(fileStream, figures);
        //    }
        //}

        // JSON десериализация
        public static void JsonDeserialization()
        {

        }
    }
}
