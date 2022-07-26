using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program


    {
        public static void LinqSyntax()
        {
            Console.WriteLine("Result with Link ");

            string[] f1 = { "Watermelon", "Apple", "Mango", "Guava", "Banana"};
            string[] f2 = { "Orange", "Kiwi", "Apple", "Watermelon"};
            var first = f1.Except(f2);
            var second = f2.Except(f1);
            var all = first.Union(second);
            foreach (var item in all)
            {
                Console.WriteLine(item);
            }
              
        }

        public static void GetDiffValueTrigger()
        {
            Console.WriteLine("another way to return without link");

            var array1 = new[] { "Watermelon", "Apple", "Mango", "Guava", "Banana" };
            var array2 = new[] { "Orange", "Kiwi", "Apple", "Watermelon" };
            GetDiffValue(array1, array2);
            GetDiffValue(array2, array1);
            Console.ReadLine();
        }

        public static void GetDiffValue(string[] array1, string[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                bool valueFound = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                        valueFound = true;
                }
                if (!valueFound)
                    Console.WriteLine(array1[i]);
            }
           
        }

        public static void AvoidDuplicate()
        {
            Console.WriteLine("Result without Link or set functions");

            //based arrays 
            string[] f1 = { "Watermelon", "Apple", "Mango", "Guava", "Banana" };
            string[] f2 = { "Orange", "Kiwi", "Apple", "Watermelon" };
           
            // merge tow array in one array
            string[] arr3 = new string[f1.Length + f2.Length];
            Array.Copy(f1, arr3, f1.Length);
            Array.Copy(f2, 0, arr3, f1.Length, f2.Length);

            //remove dublicate from merged array
            int i = 0;
            int j = 0;
            for (i = 0; i < arr3.Length; i++)
            {
                for (j = 0; j < arr3.Length; j++)
                {
                    if (i == j)
                        continue;
                    if (arr3[j] == arr3[i])
                        break;
                }
                if (arr3.Length == j)
                {
                    Console.WriteLine(arr3[i]);
                }
            }

        }


        static void Main(string[] args)
        {
            LinqSyntax();
            AvoidDuplicate();
            GetDiffValueTrigger();
            Console.ReadLine();
        }

      }
  }

