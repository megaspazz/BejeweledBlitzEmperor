﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace BejeweledBlitzEmperor
{
    static class InputWrapper
    {
        private static InputSimulator _sim = new InputSimulator();

        public static void LeftClick(Point pt)
        {
            Cursor.Position = pt;
            _sim.Mouse.LeftButtonClick();
        }

        public static void LeftClick(int x, int y)
        {
            LeftClick(new Point(x, y));
        }

        public static void ClickAndDrag(Point pt0, Point ptf)
        {
            Cursor.Position = pt0;
            _sim.Mouse.LeftButtonDown();
            //System.Threading.Thread.Sleep(1000);
            Cursor.Position = ptf;
            _sim.Mouse.LeftButtonUp();
        }

        public static void ClickAndDrag(int x0, int y0, int xf, int yf)
        {
            //_sim.Mouse.MoveMouseToPositionOnVirtualDesktop(x0, y0);
            //_sim.Mouse.LeftButtonDown();
            //System.Threading.Thread.Sleep(1000);
            //_sim.Mouse.MoveMouseToPositionOnVirtualDesktop(xf, yf);
            //_sim.Mouse.LeftButtonUp();
            ClickAndDrag(new Point(x0, y0), new Point(xf, yf));
        }
    }
}
