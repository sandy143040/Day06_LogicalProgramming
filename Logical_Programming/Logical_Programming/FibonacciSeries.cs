using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class FibonacciSeries
    {
        public void FindFibonacci(int num)
        {
            int firstNum = 0;
            int secondNum = 1;
            int currentNum;
            for (int i = 0; i < num; i++)
            {
                Console.Write(firstNum + " ");
                currentNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = currentNum;
            }
        }
    }
}
