namespace MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Interfaces
{
    public interface IShape
    {
        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>The area of the shape.</returns>
        double CalculateArea();

        /// <summary>
        /// Draws the shape to a graphical context.
        /// </summary>
        void Draw();
    }
}
