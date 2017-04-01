using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    class DriverBot : Bot
    {
        public override void RunSingle()
        {
            ScreenIO.ExecuteAllStates();
        }
    }
}
