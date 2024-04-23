using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class TimeComplexity
    {
        //FrogJmp
        public int solution(int X, int Y, int D)
        {
            if (X == Y) return 0;
            int dist = Y - X;
            return dist % D == 0 ? dist / D : dist / D + 1;
        }
        //PermMissingElem
        public int solution2(int[] A)
        {
            if(A.Length == 0) return 1;

            Array.Sort(A);

            for(int i = 0; i < A.Length; i++)
            {
                if (A[i] != i + 1)
                {
                    return i + 1;
                }
            }

            return A.Length + 1;
        }
        //TapeEquilibrium
        public int solution3(int[] A)
        {
            int N = A.Length;

            int sum1 = A[0];
            int sum2 = 0;
            int P = 1;
            for (int i = P; i < N; i++)
            {
                sum2 += A[i];
            }
            int diff = Math.Abs(sum1 - sum2);

            for (; P < N - 1; P++)
            {
                sum1 += A[P];
                sum2 -= A[P];

                int newDiff = Math.Abs(sum1 - sum2);
                if (newDiff < diff)
                {
                    diff = newDiff;
                }
            }
            return diff;
        }

    }
}
