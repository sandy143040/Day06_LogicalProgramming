using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class VendingMachine
    {
        public static void GetMinimumNumOfNotes(int amount)
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] numbOfNotes = new int[notes.Length];
            int i = 0;
            while (amount > 0)
            {
                if (amount >= notes[i])
                {
                    int remainder = amount % notes[i]; //5
                    numbOfNotes[i] = amount / notes[i]; //1
                    amount = remainder;
                }
                i++;
            }
            for (int j = 0; j < notes.Length; j++)
            {
                if (numbOfNotes[j] != 0)
                {
                    Console.WriteLine(notes[j] + " rs:" + numbOfNotes[j]);
                }
            }
        }
    }
}
