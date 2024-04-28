using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class Arrays
    {
        //CyclicRotation
        public int[] Solution(int[] A, int K)
        {
            int n = A.Length;

            if (n < 2) return A;

            int k = K % n;

            if (k > 0 && n > 0)
            {
                int[] tempArr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int newIndex = i + k;
                    if (i + k > n - 1)
                    {
                        newIndex = (i + k) - n;
                    }
                    tempArr[newIndex] = A[i];
                }
                return tempArr;
            }
            return A;
        }

        //OddOccurancesInArray
        public int Solution2(int[] A)
        {
            int n = A.Length;

            if(n == 0) return 0;

            Dictionary<int,int> dict = new Dictionary<int,int>();

            for(int i = 0; i < n; ++i)
            {
                if (dict.ContainsKey(A[i]))
                {
                    dict[A[i]] += 1;
                }
                else
                {
                    dict.Add(A[i], 1);
                }
            }

            foreach(KeyValuePair<int,int> pair in dict)
            {
                if (pair.Value % 2 != 0)
                {
                    return pair.Key;
                }
            }
            return 0;
        }
    }
}
