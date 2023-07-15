using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratical_05_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Summation sumation=new Summation();
            sumation.Setnumbers();
            Console.WriteLine("Sum: " + sumation.GetSum());


            Substraction substraction=new Substraction();
            substraction.Setnumbers();
            Console.WriteLine("Substraction: " + substraction.Getsub());

            Multiplication multiplication=new Multiplication();
            multiplication.Setnumbers();
            Console.WriteLine("Multiplication: " + multiplication.GetMul());  

            Division division=new Division();
            division.Setnumbers();
            Console.WriteLine("Division: " + division.GetDiv());
            Console.ReadKey();  
        }

    }
}
