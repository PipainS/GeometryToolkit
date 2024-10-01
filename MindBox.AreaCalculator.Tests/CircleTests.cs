using MindBox.AreaCalculator.src.ShapeLibrary.Constants;
using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Models;

namespace MindBox.AreaCalculator.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Circle_CalculateArea_ValidRadius_ReturnsCorrectArea()
        {
            // Arrange
            var radius = 5.0;
            var circle = new Circle(radius);
            var expectedArea = Math.PI * radius * radius;

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, area, 5);
        }

        [Fact]
        public void Circle_Constructor_InvalidRadius_NegativeValue_ThrowsArgumentException()
        {
            // Arrange
            var radius = -5.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Fact]
        public void Circle_Constructor_InvalidRadius_ZeroValue_ThrowsArgumentException()
        {
            // Arrange
            var radius = 0.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Fact]
        public void Circle_CalculateArea_HighPrecision_ReturnsExpectedArea()
        {
            // Arrange
            var radius = 2.5;
            var circle = new Circle(radius);
            var expectedArea = Math.PI * radius * radius;

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.Equal(expectedArea, area, 5);
        }

        [Fact]
        public void Circle_Constructor_RadiusExceedsMaxRadius_ThrowsArgumentException()
        {
            // Arrange
            var radius = ShapeConstants.MaxRadius * 1.1;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Fact]
        public void Circle_Constructor_RadiusExceedsMaxDouble_ThrowsArgumentException()
        {
            // Arrange
            var radius = Double.MaxValue;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}