using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    class NotCheck
    {
        private IScreenCheck _check;

        public NotCheck(IScreenCheck c)
        {
            if (c == null)
            {
                throw new ArgumentException("NOT logic requires at least non-null parameter.");
            }
            _check = c;
        }

        public bool Evaluate(Bitmap24 bmp24)
        {
            return !_check.Evaluate(bmp24);
        }
    }
}
