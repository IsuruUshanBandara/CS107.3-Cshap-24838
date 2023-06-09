using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the kilometer amount");
            int kilometers = int.Parse(Console.ReadLine());
            ConvertValues objconvertValues = new ConvertValues();
            objconvertValues.kilometerToMmter(kilometers);
            Console.ReadKey();
        }
    }
}
