using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllIntegers
{
    internal class assignQ5
    {
        public static void Main(string[] args)
        {
            int[] number = { 1, 2, 3, 4, 5, 6, };

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum = sum + number[i];
            }

            Console.WriteLine("the sum is {0}", sum);
        }
    }
}