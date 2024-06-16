using CalculateAreaLibrary.Interfaces;

namespace CalculateAreaLibrary.Implementations;

public class Circle : IShape
{
    private double Radius { get; }
    public Circle(double radius)
    {
        Radius = radius > 0 ? radius 
            : throw new ArgumentException("Радиус не может быть меньше нуля");
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
