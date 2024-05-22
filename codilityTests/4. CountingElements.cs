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
        
        //MaxCounters - 77% total, 100% Correctness, 60% Performance
        public int[] Solution3(int N, int[] A)
        {
            int[] counters = new int[N];
            int highestValue = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == N+1)
                {
                    counters = new int[N];
                    Array.Fill(counters, highestValue);
                    //for(int j = 0; j < N; j++)
                    //{
                    //    counters[j] = highestValue; 
                    //}
                }
                else
                {
                    counters[A[i]-1]++;
                    if (counters[A[i]-1] > highestValue)
                    {
                        highestValue = counters[A[i]-1];
                    }
                }
            }
            return counters;
        }

        //MissingInteger
        public int Solution4(int[] A)
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

            for (int i = indexOfOne + 1; i < A.Length; i++)
            {
                if (A[i] != A[i - 1])
                {
                    tempArr[distinctCounter] = A[i];
                    distinctCounter++;
                }
            }

            //Check which is missing
            for (int i = 0; i < tempArr.Length; i++)
            {
                if (tempArr[i] != i + 1)
                {
                    return i + 1;
                }
            }
            //If no number is missing, return next number outside array
            return A[A.Length - 1] + 1;
        }
    }
}
