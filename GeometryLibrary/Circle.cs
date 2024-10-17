namespace GeometryLibrary;

/// <summary>
///     Класс для представления круга.
/// </summary>
public class Circle : IShape
{
    /// <summary>
    ///     Конструктор для создания круга с заданным радиусом.
    /// </summary>
    /// <param name="radius">Радиус круга.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если радиус меньше или равен нулю.</exception>
    public Circle(double radius)
    {
        if (radius <= 0) throw new ArgumentException("Радиус должен быть положительным числом.");

        Radius = radius;
    }

    /// <summary>
    ///     Радиус круга.
    /// </summary>
    public double Radius { get; }

    /// <summary>
    ///     Вычисление площади круга по формуле: π * r^2.
    /// </summary>
    /// <returns>Площадь круга.</returns>
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}