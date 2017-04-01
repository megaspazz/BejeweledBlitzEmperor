using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    abstract class GameBot : Bot
    {
        public delegate Move[] MoveSelector(Move[] moves);
        
        private MoveSelector _moveSel;

        public GameBot(MoveSelector moveSelFcn)
        {
            _moveSel = moveSelFcn;
        }

        public override void RunSingle()
        {
            GemBoard board = ScreenIO.GetBoard();
            Move[] moves = board.GetMoves();
            if (moves.Length == 0)
            {
                return;
            }

            Move[] makeMoves = _moveSel.Invoke(moves);
            foreach (Move mv in makeMoves)
            {
                Point prev = System.Windows.Forms.Cursor.Position;
                ScreenIO.MakeMove(mv);
                System.Windows.Forms.Cursor.Position = prev;
            }
        }
    }
}
