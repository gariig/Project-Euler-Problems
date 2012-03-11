using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblems
{
    class Problem3
    {
        public static IEnumerable<long> FindPrimeFactors(long input)
        {
            var primeFactors = new List<long>();
            long newnum = input;
            long factor = 2;

            while (factor * factor <= newnum)
            {
                if (newnum % factor == 0)
                {
                    primeFactors.Add(factor);
                    newnum = newnum / factor;
                }
                else
                {
                    factor++;
                }
            }

            if (newnum != 1)//Remainder is a prime factor
            {
                primeFactors.Add(newnum);
            }

            return primeFactors.Distinct();
        }
    }
}
