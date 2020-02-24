using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knightTour
{
    class Program
    {
        //2 arrays to relate to each other to show the possible moves for the knight
        static int[] xMove = { 2, 1, -1, -2, -2, -1, 1, 2 };

        static int[] yMove = { 1, 2, 2, 1, -1, -2, -2, -1 };

        static void Main(string[] args)
        {
            int[,] board =   {{0,0,0,0,0,0,0,0 },
                              {0,0,0,0,0,0,0,0 },
                              {0,0,0,0,0,0,0,0 },
                              {0,0,0,0,0,0,0,0 },
                              {0,0,0,0,0,0,0,0 },
                              {0,0,0,0,0,0,0,0 },
                              {0,0,0,0,0,0,0,0 },
                              {0,0,0,0,0,0,0,0 }};
            //This is where you can change where it starts
            board[0, 0] = 1;
            KnightTour(board, 0, 0, 1);

            Console.ReadLine();
        }

        public static bool KnightTour(int[,] board, int x, int y, int moves)
        {
            //The way the recursion ends and knows when it's done
            if (moves == 64)
            {
                //this prints the board
                printBoard(board);
                return true;
            }
            else
            {
                //This is where the brunt of the recursive method is
                for (int index = 0; index < xMove.Length; index++)
                {
                    //Goes through the different moves using a variable as the index for the move list arrays
                    int xNew = x + xMove[index];
                    int yNew = y + yMove[index];
                    //If the new move is valid, meaning the knight hasn't traveled there yet, continue
                    if (IfValidMove(board, xNew, yNew))
                    {
                        //Increase move, since we are "moving" at this point and set that point equal to move so we can see the order the knight took
                        moves++;
                        board[xNew, yNew] = moves;
                        //Console.WriteLine(move);
                        if (KnightTour(board, xNew, yNew, moves))
                        {
                            //This ends recursion
                            return true;
                        }
                        //resets the space if the program gets to this point since that would mean the move didn't actually work
                        moves--;
                        board[xNew, yNew] = 0;
                        //Console.WriteLine(move);
                    }
                }
            }
            return false;
        }

        static bool IfValidMove(int[,] board, int xNew, int yNew)
        {
            //Makes sure the next space is within bounds and hasn't been seen yet.
            if ((xNew >= 0) && (xNew < 8) && (yNew >= 0) && (yNew < 8) && (board[xNew, yNew] == 0))
            {
                return true;
            }
            return false;
        }

        static void printBoard(int[,] board)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{board[i, j]}, ");
                }
                Console.WriteLine();
            }
        }
    }
}