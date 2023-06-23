using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class Coupon
    {
        public static void getDistinctNumbers(int number)
        {
            Random random = new Random();
            int[] array = new int[number];
            int i = 0;
            while (array.Length > i)
            {
                int randomNumber = random.Next(1, 50);
                if (!array.Contains(randomNumber))
                {
                    array[i] = randomNumber;
                    i++;
                }
            }
            foreach (int j in array)
            {
                Console.Write(j + " ");
            }
        }
    }
}
