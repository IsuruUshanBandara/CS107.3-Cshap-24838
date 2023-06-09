using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            double radius=double.Parse(Console.ReadLine());
            FindValues objfindvalues = new FindValues();

            double area = objfindvalues.findarea(radius);
            Console.WriteLine("area =" + area);
           double circumference = objfindvalues.findCircumference(radius);
            Console.WriteLine("Circumference =" + circumference);
            Console.ReadLine();
        }
    }
}
