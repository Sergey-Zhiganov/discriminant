using System;

namespace Discriminant
{
    public class MathsMethods
    {
        public (double?, double?) Discriminant(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                return (null, null);
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                return (x, x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                return (x1, x2);
            }
        }
        public double PercentOfNumber(double number, double percent)
        {
            return (number / 100) * percent;
        }
    }
}
