using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class CountingElements
    {
        //FrogRiverOne
        public int Solution(int x, int[] A)
        {
            int[] count = new int[x + 1];
            int counter = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if(count[A[i]] == 0)
                {
                    counter++;
                    count[A[i]] = 1;
                    if(counter == x)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        //PermCheck
        public int Solution2(int[] A)
        {
            int N = A.Length;
            if (!A.OrderBy(x => x).SequenceEqual(Enumerable.Range(1, N)))
            {
                return 0;
            }
            if (A.Distinct().Count() != N)
            {
                return 0;
            }
            return 1;
        }      
    }
}
