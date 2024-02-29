using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lommeregner
{
    internal class Calculator
    {
        int x;
        int y;
        public int Add(int x, int y) {
            return x + y;
        }
        public int Subtract(int x, int y) {
            return x - y;
        }
        public double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)x / y;
        }
        public int Multi(int x, int y) {
            return x * y;
        }
    }
}
