using System;
using Xunit;
using Lab_4._3._0___Prime_Numbers;

namespace Lab_4._3._0___Prime_Numbers_Tests
{
    public class UnitTest1
    {
        /*
        * Three Tests
        *      Enter 3, expect 7
        *      Enter 1, expect 2   
        */
        [Theory]
        [InlineData(1, 2)]
        [InlineData(2, 3)]
        [InlineData(3, 5)]
        [InlineData(4, 7)]
        [InlineData(5, 11)]
        [InlineData(6, 13)]
        [InlineData(7, 17)]
        [InlineData(13, 41)]

        public void Test1(int entry, int expected)
        {
            PrimeNumber myPrime = new PrimeNumber();
            int result = myPrime.GetPrime(entry);
            Assert.Equal(expected, result);
        }
    }
}
