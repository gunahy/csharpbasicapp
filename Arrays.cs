using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicApp
{
    internal class Arrays
    {
        public static void ChangeCharInName()
        {
            Console.WriteLine("Введите своё имя");

            var name = Console.ReadLine();
            string[] eman = new string[name.Length];

            int j = 0;
            int i = name.Length-1;
            for (; i >= 0; i--)
            {
                eman[i] = name[j].ToString();
                j++;
            }
            

            foreach (string ch in eman)
            {
                Console.Write(ch); 
            }
        

            Console.ReadKey();
        }
        
        public static void ArraySort()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var temp = arr[j];
                        arr[j] = arr[j+ 1];
                        arr[j + 1] = temp;

                    }
                }
                
            }

            foreach (int i in arr) Console.Write(i);
        }

        public static void ArrWeight()
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };
            int sum = 0;

            foreach (int i in arr) { sum += i; }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
