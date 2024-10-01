using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Interfaces;
using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Models;

namespace MindBox.AreaCalculator.src.ShapeLibrary.Factories
{
    /// <summary>
    /// Factory for creating instances of various shapes.
    /// </summary>
    public static class ShapeFactory
    {
        /// <summary>
        /// Creates an instance of a circle with the specified radius.
        /// </summary>
        public static IShape CreateCircle(double radius)
        {
            return new Circle(radius);
        }

        /// <summary>
        /// Creates an instance of a triangle with the specified side lengths.
        /// </summary>
        public static IShape CreateTriangle(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }
    }
}
