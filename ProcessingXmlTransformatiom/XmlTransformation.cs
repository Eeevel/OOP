using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2;
using ProcessingInterface;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace ProcessingXmlTransformatiom
{
    public class XmlTransformation : IProcessing
    {
        public string Name { get; set; } = "Трансформация XML в JSON";
        public void Transform(List<Figure> figures)
        {
            string xmlString;
            using (FileStream fileStream = new FileStream("Files\\XmlFigures.xml", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                xmlString = Encoding.Default.GetString(buffer);
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlString);
            string jsonString = JsonConvert.SerializeXmlNode(xmlDocument);

            using (FileStream fileStream = new FileStream("Files\\JsonFigures.json", FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(jsonString);
                fileStream.Write(buffer, 0, buffer.Length);
            }
        }

        public List<Figure> Restore()
        {
            string jsonString;
            using (FileStream fileStream = new FileStream("Files\\JsonFigures.json", FileMode.OpenOrCreate))
            {
                byte[] buffer = new byte[fileStream.Length];
                fileStream.Read(buffer, 0, buffer.Length);
                jsonString = Encoding.Default.GetString(buffer);
            }

            XNode xNode = JsonConvert.DeserializeXNode(jsonString);
            string xmlString = xNode.ToString();

            XmlSerializer formatter = new XmlSerializer(typeof(List<Figure>), new[] { typeof(Circle),
                                                        typeof(Ellipse), typeof(Rectangle),
                                                        typeof(Square), typeof(Triangle),
                                                        typeof(EquilateralTriangle)});

            byte[] bytes = Encoding.Default.GetBytes(xmlString);
            using (MemoryStream memoryStream = new MemoryStream(bytes, 0, bytes.Length))
            {
                memoryStream.Write(bytes, 0, bytes.Length);
                memoryStream.Position = 0;
                List<Figure> figures = (List<Figure>)formatter.Deserialize(memoryStream);

                foreach (Figure figure in figures)
                {
                    figure.Color = System.Drawing.Color.FromArgb(figure.Argb);
                }

                return figures;
            }
        }
    }
}
