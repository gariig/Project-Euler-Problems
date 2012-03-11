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
            int sum = Problem1.SumMultipleOf3or5(999);
            Console.WriteLine("The sum is {0}", sum);
            Console.ReadKey();
        }
    }
}
