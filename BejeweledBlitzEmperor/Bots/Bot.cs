using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejeweledBlitzEmperor
{
    abstract class Bot
    {
        public bool Running { get; set; }

        private bool _stop;

        public abstract void RunSingle();
        
        public virtual bool RunTimedAsync(int ms)
        {
            if (this.Running)
            {
                return false;
            }

            this.Running = true;
            _stop = false;

            Task.Factory.StartNew(() =>
            {
                RunTimed(ms);
            });

            return true;
        }

        public virtual void RunTimed(int ms)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (!_stop && sw.ElapsedMilliseconds < ms)
            {
                RunSingle();
            }

            this.Running = false;
        }

        public void StopAsync()
        {
            _stop = true;
        }
    }
}
