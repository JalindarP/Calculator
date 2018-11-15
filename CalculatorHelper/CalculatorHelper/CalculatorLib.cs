using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorHelper
{
    public class CalculatorLib
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static int Division(int a, int b)
        {
            if (b != 0)
                return a / b;
            else
                return 0;
        }
    }
}
