using System.Collections.Generic;
using System.Text;

namespace DataStructure.InterviewQuestion.FizzBuzz
{
    public class FizzBuzzService
    {
        public IEnumerable<object> FizzBuzz_string(int loopRange, int[] nArray)
        {
            string result;
            var resultArray = new object[loopRange];

            for (int i = 1; i <= loopRange; i++)
            {
                result = "";

                foreach (var n in nArray)
                {
                    if (i % n == 0)
                        result += n;
                }

                if (result.Length == 0)
                    resultArray[i - 1] = i;
                else
                {
                    resultArray[i - 1] = "\"" + result + "\"";
                }
            }
            return resultArray;
        }

        public IEnumerable<object> FizzBuzz_stringBuilder(int loopRange, int[] nArray)
        {
            StringBuilder result = new StringBuilder();
            var resultArray = new object[loopRange];

            for (int i = 1; i <= loopRange; i++)
            {
                result.Clear();

                foreach (var n in nArray)
                {
                    if (i % n == 0)
                        result.Append(n);
                }

                if (result.Length == 0)
                    resultArray[i - 1] = i;
                else
                {
                    resultArray[i - 1] = "\"" + result + "\"";
                }
            }
            return resultArray;
        }

    }
}
