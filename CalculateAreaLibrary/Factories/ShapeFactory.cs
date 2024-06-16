﻿using CalculateAreaLibrary.Implementations;
using CalculateAreaLibrary.Interfaces;

namespace CalculateAreaLibrary.Factories;

public class ShapeFactory
{
    public static IShape CreateCircle(double radius)
    {
        return new Circle(radius);
    }

    public static IShape CreateTriangle(double sideA, double sideB, double sideC)
    {
        return new Triangle(sideA, sideB, sideC);
    }
}
