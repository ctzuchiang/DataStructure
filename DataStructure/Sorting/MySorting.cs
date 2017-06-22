using System.Linq;

namespace DataStructure.Sorting
{
    public class MySorting
    {
        public int[] Sorting(int[] s)
        {
            var tmp = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[j] > s[j + 1])
                    {
                        tmp = s[j];
                        s[j] = s[j + 1];
                        s[j + 1] = tmp;
                    }
                }
            }

            return s;
        }

        public int[] BucketSorting(int[] s)
        {
            int[] buckets = new int[s.Max() + 1];

            foreach (int t1 in s)
            {
                buckets[t1]++;
            }

            int[] result = new int[s.Length];
            var t = 0;
            for (int i = 0; i < buckets.Length; i++)
            {
                while (buckets[i] != 0)
                {
                    result[t++] = i;
                    buckets[i]--;
                }
            }
            return result;
        }
    }
}
