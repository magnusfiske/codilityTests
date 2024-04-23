using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class Test
    {
        public int solution(int[] A)
        {
            int n = A.Length;
            Array.Sort(A);
            if(A.Sum() == 0)
            {
                return 0;
            }

            int index = Array.IndexOf(A, 1);

            int ones = n - index;

            int zeros = n - ones;

            if(ones < zeros)
            {
                return ones;
            }
            return zeros;
        }

        public int solution2(string G)
        {
            int n = G.Length;

            var gestureChars = G.ToCharArray();

            int[] points = new int[3];
            char[] chosenGestures = ['R','P','S'];

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (gestureChars[j].Equals(chosenGestures[i]))
                    {
                        points[i]++;
                    }
                    else if (i == 0 && gestureChars[j] == 'S')
                    {
                        points[i] += 2;
                    }
                    else if (i == 1 && gestureChars[j] == 'R')
                    {
                        points[i] += 2;
                    }
                    else if (i == 2 && gestureChars[j] == 'P')
                    {
                        points[i] += 2;
                    }
                }
            }

            Array.Sort(points);

            return points[2];
        }

        public string solution3(int T) 
        {
            int minutesAndSeconds = T % 3600;
            int hours = (T - minutesAndSeconds) / 3600;
            int seconds = minutesAndSeconds % 60;
            int minutes = (minutesAndSeconds - seconds) / 60;


            return $"{hours}h{minutes}m{seconds}s";
        }
    }
}
