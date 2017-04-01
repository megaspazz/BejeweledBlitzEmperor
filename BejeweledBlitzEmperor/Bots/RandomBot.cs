using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    sealed class RandomBot : GameBot
    {
        private static readonly Random RNG = new Random();

        private static readonly MoveSelector _randomMoveFcn = delegate (Move[] moves)
        {
            return new Move[] { moves[RNG.Next(moves.Length)] };
        };

        public RandomBot() 
            : base(_randomMoveFcn)
        { }
    }
}
