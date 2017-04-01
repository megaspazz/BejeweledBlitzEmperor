using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    class ScreenState
    {
        public delegate void SuccessAction();

        private IScreenCheck _check;
        private SuccessAction _act;

        public ScreenState(IScreenCheck chk, SuccessAction act)
        {
            _check = chk;
            _act = act;
        }

        public bool Execute(Bitmap24 bmp24)
        {
            if (_check.Evaluate(bmp24))
            {
                _act.Invoke();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
