using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__practical_6_16_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number1:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            int b = Convert.ToInt32(Console.ReadLine());
            CalculateValues value= new CalculateValues();
            {
                
                bool done = true;
               
                while (done)
                {
                    int res;
                    int des;
                    Console.WriteLine("From below select your decision :\nEnter number 1 Adition\nEnter number 2 Substractionn\nEnter number 3 Divition\nEnter number 4 Multiplication\nEnter 0 to stop\nEnter your decision:");
                    des=Convert.ToInt32(Console.ReadLine());
                    switch (des)
                    {
                        case 1:
                             res=value.Adition(a, b);
                            Console.WriteLine("your answer is:"+res);
                            break;
                        case 2:
                             res=value.Substraction(a, b);
                            Console.WriteLine("your answer is:" + res);
                            break;
                        case 3:
                           res= value.Division(a, b);
                            Console.WriteLine("your answer is:" + res);
                            break;
                        case 4:
                           res= value.multiplication(a, b);
                            Console.WriteLine("your answer is:" + res);
                            break;

                        case 0:
                            done = false;
                            break;
                        default:
                            Console.WriteLine("Sorry invalid operator.");
                            break;



                    }
                }
                Console.ReadLine();
            }
        }
    }
}
