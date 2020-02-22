using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Cell
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public int openNeighbors { get; set; }
        public bool visited { get; set; }

        public bool CurrentlyOccupied { get; set; }

        public bool LegalNextMove { get; set; }

        public Cell(int r, int c)
        {
            RowNumber = r;
            ColumnNumber = c;
            visited = false;
        }
    }
}
