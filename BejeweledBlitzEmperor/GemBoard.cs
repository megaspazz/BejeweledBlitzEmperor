using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    class GemBoard
    {
        private Gem[,] _board;

        private GemBoard(Gem[,] b)
        {
            _board = b;
        }

        public int XMax
        {
            get
            {
                return _board.GetLength(0);
            }
        }

        public int YMax
        {
            get
            {
                return _board.GetLength(1);
            }
        }

        //public Gem this[int x, int y]
        //{
        //    get
        //    {
        //        if (x >= 0 && x < this.Board.GetLength(0) && y >= 0 && y < this.Board.GetLength(1))
        //        {
        //            return this.Board[x, y];
        //        }
        //        else
        //        {
        //            return Gem.None;
        //        }
        //    }
        //}

        public GemColor GetColor(int x, int y)
        {
            if (x >= 0 && x < this.XMax && y >= 0 && y < this.YMax)
            {
                return _board[x, y].Color;
            }
            else
            {
                return GemColor.None;
            }
        }

        private static Point[] DIRS =
        {
            new Point(0, -1),
            new Point(1, 0),
            new Point(0, 1),
            new Point(-1, 0),
        };

        public Move[] GetMoves()
        {
            List<Move> moves = new List<Move>();

            // Basic moves to line up 3+ in a row
            for (int x = 0; x < this.XMax; ++x)
            {
                for (int y = 0; y < this.YMax; ++y)
                {
                    if (GetColor(x, y) == GemColor.Hypercube)
                    {
                        foreach (Point dir in DIRS)
                        {
                            int xf = x + dir.X;
                            int yf = y + dir.Y;
                            if (IsValidHypercubeSwap(xf, yf))
                            {
                                moves.Add(new Move(x, y, xf, yf));
                            }
                        }
                    }
                    else
                    {
                        if (x + 1 < this.XMax)
                        {
                            Swap(x, y, x + 1, y);
                            if (IsMatch(x, y) || IsMatch(x + 1, y))
                            {
                                moves.Add(new Move(x, y, x + 1, y));
                            }
                            Swap(x, y, x + 1, y);
                        }
                        if (y + 1 < this.YMax)
                        {
                            Swap(x, y, x, y + 1);
                            if (IsMatch(x, y) || IsMatch(x, y + 1))
                            {
                                moves.Add(new Move(x, y, x, y + 1));
                            }
                            Swap(x, y, x, y + 1);
                        }
                    }
                }
            }

            return moves.ToArray();
        }

        private bool IsMatch(int x0, int y0)
        {
            GemColor origColor = GetColor(x0, y0);
            if (origColor == GemColor.None)
            {
                return false;
            }

            int horiz = 1;
            for (int x = x0 - 1; GetColor(x, y0) == origColor; --x)
            {
                ++horiz;
            }
            for (int x = x0 + 1; GetColor(x, y0) == origColor; ++x)
            {
                ++horiz;
            }

            int vert = 1;
            for (int y = y0 - 1; GetColor(x0, y) == origColor; --y)
            {
                ++vert;
            }
            for (int y = y0 + 1; GetColor(x0, y) == origColor; ++y)
            {
                ++vert;
            }

            return (horiz >= 3) || (vert >= 3);
        }

        private bool IsValidHypercubeSwap(int x, int y)
        {
            GemColor gem = GetColor(x, y);
            return (gem != GemColor.None) && (gem != GemColor.Hypercube);
        }

        private void Swap(int x0, int y0, int xf, int yf)
        {
            Gem tmp = _board[x0, y0];
            _board[x0, y0] = _board[xf, yf];
            _board[xf, yf] = tmp;
        }

        public static GemBoard FromGemArray(Gem[,] board)
        {
            return new GemBoard(board);
        }
    }
}
