using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class SquareRoot
    {
        public static double Sqrt(double c)
        {
            if (c < 0)
            {
                Console.WriteLine("Input must be non-negative.");
            }

            double epsilon = 1e-15;
            double t = c;
            while (Math.Abs(t - c / t) > epsilon * t)
            {
                t = (c / t + t) / 2.0;
            }
            return t;
        }
    }
}
