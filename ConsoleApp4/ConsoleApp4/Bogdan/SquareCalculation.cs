using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogdan
{
    public class SquareCalculation : LinearCalculation, core.EquationInterface
    {
        protected double discriminant(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }

        public List<double> solve(double a, double b, double c)
        {

            if (a == 0)
            {
                return x = LinearEquation(b, c);
                //return list;
            }

            double disc = discriminant(a, b, c);
            if (disc < 0)
            {
                return null;
            }

            if (disc > 0)
            {
                return x = new List<double>() { (-b + Math.Sqrt(disc)) / (2 * a), (-b - Math.Sqrt(disc)) / (2 * a) };
            }

            return x = new List<double>() { -b / (2 * a) };

        }
    }
}
