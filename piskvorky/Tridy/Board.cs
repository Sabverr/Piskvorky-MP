using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piskvorky.Tridy
{
    public class Board
    {
        public const int MinSize = 5;
        private readonly Symbol[,] cells;

        public int Size { get; }
        public int MoveCount { get; private set; }

        public Board(int size)
        {
            if (size < MinSize)
                throw new ArgumentOutOfRangeException("size",
                    "Minimální velikost desky je " + MinSize + "x" + MinSize + ".");

            Size = size;
            cells = new Symbol[size, size];   
        }

        public Symbol this[int row, int col]
        {
            get { return cells[row, col]; }
        }

        public bool IsInside(int row, int col)
        {
            return row >= 0 && row < Size && col >= 0 && col < Size;
        }

        public bool IsEmpty(int row, int col)
        {
            return IsInside(row, col) && cells[row, col] == Symbol.None;
        }
        public bool PlaceSymbol(int row, int col, Symbol symbol)
        {
            if (symbol == Symbol.None || !IsEmpty(row, col))
                return false;

            cells[row, col] = symbol;
            MoveCount++;
            return true;
        }

        public bool IsFull()
        {
            return MoveCount == Size * Size;
        }
    }
}
