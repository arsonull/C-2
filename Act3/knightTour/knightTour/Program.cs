using System;
using ChessBoardModel;

namespace knightTour
{
    class Program
    {
        static int boardSize = 8;
        static int attemptedMoves = 0;

        static int[] xMove = { -2, -1, 0, 1, 2 };
        static int[] yMove = { -2, -1, 0, 1, 2 };

        static int[,] board = new int[boardSize, boardSize];
        public static void Main(string[] args)
        {
            solveKT();
            Console.ReadLine();
        }
        static void solveKT()
        {
            for (int x = 0; x < boardSize; x++)
            {
                for (int y = 0; y < boardSize; y++)
                {
                    board[x, y] = -1;
                }
            }
            int startX = 0;
            int startY = 4;

            board[startX, startY] = 0;

            attemptedMoves = 0;

            if (!solveKTUtil(startX, startY, 1))
            {
                Console.WriteLine("Solution does not exist for {0}, {1}", startX, startY);
            }
            else
            {
                printSolution(board);
                Console.Out.WriteLine("Total attempted moves: {0}", attemptedMoves);
            }
        }
        static bool solveKTUtil(int x, int y, int moveCount)
        {
            attemptedMoves++;
            if (attemptedMoves % 1000000 == 0) { Console.Out.WriteLine("Attempts: {0}", attemptedMoves); }
            int k, nextX, nextY;

            if (moveCount == boardSize * boardSize) { return true; }

            for (k = 0; k < 8; k++)
            {
                if (x + xMove[k] <= boardSize) { nextX = x + xMove[k]; }
                else { return true; }
                if (y + yMove[k] <= boardSize) { nextY = y + yMove[k]; }
                else { return true; }
                if (isSquareSafe(nextX, nextY))
                {
                    board[nextX, nextY] = moveCount;
                    if (solveKTUtil(nextX, nextY, moveCount + 1)) { return true; }
                    else { board[nextX, nextY] = -1; }
                }
            }
            return false;
        }
        static bool isSquareSafe(int x, int y)
        {
            return (x >= 0 && x < boardSize && y >= 0 && y < boardSize && board[x, y] == -1);
        }
        static void printSolution(int[,] game)
        {
            for (int x = 0; x < boardSize; x++)
            {
                for (int y = 0; y < boardSize; y++)
                {
                    Console.Out.Write(game[x, y] + " ");
                }
                Console.Out.WriteLine();
            }
        }
    }
}
