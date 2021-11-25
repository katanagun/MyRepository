using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogdan
{
    public class LinearCalculation
    {
        protected List<double> x;

        public List<double> LinearEquation(double a, double b)
        {

            if (b == 0)
            {
                return null;
            }

            //  x = -b / a;
            Console.WriteLine("Это линейное уравнение");
            return x = new List<double>() { -b / a };
        }
    }
}
