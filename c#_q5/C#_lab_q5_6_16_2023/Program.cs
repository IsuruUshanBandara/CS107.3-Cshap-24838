using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace C__lab_q5_6_16_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sizecal size = new Sizecal();

            
            bool dim = true;
            int res;
            double dou;
            while (dim)
              {
                Console.WriteLine("Enter 1 to find min value \n Enter 2 to find max values\nEnter 3 for average\n Enter 4 to get the reverse:\n Enter any other number to exit:");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        res = size.minimum();
                        Console.WriteLine("min is " + res);
                        break;
                    case 2:
                        res = size.maximum();
                        Console.WriteLine("max is " + res);
                        break;

                    case 3:
                        dou = size.average();
                        Console.WriteLine("äverage is " + a);
                        break;
                    case 4:

                        size.reverse();

                        break;
                    default:
                        dim = false;
                        break;

                }
              }
        }
        
    }
}
