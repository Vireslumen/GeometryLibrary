namespace GeometryLibrary;

/// <summary>
///     Интерфейс для представления геометрических фигур.
///     Все фигуры должны реализовывать метод для вычисления площади.
/// </summary>
public interface IShape
{
    /// <summary>
    ///     Вычисление площади фигуры.
    /// </summary>
    /// <returns>Площадь фигуры.</returns>
    double CalculateArea();
}