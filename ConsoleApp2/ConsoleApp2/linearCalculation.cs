using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bogdan
{
    public class linearCalculation
    {
        protected List<double> x;

        public List<double> linearEquation(double a, double b)
        {

            if (b == 0)
            {
                return null;
            }

            //  x = -b / a;
            return x = new List<double>() { -b / a };
        }
    }
}
