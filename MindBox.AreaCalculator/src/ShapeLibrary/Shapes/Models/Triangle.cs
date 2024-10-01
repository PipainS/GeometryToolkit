using MindBox.AreaCalculator.src.ShapeLibrary.Constants;
using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Base;
using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Base.Struct;
using MindBox.AreaCalculator.src.ShapeLibrary.Utils;

namespace MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Models
{
    /// <summary>
    /// Represents a triangle defined by its sides or vertices.
    /// </summary>
    public record Triangle : ShapeBase
    {
        /// <summary>
        /// Gets the length of side A.
        /// </summary>
        public double SideA { get; init; }

        /// <summary>
        /// Gets the length of side B.
        /// </summary>
        public double SideB { get; init; }

        /// <summary>
        /// Gets the length of side C.
        /// </summary>
        public double SideC { get; init; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class using side lengths.
        /// </summary>
        public Triangle(double sideA, double sideB, double sideC)
        {
            ValidateTriangleSides(sideA, sideB, sideC);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class using vertex points.
        /// </summary>
        public Triangle(Point vertexA, Point vertexB, Point vertexC) 
            : this(Point.Distance(vertexB, vertexC), Point.Distance(vertexA, vertexC), Point.Distance(vertexA, vertexB))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class using an array of side lengths.
        /// </summary>
        public Triangle(IEnumerable<double> sides)
        {
            var triangleSides = sides.ToArray();
            if (triangleSides.Length != ShapeConstants.NumberOfSides)
            {
                throw new ArgumentException(ShapeConstants.InvalidSidesMessage);
            }

            SideA = triangleSides[ShapeConstants.SideAIndex];
            SideB = triangleSides[ShapeConstants.SideBIndex];
            SideC = triangleSides[ShapeConstants.SideCIndex];
            ValidateTriangleSides(SideA, SideB, SideC);
        }

        /// <summary>
        /// Validates the lengths of the triangle's sides.
        /// Throws an exception if the sides do not form a valid triangle.
        /// </summary>
        private static void ValidateTriangleSides(double sideA, double sideB, double sideC)
        {
            if (!TriangleUtils.IsValidTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException(ShapeConstants.InvalidTriangleMessage);
            }
        }

        /// <summary>
        /// Calculates the area of the triangle using Heron's formula.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public override double CalculateArea()
        {
            // Semi-perimeter of the triangle.
            double semiPerimeter = (SideA + SideB + SideC) / ShapeConstants.SemiPerimeterFactor;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }

        /// <summary>
        /// Returns a string that represents the current triangle.
        /// </summary>
        public override string ToString()
        {
            return $"Triangle(Side A: {SideA}, Side B: {SideB}, Side C: {SideC})";
        }
    }
}
