using MindBox.AreaCalculator.src.ShapeLibrary.Constants;

namespace MindBox.AreaCalculator.src.ShapeLibrary.Utils
{
    /// <summary>
    /// Provides utility methods for triangle calculations.
    /// </summary>
    public static class TriangleUtils
    {
        /// <summary>
        /// Validates the lengths of the triangle's sides.
        /// </summary>
        /// <returns>True if the sides form a valid triangle; otherwise, false.</returns>
        public static bool IsValidTriangle(double sideA, double sideB, double sideC)
        {
            // Check if the sides are within the defined limits
            if (sideA < ShapeConstants.MinSideLength || sideA > ShapeConstants.MaxSideLength ||
                sideB < ShapeConstants.MinSideLength || sideB > ShapeConstants.MaxSideLength ||
                sideC < ShapeConstants.MinSideLength || sideC > ShapeConstants.MaxSideLength)
            {
                return false;
            }

            return sideA.IsPositive() && sideB.IsPositive() && sideC.IsPositive() &&
                   sideA + sideB > sideC &&
                   sideA + sideC > sideB &&
                   sideB + sideC > sideA;
        }
    }
}
