using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Donet_Task_Akshay_Dhumal
{
    class IEnumerable_and_IEnumerator
    {
        public void shop()
        {
            fruitBasket basket = new fruitBasket();

            Console.WriteLine("Using IEnumerable");
            foreach(string fruit in basket)
            {
                Console.WriteLine(fruit);
            }


            Console.WriteLine("Using IEnumrator");
            IEnumerator enumerator = basket.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        
    }

    public class fruitBasket : IEnumerator
    {
        private string[] fruits = { "Apple", "Banana", "Cherry" };

        public object Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            return fruits.GetEnumerator();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
