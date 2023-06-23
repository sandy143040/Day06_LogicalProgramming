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
                Console.WriteLine("2.Perfect Number");
                Console.WriteLine("3.Prime Number");
                Console.WriteLine("4.Reverse Number");
                Console.WriteLine("5.Coupon Number");
                Console.WriteLine("6.Stop watch");
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
                    case 2:
                        Console.WriteLine("Enter Number");
                        int input = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.FindPerfect(input);
                        break;
                    case 3:
                        Console.WriteLine("Please enter number");
                        int numPrime = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.FindPrime(numPrime);
                        break;
                    case 4:
                        Console.WriteLine("Please enter number");
                        int numReverse = Convert.ToInt32(Console.ReadLine());
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse(numReverse);
                        break;
                    case 5:
                        Console.WriteLine("Enter Number");
                        int number = Convert.ToInt32(Console.ReadLine());
                        Coupon.getDistinctNumbers(number);
                        break;
                    case 6:
                        Stopwatch.StopwatchFunction();
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
