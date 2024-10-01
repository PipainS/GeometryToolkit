using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindBox.AreaCalculator.src.ShapeLibrary.Constants;

namespace MindBox.AreaCalculator.src.ShapeLibrary.Utils
{
    public static class CircleUtils
    {
        /// <summary>
        /// Validates the radius of a circle.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <exception cref="ArgumentException">Thrown when the radius is not valid.</exception>
        public static void ValidateRadius(double radius)
        {
            if (!radius.IsPositive())
                throw new ArgumentException(ShapeConstants.InvalidRadiusMessage, nameof(radius));

            if (radius > ShapeConstants.MaxRadius)
                throw new ArgumentException(ShapeConstants.ExceedsMaxRadiusMessage, nameof(radius));

            if (radius <= ShapeConstants.MinRadius)
                throw new ArgumentException(ShapeConstants.BelowMinRadiusMessage, nameof(radius));
        }
    }
}
