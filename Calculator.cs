using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Calculator
    {
        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
