// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace _2iCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string> { "abc123", "a1b2c3ad11", "329z" };
            int result = DigitSum.LargestDigitSum(input);
            Console.WriteLine($"Largest digit sum: {result}");
        }
    }
}

