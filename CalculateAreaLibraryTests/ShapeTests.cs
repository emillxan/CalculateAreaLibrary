using CalculateAreaLibrary.Factories;
using CalculateAreaLibrary.Interfaces;

namespace CalculateAreaLibraryTests;

public class ShapeTests
{
    [Test]
    public void Circle_CalculateArea_ReturnsCorrectResult()
    {
        IShape circle = ShapeFactory.CreateCircle(5);
        double expected = Math.PI * 25;
        Assert.AreEqual(expected, circle.CalculateArea(), 1e-10);
    }

    [Test]
    public void Circle_NegativeRadius_ThrowsArgumentException()
    {
        IShape circle = ShapeFactory.CreateCircle(-5);
    }

    [Test]
    public void Triangle_CalculateArea_ReturnsCorrectResult()
    {
        IShape triangle = ShapeFactory.CreateTriangle(3, 4, 5);
        double expected = 6;
        Assert.AreEqual(expected, triangle.CalculateArea(), 1e-10);
    }

    [Test]
    public void Triangle_InvalidSides_ThrowsArgumentException()
    {
        IShape triangle = ShapeFactory.CreateTriangle(1, 1, 10);
    }

    [Test]
    public void Triangle_IsRightAngled_ReturnsTrueForRightAngledTriangle()
    {
        Triangle triangle = (Triangle)ShapeFactory.CreateTriangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightAngled());
    }

    [Test]
    public void Triangle_IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
    {
        Triangle triangle = (Triangle)ShapeFactory.CreateTriangle(3, 4, 6);
        Assert.IsFalse(triangle.IsRightAngled());
    }
}
