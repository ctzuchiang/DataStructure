using System.Collections.Generic;
using System.Linq;

namespace DataStructure.Math
{
    public class MyMath
    {
        public int GCD(int a, int b)
        {
            while ((a %= b) != 0 && (b %= a) != 0) ;

            return System.Math.Max(a, b);
        }

        public int GCD1(int a, int b)
        {
            var _a = System.Math.Max(a, b);
            var _b = System.Math.Min(a, b);
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

            return System.Math.Max(a, b);
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
            if (n < 2)
                return new int[] { };

            int[] isPrime = new int[n+1];
            for (var i = 2; i <= System.Math.Sqrt(n); i++)
            {
                if (isPrime[i] == 0)
                {
                    for (var j = i * 2; j <= n; j += i)
                    {
                        isPrime[j] = 1;
                    }
                }
            }
            var result = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i] == 0)
                    result.Add(i);
            }

            return result.ToArray();
        }

        public IEnumerable<int> PrimeList(int n)
        {
            int[] list = new int[n + 1];
            for (int i = 2; i <= n; i++)
            {
                list[i] = i;
            }
            for (int i=2;i<System.Math.Sqrt(n);i++)
            {
                if (list[i] != 0)
                {
                    for (int y=i*2;y<=n;y+=i)
                    {
                        list[y] = 0;
                    }
                }
            }
            return list.Where(t => t != 0).ToArray();

        }
    }
}