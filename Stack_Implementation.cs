using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class Stack_Implementation
    {
        public void stack_demo()
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine($"Top Element : {stack.Peek()}");

            Console.WriteLine($"Removing the top element: {stack.Pop()}");

            foreach(var i in stack)
            {
                Console.WriteLine(i);
            }
        }

    }
}
