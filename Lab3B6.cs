using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_MAB
{
    internal class Lab3B6
    {
        public int FindArea(int side)
        {
            int result = side * side;
            return result;
        }

        public double FindArea(double length,double breadth)
        {
            double result = length * breadth;
            return result;
        }

        public double FindArea(double radius)
        {
            double result = 3.14 * radius * radius;
            return result;
        }
    }
}
