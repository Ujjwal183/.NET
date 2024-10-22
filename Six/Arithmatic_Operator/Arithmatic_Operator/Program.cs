using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input: Two numbers
            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());
            // Perform arithmetic operations
            double sum = num1 + num2;
            double difference = num1 - num2;
            double product = num1 * num2;
            double quotient = num1 / num2;
            double remainder = num1 % num2;
            // Output: Display the results
            Console.WriteLine("\nArithmetic Operations:");
            Console.WriteLine($"Sum: {num1} + {num2} = {sum}");
            Console.WriteLine($"Difference: {num1} - {num2} = {difference}");
            Console.WriteLine($"Product: {num1} * {num2} = {product}");
            Console.WriteLine($"Quotient: {num1} / {num2} = {quotient}");
            Console.WriteLine($"Remainder: {num1} % {num2} = {remainder}");
        }
    }
}
