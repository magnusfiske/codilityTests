using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class PrimeNumbers
    {
        //CountFactors -> 92%, TimeComplexity: O(sqrt(N))
        public int Solution(int N)
        {
            return CaluculateNumberOfDivisors(N);
        }

        public int CaluculateNumberOfDivisors(int N)
        {
            int i = 1;
            int result = 0;

            while (i * i < N)
            {
                if (N % i == 0)
                {
                    result += 2;
                }
                i++;
            }
            if (i * i == N)
            {
                result++;
            }
            return result;
        }

        //MinPerimeterRectangle
        public int Solution2(int N)
        {
            Dictionary<int,int> measurements = new Dictionary<int,int>();

            //find divisors of N
            int i = 1;

            while(i * i <= N)
            {
                if (N % i == 0)
                {
                    measurements[i] = N / i;
                }
                i++;
            }

            //calculate perimeter for each divisor couple and save smallest.
            int minPerimeter = int.MaxValue;
            if(measurements.Count >= 1)
            {
                foreach(KeyValuePair<int,int> pair in measurements)
                {
                    minPerimeter = Math.Min(minPerimeter, 2 * (pair.Key + pair.Value));
                }
            }
            else
            {
                minPerimeter = 2 * (N + 1);
            }

            return minPerimeter;
        }

        public bool TestForPrimality(int N)
        {
            int i = 2;
            while (i * i <= N)
            {
                if (N % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}
