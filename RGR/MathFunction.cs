using System;

namespace RGR
{
    // Базовий абстрактний клас, що визначає загальну архітектуру та інтерфейс для всіх математичних функцій
    public abstract class MathFunction
    {
        // Абстрактна властивість (доступна лише для читання), що повертає текстову назву функції та її загальну формулу
        public abstract string Name { get; }

        // Абстрактний метод для обчислення значення функції (координати Y) для заданого аргументу X та трьох коефіцієнтів (a, b, c)
        public abstract double Calculate(double x, double a, double b, double c);

        // Абстрактний метод, який формує та повертає оновлений рядок аналітичного рівняння кривої
        public abstract string GetEquationString(double a, double b, double c);
    }
}