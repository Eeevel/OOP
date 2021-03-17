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
        // Словарь названий фигур и фабрик
        Dictionary<string, Factory> factories = new Dictionary<string, Factory>
        {
            ["Прямоугольник"] = new FactoryRectangle(),
            ["Квадрат"] = new FactorySquare(),
            ["Эллипс"] = new FactoryEllipse(),
            ["Круг"] = new FactoryCircle(),
            ["Треугольник"] = new FactoryTriangle(),
            ["Равносторонний треугольник"] = new FactoryEquilateralTriangle()
        };

        Color color;

        // Список для хранения фигур
        List<Figure> figures = new List<Figure>();

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
            try
            {
                string title = textBoxFigure.Text;
                string name = textBoxName.Text;
                double width = double.Parse(textBoxWidth.Text);
                double height = double.Parse(textBoxHeight.Text);
                int x = int.Parse(textBoxX.Text);
                int y = int.Parse(textBoxY.Text);

                // Создание фигуры
                Figure figure = factories[title].CreateFigure(name, width, height, x, y, color);

                // Добавление фигуры в список и отображение на экран
                figures.Add(figure);
                listBoxFigures.Items.Add(figure.Name);
                

                //factories[title].DrawFigure(this, figures[figures.Count - 1]);

                lbError.Text = "";
            }
            catch(KeyNotFoundException)
            {
                lbError.Text = "Неверное название фигуры";
            }
            catch
            {
                lbError.Text = "Введите корректные данные";
            } 
        }

        // Обработчик нажатия на кнопку "Нарисовать"
        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBoxFigures.SelectedIndex;
                Figure figure = figures[index];

                factories[figure.Title].DrawFigure(this, figure);

                lbError.Text = "";
            }
            catch(ArgumentOutOfRangeException)
            {
                lbError.Text = "Выберите фигуру";
            }
        }

        // Обработчик нажатия на кнопку "Удалить"
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Удаление фигуры из списка
                int index = listBoxFigures.SelectedIndex;
                figures.RemoveAt(index);
                listBoxFigures.Items.RemoveAt(index);

                lbError.Text = "";
            }
            
            catch (ArgumentOutOfRangeException)
            {
                lbError.Text = "Выберите фигуру";
            }
        }

        // Обработчик выбора цвета
        private void btnWhite_Click(object sender, EventArgs e)
        {
            color = ((Button)sender).BackColor;
        }
    }
}
