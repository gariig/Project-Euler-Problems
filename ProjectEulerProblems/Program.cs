using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Problem3.FindPrimeFactors(600851475143).Max());
            Console.ReadKey();

        }
    }
}
