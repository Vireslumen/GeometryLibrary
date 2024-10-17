namespace GeometryLibrary.Tests;

public class ShapeTests
{
    /// <summary>
    ///     Тест для проверки вычисления площади фигуры (круг).
    /// </summary>
    [Fact]
    public void AreaCalculator_CalculateShapeArea_ReturnsCorrectAreaForCircle()
    {
        // Подготовка данных
        var circle = new Circle(5);

        // Выполнение действия
        var area = AreaCalculator.CalculateShapeArea(circle);

        // Проверка результата
        Assert.Equal(Math.PI * 25, area);
    }

    /// <summary>
    ///     Тест для проверки вычисления площади фигуры (треугольник).
    /// </summary>
    [Fact]
    public void AreaCalculator_CalculateShapeArea_ReturnsCorrectAreaForTriangle()
    {
        // Подготовка данных
        var triangle = new Triangle(3, 4, 5);

        // Выполнение действия
        var area = AreaCalculator.CalculateShapeArea(triangle);

        // Проверка результата
        Assert.Equal(6, area, 2);
    }

    /// <summary>
    ///     Тест для проверки вычисления площади круга.
    /// </summary>
    [Fact]
    public void Circle_CalculateArea_ReturnsCorrectArea()
    {
        // Подготовка данных
        const double radius = 5;
        var circle = new Circle(radius);

        // Выполнение действия
        var area = circle.CalculateArea();

        // Проверка результата
        Assert.Equal(Math.PI * radius * radius, area);
    }

    /// <summary>
    ///     Тест для проверки вычисления площади треугольника по формуле Герона.
    /// </summary>
    [Fact]
    public void Triangle_CalculateArea_ReturnsCorrectArea()
    {
        // Подготовка данных
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        // Выполнение действия
        var area = triangle.CalculateArea();

        // Проверка результата
        Assert.Equal(6, area, 2);
    }

    /// <summary>
    ///     Тест для проверки, является ли треугольник прямоугольным.
    /// </summary>
    [Fact]
    public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
    {
        // Подготовка данных
        var triangle = new Triangle(3, 4, 5);

        // Выполнение действия
        var isRight = triangle.IsRightTriangle();

        // Проверка результата
        Assert.True(isRight);
    }
}