namespace MindBox.AreaCalculator.src.ShapeLibrary.Utils
{
    public static class ValidationExtensions
    {
        /// <summary>
        /// Checks if the given integer is positive (greater than 0).
        /// </summary>
        public static bool IsPositive(this double value) => value > 0;
    }
}
