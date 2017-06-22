using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DataStructure.MazingProblem;
using DataStructure.StakeAndQueue;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureTest.StakeAndQueue.MazeingProblemTest
{
    [TestClass]
    public class MazingProblemTest
    {
        private string ForamtPath(List<string> path)
        {
            return string.Join("-", path);
        }

        [TestMethod]
        public void FormatPathTest()
        {
            var ExpectedPath = new List<string>()
                {
                    "(1,1)",
                    "(2,2)"
                };
            var solution = new MazingProblem();

            MyStack path = new MyStack(ExpectedPath.Count);
            path.Push("(1,1)");
            path.Push("(2,2)");

            Assert.AreEqual(ForamtPath(ExpectedPath), solution.FormatPath(path));
        }

        [TestMethod]
        public void Mazing3x3()
        {
            int[][] mazing =
            {
                new int[] {1,1,1},
                new int[] {1,0,1},
                new int[] {1,1,0}
            };

            var ExpectedPath = new List<string>()
            {
                "(1,1)",
                "(2,2)"
            };

            var solution = new MazingProblem();
            MyStack path = solution.FindPath(mazing, 3, 3);

            Assert.AreEqual(ForamtPath(ExpectedPath), solution.FormatPath(path));
        }

        [TestMethod]
        public void Mazing5x5()
        {
            int[][] mazing =
            {
                new int[] {1,1,1,1,1},
                new int[] {1,0,1,1,1},
                new int[] {1,1,0,1,1},
                new int[] {1,1,1,0,1},
                new int[] {1,1,1,1,0}
            };

            var ExpectedPath = new List<string>()
            {
                "(1,1)",
                "(2,2)",
                "(3,3)",
                "(4,4)"
            };

            var solution = new MazingProblem();
            MyStack path = solution.FindPath(mazing, 5, 5);
            Assert.AreEqual(ForamtPath(ExpectedPath), solution.FormatPath(path));
        }

        [TestMethod]
        public void Mazing7x7()
        {
            int[][] mazing =
            {
                new int[] {1,1,1,1,1,1,1},
                new int[] {1,0,1,1,1,1,1},
                new int[] {1,1,0,1,1,1,1},
                new int[] {1,1,1,0,1,1,1},
                new int[] {1,1,1,0,1,1,1},
                new int[] {1,1,1,1,0,0,1},
                new int[] {1,1,1,1,1,1,0}
            };

            var ExpectedPath = new List<string>()
            {
                "(1,1)",
                "(2,2)",
                "(3,3)",
                "(4,3)",
                "(5,4)",
                "(5,5)",
                "(6,6)",
            };

            var solution = new MazingProblem();
            MyStack path = solution.FindPath(mazing, 7, 7);
            Assert.AreEqual(ForamtPath(ExpectedPath), solution.FormatPath(path));
        }

        [TestMethod]
        public void Mazing11x11()
        {
            int[][] mazing =
            {
                new int[] {1,1,1,1,1,1,1,1,1,1,1},
                new int[] {1,0,0,0,0,0,0,0,0,0,1},
                new int[] {1,1,1,1,1,1,1,1,1,0,1},
                new int[] {1,0,0,0,0,0,0,0,0,1,1},
                new int[] {1,0,1,1,1,1,1,1,1,1,1},
                new int[] {1,1,0,0,0,0,0,0,0,0,1},
                new int[] {1,1,1,1,1,1,1,1,1,0,1},
                new int[] {1,0,0,0,0,0,0,0,0,1,1},
                new int[] {1,0,1,1,1,1,1,1,1,1,1},
                new int[] {1,1,0,0,0,0,0,0,0,0,1},
                new int[] {1,1,1,1,1,1,1,1,1,1,0}
            };

            var ExpectedPath = new List<string>()
            {
                "(1,1)",
                "(1,2)",
                "(1,3)",
                "(1,4)",
                "(1,5)",
                "(1,6)",
                "(1,7)",
                "(1,8)",
                "(1,9)",
                "(2,9)",
                "(3,8)",
                "(3,7)",
                "(3,6)",
                "(3,5)",
                "(3,4)",
                "(3,3)",
                "(3,2)",
                "(4,1)",
                "(5,2)",
                "(5,3)",
                "(5,4)",
                "(5,5)",
                "(5,6)",
                "(5,7)",
                "(5,8)",
                "(5,9)",
                "(6,9)",
                "(7,8)",
                "(7,7)",
                "(7,6)",
                "(7,5)",
                "(7,4)",
                "(7,3)",
                "(7,2)",
                "(8,1)",
                "(9,2)",
                "(9,3)",
                "(9,4)",
                "(9,5)",
                "(9,6)",
                "(9,7)",
                "(9,8)",
                "(9,9)",
                "(10,10)"
            };

            var solution = new MazingProblem();
            MyStack path = solution.FindPath(mazing, 11, 11);
            Assert.AreEqual(ForamtPath(ExpectedPath), solution.FormatPath(path));
        }

        [TestMethod]
        public void Mazing7x7HasWrongWay()
        {
            int[][] mazing =
            {
                new int[] {1,1,1,1,1,1,1},
                new int[] {1,0,0,0,0,0,1},
                new int[] {1,1,0,1,1,1,1},
                new int[] {1,1,1,0,1,1,1},
                new int[] {1,1,1,0,1,1,1},
                new int[] {1,0,0,1,0,0,1},
                new int[] {1,1,1,1,1,1,0}
            };

            var ExpectedPath = new List<string>()
            {
                "(1,1)",
                "(1,2)",
                "(1,3)",
                "(2,2)",
                "(3,3)",
                "(4,3)",
                "(5,4)",
                "(5,5)",
                "(6,6)",
            };

            var solution = new MazingProblem();
            MyStack path = solution.FindPath(mazing, 7, 7);
            Assert.AreEqual(ForamtPath(ExpectedPath), solution.FormatPath(path));
        }

        [Ignore]
        [TestMethod]
        public void GenerateMazingTest()
        {
            var solution = new MazingProblem();
            int row = 11;
            int col = 11;
            int[][] mazing = solution.MazeGenerator.GenerateMazing(row, col);

            for (int i = 1; i < row; i++)
            {
                bool hasPath = false;
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < col; j++)
                {
                    sb.Append(mazing[i][j]);
                    if (mazing[i][j] == 0)
                    {
                        hasPath = true;
                        //break;
                    }
                }
                Debug.WriteLine(sb.ToString());
                Assert.AreEqual(true, hasPath);
            }
            Debug.WriteLine("===================");
            solution.MazeGenerator.PrintMaze(row,col,mazing);
        }
    }
}