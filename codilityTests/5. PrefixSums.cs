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
        public int solution(int[] A)
        {
            int n = A.Length;
            int passingCarsCount = 0;
            
            int[] prefixSum = new int[n];
            prefixSum[0] = A[0];
            
            for (int i = 1; i < n; i++)
            {
                prefixSum[i] = A[i] + prefixSum[i - 1];
            }
            
            int sum = prefixSum[n - 1];
            
            //If all 1:s - no passing cars
            if (sum == n)
            {
                return 0;
            }
            
            for (int i = 0;i < n; i++)
            {
                if (A[i] == 0)
                {
                    int numberOfOnesAfter = sum - prefixSum[i];
                    passingCarsCount += numberOfOnesAfter;
                    if(passingCarsCount > 1000000000)
                    {
                        return -1;
                    }
                }
            }
            
            return passingCarsCount;
        }

        //CountingDiv
        public int Solution2(int A, int B, int K)
        {
            return B / K - A / K + (A % K == 0 ? 1 : 0);
        }
    }
}
