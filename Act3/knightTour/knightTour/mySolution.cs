using System;
using System.Collections.Generic;
using System.Text;
using ChessBoardModel;

namespace knightTour
{
    class mySolution
    {
        static int boardSize = 8;
        static int attemptedMoves = 0;
        static Board game = new Board(boardSize);
        public static void main(string[] args)
        {
            Console.Out.WriteLine("Please enter the row and column that you want the knight to start on.");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            knightTour(x, y);
            Console.ReadLine();
        }

        static void knightTour (int x, int y)
        {
            Cell currentCell = new Cell(x, y);
            game.theGrid[x, y].visited = true;
            game.setOpenNeighbors(currentCell);

        }
    }
}
