using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Donet_Task_Akshay_Dhumal
{
    class logicals
    {

        // Find the second highest number from the array
        public void secondHighest()
        {
            int[] array = { 12, 35, 1, 10, 34, 1, 35 };
            int secondLarge = 0;
            int large = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > large)
                {
                    secondLarge = large;
                    large = array[i];
                }
                if (array[i] < large && array[i] > secondLarge)
                {
                    secondLarge = array[i];
                }
            }

            Console.WriteLine($"Second Largest Element : {secondLarge}");
        }

        //WAP to reverse an integer without converting it to a string, without using any built-in methods.
        public void reverseInteger()
        {
            int n = 123;
            int reversed = 0;

            while(n > 0)
            {
                int temp = n % 10;
                reversed = reversed * 10 + temp;
                n = n / 10;
            }
            Console.WriteLine($"Reverse of 123 : {reversed}");
        }

        //2. Swap Values without using any variable a = 10, b = 12.
        public void swapValues()
        {
            int a = 10;
            int b = 12;

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"a(10) : {a} and b(12) : {b}");
        }

        //3. Logic for anagram program with its time complexity.
        public void anagram()
        {
            string str1 = "listen";
            string str2 = "silemt";

            str1 = str1.ToLower();
            str2 = str2.ToLower();

            if(isAnagram(str1, str2))
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }

        }

        public bool isAnagram(string str1, string str2)
        {
            if(str1.Length != str2.Length)
            {
                return false;
            }
            int[] array = new int[256];

            for(int i = 0; i < str1.Length; i++)
            {
                array[str1[i]]++;
                array[str2[i]]--;
            }

            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    return false;
                }
            }
            return true;

        }

        //4. Find the reverse of the string.
        public void stringReverse()
        {
            string str = "Akshay";

            string reversed = "";

            for(int i=str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            Console.WriteLine(reversed);
        }


        //5. WAP to find missing elements from the array?

        public void missingElements()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 10 };
            int n = array.Length;
            var list = new List<int>(array);
            int min = array.Min();
            int max = array.Max();

            for(int i = min; i < max; i++)
            {
                if(!list.Contains(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        //6. WAP to find the given string is Palindrome or not.
        public void Palindrome()
        {
            string str = "aabaa";

            if (isPalindrome(str))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not an Palindrome");
            }
        }

        public bool isPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while(left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }

        // 7. WAP to print Fibonacci series with recursion.
        public void Fibonacci_With_Recursion()
        {
            Console.WriteLine("Enter the number :");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(fibo(i));
            }
        }

        public int fibo(int n)
        {
            if (n <= 1) return n;

            return fibo(n - 1) + fibo(n - 2);
        }



        //8. WAP to print Fibonacci series without recursion.
        public void Fibonacci_Without_Recursion()
        {
            Console.WriteLine("Enter the number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a + " ");

                c = a + b;
                b = a;
                a = c;
               
            }

        }

        //11. Find prime numbers from 1 ....n
        public void PrimeNumbers()
        {
            Console.WriteLine("Enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                if (isPrime(i))
                {
                    Console.WriteLine(i);
                }
            }


        }

        public bool isPrime(int n)
        {
            if (n <= 1) return false;

            if (n == 2) return true;

            for(int i = 2; i * i <= n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }
            return true;
            
        }

    }
}
