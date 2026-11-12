
namespace piskvorky.Tridy
{
    public class Game
    {
        public Board Board { get; }
        public Player Player1 { get; }
        public Player Player2 { get; }

        public Player CurrentPlayer { get; private set; }
        public Player? Winner { get; private set; }

        public bool IsGameOver { get; private set; }
        public bool IsDraw { get; private set; }

        public Game(int size)
        {
            Board = new Board(size);

            Player1 = new Player("Hráč 1", Symbol.X);
            Player2 = new Player("Hráč 2", Symbol.O);

            CurrentPlayer = Player1;
        }

        public bool MakeMove(int row, int col)
        {
            if (IsGameOver)
                return false;

            if (!Board.PlaceSymbol(row, col, CurrentPlayer.Symbol))
                return false;

            if (CheckWin(row, col))
            {
                Winner = CurrentPlayer;
                IsGameOver = true;
            }
            else if (Board.IsFull())
            {
                IsDraw = true;
                IsGameOver = true;
            }
            else
            {
                CurrentPlayer = (CurrentPlayer == Player1) ? Player2 : Player1;
            }

            return true;
        }

        private bool CheckWin(int row, int col)
        {
            Symbol symbol = Board[row, col];

            // horizontalni 
            if (CountLine(row, col, 0, 1, symbol) >= 5)
                return true;

            // vertikalni
            if (CountLine(row, col, 1, 0, symbol) >= 5)
                return true;

            // zleva nahore, doprava dolu
            if (CountLine(row, col, 1, 1, symbol) >= 5)
                return true;

            // zprava nahore, doleva dolu
            if (CountLine(row, col, 1, -1, symbol) >= 5)
                return true;

            return false;
        }

        private int CountLine( int row, int col, int rowDirection, int colDirection, Symbol symbol)
        {
            int count = 1;
            count += CountDirection(row, col, rowDirection, colDirection, symbol);
            count += CountDirection(row, col, -rowDirection, -colDirection, symbol);
            //v obou smerech (horizontalne doleva/doprava, vertikalne nahoru/dolu, diagonaly)
            return count;
        }

        private int CountDirection(int row, int col, int rowDirection, int colDirection, Symbol symbol)
        {
            int count = 0;

            int r = row + rowDirection; //starting row 
            int c = col + colDirection; //starting column

            while (Board.IsInside(r, c) && Board[r, c] == symbol)
            {
                count++;

                r += rowDirection;
                c += colDirection;
            }
            return count;
        }
    }
}
