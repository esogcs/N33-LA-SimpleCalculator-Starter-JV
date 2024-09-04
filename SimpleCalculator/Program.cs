using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 2.2m;
            var b = 5.5m;
            var c = CalculatorLibrary.CalcUtilities.add(a, b);

            try
            {
                // Class to convert user input
                InputConverter inputConverter = new InputConverter();

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Enter a number, a plus operator or write add and then another number (ex. 5 + 5)");
                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine("The result is: " + result);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
    }
}
