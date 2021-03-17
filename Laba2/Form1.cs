using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class MainForm : Form
    {
        // Словарь имен фигур и фабрик
        Dictionary<string, Factory> figures = new Dictionary<string, Factory>
        {
            ["Прямоугольник"] = new FactoryRectangle(),
            ["Квадрат"] = new FactorySquare(),
            ["Эллипс"] = new FactoryEllipse(),
            ["Круг"] = new FactoryCircle(),
            ["Треугольник"] = new FactoryTriangle(),
            ["Равносторонний треугольник"] = new FactoryEquilateralTriangle()
        };

        Color color;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Возвращает ссылку на поле для рисования
        public PictureBox GetPictureBox()
        {
            return picture;
        }

        // Обработчик нажатия на кнопку "Создать фигуру"
        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxFigure.Text;
            double width = double.Parse(textBoxWidth.Text);
            double height = double.Parse(textBoxHeight.Text);
            int x = int.Parse(textBoxX.Text);
            int y = int.Parse(textBoxY.Text);

            Figure figure = figures[name].CreateFigure(name, width, height, x, y, color);
            figures[name].DrawFigure(this, figure);
        }

        // Обработчик выбора цвета
        private void btnWhite_Click(object sender, EventArgs e)
        {
            color = ((Button)sender).BackColor;
        }
    }
}
