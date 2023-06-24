using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_q6
{
    internal class nclass
    {
        
        
            public void array(int n)
            {
                int[] a = new int[n];
                for(int i=0;i<a.Length;i=i+2)
                {
                    Console.WriteLine($"enter your number {i}: ");
                    a[i]=Convert.ToInt32(Console.ReadLine());
                    if (i+1<n)
                    {
                        a[i + 1] = 0;
                    }


                }
                for(int f=0;f<a.Length;f++)
                {
                    Console.Write($"{a[f]},");
                }
             

            }
         
    }
}
