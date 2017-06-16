using System;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace DataStructure.MazingProblem
{
    public class MazeGenerator
    {
        /*
         * -------------    -----------------------------------------------
         * | 0 | 1 | 2 |    | r , c     |  r , c + 1      | r , c + 2     |
         * -------------    -----------------------------------------------
         * | 3 | 4 | 5 |    | r + 1 , c |  r + 1 , c + 1  | r + 1 , c + 2 |
         * -------------    -----------------------------------------------
         *                  | r + 2 , c |  r + 2 , c + 1  |
         * ---------        -------------------------------
         * | 0 | 3 | 
         * ---------
         * | 1 | 4 |
         * ---------
         * | 2 | 5 |
         * ---------
         */
        private int[][] _Maze;
        private readonly int[][] _DivideArea;
        private Random rnd = new Random();

        public MazeGenerator()
        {
            _DivideArea = new int[2][]
            {
                new int[2],   //start point
                new int[2]    //end Point
            };
        }

        public int[][] GenerateMazing(int mazeHeight, int mazeWidth)
        {
            _Maze = InitMazeArea(mazeHeight, mazeWidth);

            while (SearchVerticalRoom(_Maze, mazeHeight, mazeWidth) || SearchHarizontalRoom(_Maze, mazeHeight, mazeWidth))
            {
                //PrintMaze(mazeHeight, mazeWidth, _Maze);

                BuildWall();
            }

            return _Maze;
        }

        public void PrintMaze(int mazeHeight, int mazeWidth, int[][] maze)
        {
            for (int i = 0; i < mazeHeight; i++)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < mazeWidth; j++)
                {
                    string replaceInt;
                    if (i == 1 && j == 1)
                        replaceInt = "O";
                    else if (i == mazeHeight - 1 && j == mazeWidth - 1)
                        replaceInt = "X";
                    else
                        replaceInt = maze[i][j] == 1 ? "#" : " ";
                    sb.Append(replaceInt);
                }
                Debug.WriteLine(sb.ToString());
            }
            Debug.WriteLine("===================");
        }

        private int _VDoorPrevious;
        private int _HDoorPrevious;

        private void BuildWall()
        {
            int startCol = _DivideArea[0][1];
            int endCol = _DivideArea[1][1];
            int startRow = _DivideArea[0][0];
            int endRow = _DivideArea[1][0];

            //Debug.WriteLine("Start: ({0},{1}), End: ({2},{3})", startRow, startCol, endRow, endCol);

            int roomWidth = endCol - startCol;
            int roomHight = endRow - startRow;

            if (roomWidth < roomHight)
            {
                HorizontalWall(startRow, roomHight, startCol, roomWidth, endCol);
            }
            else if (roomHight < roomWidth)
            {
                VirticalWall(startRow, roomHight, startCol, roomWidth, endRow);
            }
            else
            {
                if (rnd.Next(0, 2) == 0)
                {
                    HorizontalWall(startRow, roomHight, startCol, roomWidth, endCol);
                }
                else
                {
                    VirticalWall(startRow, roomHight, startCol, roomWidth, endRow);
                }
            }
        }

        private void VirticalWall(int startRow, int roomHight, int startCol, int roomWidth, int endRow)
        {
            //Debug.WriteLine("Virtical Wall");

            int vWall = startCol + rnd.Next(1, roomWidth);

            while (vWall == _HDoorPrevious)
            {
                vWall = startCol + rnd.Next(1, roomWidth);
            }

            for (int i = startRow; i <= startRow + roomHight; i++)
            {
                if (_Maze[i][vWall] == 1)
                    break;

                _Maze[i][vWall] = 1;
            }
            int vDoor = rnd.Next(startRow, endRow + 1);
            //Debug.WriteLine("Wall & Door point: ({0},{1})", vDoor, vWall);
            _Maze[vDoor][vWall] = 0;
            _VDoorPrevious = vDoor;
        }

        private void HorizontalWall(int startRow, int roomHight, int startCol, int roomWidth, int endCol)
        {
            //Debug.WriteLine("Horizontal Wall");

            int hWall = startRow + rnd.Next(1, roomHight);

            while (hWall == _VDoorPrevious)
            {
                hWall = startRow + rnd.Next(1, roomHight);
            }

            for (int i = startCol; i <= startCol + roomWidth; i++)
            {
                if (_Maze[hWall][i] == 1)
                {
                    break;
                }
                _Maze[hWall][i] = 1;
            }
            int hDoor = rnd.Next(startCol, endCol + 1);
            //Debug.WriteLine("Door & Wall point: ({0},{1})", hWall, hDoor);
            _Maze[hWall][hDoor] = 0;
            _HDoorPrevious = hDoor;
        }


        private bool SearchVerticalRoom(int[][] maze, int mazeHeight, int mazeWidth)
        {
            int[] room = new int[6];
            bool startPoint = false;
            bool endRow = false;
            for (int c = 0; c < mazeWidth - 1; c++)
            {
                for (int r = 0; r < mazeHeight - 2; r++)
                {
                    int roomSize = 0;
                    room[0] = maze[r][c];
                    room[1] = maze[r + 1][c];
                    room[2] = maze[r + 2][c];
                    room[3] = maze[r][c + 1];
                    room[4] = maze[r + 1][c + 1];
                    room[5] = maze[r + 2][c + 1];

                    //Debug.WriteLine("Room Point: ({0},{1})", r, c);

                    roomSize = RoomSize(room, roomSize);

                    if (roomSize == 6 && startPoint == false)
                    {
                        startPoint = true;
                        _DivideArea[0][0] = r;
                        _DivideArea[0][1] = c;
                    }
                    if (startPoint == true && endRow == false)
                    {
                        if (room[2] == 1 || room[5] == 1)
                        {
                            _DivideArea[1][0] = r + 1;
                            endRow = true;
                            break;
                        }
                    }
                }
                if (HitBottom(room) && startPoint == true)
                {
                    //Debug.WriteLine("|{0}|{1}|", room[0], room[3]);
                    //Debug.WriteLine("|{0}|{1}|", room[1], room[4]);
                    //Debug.WriteLine("|{0}|{1}|", room[2], room[5]);
                    _DivideArea[1][1] = c;
                    return true;
                }
            }
            return false;
        }

        private bool SearchHarizontalRoom(int[][] maze, int mazeHeight, int mazeWidth)
        {
            int[] room = new int[6];
            bool startPoint = false;
            bool endCol = false;
            for (int r = 0; r < mazeHeight - 1; r++)
            {
                for (int c = 0; c < mazeWidth - 2; c++)
                {
                    int roomSize = 0;

                    room[0] = maze[r][c];
                    room[1] = maze[r][c + 1];
                    room[2] = maze[r][c + 2];
                    room[3] = maze[r + 1][c];
                    room[4] = maze[r + 1][c + 1];
                    room[5] = maze[r + 1][c + 2];

                    //Debug.WriteLine("Room Point: ({0},{1})", r, c);


                    roomSize = RoomSize(room, roomSize);

                    if (roomSize == 6 && startPoint == false)
                    {
                        startPoint = true;
                        _DivideArea[0][0] = r;
                        _DivideArea[0][1] = c;
                    }
                    if (startPoint == true && endCol == false)
                    {
                        if (room[2] == 1 || room[5] == 1)
                        {
                            _DivideArea[1][1] = c + 1;
                            endCol = true;
                            break;
                        }
                    }
                }
                if (HitBottom(room) && startPoint == true)
                {
                    //Debug.WriteLine("|{0}|{1}|{2}|", room[0], room[1], room[2]);
                    //Debug.WriteLine("|{0}|{1}|{2}|", room[3], room[4], room[5]);
                    _DivideArea[1][0] = r;
                    return true;
                }
            }
            return false;
        }

        private bool HitBottom(int[] room)
        {
            int wallCount = 0;
            for (int i = 3; i <= 5; i++)
            {
                if (room[i] == 1)
                {
                    wallCount++;
                }
            }
            return wallCount > 1;
        }

        private int RoomSize(int[] room, int roomSize)
        {
            for (int i = 0; i < room.Length; i++)
            {
                if (room[i] == 0)
                {
                    roomSize++;
                }
            }
            return roomSize;
        }

        private int[][] InitMazeArea(int mazeHeight, int mazeWidth)
        {
            int[][] maze = new int[mazeHeight][];
            for (int i = 0; i < mazeHeight; i++)
            {
                maze[i] = new int[mazeWidth];
                //Setup Edge Wall
                maze[i][0] = 1;
                maze[i][mazeWidth - 1] = 1;
            }

            for (int i = 0; i < mazeWidth; i++)
            {
                //Setup Edge Wall
                maze[0][i] = 1;
                maze[mazeHeight - 1][i] = 1;
            }

            //Exit Door
            maze[mazeHeight - 1][mazeWidth - 1] = 0;

            return maze;
        }
    }
}