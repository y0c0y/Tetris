using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Tetris_MainView;

namespace Tetris_GAME
{

    static class Constants
    {
        /* Direction KEYs */

        public const int LEFT = 75;
        public const int RIGHT = 77;
        public const int UP = 72;
        public const int SPACEDOWN = 32;

        public const int num = 7; // Number of Block

        /* Size of gameboard */
        public const int GBOARD_WIDTH = 10;
        public const int GBOARD_HEIGHT = 20;

        /* Starting point of gameboard */
        public const int GBOARD_ORIGIN_X = 4;
        public const int GBOARD_ORIGIN_Y = 2;

        /* Conditions of victory */
        public const int END = 5;
    }

    static class Globals
    {
        public static int[,] BlockModel(int id)
        {
            switch (id)
            {
                /* 1st Block
                        ■
                        ■■■     */

                case 0:
                    return new int[4, 4]
                    {
                                { 0, 0, 0, 0},
                                { 1, 0, 0, 0},
                                { 1, 1, 1, 0},
                                { 0, 0, 0, 0}
                    };

                case 1:
                    return new int[4, 4]
                    {
                                 {0, 1, 0, 0},
                                 {0, 1, 0, 0},
                                 {1, 1, 0, 0},
                                 {0, 0, 0, 0}
                    };

                case 2:
                    return new int[4, 4]
                    {
                                {0, 0, 0, 0},
                                {1, 1, 1, 0},
                                {0, 0, 1, 0},
                                {0, 0, 0, 0}
                    };
                case 3:
                    return new int[4, 4]
                    {
                               {0, 0, 0, 0},
                               {1, 1, 0, 0},
                               {1, 0, 0, 0},
                               {1, 0, 0, 0}
                    };

                /* 2nd Block
                               ■
                           ■■■     */

                case 4:
                    return new int[4, 4]
                    {
                                {0, 0, 0, 0},
                                {0, 0, 1, 0},
                                {1, 1, 1, 0},
                                {0, 0, 0, 0}
                    };
                case 5:
                    return new int[4, 4]
                    {
                                {0, 0, 0, 0},
                                {0, 1, 1, 0},
                                {0, 0, 1, 0},
                                {0, 0, 1, 0}
                    };
                case 6:
                    return new int[4, 4]
                    {
                                {0, 0, 0, 0},
                                {0, 1, 1, 1},
                                {0, 1, 0, 0},
                                {0, 0, 0, 0}
                    };
                case 7:
                    return new int[4, 4]
                    {
                                 {0, 1, 0, 0},
                                 {0, 1, 0, 0},
                                 {0, 1, 1, 0},
                                 {0, 0, 0, 0}
                    };
                /* 4th Block

                      ■
                    ■■■     */
                case 8:
                    return new int[4, 4]
                    {
                                {0, 0, 0, 0},
                                {0, 1, 0, 0},
                                {1, 1, 1, 0},
                                {0, 0, 0, 0}
                    };
                case 9:
                    return new int[4, 4]
                    {
                                {0, 0, 0, 0},
                                {0, 1, 0, 0},
                                {1, 1, 0, 0},
                                {0, 1, 0, 0 }
                    };
                case 10:
                    return new int[4, 4]
                    {
                               {0, 0, 0, 0},
                               {0, 0, 0, 0},
                               {1, 1, 1, 0},
                               {0, 1, 0, 0}
                    };
                case 11:
                    return new int[4, 4]
                    {
                                {0, 0, 0, 0},
                                {0, 1, 0, 0},
                                {0, 1, 1, 0},
                                 {0, 1, 0, 0}
                    };
                /* 4th Block

                         ■■■■     */

                case 12:
                case 14:
                    return new int[4, 4]
                    {
                               {0, 1, 0, 0},
                               {0, 1, 0, 0},
                               {0, 1, 0, 0},
                               {0, 1, 0, 0}
                    };
                case 13:
                case 15:

                    return new int[4, 4]
                    {
                                 {0, 0, 0, 0},
                                 {0, 0, 0, 0},
                                 {1, 1, 1, 1},
                                 {0, 0, 0, 0}
                    };
                /* 5th Block
                         ■■
                         ■■     */

                case 16:
                case 17:
                case 18:
                case 19:
                    return new int[4, 4]
                    {
                                {1, 1, 0, 0},
                                {1, 1, 0, 0},
                                {0, 0, 0, 0},
                                {0, 0, 0, 0}
                    };
                /* 6th Block
                           ■■
                         ■■     */

                case 20:
                case 22:
                    return new int[4, 4]
                    {
                               {0, 0, 0, 0},
                               {0, 1, 1, 0},
                               {1, 1, 0, 0},
                               {0, 0, 0, 0}
                    };
                case 21:
                case 23:
                    return new int[4, 4]
                    {
                                {0, 1, 0, 0},
                                {0, 1, 1, 0},
                                {0, 0, 1, 0},
                                {0, 0, 0, 0}
                    };
                /* 7th Block
                         ■■
                           ■■     */

                case 24:
                case 26:
                    return new int[4, 4]
                    {
                                {0, 0, 0, 0},
                                {1, 1, 0, 0},
                                {0, 1, 1, 0},
                                {0, 0, 0, 0}
                    };
                case 25:
                case 27:
                    return new int[4, 4]
                    {
                                {0, 1, 0, 0},
                                {1, 1, 0, 0},
                                {1, 0, 0, 0},
                                {0, 0, 0, 0}
                    };
                default:
                    return null;
            }

        }
        public static int[,] gameBoardInfo = new int[Constants.GBOARD_HEIGHT + 1, Constants.GBOARD_WIDTH + 2];

        public static int block_id;
        public static int curPosX;
        public static int curPosY;
        public static int speed;
        public static int NextStageScore;
        public static int level;
        public static int score;
        public static int TotalScore;
    }

    static class Tetris
    {

        public static void SetGameBoard()
        {
            Array.Clear(Globals.gameBoardInfo, 0, Globals.gameBoardInfo.Length);

            for (var y = 0; y < Constants.GBOARD_HEIGHT; y++)
            {
                Globals.gameBoardInfo[y, 0] = 1;
                Globals.gameBoardInfo[y, Constants.GBOARD_WIDTH + 1] = 1;
            }
            for (var x = 0; x < Constants.GBOARD_WIDTH + 2; x++)
            {
                Globals.gameBoardInfo[Constants.GBOARD_HEIGHT, x] = 1;
            }

        }

        public static void DrawGameBoard()
        {
            for (var y = 0; y <= Constants.GBOARD_HEIGHT; y++)
            {
                Console.SetCursorPosition(Constants.GBOARD_ORIGIN_X, Constants.GBOARD_ORIGIN_Y + y);
                if (y == Constants.GBOARD_HEIGHT) Console.Write("└");
                else Console.Write("│");
            }
            for (var y = 0; y <= Constants.GBOARD_HEIGHT; y++)
            {
                Console.SetCursorPosition(Constants.GBOARD_ORIGIN_X + (Constants.GBOARD_WIDTH + 1) * 2, Constants.GBOARD_ORIGIN_Y + y);
                if (y == Constants.GBOARD_HEIGHT) Console.Write("┘");
                else Console.Write("│");
            }
            for (var x = 1; x < Constants.GBOARD_WIDTH + 1; x++)
            {
                Console.SetCursorPosition(Constants.GBOARD_ORIGIN_X + x * 2, Constants.GBOARD_ORIGIN_Y + Constants.GBOARD_HEIGHT);
                Console.Write("─");
            }
            Globals.curPosX = Constants.GBOARD_ORIGIN_X + Constants.GBOARD_WIDTH;
            Globals.curPosY = 0;
            Console.SetCursorPosition(Globals.curPosX, Globals.curPosY);

        }

        public static void ShowBlock(int[,] blockInfo)
        {
            int x, y;
            int curPosX = Console.GetCursorPosition().Left;
            int curPosY = Console.GetCursorPosition().Top;
            for (y = 0; y < 4; y++)
            {
                for (x = 0; x < 4; x++)
                {
                    Console.SetCursorPosition(curPosX + (x * 2), curPosY + y);

                    if (blockInfo[y, x] == 1)
                    {
                        Console.Write("■");
                    }
                }
            }

            Console.SetCursorPosition(curPosX, curPosY);
        }
        public static void DeleteBlock(int[,] blockInfo)
        {
            int x, y;

            int curX = Console.GetCursorPosition().Left;
            int curY = Console.GetCursorPosition().Top;

            for (y = 0; y < 4; y++)
            {
                for (x = 0; x < 4; x++)
                {
                    Console.SetCursorPosition(curX + (x * 2), curY + y);

                    if (blockInfo[y, x] == 1)
                    {
                        Console.Write("  ");
                    }
                }
            }

            Console.SetCursorPosition(curX, curY);
        }

        public static void RedrawBlocks()
        {
            int x, y;
            int cursX, cursY;
            for (y = 0; y < Constants.GBOARD_HEIGHT; y++)
            {
                for (x = 1; x < Constants.GBOARD_WIDTH + 1; x++)
                {
                    cursX = x * 2 + Constants.GBOARD_ORIGIN_X;
                    cursY = y + Constants.GBOARD_ORIGIN_Y;
                    Console.SetCursorPosition(cursX, cursY);
                    if (Globals.gameBoardInfo[y, x] == 1)
                    {
                        Console.Write("■");
                    }
                    else { Console.Write("  "); }
                }
            }
        }

        public static void RemoveFillUpLine()
        {
            int line, x, y;
            var board = Globals.gameBoardInfo;


            for (y = Constants.GBOARD_HEIGHT - 1; y > 0; y--)
            {
                for (x = 1; x < Constants.GBOARD_WIDTH + 1; x++)
                {
                    if (Globals.gameBoardInfo[y, x] != 1)
                    {
                        break;
                    }
                }
                if (x == (Constants.GBOARD_WIDTH + 1))
                {
                    for (line = 0; y - line > 0; line++)
                    {

                        for (var i = 1; i < Constants.GBOARD_WIDTH + 1; i++)
                        {
                            Globals.gameBoardInfo[y - line, i] = Globals.gameBoardInfo[y - line - 1, i];
                        }
                    }
                    y = Constants.GBOARD_HEIGHT;
                    Globals.TotalScore += 10;
                    Globals.score += 10;
                }
            }
            RedrawBlocks();
        }

        public static bool DetectCollision(int posX, int posY, int[,] blockModel)
        {
            int arrX = (posX - Constants.GBOARD_ORIGIN_X) / 2;
            int arrY = posY - Constants.GBOARD_ORIGIN_Y;

            for (var x = 0; x < 4; x++)
            {
                for (var y = 0; y < 4; y++)
                {

                    if (blockModel[y, x] == 1 && Globals.gameBoardInfo[arrY + y, arrX + x] == 1)
                    {
                        return false;
                    }

                }
            }
            return true;
        }

        public static void RoateBlock() // Rotation
        {
            int block_base = Globals.block_id - Globals.block_id % 4;
            int block_rotated = block_base + (Globals.block_id + 1) % 4;

            if (!DetectCollision(Globals.curPosX, Globals.curPosY + 1, Globals.BlockModel(block_base))) return;

            DeleteBlock(Globals.BlockModel(Globals.block_id));
            Globals.block_id = block_rotated;
            ShowBlock(Globals.BlockModel(Globals.block_id));
        }
        public static void ShiftRight() //Right
        {
            if (!DetectCollision(Globals.curPosX + 2, Globals.curPosY, Globals.BlockModel(Globals.block_id))) return;

            DeleteBlock(Globals.BlockModel(Globals.block_id));
            Globals.curPosX += 2;
            Console.SetCursorPosition(Globals.curPosX, Globals.curPosY);
            ShowBlock(Globals.BlockModel(Globals.block_id));

        }
        public static void ShiftLeft() //Left
        {
            if (!DetectCollision(Globals.curPosX - 2, Globals.curPosY, Globals.BlockModel(Globals.block_id))) return;

            DeleteBlock(Globals.BlockModel(Globals.block_id));
            Globals.curPosX -= 2;
            Console.SetCursorPosition(Globals.curPosX, Globals.curPosY);
            ShowBlock(Globals.BlockModel(Globals.block_id));
        }
        public static bool BlockDown() // Keep Going Down
        {
            if (!DetectCollision(Globals.curPosX, Globals.curPosY + 1, Globals.BlockModel(Globals.block_id)))
            {
                return false;
            }
            DeleteBlock(Globals.BlockModel(Globals.block_id));
            Globals.curPosY += 1;
            Console.SetCursorPosition(Globals.curPosX, Globals.curPosY);
            ShowBlock(Globals.BlockModel(Globals.block_id));

            return true;
        }

        public static void SpaceDown()
        {
            while (BlockDown()) ;
        }

        public static void ProcessKeyInput()
        {
            int i, key = 0;
            for (i = 0; i < 20; i++)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.LeftArrow: // a : 왼쪽
                            ShiftLeft();
                            break;
                        case ConsoleKey.RightArrow: // d : 오른쪽
                            ShiftRight();
                            break;
                        case ConsoleKey.UpArrow:
                            RoateBlock(); // 회전
                            break;
                        case ConsoleKey.Spacebar:
                            SpaceDown();
                            break;
                        case ConsoleKey.DownArrow:
                            BlockDown();
                            break;

                        case ConsoleKey.Backspace:
                            Game();
                            break;

                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                Thread.Sleep(Globals.speed);
            }

        }

        public static void AddBlockToBoard()
        {
            int x, y, arrCurX, arrCurY;
            for (y = 0; y < 4; y++)
            {
                for (x = 0; x < 4; x++)
                {
                    /* Convert X,Y coordinate to array index */

                    arrCurX = (Globals.curPosX - Constants.GBOARD_ORIGIN_X) / 2;
                    arrCurY = Globals.curPosY - Constants.GBOARD_ORIGIN_Y;

                    var block = Globals.BlockModel(Globals.block_id);

                    if (block[y, x] == 1)
                        Globals.gameBoardInfo[arrCurY + y, arrCurX + x] = 1;
                }
            }
        }

        public static bool IsGameOver()
        {
            // 
            if (!DetectCollision(Globals.curPosX, Globals.curPosY, Globals.BlockModel(Globals.block_id))) return true;
            else return false;
        }

        public static bool IsUserWin()
        {
            if (Globals.level == Constants.END) return true;
            return false;
        }


        public static void NewBlock()
        {
            Globals.block_id = new Random().Next(0, 28);
            Globals.curPosX = Constants.GBOARD_ORIGIN_X + Constants.GBOARD_WIDTH;
            Globals.curPosY = 4;
            Console.SetCursorPosition(Globals.curPosX, Globals.curPosY);
        }

        public static void Game()
        {
            Console.CursorVisible = false;

            Globals.speed = 15;
            Globals.level = 0;
            Globals.NextStageScore = 0;

            while (true)
            {

                if (Globals.score >= Globals.NextStageScore)
                {


                    Globals.score = 0;
                    Console.Clear();
                    Globals.speed--;
                    Globals.level++;
                    Globals.NextStageScore = Globals.level * 50;

                    if (IsUserWin())
                    {
                        Console.Clear();
                        Console.SetCursorPosition(0, 10);

                        Console.Write("Congratulations, You Win!!!");
                        Console.SetCursorPosition(0, 20);
                        Console.Write("TotalScore : {0} Level : {1}", Globals.TotalScore, Globals.level);
                        Thread.Sleep(1000);
                        break;
                    }


                    Console.SetCursorPosition(0, 10);
                    Console.Write("Levle : {0}  StageGoal : {1}", Globals.level, Globals.NextStageScore);
                    Thread.Sleep(1000);
                    Console.SetCursorPosition(0, 10);
                    Console.Write("                                                                                          ");

                    Tetris.SetGameBoard();
                    Tetris.DrawGameBoard();
                }

                Console.SetCursorPosition(30, 10);
                Console.Write("Total Score: {0}  Score : {1}", Globals.TotalScore, Globals.score);
                Console.SetCursorPosition(30, 15);
                Console.Write("Levle : {0} StageGoal : {1}", Globals.level, Globals.NextStageScore);


                NewBlock();

                if (IsGameOver())
                {

                    Console.Clear();
                    Console.SetCursorPosition(0, 10);

                    Console.Write("Game Over!!");

                    Console.SetCursorPosition(0, 20);
                    Console.Write("TotalScore : {0} Level : {1}", Globals.TotalScore, Globals.level);
                    Thread.Sleep(1000);
                    break;
                }

                while (true)
                {
                    if (!BlockDown())
                    {
                        AddBlockToBoard();


                        Thread Remove = new Thread(new ThreadStart(Tetris.RemoveFillUpLine));

                        Remove.Start();

                        Remove.Join();
                        break;
                    }
                    ProcessKeyInput();
                }
            }

        }

    }




}
