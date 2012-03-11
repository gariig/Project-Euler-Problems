using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblems
{
    class Problem2
    {
        public static long SumEvenFibonacciNumbers(long ceiling)
        {
            return FibonacciGenerator(ceiling).Where(f => f % 2 == 0).Sum();
        }

        public static IEnumerable<long> FibonacciGenerator(long ceiling = -1)
        {
            long firstNumber = 0;
            long secondNumber = 0;
            long currentNumber = 1;
            while (ceiling == -1 || currentNumber <= ceiling)
            {
                if (currentNumber == 1)
                {
                    yield return 1;
                    currentNumber = 2;
                }
                else if (currentNumber == 2)
                {
                    yield return 2;
                    firstNumber = 1;
                    secondNumber = 2;
                    currentNumber = 3;
                }
                else
                {
                    yield return currentNumber;
                    firstNumber = secondNumber;
                    secondNumber = currentNumber;
                    currentNumber = firstNumber + secondNumber;
                }
            }
        }
    }
}
