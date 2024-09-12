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
        public static decimal divide(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }
            return a / b;
        }
        public static decimal modulus(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }
            return a % b;
        }
    }
}
