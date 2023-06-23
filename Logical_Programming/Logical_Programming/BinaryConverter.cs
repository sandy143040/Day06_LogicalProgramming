using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class BinaryConverter
    {
        public static string ToBinary(int decimalNumber)
        {
            int remainder;
            string binaryString = "";

            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                binaryString = remainder.ToString() + binaryString;
                decimalNumber /= 2;
            }

            // Pad the binary string with 0s to ensure it has 32 bits
            while (binaryString.Length < 32)
            {
                binaryString = "0" + binaryString;
            }

            return binaryString;
        }
    }
}
