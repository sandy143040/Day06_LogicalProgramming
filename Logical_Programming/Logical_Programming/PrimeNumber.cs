using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class PrimeNumber
    {
        public void FindPrime(int num)
        {
            int factors = 0;
            int i = 1;
            while(i <= num)
            {
               if(num%i==0)
               {
                  factors++;
               }
                i++;
            }
            if(factors==2)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("Not prime number",num);
            }
        }
    }
}
