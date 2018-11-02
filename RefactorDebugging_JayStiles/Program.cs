using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorDebugging_JayStiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6 };
            int i = 0;
            for (i = 0; i < array1.Length; i++)
            {
                array1[i]++;
            }
            int result = GetSum(array1);
            Console.WriteLine(result);
        }
        private static int GetSum(int[] array1)
        {
            int sum = 1;
            foreach (int item in array1)
            {
                sum = sum + item;
            }
            return sum;
        }
    }
   }

