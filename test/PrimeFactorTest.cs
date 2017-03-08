using System;
using System.Collections.Generic;
using NUnit.Framework;
using Chaiwatmat.PrimeFactor;

namespace Chaiwatmat.PrimeFactor.Test
{
    [TestFixture]
    public class PrimeFactorTest
    {
        private PrimeFactor _primeFactor;

        public PrimeFactorTest(){
            _primeFactor = new PrimeFactor();
        }

        [TestCase(1)]
        public void GetPrimeFactorForNumber1_ShouldReturnEmpty(int number){
            var expected = new List<int>();
            var result = _primeFactor.GetPrimeList(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(2)]
        [TestCase(3)]
        [TestCase(5)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(13)]
        public void GetPrimeFactor_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{number};
            var result = _primeFactor.GetPrimeList(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(4)]
        public void GetPrimeFactorForNumber4_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{2, 2};
            var result = _primeFactor.GetPrimeList(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(6)]
        public void GetPrimeFactorForNumber6_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{2, 3};
            var result = _primeFactor.GetPrimeList(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(10)]
        public void GetPrimeFactorForNumber10_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{2, 5};
            var result = _primeFactor.GetPrimeList(number);

            Assert.AreEqual(expected, result);
        }

        [TestCase(50)]
        public void GetPrimeFactorForNumber50_ShouldReturnValidPrimeList(int number){
            var expected = new List<int>{2, 5, 5};
            var result = _primeFactor.GetPrimeList(number);

            Assert.AreEqual(expected, result);
        }

    }
}
