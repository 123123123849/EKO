using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set
{
    class Class1
    {
        private double a;
        private double b;
        private double S;


        public Class1(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double met()
        {
            S = 0.5 * a * b;
            S = Math.Sin(S);
            return S;
        }
    }
}
