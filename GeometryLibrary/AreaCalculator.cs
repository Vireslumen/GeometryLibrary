namespace GeometryLibrary;

/// <summary>
///     Статический класс для вычисления площади фигуры без знания типа фигуры на этапе компиляции.
/// </summary>
public static class AreaCalculator
{
    /// <summary>
    ///     Вычисление площади переданной фигуры.
    /// </summary>
    /// <param name="shape">Фигура, реализующая интерфейс IShape.</param>
    /// <returns>Площадь фигуры.</returns>
    public static double CalculateShapeArea(IShape shape)
    {
        return shape.CalculateArea();
    }
}