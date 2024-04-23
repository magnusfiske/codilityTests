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
        public int solution(int[] A)
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
    }
}
