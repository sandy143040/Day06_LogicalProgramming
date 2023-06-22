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
            while (true)
            {
                Console.WriteLine("Please choose 1program from below option");
                Console.WriteLine("1.Fibonacci series");
                Console.WriteLine("0.Exit");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Please Enter Value");
                        int num = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries series = new FibonacciSeries();
                        series.FindFibonacci(num);
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
