using System;

namespace RGR
{

    // Клас, що моделює лінійну функцію
    public class LinearFunction : MathFunction
    {
        public override string Name => "Лінійна: y = ax + b";

        // Обчислення значення лінійної залежності (коефіцієнт 'c' не використовується)
        public override double Calculate(double x, double a, double b, double c) => a * x + b;

        // Формування рядка рівняння для виведення на форму
        public override string GetEquationString(double a, double b, double c) => $"{a}*x + ({b})";
    }

    // Клас, що моделює квадратичну функцію (параболу)
    public class QuadraticFunction : MathFunction
    {
        public override string Name => "Квадратична: y = ax² + bx + c";

        // Розрахунок полінома другого степеня
        public override double Calculate(double x, double a, double b, double c) => a * x * x + b * x + c;

        public override string GetEquationString(double a, double b, double c) => $"{a}*x² + ({b})*x + ({c})";
    }

    // Клас, що моделює кубічну функцію
    public class CubicFunction : MathFunction
    {
        public override string Name => "Кубічна: y = ax³ + bx² + c";

        // Використання стандартної функції Math.Pow для піднесення до кубічного степеня
        public override double Calculate(double x, double a, double b, double c) => a * Math.Pow(x, 3) + b * x * x + c;

        public override string GetEquationString(double a, double b, double c) => $"{a}*x³ + ({b})*x² + ({c})";
    }

    // Клас, що моделює тригонометричну функцію синуса
    public class SineFunction : MathFunction
    {
        public override string Name => "Синусоїда: y = a*sin(bx) + c";

        // Обчислення синусоїди, де 'a' регулює амплітуду, 'b' - частоту (період), 'c' - зсув по осі Y
        public override double Calculate(double x, double a, double b, double c) => a * Math.Sin(b * x) + c;

        public override string GetEquationString(double a, double b, double c) => $"{a}*sin({b}*x) + ({c})";
    }

    // Клас, що моделює тригонометричну функцію косинуса
    public class CosineFunction : MathFunction
    {
        public override string Name => "Косинусоїда: y = a*cos(bx) + c";

        public override double Calculate(double x, double a, double b, double c) => a * Math.Cos(b * x) + c;

        public override string GetEquationString(double a, double b, double c) => $"{a}*cos({b}*x) + ({c})";
    }

    // Клас, що моделює тригонометричну функцію тангенса
    public class TangentFunction : MathFunction
    {
        public override string Name => "Тангенсоїда: y = a*tan(bx) + c";

        public override double Calculate(double x, double a, double b, double c) => a * Math.Tan(b * x) + c;

        public override string GetEquationString(double a, double b, double c) => $"{a}*tan({b}*x) + ({c})";
    }

    // Клас, що моделює показникову (експоненційну) функцію
    public class ExponentFunction : MathFunction
    {
        public override string Name => "Показникова: y = a * e^(bx) + c";

        // Використання константи експоненти через метод Math.Exp (e в степені bx)
        public override double Calculate(double x, double a, double b, double c) => a * Math.Exp(b * x) + c;

        public override string GetEquationString(double a, double b, double c) => $"{a} * e^({b}*x) + ({c})";
    }

    // Клас, що моделює функцію гіперболи (обернена пропорційність)
    public class HyperbolaFunction : MathFunction
    {
        public override string Name => "Гіпербола: y = a / (x + b) + c";

        // Безпечний розрахунок із перевіркою ділення на нуль в точці розриву
        public override double Calculate(double x, double a, double b, double c) => (x + b == 0) ? double.NaN : a / (x + b) + c;

        public override string GetEquationString(double a, double b, double c) => $"{a} / (x + {b}) + ({c})";
    }
}