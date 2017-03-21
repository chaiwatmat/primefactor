using System;
using System.Collections.Generic;
using Xunit;
using Chaiwatmat.PrimeFactor;

namespace Chaiwatmat.PrimeFactor.Test
{
    public class PrimeFactorTest
    {
        private PrimeFactor _primeFactor;

        public PrimeFactorTest(){
            _primeFactor = new PrimeFactor();
        }

        [Theory]
        [InlineData(1)]
        public void GetPrimeFactorForNumber1_ShouldReturnEmpty(int number){
            var expected = new List<int>();
            var result = _primeFactor.GetPrimeList(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(11)]
        [InlineData(13)]
        public void GetPrimeFactor_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{number};
            var result = _primeFactor.GetPrimeList(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(4)]
        public void GetPrimeFactorForNumber4_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{2, 2};
            var result = _primeFactor.GetPrimeList(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(6)]
        public void GetPrimeFactorForNumber6_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{2, 3};
            var result = _primeFactor.GetPrimeList(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10)]
        public void GetPrimeFactorForNumber10_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{2, 5};
            var result = _primeFactor.GetPrimeList(number);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(50)]
        public void GetPrimeFactorForNumber50_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{2, 5, 5};
            var result = _primeFactor.GetPrimeList(number);

            Assert.Equal(expected, result);
        }
    }
}
