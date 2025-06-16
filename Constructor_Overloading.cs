using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class Constructor_Overloading
    {
        public string Name;
        public int Age;

        public Constructor_Overloading()
        {
            Name = "Unknown";
            Age = 100;
            Console.WriteLine("Default Constructor");
        }

        public Constructor_Overloading(string name)
        {
            Name = name;
            Age = 0;
            Console.WriteLine("Constructor with 1 Parameter");
        }

        public Constructor_Overloading(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Constructor with 2 Parameters");
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}, Age : {Age}");
        }
    }
}
