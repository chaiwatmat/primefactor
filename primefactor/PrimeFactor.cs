using System;
using System.Collections.Generic;

namespace Chaiwatmat.PrimeFactor
{
    public class PrimeFactor
    {
        public List<int> GetPrimeList(int number){
            var primes = new List<int>();

            // Take out the 2s.
            while (number % 2 == 0)
            {
                primes.Add(2);
                number = number / 2;
            }

            // Take out other primes.
            int factor = 3;
            while (factor * factor <= number)
            {
                if (number % factor == 0)
                {
                    primes.Add(factor);
                    number = number / factor;
                }
                else
                {
                    factor += 2;
                }
            }

            // If num is not 1, then whatever is left is prime.
            if (number > 1){
                primes.Add(number);
            }

            return primes;
        }

        public static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = Math.Floor(Math.Sqrt(number));
            for (int i = 2; i <= boundary; ++i){
                if (number % i == 0)  return false;
            }

            return true;
        }

    }
}
