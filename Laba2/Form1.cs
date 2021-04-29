using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using PluginInterface;
using ProcessingInterface;
using Encryption;

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

        // Список расширений
        private List<IPlugin> plugins = new List<IPlugin>();

        // Путь к папке с плагинами
        private readonly string pluginPath = Path.Combine(Directory.GetCurrentDirectory(), "Plugins");

        // Список расширений для сериализации
        private List<IProcessing> serializationPlugins = new List<IProcessing>();

        // Путь к папке с плагинами для сериализации
        private readonly string serializationPluginPath = Path.Combine(Directory.GetCurrentDirectory(), "Serialization plugins");

        public MainForm()
        {
            InitializeComponent();
            Drawing.Initialize(this);
            RefreshPlugins();
            RefreshSerializationPlugins();
            LoadingAdapter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadingAdapter()
        {
            ColumnEncryption encryptor = new ColumnEncryption();
            IProcessing adapter = new Adapter(encryptor);

            serializationPlugins.Add(adapter);
            listBoxSerPlugins.Items.Add(adapter.Name);
        }

        private void RefreshPlugins()
        {
            try
            {
                plugins.Clear();

                DirectoryInfo pluginDirectory = new DirectoryInfo(pluginPath);
                if (!pluginDirectory.Exists)
                    pluginDirectory.Create();

                // Выбираем из директории все файлы с расширением .dll      
                var pluginFiles = Directory.GetFiles(pluginPath, "*.dll");
                foreach (var file in pluginFiles)
                {
                    // Загружаем сборку
                    Assembly asm = Assembly.LoadFrom(file);
                    // Ищем типы, реализующие интерфейс IPlugin
                    var types = asm.GetTypes().
                                    Where(t => t.GetInterfaces().
                                    Where(i => i.FullName == typeof(IPlugin).FullName).Any());

                    // Заполняем экземплярами полученных типов коллекцию плагинов
                    foreach (var type in types)
                    {
                        var plugin = asm.CreateInstance(type.FullName) as IPlugin;
                        plugins.Add(plugin);
                        listBoxPlugins.Items.Add(plugin.Name);
                    }
                }
            }
            catch
            {
                lbCalculate.Text = "Ошибка при загрузке плагина";
            }
            
        }

        private void RefreshSerializationPlugins()
        {
            try
            {
                serializationPlugins.Clear();

                DirectoryInfo pluginDirectory = new DirectoryInfo(serializationPluginPath);
                if (!pluginDirectory.Exists)
                    pluginDirectory.Create();

                // Выбираем из директории все файлы с расширением .dll      
                var pluginFiles = Directory.GetFiles(serializationPluginPath, "*.dll");
                foreach (var file in pluginFiles)
                {
                    // Загружаем сборку
                    Assembly asm = Assembly.LoadFrom(file);
                    // Ищем типы, реализующие интерфейс IProcessing
                    var types = asm.GetTypes().
                                    Where(t => t.GetInterfaces().
                                    Where(i => i.FullName == typeof(IProcessing).FullName).Any());

                    // Заполняем экземплярами полученных типов коллекцию плагинов
                    foreach (var type in types)
                    {
                        var plugin = asm.CreateInstance(type.FullName) as IProcessing;
                        serializationPlugins.Add(plugin);
                        listBoxSerPlugins.Items.Add(plugin.Name);
                    }
                }
            }
            catch
            {
                lbPluginError.Text = "Ошибка при загрузке плагина";
            }

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

        // Обработчик нажатия на кнопку "Очистить"
        private void btnClear_Click(object sender, EventArgs e)
        {
            Drawing.Clear(this);
        }

        // Обработчик выбора цвета
        private void btnWhite_Click(object sender, EventArgs e)
        {
            color = ((Button)sender).BackColor;
        }

        // Обработчик нажатия на кнопку "Бинарная сериализация"
        private void btnBinarySerialization_Click(object sender, EventArgs e)
        {
            Saving.BinarySerialization(figures);
        }

        // Обработчик нажатия на кнопку "Бинарная десериализация"
        private void btnBinaryDeserialization_Click(object sender, EventArgs e)
        {
            figures.AddRange(Saving.BinaryDeserialization());

            listBoxFigures.Items.Clear();
            foreach (Figure figure in figures)
            {
                listBoxFigures.Items.Add(figure.Name);
            }
        }

        // Обработчик нажатия на кнопку "XML сериализация"
        private void btnXmlSerialization_Click(object sender, EventArgs e)
        {
            Saving.XmlSerialization(figures);
        }

        // Обработчик нажатия на кнопку "XML десериализация"
        private void btnXmlDeserialization_Click(object sender, EventArgs e)
        {
            figures.AddRange(Saving.XmlDeserialization());

            listBoxFigures.Items.Clear();
            foreach (Figure figure in figures)
            {
                listBoxFigures.Items.Add(figure.Name);
            }
        }

        // Обработчик нажатия на кнопку "Вычислить"
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int pluginIndex = listBoxPlugins.SelectedIndex;
                int figureIndex = listBoxFigures.SelectedIndex;
                Figure figure = figures[figureIndex];

                lbCalculate.Text = plugins[pluginIndex].Calculate(figure);
            }
            catch
            {
                lbCalculate.Text = "Что-то пошло не так";
            }
            
        }

        // Обработчик нажатия на кнопку "Сериализация"
        private void btnSerialization_Click(object sender, EventArgs e)
        {
            lbPluginError.Text = "";
            try
            {
                int pluginIndex = listBoxSerPlugins.SelectedIndex;

                serializationPlugins[pluginIndex].Transform(figures);
            }
            catch
            {
                lbPluginError.Text = "Что-то пошло не так";
            }
        }

        // Обработчик нажатия на кнопку "Десериализация"
        private void btnDeserialization_Click(object sender, EventArgs e)
        {
            lbPluginError.Text = "";
            try
            {
                int pluginIndex = listBoxSerPlugins.SelectedIndex;

                figures.AddRange(serializationPlugins[pluginIndex].Restore());

                listBoxFigures.Items.Clear();
                foreach (Figure figure in figures)
                {
                    listBoxFigures.Items.Add(figure.Name);
                }
            }
            catch
            {
                lbPluginError.Text = "Что-то пошло не так";
            }
        }
    }
}
