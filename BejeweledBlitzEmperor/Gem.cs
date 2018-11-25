using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    sealed class Gem
    {
        private static Dictionary<GemColor, Dictionary<GemType, Gem>> _gems = new Dictionary<GemColor, Dictionary<GemType, Gem>>();
        
        public GemColor Color { get; private set; }
        public GemType Type { get; private set; }

        private Gem(GemColor color, GemType type)
        {
            this.Color = color;
            this.Type = type;
        }

        static Gem()
        {
            IEnumerable<GemColor> colors = Enum.GetValues(typeof(GemColor)).Cast<GemColor>();
            IEnumerable<GemType> types = Enum.GetValues(typeof(GemType)).Cast<GemType>();
            foreach (GemColor color in colors)
            {
                Dictionary<GemType, Gem> map = new Dictionary<GemType, Gem>();
                foreach (GemType type in types)
                {
                    map[type] = new Gem(color, type);
                }
                _gems[color] = map;
            }
        }

        public static Gem Get(GemColor color, GemType type)
        {
            return _gems[color][type];
        }
    }
    
    enum GemColor
    {
        None,
        Red,
        Green,
        Blue,
        Yellow,
        Purple,
        Orange,
        White,
        Hypercube,
    }

    enum GemType
    {
        None,
        Basic,
        Coin,
        Fire,
        Glowing,
        X2,
        X3,
        X4,
        X5,
        X6,
        X7,
        X8,
        X9,
        X10,
        X11,
        X12,
        Hypercube
    }
}
