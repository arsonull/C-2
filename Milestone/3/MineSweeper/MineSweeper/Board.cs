using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class Board
    {
        public int size { get; set; }
        public int difficulty { get; set; }
        public int numBombs { get; set; }
        public Cell[,] grid;

        public Board(int s)
        {
            size = s;
            numBombs = 0;

            grid = new Cell[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    grid[i, j] = new Cell(i, j);
                }
            }
        }

        public void createBombs(int d)
        {
            Random rand = new Random();

            int bombs = d * size;

            for (int b = 0; b < bombs; b++)
            {
                int x = rand.Next(size);
                int y = rand.Next(size);
                if (!grid[x, y].Live)
                {
                    grid[x, y].Live = true;
                    numBombs += 1;
                }
                else
                {
                    b--;
                }
            }
        }
        //This is not being used
        /*
        public void checkNeighbors()
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    int n = 0;
                    if (r < size - 1)
                    {
                        if (grid[r + 1, c].Live) { n++; }
                        if (r < size - 1 && c < size - 1) { if (grid[r + 1, c + 1].Live) { n++; } }
                        if (c > 0)
                        {
                            if (r < size - 1) { if (grid[r + 1, c - 1].Live) { n++; } }
                            if (grid[r, c - 1].Live) { n++; }
                        }
                        if (r > 0)
                        {
                            if (c < size - 1) { if (grid[r - 1, c + 1].Live) { n++; } }
                            if (grid[r - 1, c].Live) { n++; }
                        }
                        if (r > 0 && c > 0) { if (grid[r - 1, c - 1].Live) { n++; } }
                        if (c < size - 1) { if (grid[r, c + 1].Live) { n++; } }
                        if (n == 8 && grid[r, c].Live) { n++; }
                        grid[r, c].liveNeighbours = n;
                    }
                }
            }
        }*/
        public void checkNeighbors2()
        {
            for (int r = 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    int n = 0;
                    if(r < size - 1)
                    {
                        if (grid[r + 1, c].Live) { n++; }
                    }
                    if (r < size - 1 && c < size - 1) { if (grid[r + 1, c + 1].Live) { n++; } }
                    if (c > 0 && r < size - 1)
                    {
                        if (grid[r + 1, c - 1].Live) { n++; }
                    }
                    if (r > 0 && c < size - 1)
                    {
                        if (grid[r - 1, c + 1].Live) { n++; }
                    }
                    if (r > 0)
                    {
                        if (grid[r - 1, c].Live) { n++; }
                    }
                    if (c > 0)
                    {
                        if (grid[r, c - 1].Live) { n++; }
                    }
                    if (r > 0 && c > 0) { if (grid[r - 1, c - 1].Live) { n++; } }
                    if (c < size - 1) { if (grid[r, c + 1].Live) { n++; } }
                    if (n == 8 && grid[r, c].Live) { n++; }
                    grid[r, c].liveNeighbours = n;
                }
            }
        }
        public void floodFill(int r, int c)
        {
            if (r < 0 || c < 0) { return; }
            if (r >= size || c >= size) { return; }
            if (!grid[r, c].Live && grid[r, c].liveNeighbours == 0 && !grid[r,c].visited)
            {
                grid[r, c].visited = true;
                floodFill(r + 1, c);
                floodFill(r - 1, c);
                floodFill(r, c + 1);
                floodFill(r, c - 1);
                return;
            }
            else if (!grid[r, c].Live && !grid[r,c].visited)
            {
                grid[r, c].visited = true;
                return;
            }
            else
            {
                return;
            }
        }
    }
}
