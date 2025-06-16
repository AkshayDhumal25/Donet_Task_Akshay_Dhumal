using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class StopwatchDemo
    {
        public void stopwatch_()
        {
            Stopwatch stw = new Stopwatch();


            Console.WriteLine("Press any key to start the stopwatch");
            Console.ReadKey();
            stw.Start();

            Console.WriteLine("Press any key to stop the stopwatch");
            Console.ReadKey();
            stw.Stop();

            Console.WriteLine($"Timing : {stw.Elapsed}");
        }
    }
}
