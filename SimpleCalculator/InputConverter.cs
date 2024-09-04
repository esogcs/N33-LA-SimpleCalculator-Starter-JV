using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            double result = double.Parse(argTextInput);
            return result;
        }
    }
}
