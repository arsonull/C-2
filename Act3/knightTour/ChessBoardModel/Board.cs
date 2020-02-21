using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    public class Board
    {
        public int size { get; set; }

        public Cell[,] theGrid;

        public Board(int s)
        {
            size = s;

            theGrid = new Cell[size, size];
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }
        public void MarkNextLegalMove(Cell currentCell, string chessPiece)
        {
            for (int r= 0; r < size; r++)
            {
                for (int c = 0; c < size; c++)
                {
                    theGrid[r, c].LegalNextMove = false;
                }
            }
            //find legal moves
            switch(chessPiece)
            {
                case "Knight":
                    if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber - 2 >= 0 && currentCell.ColumnNumber + 1 < size)
                    {
                        theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 2 < size  && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 2 < size && currentCell.ColumnNumber + 1 < size)
                    {
                        theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber - 2 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 2 < size)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 1 < size && currentCell.ColumnNumber - 2 >= 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 1 < size && currentCell.ColumnNumber + 2 < size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    }
                    break;
                case "King":
                    if (currentCell.RowNumber + 1 < size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 1 < size && currentCell.ColumnNumber + 1 < size)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber + 1 < size && currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber + 1 < size)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (currentCell.RowNumber - 1 >= 0 && currentCell.ColumnNumber -1 >= 0)
                    {
                        theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    if (currentCell.ColumnNumber + 1 < size)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    }
                    if (currentCell.ColumnNumber - 1 >= 0)
                    {
                        theGrid[currentCell.RowNumber, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    }
                    break;
                case "Bishop":
                    for (int l = 0; l < size; l++)
                    {
                        int i = l + 1;
                        if (currentCell.RowNumber + i < size &&
                            currentCell.ColumnNumber + i < size)
                        {
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber + i]
                                .LegalNextMove = true;
                        }
                        if (currentCell.RowNumber - i >= 0 &&
                            currentCell.ColumnNumber - i >= 0)
                        {
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber - i]
                                .LegalNextMove = true;
                        }
                        if (currentCell.RowNumber + i + 1 < size &&
                            currentCell.ColumnNumber - i >= 0)
                        {
                            theGrid[currentCell.RowNumber + i, currentCell.ColumnNumber - i]
                                .LegalNextMove = true;
                        }
                        if (currentCell.RowNumber - i >= 0 &&
                            currentCell.ColumnNumber + i < size)
                        {
                            theGrid[currentCell.RowNumber - i, currentCell.ColumnNumber + i]
                                .LegalNextMove = true;
                        }
                    }
                    break;
                case "Rook":
                    for (int i = 0; i < size; i++)
                    {
                        if (currentCell.RowNumber + i + 1 < size)
                        {
                            theGrid[currentCell.RowNumber + i + 1, currentCell.ColumnNumber].
                                LegalNextMove = true;
                        }
                        if (currentCell.RowNumber - i - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber - i - 1, currentCell.ColumnNumber].
                                LegalNextMove = true;
                        }
                        if (currentCell.ColumnNumber + i + 1 < size)
                        {
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + i + 1].
                                LegalNextMove = true;
                        }
                        if (currentCell.ColumnNumber - i - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber - i - 1].
                                LegalNextMove = true;
                        }
                    }
                    break;
                case "Queen":
                    for (int i = 0; i < size; i++)
                    {
                        if (currentCell.RowNumber + i + 1 < size)
                        {
                            theGrid[currentCell.RowNumber + i + 1, currentCell.ColumnNumber].
                                LegalNextMove = true;
                        }
                        if (currentCell.RowNumber - i - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber - i - 1, currentCell.ColumnNumber].
                                LegalNextMove = true;
                        }
                        if (currentCell.ColumnNumber + i + 1 < size)
                        {
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber + i + 1].
                                LegalNextMove = true;
                        }
                        if (currentCell.ColumnNumber - i - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber, currentCell.ColumnNumber - i - 1].
                                LegalNextMove = true;
                        }
                        if (currentCell.RowNumber + i + 1 < size &&
                            currentCell.ColumnNumber + i + 1 < size)
                        {
                            theGrid[currentCell.RowNumber + i + 1, currentCell.ColumnNumber + i + 1]
                                .LegalNextMove = true;
                        }
                        if (currentCell.RowNumber - i - 1 >= 0 &&
                            currentCell.ColumnNumber - i - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber - i - 1, currentCell.ColumnNumber - i - 1]
                                .LegalNextMove = true;
                        }
                        if (currentCell.RowNumber + i + 1 < size &&
                            currentCell.ColumnNumber - i - 1 >= 0)
                        {
                            theGrid[currentCell.RowNumber + i + 1, currentCell.ColumnNumber - i - 1]
                                .LegalNextMove = true;
                        }
                        if (currentCell.RowNumber - i - 1 >= 0 &&
                            currentCell.ColumnNumber + i + 1 < size)
                        {
                            theGrid[currentCell.RowNumber - i - 1, currentCell.ColumnNumber + i + 1]
                                .LegalNextMove = true;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
