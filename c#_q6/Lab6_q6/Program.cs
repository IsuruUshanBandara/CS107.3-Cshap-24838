using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            nclass cls = new nclass();
            {
                Console.WriteLine("enter length");
                int an = Convert.ToInt32(Console.ReadLine());
                cls.array(an);
                Console.ReadLine();
            }

        }
    }
}
