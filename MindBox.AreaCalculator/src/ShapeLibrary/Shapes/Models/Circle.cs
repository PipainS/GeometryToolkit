using MindBox.AreaCalculator.src.ShapeLibrary.Constants;
using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Base;
using MindBox.AreaCalculator.src.ShapeLibrary.Utils;

namespace MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Models
{
    /// <summary>
    /// Represents a circle defined by its radius.
    /// </summary>
    public record Circle : ShapeBase
    {

        /// <summary>
        /// Gets the radius of the circle.
        /// </summary>
        public double Radius { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="radius">The radius of the circle. Must be positive.</param>
        /// <exception cref="ArgumentException">Thrown when the radius is not positive.</exception>
        public Circle(double radius)
        {
            CircleUtils.ValidateRadius(radius);

            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        /// <summary>
        /// Returns a string that represents the current circle.
        /// </summary>
        public override string ToString()
        {
            return $"Circle(Radius: {Radius}, Area: {CalculateArea()})";
        }
    }
}
