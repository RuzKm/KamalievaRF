﻿namespace KamalievaRF
{
    internal class Program
    {
        public static class MathUtils
        {
            public static double Sqr(double x)
            {
                return x * x;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TestSqr(2, 4));
            Console.WriteLine(TestSqr(-3, 9));
            Console.WriteLine(TestSqr(1.5, 2.25));
        }

        static string TestSqr(double input, double expected)
        {
            double result = MathUtils.Sqr(input);
            return Math.Abs(result - expected) < 0.0001 ? "PASS" : $"FAIL: {input}² != {result}";
        }
    }
}
//KamalievaRF Am-1-24

//solve task2
//solve task1