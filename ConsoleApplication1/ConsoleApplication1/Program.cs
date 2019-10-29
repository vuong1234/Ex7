using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle1 c1 = new Circle1();
            Console.WriteLine("The circle has radius of {0} and area of {1} and circumference {2}",
                c1.Getradius(), c1.GetArea(), c1.GetCircumference());

            Circle1 c2 = new Circle1(2);
            Console.WriteLine("The circle has radius of {0} and area of {1} and circumference {2} ",
                c2.Getradius(), c2.GetArea(), c2.GetCircumference());

            Circle1 c3 = new Circle1(2);
            c3.Setradius(5);
            Console.WriteLine("radius is: " + c3.Getradius());
        }
    }
}
