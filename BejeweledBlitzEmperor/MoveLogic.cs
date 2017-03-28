using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    static class MoveLogic
    {
        public static Move[] GetMoves(GemBoard board)
        {
            List<Move> moves = new List<Move>();

            /*
            // x.x configuration
            for (int x = 0; x + 2 < ScreenInput.BOARD_DIM; ++x)
            {
                for (int y = 0; y < ScreenInput.BOARD_DIM; ++y)
                {
                    if (board.Get(x, y) == Gem.None)
                    {
                        continue;
                    }

                    if (board.Get(x, y) == board.Get(x + 2, y))
                    {
                        if (board.Get(x + 1, y - 1) == board.Get(x, y))
                        {
                            moves.Add(new Move(x + 1, y - 1, x, y));
                        }
                        if (board.Get(x + 1, y + 1) == board.Get(x, y))
                        {
                            moves.Add(new Move(x + 1, y + 1, x, y));
                        }
                    }
                }
            }

            // .xx. configuration
            for (int x = 0; x + 1 < ScreenInput.BOARD_DIM; ++x)
            {
                for (int y = 0; y < ScreenInput.BOARD_DIM; ++y)
                {
                    if (board.Get(x, y) == Gem.None)
                    {
                        continue;
                    }

                    if (board.Get(x, y) == board.Get(x + 1, y))
                    {

                    }
                }
            }
            */

            // horizontal swap

            return moves.ToArray();
        }

        //public static Gem GetGem(Gem[,] board, int x, int y)
        //{
        //    if (x >= 0 && x < ScreenInput.BOARD_DIM && y >= 0 && y < ScreenInput.BOARD_DIM)
        //    {
        //        return board[x, y];
        //    } else
        //    {
        //        return Gem.None;
        //    }
        //}

        //private class MoveHelper
        //{
        //    private Gem[,] _board;

        //    public MoveHelper(Gem[,] b)
        //    {
        //        _board = b;
        //    }

        //    public static Move[] GetMoves(Gem[,] board)
        //    {
        //        List<Move> moves = new List<Move>();

        //        // x.x configuration
        //        for (int x = 0; x + 2 < ScreenInput.BOARD_DIM; ++x)
        //        {
        //            for (int y = 0; y < ScreenInput.BOARD_DIM; ++y)
        //            {
        //                if (GetGem(x, y) == Gem.None)
        //                {
        //                    continue;
        //                }

        //                if (GetGem(x, y) == GetGem(x + 2, y))
        //                {
        //                    if (GetGem(x + 1, y - 1) == GetGem(x, y))
        //                    {
        //                        moves.Add(new Move(x + 1, y - 1, x, y));
        //                    }
        //                    if (GetGem(x + 1, y + 1) == GetGem(x, y))
        //                    {
        //                        moves.Add(new Move(x + 1, y + 1, x, y));
        //                    }
        //                }
        //            }
        //        }

        //        // .xx. configuration
        //        for (int x = 0; x + 1 < ScreenInput.BOARD_DIM; ++x)
        //        {
        //            for (int y = 0; y < ScreenInput.BOARD_DIM; ++y)
        //            {
        //                if (GetGem(x, y) == Gem.None)
        //                {
        //                    continue;
        //                }

        //                if (GetGem(x, y) == GetGem(x + 1, y))
        //                {

        //                }
        //            }
        //        }

        //        return moves.ToArray();
        //    }

        //    public static Gem GetGem(int x, int y)
        //    {
        //        if (x >= 0 && x < ScreenInput.BOARD_DIM && y >= 0 && y < ScreenInput.BOARD_DIM)
        //        {
        //            return _board[x, y];
        //        }
        //        else
        //        {
        //            return Gem.None;
        //        }
        //    }
        //}
    }

    class Move
    {
        public Point From { get; set; }
        public Point To { get; set; }

        public Move(Point f, Point t)
        {
            this.From = f;
            this.To = t;
        }

        public Move(int xf, int yf, int xt, int yt)
            : this(new Point(xf, yf), new Point(xt, yt))
        { }
    }
}
