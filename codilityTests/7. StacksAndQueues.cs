using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class StacksAndQueues
    {
        //Brackets
        public int Solution(string S)
        {
            if(string.IsNullOrEmpty(S)) return 1;

            char[] chars = S.ToCharArray();
            if(chars.Length % 2 != 0 )
            {  
                return 0; 
            }

            Stack<char> stack = new Stack<char>();

            foreach (char c in chars)
            {

                if(c.Equals('{') || c.Equals('[') || c.Equals('('))
                {
                    stack.Push(c);
                }

                if (stack.Count == 0) return 0;

                else
                {
                    if(c.Equals('}'))
                    {
                        if (!stack.Peek().Equals('{')) return 0;
                        stack.Pop();
                    }
                    if(c.Equals(']'))
                    {
                        if (!stack.Peek().Equals('[')) return 0;
                        stack.Pop();
                    }
                    if (c.Equals(')'))
                    {
                        if (!stack.Peek().Equals('(')) return 0;
                        stack.Pop();
                    }
                }
            }
            if(stack.Count != 0)
            { 
                return 0; 
            }

            return 1;
        }

        //Fish
        public int Solution2(int[] A, int[] B)
        {
            int n = A.Length;
            if (n < 2) return 1;

            Stack<int> downstreamStack = new Stack<int>();
            Stack<int> upstreamStack = new Stack<int>();

            int upstreamStarters = Array.IndexOf(B, 1);
            int downstreamEnders = (n - 1) - Array.LastIndexOf(B, 0);

            //either no 1:s or no 0:s -> All fish live
            if (upstreamStarters < 0 || downstreamEnders < 0) return n;

            int remainingFish = n - (upstreamStarters + downstreamEnders);

            if(remainingFish < 2)
            {
                return remainingFish + upstreamStarters + downstreamEnders;
            }

            for (int i = upstreamStarters; i < n - downstreamEnders; i++)
            {
                if (B[i] == 1)
                {
                    downstreamStack.Push(A[i]);
                }
                else
                {
                    while(downstreamStack.Count > 0 && downstreamStack.Peek() < A[i])
                    {
                        downstreamStack.Pop();
                    }
                    if(downstreamStack.Count < 1)
                    {
                        upstreamStack.Push(A[i]);
                    }
                }
            }

            return downstreamStack.Count + upstreamStack.Count + upstreamStarters + downstreamEnders;
        }

        //Nesting
        public int Solution3(string s)
        {
            if(string.IsNullOrEmpty(s)) return 1;

            char[] chars = s.ToCharArray();
            int n = chars.Length;
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < n; i++)
            {
                if (chars[i] == '(') stack.Push(chars[i]);
                if (chars[i] == ')')
                {
                    if(stack.Count != 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                    }
                    else
                    {
                      return 0;
                    }
                }
            }
            return stack.Count == 0 ? 1 : 0;
        }

        //StoneWall
        public int Solution4(int[] H)
        {
            int n = H.Length;

            if (n < 2) return 1;

            Stack<int> stack = new Stack<int>();

            stack.Push(H[0]);
            int usedAndRemovedBlocks = 0;

            for(int i = 1; i < n; i++)
            {
                if(stack.Count != 0)
                {
                    if (H[i] > stack.Peek())
                    { 
                        stack.Push(H[i]); 
                    }
                    else if (H[i] < stack.Peek())
                    {
                        while(stack.Count != 0 && stack.Peek() > H[i])
                        {
                            usedAndRemovedBlocks++;
                            stack.Pop();
                        }
                        if(stack.Count != 0 && !stack.Peek().Equals(H[i]))
                        { 
                            stack.Push(H[i]);
                        }
                        else if(stack.Count == 0)
                        {
                            stack.Push(H[i]);
                        }
                    }
                }
                else
                {
                    stack.Push(H[i]);
                }
            }
            return stack.Count + usedAndRemovedBlocks;
        }
    }
}
