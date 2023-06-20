using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to logical programming problem");
            Console.WriteLine("Please choose 1program from below option");
            Console.WriteLine("1.Fibonacci series");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    Console.WriteLine("Please Enter Value");
                    int n = Convert.ToInt32(Console.ReadLine());
                    FibonacciSeries.FindFibonacci(n);
                    break;
            }
            Console.ReadLine();
        }
    }
}
