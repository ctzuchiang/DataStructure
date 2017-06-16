using System;
using System.Collections.Generic;

namespace DataStructure.MyMath
{
    public class MyMath
    {
        public int GCD(int a, int b)
        {
            while ((a %= b) != 0 && (b %= a) != 0) ;

            return Math.Max(a, b);
        }

        public int GCD1(int a, int b)
        {
            var _a = Math.Max(a, b);
            var _b = Math.Min(a, b);
            while (_b != 0)
            {
                var tmp = _b;
                _b = _a % _b;
                _a = tmp;
            }

            return _a;
        }

        public int GCD_Recursive(int a, int b)
        {
            if ((a %= b) != 0 && (b %= a) != 0)
                return GCD_Recursive(a, b);

            return Math.Max(a, b);
        }

        public int GCD1_Recursive(int a, int b)
        {
            if (b > a)
                return GCD1_Recursive(b, a);

            var r = a % b;
            if (r != 0)
                return GCD1_Recursive(b, r);

            return b;
        }

        public int[] Prime(int n)
        {
            if (n < 3)
                return new int[] { };

            int[] isPrime = new int[n];

            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (isPrime[i] == 0)
                {
                    for (int j = i * 2; j < n; j += i)
                    {
                        isPrime[j] = 1;
                    }
                }
            }

            var result = new List<int>();

            for (int i = 2; i < n; i++)
            {
                if (isPrime[i] == 0)
                    result.Add(i);
            }

            return result.ToArray();
        }

    }
}