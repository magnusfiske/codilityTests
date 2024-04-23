using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class PrefixSums
    {
        //PassingCars
        //Not done!
        public int solution(int[] A)
        {
            int n = A.Length;
            int result = 0;
            int[] pref = new int[n];
            int zeroCount = A[0] == 0 ? 1 : 0;

            pref[0] = A[0];
            for (int i = 1; i < n; i++)
            {
                pref[i] = pref[i - 1] + A[i];
                if (pref[i] == 0)
                {
                    zeroCount++;
                }
            }

            return 5; 

        }

        static int CountTotal(int[] pref, int leftPos, int rightPos)
        {
            if (leftPos == 0)
                return pref[rightPos];
            return pref[rightPos] - pref[leftPos - 1];
        }

        static int[] CalcPrefixSums(int[] A)
        {
            int n = A.Length;
            int[] pref = new int[n];

            pref[0] = A[0];
            for (int i = 1; i < n; i++)
            {
                pref[i] = pref[i - 1] + A[i];
            }

            return pref;
        }

        static int Mushrooms(int[] A, int k, int m)
        {
            int n = A.Length;
            int result = 0;
            int[] pref = CalcPrefixSums(A);

            for (int p = 0; p <= Math.Min(m, k); p++)
            {
                int leftPos = k - p;
                int rightPos = Math.Min(n - 1, Math.Max(k, k + m - 2 * p));
                result = Math.Max(result, CountTotal(pref, leftPos, rightPos));
            }

            for (int p = 0; p < Math.Min(m + 1, n - k); p++)
            {
                int rightPos = k + p;
                int leftPos = Math.Max(0, Math.Min(k, k - (m - 2 * p)));
                result = Math.Max(result, CountTotal(pref, leftPos, rightPos));
            }

            return result;
        }
    }
}
