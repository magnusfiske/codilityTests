using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class Demo
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int indexOfOne = Array.IndexOf(A, 1);

            if (indexOfOne == -1)
            {
                return 1;
            }

            int[] tempArr = new int[A.Length - indexOfOne];
            
            //Get distinct positive values
            tempArr[0] = A[indexOfOne];
            int distinctCounter = 1;

            for(int i = indexOfOne +1; i < A.Length; i++)
            {
                if (A[i] != A[i - 1])
                {
                    tempArr[distinctCounter] = A[i];
                    distinctCounter++;
                }
            }

            //Check which is missing
            for(int i = 0; i < tempArr.Length; i++)
            {
                if (tempArr[i] != i+1)
                {
                    return i + 1;
                }
            }
            //If no number is missing, return next number outside array
            return A[A.Length -1] + 1;
        }
    }
}
