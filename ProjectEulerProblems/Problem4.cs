using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblems
{
    class Problem4
    {
        public static long LargestPalindromeFromProductionOfThreeDigitNumbers()
        {
            long palindrone = 0;
            for (long j = 100; j < 1000; j++)
            {
                for (long k = 100; k < 1000; k++)
                {
                    var product = j * k;
                    
                    var testPalindrone = new String( product.ToString().ToCharArray().Reverse().ToArray());
                    
                    if (product.ToString() ==  testPalindrone)
                    {
                        if (product > palindrone)
                            palindrone = product;
                        //else
                            //Console.WriteLine("here");
                    }

                }
            }
            return palindrone;
        }
    }
}
