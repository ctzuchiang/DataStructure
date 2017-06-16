using System.Collections;

namespace DataStructure
{
    public class Recursive
    {
        public int Bar(int n)
        {
            if (n == 1)
                return 1;

            return n * Bar(n - 1);
        }

        public string RecursiveReverse(string input)
        {
            if (input.Length == 1)
            {
                return input;
            }

            return input[input.Length - 1] + RecursiveReverse(input.Substring(0, input.Length - 1));
        }

        
    }
}
