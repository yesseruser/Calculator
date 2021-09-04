using System;

namespace Calculator
{
    internal static class Program
    {
        private static decimal firstNumber;
        private static int Operator;
        private static decimal secondNumber;
        private static decimal result;

        private static void Main(string[] args)
        {
            Console.WriteLine("Calculator. Use , for decimal numbers.");
            Console.Write("Enter the first number: ");
            while (true)
            {
                try
                {
                    firstNumber = Convert.ToDecimal(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Something went wrong.(probably you entered an invalid number) Please try again.");
                    continue;
                }
                break;
            }
            Console.Write("Enter the operator number (1 for +, 2 for -, 3 for ×, 4 for ÷ and 5 for %(divide remainder).): ");
            while (true)
            {
                while (true)
                {
                    try
                    {
                        Operator = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Something went wrong.(probably you entered an invalid number) Please try again.");
                        continue;
                    }
                    break;
                }
                if (!(Operator > 5 || Operator < 1))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid number. Enter a valid operator number: ");
                }
            }
            Console.Write("Enter the second number: ");
            while (true)
            {
                try
                {
                    secondNumber = Convert.ToDecimal(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Something went wrong.(probably you entered an invalid number) Please try again.");
                    continue;
                }
                break;
            }
            Console.WriteLine("Calculating...");
            result = Operator switch
            {
                1 => firstNumber + secondNumber,
                2 => firstNumber - secondNumber,
                3 => firstNumber * secondNumber,
                4 => firstNumber / secondNumber,
                5 => firstNumber % secondNumber,
                _ => 0,
            };
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
