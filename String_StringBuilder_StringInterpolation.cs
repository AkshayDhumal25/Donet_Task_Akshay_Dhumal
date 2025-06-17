using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class String_StringBuilder_StringInterpolation
    {
        public void Strings()
        {
            string Name = "Akshay Dhumal";
            Name = "Akshay D. Dhumal";

            Console.WriteLine(Name);
        }

        public void stringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Akshay");
            Console.WriteLine(sb.ToString());
            sb.Append(" Dhumal");
            Console.WriteLine(sb.ToString());
        }

        public void stringInterpolation()
        {
            var Name = "Akshay Dhumal";

            Console.WriteLine($"Name : {Name}");
        }
    }
}
