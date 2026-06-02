using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RGR
{
    // Головний клас форми, що відповідає за графічний інтерфейс користувача (GUI)
    public partial class Form1 : Form
    {
        // Список доступних математичних функцій (поліморфний контейнер)
        private List<MathFunction> functionsList;
        // Посилання на поточну обрану користувачем функцію
        private MathFunction currentFunction;

        // Конструктор головної форми додатка
        public Form1()
        {
            InitializeComponent();
            InitializeFunctions(); // Ініціалізація списку моделей функцій
            this.KeyPreview = true;  // Дозволяємо формі перехоплювати натискання клавіш до елементів керування
        }

        // Метод для початкового наповнення списку функцій та компонента ComboBox
        private void InitializeFunctions()
        {
            // Створення екземплярів конкретних класів функцій
            functionsList = new List<MathFunction>
            {
                new LinearFunction(),
                new QuadraticFunction(),
                new CubicFunction(),
                new SineFunction(),
                new CosineFunction(),
                new TangentFunction(),
                new ExponentFunction(),
                new HyperbolaFunction()
            };

            // Динамічне додавання назв функцій у випадаючий список інтерфейсу
            foreach (var func in functionsList)
            {
                cmbFunctions.Items.Add(func.Name);
            }

            // Встановлення квадратичної функції за замовчуванням
            cmbFunctions.SelectedIndex = 1;
        }

        // Головний метод розрахунку точок та візуалізації графіка
        private void BuildGraph()
        {
            // Перевірка, чи обрано функцію у списку
            if (cmbFunctions.SelectedIndex == -1) return;

            // Визначення поточної функції за індексом у ComboBox (поліморфізм)
            currentFunction = functionsList[cmbFunctions.SelectedIndex];

            // Зчитування поточних значень коефіцієнтів та меж відрізка з NumericUpDown
            double a = (double)numA.Value;
            double b = (double)numB.Value;
            double c = (double)numC.Value;
            double xMin = (double)numXMin.Value;
            double xMax = (double)numXMax.Value;

            // Виведення оновленого аналітичного рівняння кривої з підставленими коефіцієнтами
            lblEquation.Text = "Рівняння: " + currentFunction.GetEquationString(a, b, c);

            // Очищення старих графічних даних та налаштування меж осі Х
            chartGraph.Series.Clear();
            chartGraph.ChartAreas[0].AxisX.Minimum = xMin;
            chartGraph.ChartAreas[0].AxisX.Maximum = xMax;

            // Налаштування візуального стилю нової лінії графіка (серії даних)
            Series series = new Series
            {
                Name = "Graph",
                Color = System.Drawing.Color.Blue,
                ChartType = SeriesChartType.Spline, // Згладжена лінія (сплайн)
                BorderWidth = 3                     // Товщина лінії
            };

            // Динамічний розрахунок кроку дискретизації для плавності малювання
            double step = (xMax - xMin) / 200;

            // Цикл генерації точок графіка на заданому координатному відрізку
            for (double x = xMin; x <= xMax; x += step)
            {
                // Поліморфний виклик методу розрахунку значення Y для кожної конкретної функції
                double y = currentFunction.Calculate(x, a, b, c);

                // Фільтрація точок розриву (наприклад, ділення на нуль) та екстремальних значень
                if (!double.IsNaN(y) && !double.IsInfinity(y) && y < 1000 && y > -1000)
                {
                    series.Points.AddXY(x, y); // Додавання координатної пари до графіка
                }
            }

            // Відображення сформованої лінії на графічному компоненті Chart
            chartGraph.Series.Add(series);
        }

        // Обробник події зміни обраної функції у випадаючому списку
        private void cmbFunctions_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuildGraph(); // Перебудова графіка
        }

        // Універсальний обробник подій зміни значень будь-якого з лічильників (коефіцієнтів чи меж)
        private void numValues_ValueChanged(object sender, EventArgs e)
        {
            BuildGraph(); // Автоматичний перерахунок у режимі реального часу
        }

        // Перевизначення системного методу перехоплення апаратних клавіш керування
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Керування коефіцієнтом 'a' за допомогою клавіш вгору / вниз
            if (keyData == Keys.Up)
            {
                if (numA.Value < numA.Maximum) numA.Value += 1;
                return true; // Подія оброблена, блокуємо стандартну поведінку форми
            }
            if (keyData == Keys.Down)
            {
                if (numA.Value > numA.Minimum) numA.Value -= 1;
                return true;
            }

            // Керування коефіцієнтом 'b' за допомогою клавіш вправо / вліво
            if (keyData == Keys.Right)
            {
                if (numB.Value < numB.Maximum) numB.Value += 1;
                return true;
            }
            if (keyData == Keys.Left)
            {
                if (numB.Value > numB.Minimum) numB.Value -= 1;
                return true;
            }

            // Для всіх інших клавіш викликаємо стандартну базову обробку
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}