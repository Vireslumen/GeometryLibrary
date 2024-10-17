namespace GeometryLibrary;

/// <summary>
///     Класс для представления треугольника.
/// </summary>
public class Triangle : IShape
{
    /// <summary>
    ///     Конструктор для создания треугольника с заданными сторонами.
    /// </summary>
    /// <param name="sideA">Первая сторона треугольника.</param>
    /// <param name="sideB">Вторая сторона треугольника.</param>
    /// <param name="sideC">Третья сторона треугольника.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если стороны не образуют треугольник.</exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        // Проверка на то, что заданные стороны могут образовать треугольник (неравенство треугольника)
        if (sideA <= 0 || sideB <= 0 || sideC <= 0) throw new ArgumentException("Все стороны должны быть положительными.");

        if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            throw new ArgumentException("Стороны не образуют треугольник.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <summary>
    ///     Первая сторона треугольника.
    /// </summary>
    public double SideA { get; }
    /// <summary>
    ///     Вторая сторона треугольника.
    /// </summary>
    public double SideB { get; }
    /// <summary>
    ///     Третья сторона треугольника.
    /// </summary>
    public double SideC { get; }

    /// <summary>
    ///     Вычисление площади треугольника по формуле Герона.
    /// </summary>
    /// <returns>Площадь треугольника.</returns>
    public double CalculateArea()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    /// <summary>
    ///     Определение, является ли треугольник прямоугольным.
    /// </summary>
    /// <returns>true, если треугольник является прямоугольным; иначе false.</returns>
    public bool IsRightTriangle()
    {
        // Для проверки используется теорема Пифагора
        double[] sides = {SideA, SideB, SideC};
        Array.Sort(sides); // Сортировка сторон для упрощенной проверки
        return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 1e-10;
    }
}