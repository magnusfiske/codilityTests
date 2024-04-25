using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class Sorting
    {
        //Distinct
        public int Solution(int[] A)
        {
            int n = A.Length;
            int result = 0;

            if(n < 1) return result;

            Array.Sort(A);

            result++;
            if (n == 1) return result;

            for(int i = 1; i < n; i++)
            {
                if (A[i] != A[i -1])
                {
                    result++;
                }
            }
            return result;
        }

        //MaxProductOfThree
        public int Solution2(int[] A)
        {
            Array.Sort(A);
        
            var topMax = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            var bottomMax = A[0] * A[1] * A[A.Length - 1];
        
            return Math.Max(topMax, bottomMax);
        }
    }
}
