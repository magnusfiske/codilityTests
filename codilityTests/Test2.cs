using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class Test2
    {
        public int Solution(int[] A)
        {
            int n = A.Length;
            int sumOfTwoDigitInts = 0;

            for(int i = 0; i < n; i++)
            {
                if ((A[i] < -9 && A[i] > -100) || (A[i] > 9 && A[i] < 100))
                {
                    sumOfTwoDigitInts += A[i];
                }
            }

            return sumOfTwoDigitInts;
        }

        public int Solution2(string S, string[] L)
        {
            Dictionary<char, int> letterMap = new Dictionary<char, int>();

            foreach (char c in S)
            {
                if (!letterMap.ContainsKey(c))
                {
                    letterMap[c] = 0;
                }
                letterMap[c]++;
            }

            int maxFrequency = 0;

            foreach (string word in L)
            {
                Dictionary<char, int> wordMap = new Dictionary<char, int>();

                foreach (char c in word)
                {
                    if (!wordMap.ContainsKey(c))
                    {
                        wordMap[c] = 0;
                    }
                    wordMap[c]++;
                }

                int wordMaxFrequency = int.MaxValue;
                foreach (var kvp in wordMap)
                {
                    char letter = kvp.Key;
                    int frequency = kvp.Value;

                    if (!letterMap.ContainsKey(letter))
                    {
                        wordMaxFrequency = 0;
                        break;
                    }

                    int maxWordFrequency = letterMap[letter] / frequency;
                    wordMaxFrequency = Math.Min(wordMaxFrequency, maxWordFrequency);
                }

                maxFrequency = Math.Max(maxFrequency, wordMaxFrequency);
            }

            return maxFrequency;
        }

        public string Solution3(string S)
        {
            string[] rows = S.Split('\n');
            StringBuilder stringBuilder = new StringBuilder();

            foreach(string row in rows)
            {
                int index = row.IndexOf("NULL", StringComparison.Ordinal);
                if (index < 0)
                {
                    stringBuilder.Append(row);
                    stringBuilder.Append("\n");
                }
            }

            return stringBuilder.ToString();
        }
    }
}
