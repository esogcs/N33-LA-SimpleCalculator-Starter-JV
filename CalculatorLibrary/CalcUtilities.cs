using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class CalcUtilities
    {
        public static decimal add(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public static decimal multiply(decimal a, decimal b)
        {
            return a * b;
        }
        public static decimal divive(decimal a, decimal b)
        {
            return a / b;
        }
        public static decimal modulus(decimal a, decimal b)
        {
            return a % b;
        }
    }
}
