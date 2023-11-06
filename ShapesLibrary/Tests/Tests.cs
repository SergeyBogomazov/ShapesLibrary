using ShapesLibrary.Shapes;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public async Task CircleNegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-0.5d));
        }

        [Fact]
        public async Task CircleArea1()
        {
            var circle = new Circle(1d);

            var area = circle.Area;
            var expected = Math.PI;

            Assert.Equal(expected, area);
        }

        [Fact]
        public async Task CircleArea3()
        {
            var circle = new Circle(0d);

            var area = circle.Area;
            var expected = 0d;

            Assert.Equal(expected, area);
        }

        [Fact]
        public async Task CircleArea2()
        {
            var radius = 13d;
            var circle = new Circle(radius);

            var area = circle.Area;
            var expected = Math.PI * Math.Pow(radius, 2d);

            Assert.Equal(expected, area);
        }
    }
}