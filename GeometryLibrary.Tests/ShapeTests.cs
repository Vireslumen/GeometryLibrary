namespace GeometryLibrary.Tests;

public class ShapeTests
{
    /// <summary>
    ///     ���� ��� �������� ���������� ������� ������ (����).
    /// </summary>
    [Fact]
    public void AreaCalculator_CalculateShapeArea_ReturnsCorrectAreaForCircle()
    {
        // ���������� ������
        var circle = new Circle(5);

        // ���������� ��������
        var area = AreaCalculator.CalculateShapeArea(circle);

        // �������� ����������
        Assert.Equal(Math.PI * 25, area);
    }

    /// <summary>
    ///     ���� ��� �������� ���������� ������� ������ (�����������).
    /// </summary>
    [Fact]
    public void AreaCalculator_CalculateShapeArea_ReturnsCorrectAreaForTriangle()
    {
        // ���������� ������
        var triangle = new Triangle(3, 4, 5);

        // ���������� ��������
        var area = AreaCalculator.CalculateShapeArea(triangle);

        // �������� ����������
        Assert.Equal(6, area, 2);
    }

    /// <summary>
    ///     ���� ��� �������� ���������� ������� �����.
    /// </summary>
    [Fact]
    public void Circle_CalculateArea_ReturnsCorrectArea()
    {
        // ���������� ������
        const double radius = 5;
        var circle = new Circle(radius);

        // ���������� ��������
        var area = circle.CalculateArea();

        // �������� ����������
        Assert.Equal(Math.PI * radius * radius, area);
    }

    /// <summary>
    ///     ���� ��� �������� ���������� ������� ������������ �� ������� ������.
    /// </summary>
    [Fact]
    public void Triangle_CalculateArea_ReturnsCorrectArea()
    {
        // ���������� ������
        const double sideA = 3;
        const double sideB = 4;
        const double sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);

        // ���������� ��������
        var area = triangle.CalculateArea();

        // �������� ����������
        Assert.Equal(6, area, 2);
    }

    /// <summary>
    ///     ���� ��� ��������, �������� �� ����������� �������������.
    /// </summary>
    [Fact]
    public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
    {
        // ���������� ������
        var triangle = new Triangle(3, 4, 5);

        // ���������� ��������
        var isRight = triangle.IsRightTriangle();

        // �������� ����������
        Assert.True(isRight);
    }
}