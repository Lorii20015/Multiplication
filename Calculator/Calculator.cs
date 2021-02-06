using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            string x = Console.ReadLine();
            Console.WriteLine("Enter second number:");
            string y = Console.ReadLine();
            int a = Int32.Parse(x);
            int b = Int32.Parse(y);
            int z = a * b;
            Console.WriteLine(z);
        }
    }
}
