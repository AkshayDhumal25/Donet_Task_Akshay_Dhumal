using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class Method_Overriding
    {
        public virtual void speak()
        {
            Console.WriteLine("Voice of animals");
        }
    }

    class Dog : Method_Overriding
    {
        public override void speak()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    class Cat : Method_Overriding
    {
        public override void speak()
        {
            Console.WriteLine("Cat Meows");
        }
    }
}
