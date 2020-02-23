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
        public static void Main(string[] args)
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
            int lowestMoves = 100;
            //Find which moves have the lowest moves
            if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber - 1 >= 0)
            {
                if (game.theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].openNeighbors < lowestMoves) { lowestMoves = game.theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].openNeighbors; }
            }
            if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber + 1 < boardSize)
            {
                if (game.theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].openNeighbors < lowestMoves) { lowestMoves = game.theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].openNeighbors; }
            }
            if (currentCell.RowNumber + 2 < boardSize && currentCell.ColumnNumber - 1 >= 0)
            {
                if (game.theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].openNeighbors < lowestMoves) { lowestMoves = game.theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].openNeighbors; }
            }
            if (currentCell.RowNumber + 2 < boardSize && currentCell.ColumnNumber + 1 < boardSize)
            {
                if (game.theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].openNeighbors < lowestMoves) { lowestMoves = game.theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].openNeighbors; }
            }
            if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 2 >= 0)
            {
                if (game.theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].openNeighbors < lowestMoves) { lowestMoves = game.theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].openNeighbors; }
            }
            if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 2 < boardSize)
            {
                if (game.theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].openNeighbors < lowestMoves) { lowestMoves = game.theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].openNeighbors; }
            }
            if (currentCell.RowNumber + 1 < boardSize && currentCell.ColumnNumber - 2 >= 0)
            {
                if (game.theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].openNeighbors < lowestMoves) { lowestMoves = game.theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].openNeighbors; }
            }
            if (currentCell.RowNumber + 1 < boardSize && currentCell.ColumnNumber + 2 < boardSize)
            {
                if (game.theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].openNeighbors < lowestMoves) { lowestMoves = game.theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].openNeighbors; }
            }
            if (lowestMoves != 0)
            {
                //Choose a option that has the lowest amount of moves possible
                if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber - 1 >= 0)
                {
                    if (game.theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].openNeighbors == lowestMoves)
                    {
                        game.theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].visited = true;
                        attemptedMoves++;
                        knightTour(x - 2, y - 1);
                    }
                }
                else if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber + 1 < boardSize)
                {
                    if (game.theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].openNeighbors == lowestMoves)
                    {
                        game.theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].visited = true;
                        attemptedMoves++;
                        knightTour(x - 2, y + 1);
                    }
                }
                else if (currentCell.RowNumber + 2 < boardSize && currentCell.ColumnNumber - 1 >= 0)
                {
                    if (game.theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].openNeighbors == lowestMoves)
                    {
                        game.theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].visited = true;
                        attemptedMoves++;
                        knightTour(x + 2, y - 1);
                    }
                }
                else if (currentCell.RowNumber + 2 < boardSize && currentCell.ColumnNumber + 1 < boardSize)
                {
                    if (game.theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].openNeighbors == lowestMoves)
                    {
                        game.theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].visited = true;
                        attemptedMoves++;
                        knightTour(x + 2, y + 1);
                    }
                }
                else if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 2 >= 0)
                {
                    if (game.theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].openNeighbors == lowestMoves)
                    {
                        game.theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].visited = true;
                        attemptedMoves++;
                        knightTour(x - 1, y - 2);
                    }
                }
                else if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 2 < boardSize)
                {
                    if (game.theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].openNeighbors == lowestMoves)
                    {
                        game.theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].visited = true;
                        attemptedMoves++;
                        knightTour(x - 1, y + 2);
                    }
                }
                else if (currentCell.RowNumber + 1 < boardSize && currentCell.ColumnNumber - 2 >= 0)
                {
                    if (game.theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].openNeighbors == lowestMoves)
                    {
                        game.theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].visited = true;
                        attemptedMoves++;
                        knightTour(x + 1, y - 2);
                    }
                }
                else if (currentCell.RowNumber + 1 < boardSize && currentCell.ColumnNumber + 2 < boardSize)
                {
                    if (game.theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].openNeighbors == lowestMoves)
                    {
                        game.theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].visited = true;
                        attemptedMoves++;
                        knightTour(x + 1, y + 2);
                    }
                }
            }
            else
            {
                Console.Out.WriteLine("The knight has completed it's tour in " + attemptedMoves + " moves!");
            }
        }
    }
}
