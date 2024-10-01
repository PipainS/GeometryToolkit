using MindBox.AreaCalculator.src.ShapeLibrary.Constants;
using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Base.Struct;
using MindBox.AreaCalculator.src.ShapeLibrary.Shapes.Models;

namespace MindBox.AreaCalculator.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_Constructor_ValidSides_CreatesTriangle()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;

            // Act
            var triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
        }

        [Fact]
        public void Triangle_Constructor_InvalidSides_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 1.0;
            double sideB = 2.0;
            double sideC = 3.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_Constructor_InvalidSides_NegativeLength_ThrowsArgumentException()
        {
            // Arrange
            double sideA = -1.0;
            double sideB = 2.0;
            double sideC = 2.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_Constructor_InvalidSides_ZeroLength_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 0.0;
            double sideB = 2.0;
            double sideC = 2.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Fact]
        public void Triangle_Constructor_ValidVertices_CreatesTriangle()
        {
            // Arrange
            var vertexA = new Point(0, 0);
            var vertexB = new Point(0, 4);
            var vertexC = new Point(3, 0);

            // Act
            var triangle = new Triangle(vertexA, vertexB, vertexC);

            // Assert
            Assert.True(triangle.SideA > 0);
            Assert.True(triangle.SideB > 0);
            Assert.True(triangle.SideC > 0);
        }

        [Fact]
        public void Triangle_Constructor_InvalidVertexPoints_ThrowsArgumentException()
        {
            // Arrange
            var vertexA = new Point(0, 0);
            var vertexB = new Point(0, 0); // Same point
            var vertexC = new Point(3, 0);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(vertexA, vertexB, vertexC));
        }

        [Fact]
        public void Triangle_Constructor_ValidArrayOfSides_CreatesTriangle()
        {
            // Arrange
            var sides = new double[] { 3.0, 4.0, 5.0 };

            // Act
            var triangle = new Triangle(sides);

            // Assert
            Assert.Equal(3.0, triangle.SideA);
            Assert.Equal(4.0, triangle.SideB);
            Assert.Equal(5.0, triangle.SideC);
        }

        [Fact]
        public void Triangle_Constructor_InvalidArrayOfSides_ThrowsArgumentException()
        {
            // Arrange
            var sides = new double[] { 1.0, 2.0 }; // Not enough sides

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sides));
        }

        [Fact]
        public void Triangle_CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3.0;
            double sideB = 4.0;
            double sideC = 5.0;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(6.0, area, 1);
        }

        [Fact]
        public void Triangle_CalculateArea_InvalidSides_ThrowsArgumentException()
        {
            // Arrange
            double sideA = 1.0;
            double sideB = 2.0;
            double sideC = 3.0;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC).CalculateArea());
        }

        [Fact]
        public void Triangle_CalculateArea_EquilateralTriangle_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3.0;
            var triangle = new Triangle(sideA, sideA, sideA);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            double expectedArea = (Math.Sqrt(3) / 4) * Math.Pow(sideA, 2);
            Assert.Equal(expectedArea, area, 1);
        }

        [Fact]
        public void Triangle_CalculateArea_IsoscelesTriangle_ReturnsCorrectArea()
        {
            // Arrange
            double baseSide = 4.0;
            double equalSide = 3.0;
            var triangle = new Triangle(equalSide, equalSide, baseSide);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            double expectedArea = (baseSide / 4) * Math.Sqrt(4 * Math.Pow(equalSide, 2) - Math.Pow(baseSide, 2));
            Assert.Equal(expectedArea, area, 1);
        }

        [Fact]
        public void Triangle_CalculateArea_FloatingPointPrecision_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 2.123456;
            double sideB = 2.987654;
            double sideC = 3.456789;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            double s = (sideA + sideB + sideC) / 2;
            double expectedArea = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            Assert.Equal(expectedArea, area, 6);
        }

        [Fact]
        public void Triangle_CalculateArea_VariousSides_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 5.0;
            double sideB = 12.0;
            double sideC = 13.0;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            double area = triangle.CalculateArea();

            // Assert
            Assert.Equal(30.0, area, 1);
        }

        [Fact]
        public void Triangle_CalculateArea_LinienarTriangle_ReturnsZeroArea()
        {
            // Arrange
            var vertexA = new Point(0, 0);
            var vertexB = new Point(1, 1);
            var vertexC = new Point(2, 2); // All points are on a line

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(vertexA, vertexB, vertexC));
        }

        [Fact]
        public void Triangle_CalculateArea_MaxValues_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = double.MaxValue / 2;
            double sideB = double.MaxValue / 2;
            double sideC = double.MaxValue / 2;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        [InlineData(8, 15, 17)]
        public void IsRightTriangleCondition_ShouldReturnTrue_ForRightTriangles(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.IsRightTriangle;

            // Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData(2, 2, 3)]
        [InlineData(5, 5, 8)]
        public void IsRightTriangleCondition_ShouldReturnFalse_ForNonRightTriangles(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.IsRightTriangle;

            // Assert
            Assert.False(result);
        }
    }
}
