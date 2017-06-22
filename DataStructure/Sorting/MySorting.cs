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
    }
}
