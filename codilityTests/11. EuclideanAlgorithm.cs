using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class EuclideanAlgorithm
    {
        //ChocolatesByNumbers
        public int Solution(int N, int M)
        {
            if (M == 1) return N;
            if (M == N) return 1;
            
            int a = N, b = M;

            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }

            return N / a;
        }
    }
}
