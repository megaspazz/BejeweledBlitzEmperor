﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    abstract class GameBot
    {
        public delegate Move[] MoveSelector(Move[] moves);

        public bool Running { get; set; }

        private bool _stop;
        private MoveSelector _moveSel;

        public GameBot(MoveSelector moveSelFcn)
        {
            _moveSel = moveSelFcn;
        }

        private static readonly Random RNG = new Random();
        public bool RunTimedAsync(int ms)
        {
            if (this.Running)
            {
                return false;
            }

            this.Running = true;
            _stop = false;

            Task.Factory.StartNew(() =>
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();

                while (!_stop && sw.ElapsedMilliseconds < ms)
                {
                    GemBoard board = ScreenIO.GetBoard();
                    Move[] moves = board.GetMoves();
                    if (moves.Length == 0)
                    {
                        continue;
                    }

                    Move[] makeMoves = _moveSel.Invoke(moves);
                    foreach (Move mv in makeMoves)
                    {
                        Point prev = System.Windows.Forms.Cursor.Position;
                        ScreenIO.MakeMove(mv);
                        System.Windows.Forms.Cursor.Position = prev;
                    }
                }

                this.Running = false;
            });

            return true;
        }

        public void StopAsync()
        {
            _stop = true;
        }
    }
}
