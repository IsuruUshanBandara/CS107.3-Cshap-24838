using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratical_05_q2
{
    class Getnumbers

    {
        public int number1;
        public int number2;

        public void Setnumbers() 
        {
            Console.WriteLine("Enter number 1: ");
            number1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            number2 = Convert.ToInt32(Console.ReadLine());

        }
    }
}
