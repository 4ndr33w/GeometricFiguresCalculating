namespace GeometricFiguresCalculating
{
    public class AreaCalculate
    {
        public double CircleArea(double radius)
        {
            radius = radius > 0 ? radius : radius * (-1); //площадь не может быть отрицательной
            double result = 2 * Math.PI * radius; 

            return result;
        }

        public double TriangleArea (double sideA, double sideB, double sideC)
        {
            double result = 0;

            double a = sideA > 0 ? sideA : (-1) * sideA;
            double b = sideB > 0 ? sideB : (-1) * sideB;
            double c = sideC > 0 ? sideC : (-1) * sideC;

            double perimeter = a + b + c;
            double semiPerimeter = perimeter / 2;

            double p = semiPerimeter;

            result = Math.Sqrt(p * (p-a) * (p-b) * (p-c));

            return result;
        }

        public bool IsTriangleRectangular (double sideA, double sideB, double sideC)
        {
            bool result = false;

            if (Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2) ||
                Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2) ||
                Math.Pow(sideA, 2) == Math.Pow(sideC, 2) + Math.Pow(sideB, 2))
            {
                result = true;
            }

            return result;

        }

        public double RectangleArea (double sideA, double sideB)
        {
            double _sideA = sideA > 0? sideA : -1 * sideA;
            double _sideB = sideB > 0 ? sideB : -1 * sideB;

            double result = _sideA * _sideB;

            return result;
        }

        public double IrregularQuadrilateralArea (double sideA, double sideB, double sideC, double sideD)
        {
            double result = 0;

            double a = sideA > 0? sideA : -1 * sideA;
            double b = sideB > 0? sideB : -1 * sideB;
            double c = sideC > 0? sideC : -1 * sideC;
            double d = sideD > 0? sideD : -1 * sideD;

            double perimeter = a + b + c + d;

            double p = perimeter / 2;

            result = Math.Sqrt( (p-a) * (p-b) * (p-c) * (p-d) );

            return result;
        }


        public double UnknownFigureArea (double circleRadius)
        {
            return CircleArea(circleRadius);
        }

        public double UnknownFigureArea (double triangleSideA, double triangleSideB, double triangleSideC)
        {
            return TriangleArea(triangleSideA, triangleSideB, triangleSideC);
        }

        public double UnknownFigureArea(double rectanglelSideA, double rectangleSideB)
        {
            return RectangleArea(rectanglelSideA, rectangleSideB);
        }

        public double UnknownFigureArea(double IrrQuadrSideA, double IrrQuadrSideB, double IrrQuadrSideC, double IrrQuadrSideD)
        {
            return IrregularQuadrilateralArea(IrrQuadrSideA, IrrQuadrSideB, IrrQuadrSideC, IrrQuadrSideD);
        }
    }
}
