using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class var_dynaic_object
    {
        public void print()
        {
            Console.WriteLine("Demonstration of var : ");
            var str = "Akshay";
            Console.WriteLine($"Name  : {str}");
            str = "Akshay Dhumal";
            Console.WriteLine($"Name : {str}");


            Console.WriteLine("Demonstration of dynamic");
            dynamic name = "Akshay Dhumal";
            Console.WriteLine($"Name  : {name}");
            name = 21;

        }
    }
}
