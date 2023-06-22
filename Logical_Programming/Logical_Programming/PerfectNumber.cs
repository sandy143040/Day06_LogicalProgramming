using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class PerfectNumber
    {
        public void FindPerfect(int num)
        {
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if(num%i == 0)
                {
                    sum = sum + i;
                }
            }
            if(num == sum)
            {
                Console.WriteLine($"{num} is perfect number");
            }
            else
            {
                Console.WriteLine($"{num} is not Perfect number");
            }
        }
    }
}
