using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the array size:");
            int i= Convert.ToInt32(Console.ReadLine());
            //scalor sum
            int[] ar1 = new int[i];
            int[] ar2 = new int[i];

            for(int f=0;f<i;f++)
            {
                Console.WriteLine($"Enter number for the array 1 index {f} :");
                ar1[f] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter number for the array 2 index: {f} :");
                ar2[f] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            for(int k=0;k<i;k++ )
            {
                sum += ar1[k] + ar2[k];
            }
            Console.WriteLine($"scalor sum is {sum}");
            //vector sum
            int[]ar3= new int[i];
            for (int d = 0; d < i; d++)
            {
                ar3[d] = ar1[d] + ar2[d];
            }
            Console.WriteLine("\n");
            Console.WriteLine("the vector sum is:");
            for(int d = 0; d < i; d++)
            {
                Console.Write($"{ar3[d]},");
            }
            Console.WriteLine("\n");
            // vector product
            int[] pro=new int[i];
            for (int k = 0; k < i; k++)
            {
                pro[k]= ar1[k] * ar2[k];
            }
            Console.WriteLine("vector product is :");
            for (int b = 0; b < i; b++)
            {
                Console.Write($"{ pro[b]},");
                
            }
            //scalor product
            Console.WriteLine("\n");
            int scalpro = 0;
            for(int a=0;a<i;a++)
            {
                 scalpro=+ pro[a];
            }
            Console.WriteLine($"Scalor productis:{scalpro}");
            Console.ReadLine();
        }
    }
}
