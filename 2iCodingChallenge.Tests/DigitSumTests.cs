using Xunit;
using System.Collections.Generic;
using _2iCodingChallenge;

namespace _2iCodingChallenge.Tests
{
    public class DigitSumTests
    {
        [Fact]
        public void Test_MixedStrings()
        {
            var input = new List<string> { "abc123", "a1b2c3", "36z" };
            Assert.Equal(9, DigitSum.LargestDigitSum(input));
        }

        [Fact]
        public void Test_AllLetters()
        {
            var input = new List<string> { "abc", "xyz" };
            Assert.Equal(0, DigitSum.LargestDigitSum(input));
        }

        [Fact]
        public void Test_AllDigits()
        {
            var input = new List<string> { "123", "999" };
            Assert.Equal(27, DigitSum.LargestDigitSum(input));
        }

        [Fact]
        public void Test_TiedSums()
        {
            var input = new List<string> { "a1b2", "1d2", "3c0" };
            Assert.Equal(3, DigitSum.LargestDigitSum(input));
        }

        [Fact]
        public void Test_EmptyList()
        {
            var input = new List<string> { };
            Assert.Equal(0, DigitSum.LargestDigitSum(input));
        }
    }
}
