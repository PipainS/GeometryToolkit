using MindBox.AreaCalculator.src.ShapeLibrary.Constants;
using MindBox.AreaCalculator.src.ShapeLibrary.Factories;
using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Interfaces;

var radius = ShapeConstants.MaxRadius - 1;
IShape circle = ShapeFactory.CreateCircle(radius);
Console.WriteLine($"Area of circle: {circle.CalculateArea()}");

IShape triangle = ShapeFactory.CreateTriangle(2, 2, 2);
Console.WriteLine($"Area of triangle: {triangle.CalculateArea()}");
triangle.Draw();