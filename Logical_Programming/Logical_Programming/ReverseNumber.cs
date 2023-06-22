using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class ReverseNumber
    {
        public void Reverse(int num)
        {
            int rev = 0;
            while(num > 0)
            {
                int lastDigit = num % 10;
                rev = (rev * 10) + lastDigit;
                num = num / 10;
            }
            Console.WriteLine(rev);
        }
    }
}
