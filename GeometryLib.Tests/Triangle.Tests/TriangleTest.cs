
namespace GeometryLib.Tests.Triangle.Tests
{
    public class TriangleTest
    {
        [Theory]
        [InlineData(0,0,0)]
        [InlineData(-1,5,3)]
        [InlineData(3,4,52)]

        public void InvalidSides_ShouldThrowArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new MindBoxGeometryLib.Figure.Triangle(a, b, c));
        }
        [Theory]
        [InlineData(3,4,5,6)]
        [InlineData(5,5,5, 10.825317547305483)]
        public void GetArea_ShouldReturnCorrectAreaForValidTriangle(double a,double b, double c,double expected)
        {
            // Arrange
            var triangle = new MindBoxGeometryLib.Figure.Triangle(a, b, c);

            // Act
            var area = triangle.GetArea();

            // Assert
            Assert.Equal(expected, area);
        }
        [Theory]
        [InlineData(3,4,5)]
        public void IsRightTriangle_ShouldReturnTrueForRightTriangle(double a, double b, double c)
        {
            // Arrange
            var triangle = new MindBoxGeometryLib.Figure.Triangle(a, b, c);

            // Act
            var isRightTriangle = triangle.IsRightTriangle();

            // Assert 
            Assert.True(isRightTriangle);
        }


    }
}
