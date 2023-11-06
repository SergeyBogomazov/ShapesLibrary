using ShapesLibrary.Interfaces;
using ShapesLibrary.Shapes;

namespace Tests
{
    public class Tests
    {
        #region Circle
        [Fact]
        public async Task CircleNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-0.5d));
        }

        [Theory]
        [InlineData(1d)]
        [InlineData(0d)]
        [InlineData(13d)]
        public async Task CircleArea1(double radius)
        {
            var circle = new Circle(radius);

            var area = circle.Area;
            var expected = Math.PI * Math.Pow(radius, 2d);

            Assert.Equal(expected, area);
        }

        #endregion

        #region Triangle
        [Theory]
        [InlineData(-1d, 10, 11)]
        [InlineData(10, -1d, 10)]
        [InlineData(10, 10, -1d)]
        [InlineData(-1d, -1d, -1d)]
        public void TriangleNegativeSides(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a,b,c));
        }

        [Theory]
        [InlineData(3d, 4d, 7d)]
        [InlineData(3d, 4d, 8d)]
        public async Task TriangleWrongSides(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Fact]
        public async Task TriangleArea()
        {
            double a = 3d, b = 4d, c = 5d;
            double expected = 6d;
            var triangle = new Triangle(a, b, c);

            var square = triangle.Area;

            Assert.Equal(expected, square);
        }

        [Theory]
        [InlineData(3d, 4d, 5d, true)]
        [InlineData(5d, 12d, 13d, true)]
        [InlineData(4d, 4d, 6d, false)]
        [InlineData(4d, 2d, 5d, false)]
        public async Task CheckIsRight(double a, double b, double c, bool isRightExpected)
        {
            var triangle = new Triangle(a, b, c);

            Assert.Equal(isRightExpected, triangle.IsRight);
        }
        #endregion
    }
}