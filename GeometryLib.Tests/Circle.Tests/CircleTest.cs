
namespace GeometryLib.Tests.Circle.Tests
{
    public class CircleTest
    {
        [Theory]
        [InlineData(-10)]
        [InlineData(-0.01)]
        public void InvalidRadius_ThrowArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => new MindBoxGeometryLib.Figure.Circle(radius));
        }

        [Theory]
        [InlineData(0,0)]
        [InlineData(5,Math.PI* (5*5))]
        [InlineData(15,Math.PI* (15*15))]
        [InlineData(0.12,Math.PI* (0.12*0.12))]
        public void GetArea_ShouldReturnCorrectAreaForPositiveRadius(double a, double expected)
        {
            // Arrange
            var circle = new MindBoxGeometryLib.Figure.Circle(a);

            // Act
            var area = circle.GetArea();

            // Assert
            Assert.Equal(expected, area);
        }

    }
}
