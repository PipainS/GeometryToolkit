using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Interfaces;

namespace MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Base
{
    public abstract record ShapeBase : IShape
    {
        /// <summary>
        /// Calculates the area of the shape.
        /// </summary>
        /// <returns>The area of the shape.</returns>
        public abstract double CalculateArea();

        /// <summary>
        /// Draws the shape. Each derived class can provide its own implementation.
        /// </summary>
        public virtual void Draw() => DisplayShow();

        /// <summary>
        /// Displays the shape. This can be overridden by derived classes.
        /// </summary>
        protected virtual void DisplayShow()
        {
            Console.WriteLine($"Drawing {GetType().Name}");
        }
    }
}
