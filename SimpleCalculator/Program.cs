using System;
using System.Text;

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
                    Console.WriteLine("Invalid number. Enter a number: ");
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
                Console.WriteLine("Enter an operator: (+, -, *, /, % || add, minus, multiply, divide, modulus)");
                string operation = Console.ReadLine();

                // Loop until the user inputs a valid operator
                while (true)
                {

                    // Check for valid operators using if-else
                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "%" 
                        || operation == "add" || operation == "minus" || operation == "multiply" || operation == "divide" || operation == "modulus")
                    {
                        // Valid operator entered, exit loop
                        break;
                    }
                    else
                    {
                        // Invalid operator entered
                        Console.WriteLine("Invalid operator. Please enter a valid operator.");
                        break;
                    }
                   
                }

                // Display result with StringBuilder.
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                StringBuilder resultBuilder = new StringBuilder();
                resultBuilder.AppendLine($"The result of {firstNumber} {operation} {secondNumber} is: {result}");
                Console.WriteLine(resultBuilder);

            } catch (Exception ex)
            {
                // Normally, we'd log this error to a file.

                Console.WriteLine(ex.Message);
            }

        }
    }
}
