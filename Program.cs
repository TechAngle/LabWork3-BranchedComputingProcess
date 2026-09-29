using System;
using System.Globalization;
using System.Text;

// =========================
// Lab Work 3
// =========================
namespace LabWork3
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.Write("Enter x:");
            string? xInput = Console.ReadLine();
            Console.Write("Enter y:");
            string? yInput = Console.ReadLine();

            if (xInput == null || yInput == null || string.IsNullOrWhiteSpace(xInput) || string.IsNullOrWhiteSpace(yInput))
            {
                Console.WriteLine("Error: invalid input.");
                
                return;
            }

            int x = int.Parse(xInput);
            int y = int.Parse(yInput);

            Console.WriteLine($"Result: {GetValue(x, y)}");
        }

        private static double GetValue(double x, double y)
        {
            return x switch
            {
                < -10 when y < -5 => (1 / x + 1 / y),
                >= -10 and < 0 when (y is >= -5 and < 0) => (x - y) / (x + y),
                >= 0 and < 2 * Math.PI when y is >= 0 and < 2 / Math.PI => Math.Sin(x) / Math.Cos((y)),
                _ => Math.Log10(Math.Pow(x, 2) + Math.Pow(y, 2))
            };
        }
    }
};

