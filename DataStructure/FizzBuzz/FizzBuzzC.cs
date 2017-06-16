using System.Collections.Generic;

namespace DataStructure.FizzBuzz
{
    public class FizzBuzzC
    {
        public string FizzBuzz_3(int numberRange)
        {
            List<string> result = new List<string>();

            for (int i = 1; i <= numberRange; i++)
            {
                result.Add(GetModString(i));
            }
            return result.ToString();
        }

        public string GetModString(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            return number.ToString();
        }
    }
}
