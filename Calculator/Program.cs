﻿using System;

namespace Calculator
{
    internal class Program
    {
        private static decimal firstNumber;
        private static int Operator;
        private static decimal secondNumber;
        private static decimal result;

        private static void Main(string[] args)
        {         
            Console.Write("Enter the first number: ");
            firstNumber = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the operator number (1 for +, 2 for -, 3 for ×, 4 for ÷ and 5 for %.): ");
            while (true)
            {
                Operator = Convert.ToInt32(Console.ReadLine());
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
            secondNumber = Convert.ToDecimal(Console.ReadLine());
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
