using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class Leader
    {
        //Dominator
        public int Solution(int[] A)
        {
            int n = A.Length;
            int size = 0;
            int value = 0;
            for (int k = 0; k < n; k++)
            {
                if (size == 0)
                {
                    size += 1;
                    value = A[k];
                }
                else
                {
                    if (value != A[k])
                        size -= 1;
                    else
                        size += 1;
                }
            }

            int candidate = -1;
            if (size > 0)
                candidate = value;

            int leader = -1;
            bool trueLeader = false;
            int count = A.Count(num => num == candidate);
            if (count > n / 2)
            {
                leader = candidate;
                trueLeader = true;
            }
               
            return leader == -1 && !trueLeader ? -1 : Array.IndexOf(A, leader);
        }

        //EquiLeader
        public int Solution2(int[] A)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int N = A.Length;
            for (int i = 0; i < N; i++)
            {
                if (map.ContainsKey(A[i]))
                {
                    map[A[i]] = map[A[i]] + 1;
                }
                else
                {
                    map[A[i]] = 1;
                }
            }
            int max = 0;
            int maxCount = 0;
            foreach (KeyValuePair<int, int> entry in map)
            {
                if (maxCount < entry.Value)
                {
                    maxCount = entry.Value;
                    max = entry.Key;
                }
            }

            if (maxCount <= N / 2)
            {
                return 0;
            }

            int leaderCount = 0;
            int equiCounter = 0;
            for (int S = 0; S < N - 1; S++)
            {
                if (A[S] == max)
                {
                    leaderCount++;
                }
                if ((leaderCount > ((S + 1) / 2)) && ((maxCount - leaderCount) > (N - (S + 1)) / 2))
                {
                    equiCounter++;
                }
            }

            return equiCounter;
        }
    }
}
