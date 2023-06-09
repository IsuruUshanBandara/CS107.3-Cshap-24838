using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class ConvertValues
    {
       public void kilometerToMmter()
        {
            int kilometers, meters;

            Console.WriteLine("Enter the kilometer amount");
            kilometers=int.Parse(Console.ReadLine());

            meters = kilometers*1000;

            Console.WriteLine("Converted meter is: " + meters);
        }
    }
}
