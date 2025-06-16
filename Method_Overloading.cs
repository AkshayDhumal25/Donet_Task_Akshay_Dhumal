using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class Method_Overloading
    {


        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"Addition of 2 Numbers : {c}");
        }

        public void add(int a, int b, int c)
        {
            int d = a + b + c;
            Console.WriteLine($"addition of 3 Numbers : {d}");
        }


    }
}
