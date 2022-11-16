using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace assign1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please entert two numbers to add substract multiply and divide");
            int num1, num2 = 0;
            int add, substract, multiply, divide = 0;
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            substract = num1 - num2;
            multiply = num1 * num2;
            divide = num1 / num2;
            Console.WriteLine("results");
            Console.WriteLine("addition {0}", add);
            Console.WriteLine("susbtraction {0}", substract);
            Console.WriteLine("multiplication {0}", multiply);
            Console.WriteLine("division {0}", divide);
            Console.ReadLine();
        }
    }
}

