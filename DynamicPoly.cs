using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace yeah
{
    public class DynamicPoly
    {   
        private int num = 2;
        private int num1 = 3;  
        public virtual void Cal()
        {
          Console.WriteLine("Jesus is Lord");
        }
        public void Cal(int a, int b)
        {
          Console.WriteLine(a + b);
        }
        public void Cal(double a, double b)
        {
          Console.WriteLine(a + b);
        }
    }
}