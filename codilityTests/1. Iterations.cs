using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class Iterations
    {
        //BinaryGap
        public int solution(int N)
        {
            var binaryRepresentation = Convert.ToString(N, 2);
            binaryRepresentation = binaryRepresentation.TrimStart('0').TrimEnd('0');
            var binarychars = binaryRepresentation.ToCharArray();

            //If theres only one or fewer 1 there can be no gap
            if (binarychars.Length <= 1)
            {
                return 0;
            }

            var longestGap = 0;
            var currentGap = 0;
            foreach (var item in binarychars)
            {
                if (item == '0')
                {
                    currentGap++;
                }
                if (item == '1')
                {
                    if (currentGap > longestGap)
                    {
                        longestGap = currentGap;
                    }
                    currentGap = 0;

                    //If the gap is longer than half the max bits there cannot be a longer one in there. Return the longest gap
                    if (longestGap > 16)
                    {
                        return longestGap;
                    }
                }
            }
            return longestGap;
        }
    }
}
