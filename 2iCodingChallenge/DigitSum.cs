using System;
using System.Collections.Generic;

namespace _2iCodingChallenge
{
    public static class DigitSum
    {
        public static int LargestDigitSum(List<string> strings)
        {
            int maxSum = 0;

            foreach (var str in strings)
            {
                int sum = 0;
                foreach (char c in str)
                {
                    if (char.IsDigit(c))
                        sum += c - '0';
                }

                if (sum > maxSum)
                    maxSum = sum;
            }

            return maxSum;
        }
    }
}
