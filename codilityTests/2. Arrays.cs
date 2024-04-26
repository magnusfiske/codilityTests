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
            if(A.Length > 0)
            {
                for (int i = 0; i < K; i++)
                {
                    A = rotateArray(A);
                }
            }

            return A;
        }

        public int[] rotateArray(int[] A)
        {
            int[] tempArr = new int[A.Length];

            for (int i = 0; i < A.Length - 1; i++)
            {
                tempArr[i + 1] = A[i];
            }
            tempArr[0] = A[A.Length - 1];

            return tempArr;
        }
    }
}
