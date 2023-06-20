using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class FibonacciSeries
    {
        public static void FindFibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int c;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                c = a + b;
                a = b;
                b = c;
            }
        }
    }
}
