using System.Collections;

namespace DataStructure.InterviewQuestion
{
    public class BlockPair
    {
        public bool IsPair(string input)
        {
            var stack = new Stack();

            foreach (var c in input.ToCharArray())
            {
                if (stack.Count > 0 && (char)stack.Peek() == c)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }
        
    }
}
