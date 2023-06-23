using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programming
{
    public class Stopwatch
    {
        public static void StopwatchFunction()
        {
            Console.WriteLine("Press any key to start the stopwatch");
            Console.ReadKey();

            DateTime startTime = DateTime.Now;

            Console.WriteLine("Press any key to stop the stopwatch");
            Console.ReadKey();

            DateTime stopTime = DateTime.Now;

            TimeSpan elapsedTime = stopTime - startTime;

            Console.WriteLine("Elapsed time: {0}", elapsedTime);
            Console.ReadKey();
        }

    }
}
