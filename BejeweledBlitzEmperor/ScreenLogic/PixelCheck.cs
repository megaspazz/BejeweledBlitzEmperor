using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    class PixelCheck : IScreenCheck
    {
        private Point _pt;
        private int[] _clr;

        public PixelCheck(Point p, int[] c)
        {
            _pt = p;
            _clr = c;
        }
        
        public bool Evaluate(Bitmap24 bmp24)
        {
            return Bitmap24.PixelEqual(bmp24.GetPixel(_pt), _clr);
        }
    }
}
