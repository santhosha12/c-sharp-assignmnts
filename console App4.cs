using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndCircumferenceOfaCircle
{
    public class assignQ4
    {
        public static void Main(string[] args)
        {
            double r, Area;

            const double PI = 3.14;

            Console.WriteLine("Enter the radius of circle : ");

            r = Convert.ToDouble(Console.ReadLine());

            Area = PI * r * r;
            double circumference = 2 * PI * r;

            Console.WriteLine("The area of circle is : {0} ", Area);

            Console.WriteLine("The circumference of circle is : {0} ", circumference);

        }




    }
}