using System.Linq;

namespace DataStructure.InterviewQuestion
{
    public class Palindrom
    {
        public bool IsPalindrom(string input)
        {
            for (var i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i])
                    return false;
            }
            return true;
        }

        public bool IsPalindrom2(string input)
        {
            var recursive = new Recursive();
            return input == recursive.RecursiveReverse(input);
        }

        public bool IsPalindrom3(string input)
        {
            return input == new string(Enumerable.Range(1, input.Length).Select(i => input[input.Length - i]).ToArray());
        }

        public bool IsPalindrom4(string input)
        {
            if (input.Length <= 1)
                return true;

            var b = input[0] == input[input.Length - 1];
            return b && IsPalindrom4(input.Substring(1, input.Length - 2));
        }
    }
}