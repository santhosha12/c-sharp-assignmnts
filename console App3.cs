using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SwapTwoIntegers
{
    public class assignQ3
    {
        public static void Main(String[] args)
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            temp = number2;
            number1 = number2;
            Console.Write("\nAfter swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nsecond Number : " + number2);
            Console.Read();
        }
    }
}

