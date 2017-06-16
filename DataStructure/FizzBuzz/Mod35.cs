using System.Collections.Generic;
using System.Text;

namespace DataStructure.FizzBuzz
{
    public class Mod35
    {
        public string FizzBuzz_1(int range)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= range; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result.Add("FizzBuzz");
                else if (i % 3 == 0)
                    result.Add("Fizz");
                else if (i % 5 == 0)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }
            return result.ToString();
        }

        public string FizzBuzz_2(int range)
        {
            List<string> result = new List<string>();
            StringBuilder str = new StringBuilder();

            for (int i = 1; i <= range; i++)
            {
                str.Clear();
                if (i % 3 == 0)
                    str.Append("Fizz");
                if (i % 5 == 0)
                    str.Append("Buzz");
                if (string.IsNullOrEmpty(str.ToString()))
                    str.Append(i);

                result.Add(str.ToString());
            }
            return result.ToString();
        }
    }
}
