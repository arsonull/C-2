using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stay = true;
            do
            {
                bool gameOver = false;
                Console.WriteLine("Please enter in the size of the board you want");
                int size = int.Parse(Console.ReadLine());
                Board game = new Board(size);
                Console.WriteLine("What would you like the difficulty to be? 1-9");
                int diff = int.Parse(Console.ReadLine());
                int goal = (diff * 10) - size;
                int cleared = 0;
                game.createBombs(diff);
                game.checkNeighbors2();
                printBoard(game);

                while (!gameOver)
                {
                    Console.WriteLine("Please choose a row and then column");
                    try
                    {
                        int x = int.Parse(Console.ReadLine()) - 1;
                        int y = int.Parse(Console.ReadLine()) - 1;
                        if (game.grid[x, y].Live == true)
                        {
                            gameOver = true;
                            Console.WriteLine("You lose! Enter 1 to try again");
                            if (int.Parse(Console.ReadLine()) == 1) { break; }
                            else
                            {
                                stay = false;
                                break;
                            }
                        }
                        else if (cleared == goal - 1) //CHANGE THIS ITS ONLY TEMPORARY UNTIL VAR IS MADE
                        {
                            gameOver = true;
                            Console.WriteLine("You win!!! Enter 1 to play again");
                            if (int.Parse(Console.ReadLine()) == 1) { break; }
                            else
                            {
                                stay = false;
                                break;
                            }
                        }
                        else
                        {
                            game.grid[x, y].visited = true;
                            cleared++;
                            printBoard(game);
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Please enter a number, and then another number");
                    }
                    catch (IndexOutOfRangeException f)
                    {
                        Console.WriteLine("Please enter a number below the size that you set and not negative");
                    }
                }
            } while (stay);
        }

        public static void printBoard(Board board)
        {
            //int total = 0;
            for (int r = 0; r < board.size; r++)
            {
                for (int l = 0; l < board.size; l++)
                {
                    if (r == 0)
                    {
                        Console.Write("+-" + (l+1) + "-+");
                    }
                    else
                    {
                        Console.Write("+---+");
                    }
                }
                Console.WriteLine();
                for (int c = 0; c < board.size; c++)
                {
                    if(board.grid[r,c].visited)
                    {
                        Console.Write("| " + board.grid[r, c].liveNeighbours + " |");
                    }
                    else
                    {
                       Console.Write("|███|");
                    }
                    if(c == board.size - 1)
                    {
                        Console.Write(r + 1);
                    }
                }
                Console.WriteLine();
            }
            for (int f = 0; f < board.size; f++)
            {
                Console.Write("+---+");
            }
            Console.WriteLine();
        }
    }
}
