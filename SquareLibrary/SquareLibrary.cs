namespace SquareLibrary
{
    interface ISquare
    {
        double CalculateSquare();
    }
    public class Triangle
    {
        private List<double> _sides; //Используется для проверок
        private double _sideOne;
        private double _sideTwo;
        private double _sideThree;
        public double SideOne { get { return this._sideOne; } set { if (value > 0) { this._sideOne = value; } else { throw new ArgumentException("Значение не может быть отрицательным.", nameof(value)); } } }
        public double SideTwo { get { return this._sideTwo; } set { if (value > 0) { this._sideTwo = value; } else { throw new ArgumentException("Значение не может быть отрицательным.", nameof(value)); } } }
        public double SideThree { get { return this._sideThree; } set { if (value > 0) { this._sideThree = value; } else { throw new ArgumentException("Значение не может быть отрицательным.", nameof(value)); } } }
        public Triangle(double FirstSide, double SecondSide, double ThirdSide)
        {
            var Sum = FirstSide + SecondSide + ThirdSide;
            _sides = new List<double>() { FirstSide, SecondSide, ThirdSide };
            foreach (var s in _sides)
            {
                if (s >= (Sum - s))
                {
                    throw new ArgumentOutOfRangeException("Треугольник с такими сторонами не существует");
                }
            }
            SideOne = FirstSide;
            SideTwo = SecondSide;
            SideThree = ThirdSide;
        }
        public double CalculateSquare()
        {
            var HalfPerimeter = (_sideOne + _sideTwo + _sideThree) / 2f;
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - _sideOne) * (HalfPerimeter - _sideTwo) * (HalfPerimeter - _sideThree));
        }

        public bool IsRectangular()
        {
            _sides.Sort();

            return Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2) == Math.Pow(_sides[2], 2);
        }
    }

    public class Circle : ISquare
    {
        private double _radius;
        public double Radius { get { return this._radius; } set { if (value > 0) { this._radius = value; } else { throw new ArgumentException("Значение не может быть отрицательным.", nameof(value)); } } }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CalculateSquare()
        {
            return Math.PI*Math.Pow(_radius, 2);
        }
    }
}