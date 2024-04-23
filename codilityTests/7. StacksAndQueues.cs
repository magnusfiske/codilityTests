using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codilityTests
{
    public class StacksAndQueues
    {
        public int solution(string S)
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
    }
}
