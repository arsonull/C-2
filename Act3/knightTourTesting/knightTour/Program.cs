using System;

namespace knightTour
{
    class Program
    {
        /*public static void Main(string[] args)
        {
            int[,] board = {{0,0,0,0,0,0,0,0 },
                             {0,0,0,0,0,0,0,0 },
                             {0,0,0,0,0,0,0,0 },
                             {0,0,0,0,0,0,0,0 },
                             {0,0,0,0,0,0,0,0 },
                             {0,0,0,0,0,0,0,0 },
                             {0,0,0,0,0,0,0,0 },
                             {0,0,0,0,0,0,0,0 }};
            board[0, 0] = 1;
            solveKT(board, 0, 0, 1);
            Console.ReadLine();
        }*/
        static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };

        static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };

        static bool solveKT(int[,] board, int x, int y, int attemptedMoves)
        {
            if (attemptedMoves == 64)
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        Console.Write($"{board[i, j]}, ");
                    }
                    Console.WriteLine();
                }
                return true;
            }
            else
            {
                for (int i = 0; x < xMove.Length; x++)
                {
                    int nextX = x + xMove[i];
                    int nextY = y + yMove[i];
                    if (isSquareSafe(board, nextX, nextY))
                    {
                        attemptedMoves++;
                        //Console.WriteLine(attemptedMoves);
                        board[nextX, nextY] = attemptedMoves;
                        if (solveKT(board, nextX, nextY, attemptedMoves))
                        {
                            return true;
                        }
                        //attemptedMoves--;
                        //board[nextX, nextY] = 0;
                    }
                }
            }
            return false;
        }
        static bool isSquareSafe(int[,] board, int x, int y)
        {
            if (x >= 0 && x < 8 && y >= 0 && y < 8 && board[x, y] == 0)
            {
                return true;
            }
            return false;
        }
    }
}
