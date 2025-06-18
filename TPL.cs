using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class TPL
    {
        public void task_parallel_library()
        {
            Task Task1 = Task.Run(() => PrintNumbers("Task 1"));

            Task Task2 = Task.Run(() => PrintNumbers("Task 2"));

            Task.WaitAll(Task1, Task2);

            Console.WriteLine("Both Tasks are completed.");
        }


        public void PrintNumbers(string taskName)
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{taskName} - Number : {i}");
            }
        }
    }
}
