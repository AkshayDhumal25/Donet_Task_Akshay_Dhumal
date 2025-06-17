using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class DataTypes
    {
        public void PrimitiveTypes()
        {
            int a = 1;

            char b = 'a';

            bool c = false;

            float height = 5.8f;

            double salary = 15000.00;

            Console.WriteLine($"Int  : {a}");
            Console.WriteLine($"Char  : {b}");
            Console.WriteLine($"Bool  : {c}");
            Console.WriteLine($"Float : {height}");
            Console.WriteLine($"Double : {salary}");

        }


        public void NonPrimitiveTypes()
        {
            string Name = "Akshay Dhumal";

            Console.WriteLine($"Name : {Name}");
        }

    }
}
