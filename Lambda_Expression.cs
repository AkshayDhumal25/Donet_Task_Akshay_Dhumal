﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donet_Task_Akshay_Dhumal
{
    class Lambda_Expression
    {
        public void evenNumbers()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var list1 = list.Where(n => n % 2 == 0).ToList();
            foreach(var i in list1)
            {
                Console.WriteLine(i);
            }



        }
    }
}
