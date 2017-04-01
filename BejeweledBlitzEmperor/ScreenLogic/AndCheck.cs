using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    class AndCheck : IScreenCheck
    {
        private IScreenCheck[] _checks;

        public AndCheck(params IScreenCheck[] c)
        {
            if (c == null || c.Length < 2)
            {
                throw new ArgumentException("AND logic requires at least two parameters.");
            }
            _checks = c;
        }

        public bool Evaluate(Bitmap24 bmp24)
        {
            foreach (IScreenCheck isc in _checks)
            {
                if (!isc.Evaluate(bmp24))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
