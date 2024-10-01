namespace MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Base.Struct
{
    /// <summary>
    /// Represents a point in a two-dimensional space.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="Point"/> struct.
    /// </remarks>
    /// <param name="x">The X-coordinate of the point.</param>
    /// <param name="y">The Y-coordinate of the point.</param>
    public readonly struct Point(double x, double y)
    {
        public double X { get; } = x;

        public double Y { get; } = y;

        /// <summary>
        /// Calculates the distance between two points.
        /// </summary>
        /// <returns>The distance between <paramref name="pointA"/> and <paramref name="pointB"/>.</returns>
        public static double Distance(Point pointA, Point pointB)
        {
            // Calculate the difference in coordinates
            double deltaX = pointB.X - pointA.X;
            double deltaY = pointB.Y - pointA.Y;

            // Return the Euclidean distance
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }


}
