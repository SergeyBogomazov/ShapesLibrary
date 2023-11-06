using ShapesLibrary.Interfaces;

namespace ShapesLibrary.Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;
        private double _area = -1;

        public double Radius => _radius;
        public double Area
        {
            get
            { 
                if (_area < 0) {
                    _area = Math.PI * Math.Pow(Radius, 2d);
                }

                return _area;
            }
        }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException($"Radius must be non negative");
            }

            _radius = radius;
        }
    }
}
