using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class StringBuilderDemo
    {
        public void concatenate()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Hello");
            Console.WriteLine(sb.ToString());
            sb.Append(" ");
            sb.Append("Akshay Dhumal");
            Console.WriteLine(sb.ToString());
        }
    }
}
