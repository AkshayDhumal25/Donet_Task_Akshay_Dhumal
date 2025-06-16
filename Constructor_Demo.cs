using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class Constructor_Demo
    {
        public string Name;
        public int Age;

        public Constructor_Demo(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Constructor Called. Object Created.");
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}, Age : {Age}");
        }
    }
}
