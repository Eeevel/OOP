using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Laba2
{
    // Класс для сохранения объектов
    static class Saving
    {
        // Бинарная сериализация
        public static void BinarySerialization(List<Figure> figures)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("Files\\BinaryFigures.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, figures);
            }
        }

        // Бинарная десериализация
        public static List<Figure> BinaryDeserialization()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("Files\\BinaryFigures.dat", FileMode.OpenOrCreate))
            {
                List<Figure> figures = (List<Figure>)formatter.Deserialize(fileStream);
                return figures;
            }
        }

        // XML сериализация
        public static void XmlSerialization(List<Figure> figures)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Figure>), new[] { typeof(Circle),
                                                        typeof(Ellipse), typeof(Rectangle),
                                                        typeof(Square), typeof(Triangle),
                                                        typeof(EquilateralTriangle)});

            foreach (Figure figure in figures)
            {
                figure.Argb = figure.Color.ToArgb();
            }

            using (FileStream fileStream = new FileStream("Files\\XmlFigures.xml", FileMode.Create))
            {
                formatter.Serialize(fileStream, figures);
            }
        }

        // XML десериализация
        public static List<Figure> XmlDeserialization()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Figure>), new[] { typeof(Circle),
                                                        typeof(Ellipse), typeof(Rectangle),
                                                        typeof(Square), typeof(Triangle),
                                                        typeof(EquilateralTriangle)});

            using (FileStream fileStream = new FileStream("Files\\XmlFigures.xml", FileMode.OpenOrCreate))
            {
                List<Figure> figures = (List<Figure>)formatter.Deserialize(fileStream);

                foreach (Figure figure in figures)
                {
                    figure.Color = System.Drawing.Color.FromArgb(figure.Argb);
                }

                return figures;
            }
        }
    }
}
