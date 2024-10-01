namespace MindBox.AreaCalculator.src.ShapeLibrary.Constants
{
    /// <summary>
    /// Provides constant values related to shapes.
    /// </summary>
    public static class ShapeConstants
    {
        #region Triangle Constants
        /// <summary>
        /// Error message for invalid triangle configurations.
        /// </summary>
        public const string InvalidTriangleMessage = "The provided sides do not form a valid triangle.";

        /// <summary>
        /// The error message displayed when the incorrect number of sides is provided.
        /// </summary>
        public const string InvalidSidesMessage = "Exactly three sides must be provided.";

        /// <summary>
        /// Constant for the semi-perimeter factor.
        /// </summary>
        public const double SemiPerimeterFactor = 2.0;

        /// <summary>
        /// The number of sides in a triangle.
        /// </summary>
        public const int NumberOfSides = 3;

        // Minimum length for the sides of the triangle. The value of 1E-10 is chosen as a sufficiently small positive number 
        // to ensure that sides remain positive and to avoid precision issues when using floating-point numbers. 
        // This value also meets the conditions of the triangle inequality, allowing the triangle to exist.
        public const double MinSideLength = 1E-10;

        // Maximum length for the sides of the triangle. The value of 1E+75 is set to limit the size of the sides,
        // preventing overflow during calculations related to the semi-perimeter and area of the triangle. 
        // This value is large enough for practical applications but small enough to ensure safe execution of 
        // arithmetic operations, avoiding the potential for obtaining Infinity. 
        // The choice of 1E+75 is based on the range of double precision floating-point representation, 
        // which can handle values up to approximately ±1.7976931348623157E+308.
        public const double MaxSideLength = 1E+75;

        /// <summary>
        /// Determines if the given sides form a right triangle using the Pythagorean theorem.
        /// </summary>
        /// <returns>True if the sides form a right triangle, otherwise false.</returns>
        public const double Tolerance = 1e-10;

        /// <summary>
        /// Index constants for triangle sides
        /// </summary>
        public const int SideAIndex = 0; // Index for side A
        public const int SideBIndex = 1; // Index for side B
        public const int SideCIndex = 2; // Index for side C
        #endregion

        #region Circle Constants

        /// <summary>
        /// The maximum radius value that can be used to calculate the area of a circle
        /// without causing an overflow in the double data type.
        /// Calculated as: sqrt((double.MaxValue) / Math.PI).
        public const double MaxRadius = 7.563470072563349e+153;

        /// <summary>
        /// The minimum radius of a circle, derived from the square root of the machine epsilon for double precision floating-point numbers.
        /// Machine epsilon is the smallest positive number that, when added to 1.0, yields a result different from 1.0.
        /// Taking the square root of double.Epsilon ensures the radius is sufficiently large to maintain precision in area calculations.
        /// </summary>
        public static readonly double MinRadius = Math.Sqrt(double.Epsilon);

        /// <summary>
        /// Error message for invalid radius.
        /// </summary>
        public const string InvalidRadiusMessage = "Radius must be positive.";

        /// <summary>
        /// Error message for invalid radius.
        /// </summary>
        public const string ExceedsMaxRadiusMessage = "The radius exceeds the maximum allowed value.";

        public const string BelowMinRadiusMessage = "Radius is too small and does not maintain precision.";
        #endregion
    }
}
