using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerProblems
{
    class Problem1
    {
        public static int SumMultipleOf3or5(int end)
        {
            var range = Enumerable.Range(1, end);
            return range.Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }
    }
}
