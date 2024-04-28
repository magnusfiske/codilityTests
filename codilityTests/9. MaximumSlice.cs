using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class MaximumSlice
    {
        //MaxProfit
        public int Solution(int[] A)
        {
            if(A.Length < 2) return 0;

            int minBuyPrice = int.MaxValue;
            int maxSellPrice = 0;
            int maxProfit = 0;

            foreach(int a in A)
            {
                if(a < minBuyPrice)
                {
                    minBuyPrice = a;
                    maxSellPrice = 0;
                }
                if(a > minBuyPrice)
                {
                    maxSellPrice = Math.Max(maxSellPrice, a);
                    maxProfit = Math.Max(maxProfit, maxSellPrice - minBuyPrice);
                }
            }

            return maxProfit;
        }

        //MaxSliceSum
        public int Solution2(int[] A)
        {
            int maxEnding = 0;
            int maxSlice = int.MinValue;

            foreach (int a in A)
            {
                maxEnding = Math.Max(a, maxEnding + a);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }

        public int GetSumOfGoldenSlice(int[] A)
        {
            int maxEnding = 0;
            int maxSlice = 0;

            foreach (int a in A)
            {
                maxEnding = Math.Max(0, maxEnding + a);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }
    }
}
