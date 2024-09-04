using System;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public static double ConvertInputToNumeric(string argTextInput)
        {
            int result = Int32.Parse(argTextInput);
            return result;
        }
    }
}
