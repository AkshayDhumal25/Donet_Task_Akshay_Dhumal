using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class Ref_Out_Parameters
    {
        public void refParameter()
        {
            
            int n = 10;
            printValue(ref n);
        }

        public void printValue(ref int n)
        {
            n += 5;

            Console.WriteLine("By ref parameter.");
            Console.WriteLine(n);
        }

        public void outParameter()
        {
            int n;
            printValue1(out n);
        }
        public void printValue1(out int n)
        {
            n = 5;
            n += 5;
            Console.WriteLine("By ref method.");
            Console.WriteLine(n);
        }
    }
}
