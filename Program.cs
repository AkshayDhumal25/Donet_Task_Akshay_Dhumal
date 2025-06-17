using System;

namespace Donet_Task_Akshay_Dhumal
{
    class Programs
    {
        public static void Main(string[] args)
        {
            // Demonstration of the Constructor ******************************
            //Constructor_Demo cd = new Constructor_Demo("Akshay", 20);

            //cd.DisplayInfo();

            // Demonstration of the Constructor Overloading*********************************
            //Constructor_Overloading co = new Constructor_Overloading();
            //co.DisplayInfo();

            //Constructor_Overloading co1 = new Constructor_Overloading("Akshay");
            //co.DisplayInfo();

            //Constructor_Overloading co3 = new Constructor_Overloading("Akshay", 20);
            //co.DisplayInfo();

            // Method Overloading ******************************************************

            //Method_Overloading mo = new Method_Overloading();

            //mo.add(1, 2);
            //mo.add(1, 2, 3);


            // Stopwatch ************************************************************************
            //StopwatchDemo stp = new StopwatchDemo();
            //stp.stopwatch_();

            // StringBuilder *******************************************************************
            //StringBuilderDemo sbd =  new StringBuilderDemo();
            //sbd.concatenate();

            //Stack Demo ********************************************************

            //Stack_Implementation stki = new Stack_Implementation();
            //stki.stack_demo();


            //Method Overriding ****************************************************
            //Method_Overriding mo;

            //mo = new Dog();
            //mo.speak();

            //mo = new Cat();
            //mo.speak();


            //WAPforPrimitivevsNonPrimitivetypes **********************************************************

            //DataTypes dt = new DataTypes();
            //dt.PrimitiveTypes();
            //Console.WriteLine();
            //dt.NonPrimitiveTypes();


            // String_StringBuilder_StringInterpolation ************************************************
            //String_StringBuilder_StringInterpolation sss = new String_StringBuilder_StringInterpolation();
            //sss.Strings();
            //sss.stringInterpolation();
            //sss.stringBuilder();

            // List and Methods

            List_methods lm = new List_methods();

            lm.listMethods();
        }

    }
};