using System;

namespace Calculator
{
    class Program
    {
        static int firstNumber;
        static int Operator;
        static int secondNumber;
        static int result;
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the operator number (1 for +, 2 for -, 3 for ×, 4 for ÷): ");
            while (true)
            {
                Operator = Convert.ToInt32(Console.ReadLine());
                if (!(Operator > 4 || Operator < 1))
                {
                    break;
                }
                else
                {
                    Console.Write("Invalid number. Enter a valid operator number: ");
                }
            }
            Console.Write("Enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Calculating...");
            switch (Operator)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    break;
                case 4:
                    result = firstNumber / secondNumber;
                    break;
                default:
                    result = 0;
                    break;
            }
            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
    }
}
