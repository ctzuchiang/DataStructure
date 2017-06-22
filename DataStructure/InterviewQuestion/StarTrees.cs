using System;

namespace DataStructure.InterviewQuestion
{
    public class StarTrees
    {
        public void StarTree_1(int level)
        {
            for (int i = 1; i <= level; i++)
            {
                for (int j = 1; j <= level - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void StarTree_2(int level)
        {
            for (int i = 0; i < level; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j < (level-i)*2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
