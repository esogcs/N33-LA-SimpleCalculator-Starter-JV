using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                
                // User enters 1st number
                Console.WriteLine("Enter the first number: ");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                while (firstNumber is String) 
                {
                    Console.WriteLine("Invalid text. Enter a number: ");
                    firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                }

                // User enters 2nd number
                Console.WriteLine("Enter the second number: ");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                while (secondNumber is String)
                {
                    Console.WriteLine("Invalid number. Enter a number: ");
                    secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                }
            
                // User enters operator
                Console.WriteLine("Enter an operator: (+, -, *, /, %)" );
                string operation = Console.ReadLine();

                // +, -, %, *, / || add, divide, multiply, modulus, minus

                // Display result (add string builder)
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                Console.WriteLine($"The result is: " + result);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.

                Console.WriteLine(ex.Message);
            }

        }
    }
}
