using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructure.StakeAndQueue;

namespace DataStructure.MazingProblem
{
    public class MazingProblem
    {
        private int _MazeRow;
        private int _MazeCol;
        private readonly int[][] _DirectionArray;
        private readonly List<string> _PathResult = new List<string>();
        private readonly List<string> _WrongPath = new List<string>();
        private readonly List<string> _DecisionPoint = new List<string>();
        private readonly MazeGenerator _MazeGenerator;

        public MazingProblem()
        {
            _MazeRow = 1;
            _MazeCol = 1;
            _DirectionArray = new int[9][];

            _PathResult.Add(FormatLocation(_MazeRow, _MazeCol));
            _MazeGenerator = new MazeGenerator();
        }

        public MazeGenerator MazeGenerator
        {
            get { return _MazeGenerator; }
        }

        /*
         * -------------    -----------------
         * | 8 | 1 | 2 |    | NW |  N  | NE |
         * -------------    -----------------
         * | 7 | 0 | 3 |    | W | (0_0) | E |
         * -------------    -----------------
         * | 6 | 5 | 4 |    | SW |  S  | SE |
         * -------------    -----------------
         */

        public MyStack FindPath(int[][] mazing, int mazeHeight, int mazeWidth)
        {
            while (!IsExit(mazeHeight, mazeWidth))
            {
                InitLocation(mazing);

                int direction = GetDirection();

                if (direction != 0)
                {
                    WalkForward(direction);
                }
                else
                {
                    WalkBackward();
                }
            }

            MyStack resultStack = new MyStack(_PathResult.Count);
            foreach (var path in _PathResult)
            {
                resultStack.Push(path);
            }
            return resultStack;
        }

        private bool IsExit(int mazeHeight, int mazeWidth)
        {
            return _MazeRow == mazeHeight - 1 && _MazeCol == mazeWidth - 1;
        }

        private void WalkForward(int direction)
        {
            _MazeRow = _DirectionArray[direction][0];
            _MazeCol = _DirectionArray[direction][1];
            _PathResult.Add(FormatLocation(_MazeRow, _MazeCol));
        }

        private void WalkBackward()
        {
            string backPoint = _DecisionPoint.Last();

            while (_PathResult.Last() != backPoint)
            {
                if (_PathResult[_PathResult.Count - 2] == backPoint)
                    _WrongPath.Add(_PathResult.Last());

                _PathResult.Remove(_PathResult.Last());
            }

            _MazeRow = Int32.Parse(backPoint.Split('(', ',', ')')[1]);
            _MazeCol = Int32.Parse(backPoint.Split('(', ',', ')')[2]);

            _DecisionPoint.Remove(_DecisionPoint.Last());
        }

        private int GetDirection()
        {
            if (IsMoreThan2Ways())
            {
                _DecisionPoint.Add(FormatLocation(_MazeRow, _MazeCol));
            }

            for (int direction = 1; direction < 9; direction++)
            {
                if (IsValidPath(direction))
                {
                    return direction;
                }
            }

            const int noPath = 0;
            return noPath;
        }

        private bool IsValidPath(int direction)
        {
            var location = FormatLocation(_DirectionArray[direction][0], _DirectionArray[direction][1]);

            if (_WrongPath.Any(path => path.Contains(location)))
                return false;

            if (_PathResult.Any(path => path.Contains(location)))
                return false;

            return _DirectionArray[direction][2] == 0;
        }


        private bool IsMoreThan2Ways()
        {
            int wayCount = 0;

            for (int direction = 1; direction < 9; direction++)
            {
                var location = FormatLocation(_DirectionArray[direction][0], _DirectionArray[direction][1]);

                if (_PathResult.Any(path => path.Contains(location)))
                {
                    continue;
                }

                if (_DirectionArray[direction][2] == 0)
                {
                    wayCount++;
                }
            }

            return wayCount > 1;
        }

        public void InitLocation(int[][] mazing)
        {
            // Row , Col , Value
            _DirectionArray[0] = new int[3] { _MazeRow, _MazeCol, mazing[_MazeRow][_MazeCol] };
            _DirectionArray[1] = new int[3] { _MazeRow - 1, _MazeCol, mazing[_MazeRow - 1][_MazeCol] };
            _DirectionArray[2] = new int[3] { _MazeRow - 1, _MazeCol + 1, mazing[_MazeRow - 1][_MazeCol + 1] };
            _DirectionArray[3] = new int[3] { _MazeRow, _MazeCol + 1, mazing[_MazeRow][_MazeCol + 1] };
            _DirectionArray[4] = new int[3] { _MazeRow + 1, _MazeCol + 1, mazing[_MazeRow + 1][_MazeCol + 1] };
            _DirectionArray[5] = new int[3] { _MazeRow + 1, _MazeCol, mazing[_MazeRow + 1][_MazeCol] };
            _DirectionArray[6] = new int[3] { _MazeRow + 1, _MazeCol - 1, mazing[_MazeRow + 1][_MazeCol - 1] };
            _DirectionArray[7] = new int[3] { _MazeRow, _MazeCol - 1, mazing[_MazeRow][_MazeCol - 1] };
            _DirectionArray[8] = new int[3] { _MazeRow - 1, _MazeCol - 1, mazing[_MazeRow - 1][_MazeCol - 1] };
        }

        public string FormatLocation(int mazeRow, int mazeCol)
        {
            StringBuilder result = new StringBuilder();
            result.Append("(");
            result.Append(mazeRow);
            result.Append(",");
            result.Append(mazeCol);
            result.Append(")");
            return result.ToString();
        }

        public string FormatPath(MyStack path)
        {
            return string.Join("-", path.ItemToList());
        }



    }
}
