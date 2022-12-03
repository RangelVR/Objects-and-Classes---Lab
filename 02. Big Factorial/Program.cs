using System;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());
            BigInteger result = 1;

            for (int i = 2; i <= factorial; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
