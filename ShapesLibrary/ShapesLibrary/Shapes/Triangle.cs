using ShapesLibrary.Interfaces;

namespace ShapesLibrary.Shapes
{
    public class Triangle : ITriangle
    {
        private readonly Lazy<bool> _isRight;
        private readonly Lazy<double> _area;

        public double sideA { get; }

        public double sideB { get; }

        public double sideC { get; }

        public bool IsRight => _isRight.Value;

        public double Area => _area.Value;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides must be positive");
            }

            var maxSide = Math.Max(a, Math.Max(b, c));
            var perimeter = a + b + c;

            if (maxSide >= perimeter - maxSide)
            {
                throw new ArgumentException("The biggest side must be less than sum of other sides");
            }

            sideA = a;
            sideB = b;
            sideC = c;

            _isRight = new Lazy<bool>(CalculateIsRight);
            _area = new Lazy<double>(CalculateArea);
        }

        private double CalculateArea()
        { 
            var perimeter = sideA + sideB + sideC;
            var halfper = perimeter / 2d;

            var area = Math.Sqrt(halfper * (halfper - sideA) * (halfper - sideB) * (halfper - sideC));

            return area;
        }

        private bool CalculateIsRight()
        {
            var max = Math.Max(sideA, Math.Max(sideB, sideC));

            double a;
            double b;

            if (max == sideA)
            {
                a = sideB; b = sideC;
            }
            else if (max == sideB)
            {
                a = sideA; b = sideC;
            }
            else
            {
                a = sideA; b = sideB;
            }

            return Math.Abs(Math.Pow(max, 2) - Math.Pow(a, 2) - Math.Pow(b, 2)) == 0;
        }
    }
}
