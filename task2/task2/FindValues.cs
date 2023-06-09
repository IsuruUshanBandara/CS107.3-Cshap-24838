using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class FindValues
    {
        public double findarea(double radius)
        {
                       
            
           return (double)Math.PI*(radius*radius);
      

        }
        public double findCircumference(double radius)
        {
              
            return 2 * (double)Math.PI * radius;

        }
    }
}
