using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__lab_q5_6_16_2023
{
    internal class Sizecal
    {
        public int minimum()
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number for" + i + ":");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            int min = num[1];
            for (int f = 0; f < 5; f++)
            {
                min = Math.Min(num[f], min);

            }
            return min;
        }

        public int maximum()
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number for" + i + ":");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            int ma = num[1];
            for (int f = 0; f < 5; f++)
            {
                ma = Math.Max(num[f], ma);

            }
            return ma;
        }
        public double average()
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number for" + i + ":");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            int sum = 0;
            double av = 0;
            for (int f = 0; f < 5; f++)
            {
                sum += num[f];
                av = sum / 5;

            }
            return av;
        }

         public void reverse()
        {
            int[] num = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number for" + i + ":");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
           
            for (int f = 4; f >= 0; f--)
            {
                Console.Write(num[f]+",");


            }
            Console.WriteLine("\n");
        }

        

    }
    
}
