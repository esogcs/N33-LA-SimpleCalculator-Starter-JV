using System;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate (string argOperation, double argFirstNumber, double argSecondNumber)
        {
            double result = 0;

            if (argOperation == "+" || argOperation.ToLower() == "add") {
                result = argFirstNumber + argSecondNumber;
            }

            if (argOperation == "-" || argOperation.ToLower() == "minus")
            {
                result = argFirstNumber - argSecondNumber;
            }

            if (argOperation == "/" || argOperation.ToLower() == "divide")
            {
                switch (argSecondNumber)
                {
                    case 0: // If user enters a number as 0, the calc gives it a non number result (0)
                        Console.WriteLine("Cannot divide by 0");
                        result = double.NaN;
                        break;

                    default: // User enters >0 number
                        Console.WriteLine("The result is " + result); 
                        break;
                }
               }

            if (argOperation == "*" || argOperation.ToLower() == "multiply")
            {
                result = argFirstNumber * argSecondNumber;
            }

            if (argOperation == "%" || argOperation.ToLower() == "modulus")
            {
                switch (argSecondNumber)
                {
                    case 0:
                        Console.WriteLine("Cannot do modulus with 0");
                        result = double.NaN;
                        break;

                    default:
                        Console.WriteLine("The resut is" + result);
                        break;
                }
            }
            return result;
        }
    }
}
