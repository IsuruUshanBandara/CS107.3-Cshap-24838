using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the kilometer amount");

            int kilometers = int.Parse(Console.ReadLine());

            ConvertValues objconvertValues = new ConvertValues();

            int meters = objconvertValues.kilometerToMmter(kilometers); 
            Console.WriteLine("Converted meter is: " + meters);
            Console.ReadKey();
        }
    }
}
