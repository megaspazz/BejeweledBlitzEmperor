using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BejeweledBlitzEmperor
{
    static class ScreenIO
    {
        // Top-left corner of the game area
        // Hard-coded for Chrome browser in Windows 10 OS
        public static Point PT_BOARD = new Point(522, 348);
        public static Point OFF_BOARD = new Point(175, 109);

        public static Point OFF_MENU = new Point(-87, 333);
        public static Point OFF_RESUME = new Point(166, 240);

        public static Size SZ_GAME = new Size(760, 611);

        public static int BOX_SIZE = 40;
        public static int BOARD_DIM = 8;

        public static int[] CLR_WHITE = { 255, 255, 255 };
        public static int[] CLR_FLASH_CORNER = { 57, 21, 80 };

        // The type of Bot to use for the game itself
        private static GameBot _bot = new RandomBot();

        // States in order of execution
        private static ScreenState[] sTATES =
        {
            // Message Center popup screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(67, 40), new int[] { 222, 149, 45 }),
                    new PixelCheck(new Point(360, 27), new int[] { 168, 12, 78 }),
                    new PixelCheck(new Point(720, 29), new int[] { 141, 50, 71 })
                ),
                delegate()
                {
                    // X button to close Message Center popup
                    // May require a small pause before and after
                    Thread.Sleep(500);
                    Point orig = Cursor.Position;
                    ScreenIO.ClickRelativeToGame(678, 38);
                    Cursor.Position = orig;
                    Thread.Sleep(500);
                }
            ),

            // Illuminite popup screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(320, 205), new int[] { 237, 43, 55 }),
                    new PixelCheck(new Point(333, 242), new int[] { 253, 0, 0 }),
                    new PixelCheck(new Point(322, 305), new int[] { 255, 0, 4 })
                ),
                delegate()
                {
                    // X button to close Message Center popup
                    // Not sure if sleep is required, but added to be safe
                    Thread.Sleep(500);
                    Point orig = Cursor.Position;
                    ScreenIO.ClickRelativeToGame(671, 59);
                    Cursor.Position = orig;
                    Thread.Sleep(500);
                }
            ),

            // Progressive Ad popup screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(193, 608), new int[] { 101, 46, 56 }),
                    new PixelCheck(new Point(199, 272), new int[] { 61, 29, 30 }),
                    new PixelCheck(new Point(220, 308), new int[] { 250, 44, 58 })
                ),
                delegate()
                {
                    // X button to close Message Center popup
                    // Not sure if sleep is required, but added to be safe
                    Thread.Sleep(500);
                    Point orig = Cursor.Position;
                    ScreenIO.ClickRelativeToGame(673, 58);
                    Cursor.Position = orig;
                    Thread.Sleep(500);
                }
            ),

            // Friends popup screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(87, 30), new int[] { 217, 106, 149 }),
                    new PixelCheck(new Point(378, 9), new int[] { 18, 139, 250 }),
                    new PixelCheck(new Point(641, 21), new int[] { 222, 149, 45 })
                ),
                delegate()
                {
                    // X button to close Friends popup
                    // Sleep is probably not required, but added to be safe
                    Thread.Sleep(500);
                    Point orig = Cursor.Position;
                    ScreenIO.ClickRelativeToGame(677, 35);
                    Cursor.Position = orig;
                    Thread.Sleep(500);
                }
            ),
            
            // New Rank popup screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(212, 123), new int[] { 116, 37, 61 }),
                    new PixelCheck(new Point(378, 114), new int[] { 207, 147, 64 }),
                    new PixelCheck(new Point(551, 123), new int[] { 236, 163, 56 })
                ),
                delegate()
                {
                    // Continue button to close New Rank popup
                    Point orig = Cursor.Position;
                    ScreenIO.ClickRelativeToGame(457, 414);
                    Cursor.Position = orig;
                }
            ),

            // Awesome Game overlay screen
            // Should be before the In-game screen in the state order
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(300, 274), new int[] { 112, 31, 197 }),
                    new PixelCheck(new Point(329, 275), new int[] { 206, 116, 235 }),
                    new PixelCheck(new Point(384, 233), new int[] { 151, 10, 219 })
                ),
                delegate()
                {
                    // No Thanks button to close Awesome Game overlay
                    // May require delays to close the popup properly
                    Thread.Sleep(2500);
                    Point orig = Cursor.Position;
                    ScreenIO.ClickRelativeToGame(329, 406);
                    Cursor.Position = orig;
                    Thread.Sleep(2500);
                }
            ),

            // Rare Gem screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(61, 111), new int[] { 203, 74, 99 }),
                    new PixelCheck(new Point(277, 143), new int[] { 247, 254, 198 }),
                    new PixelCheck(new Point(463, 121), new int[] { 222, 149, 45 })
                ),
                delegate() {
                    // No Thanks button
                    Point orig = Cursor.Position;
                    ScreenIO.ClickRelativeToGame(203, 442);
                    Cursor.Position = orig;
                }
            ),

            // End game screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(29, 94), new int[] { 255, 253, 137 }),
                    new PixelCheck(new Point(257, 83), new int[] { 0, 219, 250 }),
                    new PixelCheck(new Point(501, 95), new int[] { 204, 108, 1 })
                ),
                delegate()
                {
                    // X button to close friends popup
                    Point orig = Cursor.Position;
                    ScreenIO.ClickRelativeToGame(264, 531);
                    Cursor.Position = orig;
                }
            ),

            // Main screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(107, 113), new int[] { 228, 169, 102 }),
                    new PixelCheck(new Point(264, 90), new int[] { 14, 89, 239 }),
                    new PixelCheck(new Point(416, 115), new int[] { 224, 155, 86 })
                ),
                delegate()
                {
                    // Play Now button 
                    Point orig = Cursor.Position;
                    ScreenIO.ClickRelativeToGame(265, 414);
                    Cursor.Position = orig;

                    // Play a game
                    //_bot.RunTimed(80000);
                }
            ),

            // In-game screen
            // Should be after the Awesome Game popup screen in the state order
            new ScreenState(
                new OrCheck(
                    new AndCheck(
                        new PixelCheck(new Point(37, 108), new int[] { 225, 122, 50 }),
                        new PixelCheck(new Point(146, 117), new int[] { 249, 142, 62 })
                    ),
                    new AndCheck(
                        new PixelCheck(new Point(54, 390), new int[] { 255, 161, 78 }),
                        new PixelCheck(new Point(128, 398), new int[] { 255, 161, 80 })
                    )
                ),
                delegate()
                {
                    // Make one move
                    _bot.RunSingle();
                }
            ),
        };

        // Measured from center, which is rounded up for even number box size.
        // In the diagram below, the x's are potential centers, and the o is the actual center
        // . . . . . .
        // . . . . . .
        // . . x x . .
        // . . x o . .
        // . . . . . .
        // . . . . . .
        public static Point[] PTS_READ =
        {
            new Point(-4, -4),
            new Point(3, -4),
            new Point(-5, 4),
            new Point(4, 4),
            new Point(-1, -1),
            new Point(0, -1),
            new Point(-1, 0),
            new Point(0, 0),
        };

        internal static ScreenState[] STATES
        {
            get
            {
                return sTATES;
            }

            set
            {
                sTATES = value;
            }
        }

        public static Rectangle GetBoardRectangle()
        {
            return new Rectangle(PT_BOARD.X, PT_BOARD.Y, BOX_SIZE * BOARD_DIM, BOX_SIZE * BOARD_DIM);
        }

        public static Rectangle GetBoxRectangle(int gridX, int gridY)
        {
            return new Rectangle(PT_BOARD.X + (gridX * BOX_SIZE), PT_BOARD.Y + (gridY * BOX_SIZE), BOX_SIZE, BOX_SIZE);
        }

        public static Point GetBoxCenter(Point pt)
        {
            return GetBoxCenter(pt.X, pt.Y);
        }

        public static Point GetBoxCenter(int gridX, int gridY)
        {
            return new Point((gridX * BOX_SIZE) + (BOX_SIZE / 2), (gridY * BOX_SIZE) + (BOX_SIZE / 2));
        }

        public static Point GetBoxCenterOnScreen(Point pt)
        {
            return GetBoxCenterOnScreen(pt.X, pt.Y);
        }

        public static Point GetBoxCenterOnScreen(int gridX, int gridY)
        {
            return new Point(PT_BOARD.X + (gridX * BOX_SIZE) + (BOX_SIZE / 2), PT_BOARD.Y + (gridY * BOX_SIZE) + (BOX_SIZE / 2));
        }

        public static Bitmap GetBoardBitmap()
        {
            while (true)
            {
                Bitmap bmp = WindowWrapper.ScreenCapture(GetBoardRectangle());
                if (bmp != null)
                {
                    return bmp;
                }
            }
        }

        public static Bitmap GetBoxBitmap(int gridX, int gridY)
        {
            return WindowWrapper.ScreenCapture(GetBoxRectangle(gridX, gridY));
        }

        public static Signature GetSignature(Bitmap24 bmp24, int gridX, int gridY)
        {
            bmp24.Lock();

            int[] sig = PTS_READ.Select(offset =>
            {
                int[] px = bmp24.GetPixel((gridX * BOX_SIZE) + (BOX_SIZE / 2) + offset.X, (gridY * BOX_SIZE) + (BOX_SIZE / 2) + offset.Y);
                return Signature.RGBToInt(px);
            }).ToArray();

            return new Signature(sig);
        }

        public static GemBoard GetBoard()
        {
            Gem[,] board = new Gem[BOARD_DIM, BOARD_DIM];
            using (Bitmap bmp = GetBoardBitmap())
            {
                using (Bitmap24 bmp24 = Bitmap24.FromImage(bmp))
                {
                    for (int x = 0; x < BOARD_DIM; ++x)
                    {
                        for (int y = 0; y < BOARD_DIM; ++y)
                        {
                            Signature sig = GetSignature(bmp24, x, y);
                            board[x, y] = GemParser.Get(sig);
                        }
                    }
                }
            }
            return GemBoard.FromGemArray(board);
        }

        public static void ClickRelativeToBoard(Point pt)
        {
            ClickRelativeToBoard(pt.X, pt.Y);
        }

        public static void ClickRelativeToBoard(int x, int y)
        {
            InputWrapper.LeftClick(PT_BOARD.X + x, PT_BOARD.Y + y);
        }

        public static void ClickRelativeToGame(Point pt)
        {
            ClickRelativeToBoard(pt.X, pt.Y);
        }

        public static void ClickRelativeToGame(int x, int y)
        {
            Point tl = GetGameTopLeft();
            InputWrapper.LeftClick(tl.X + x, tl.Y + y);
        }

        public static void MakeMove(Move mv)
        {
            InputWrapper.ClickAndDrag(GetBoxCenterOnScreen(mv.From), GetBoxCenterOnScreen(mv.To));
        }

        public static Point FindFlashWindowTopLeft()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                Rectangle bounds = screen.Bounds;
                using (Bitmap bmp = WindowWrapper.ScreenCapture(bounds))
                {
                    using (Bitmap24 bmp24 = Bitmap24.FromImage(bmp))
                    {
                        bmp24.Lock();
                        for (int x = 1; x < bounds.Width; ++x)
                        {
                            for (int y = 1; y < bounds.Height; ++y)
                            {
                                int[] pxLT = bmp24.GetPixel(x - 1, y - 1);
                                int[] pxRT = bmp24.GetPixel(x, y - 1);
                                int[] pxLB = bmp24.GetPixel(x - 1, y);
                                int[] pxRB = bmp24.GetPixel(x, y);
                                if (Bitmap24.PixelEqual(pxLT, CLR_WHITE) && Bitmap24.PixelEqual(pxRT, CLR_WHITE) && Bitmap24.PixelEqual(pxLB, CLR_WHITE) && Bitmap24.PixelEqual(pxRB, CLR_FLASH_CORNER))
                                {
                                    return new Point(bounds.X + x, bounds.Y + y);
                                }
                            }
                        }
                    }
                }
            }
            return Point.Empty;    // return some flag that can't be a valid point
        }

        public static bool AutoSetBoardPoint()
        {
            Point pt = FindFlashWindowTopLeft();
            if (pt == Point.Empty)
            {
                return false;
            }

            PT_BOARD = new Point(pt.X + OFF_BOARD.X, pt.Y + OFF_BOARD.Y);
            return true;
        }

        public static Point GetGameTopLeft()
        {
            return new Point(PT_BOARD.X - OFF_BOARD.X, PT_BOARD.Y - OFF_BOARD.Y);
        }

        public static Rectangle GetGameRect()
        {
            return new Rectangle(GetGameTopLeft(), SZ_GAME);
        }

        public static Bitmap GetGameBitmap()
        {
            while (true)
            {
                Bitmap bmp = WindowWrapper.ScreenCapture(GetGameRect());
                if (bmp != null)
                {
                    return bmp;
                }
            }
        }

        public static void ExecuteAllStatesAsync()
        {
            Task.Factory.StartNew(() =>
            {
                ExecuteAllStates();
            });
        }

        public static void ExecuteAllStates()
        {
            using (Bitmap bmp = ScreenIO.GetGameBitmap())
            {
                using (Bitmap24 bmp24 = Bitmap24.FromImage(bmp))
                {
                    bmp24.Lock();
                    foreach (ScreenState ss in STATES)
                    {
                        ss.Execute(bmp24);
                    }
                }
            }
        }

        public static void ExecuteAllStatesForever()
        {
            while (true)
            {
                ExecuteAllStates();
            }
        }

        public static void ExecuteAllStatesForeverAsync()
        {
            Task.Factory.StartNew(() =>
            {
                ExecuteAllStatesForever();
            });
        }

        public static void ExecuteFirstState()
        {
            using (Bitmap bmp = ScreenIO.GetGameBitmap())
            {
                using (Bitmap24 bmp24 = Bitmap24.FromImage(bmp))
                {
                    bmp24.Lock();
                    foreach (ScreenState ss in STATES)
                    {
                        if (ss.Execute(bmp24))
                        {
                            break;
                        }
                    }
                }
            }
        }

        public static void ExecuteFirstStateForever()
        {
            while (true)
            {
                ExecuteFirstState();
            }
        }

        public static void ExecuteFirstStateForeverAsync()
        {
            Task.Factory.StartNew(() =>
            {
                ExecuteFirstStateForever();
            });
        }
    }

    public sealed class Signature
    {
        public int[] Sig { get; private set; }

        private int? _hash;

        public Signature(int[] sig)
        {
            this.Sig = sig;
        }

        public bool CompareWithinTolerance(Signature rhs, int tolerance)
        {
            if (this.Sig.Length != rhs.Sig.Length)
            {
                throw new ArgumentException("Signature lengths don't match.");
            }

            for (int i = 0; i < this.Sig.Length; ++i)
            {
                int[] lhsPx = IntToRGB(this.Sig[i]);
                int[] rhsPx = IntToRGB(rhs.Sig[i]);
                for (int j = 0; j < lhsPx.Length; ++j)
                {
                    if (Math.Abs(lhsPx[j] - rhsPx[j]) > tolerance)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static int RGBToInt(int[] px)
        {
            return RGBToInt(px[0], px[1], px[2]);
        }

        public static int RGBToInt(int r, int g, int b)
        {
            return (r << 16) | (g << 8) | b;
        }

        public static int[] IntToRGB(int sig)
        {
            return new int[]
            {
                sig >> 16,
                (sig >> 8) % 256,
                sig % 256,
            };
        }

        public override int GetHashCode()
        {
            if (!_hash.HasValue)
            {
                int h = 0;
                foreach (int v in this.Sig)
                {
                    h = unchecked((h * 31769) + v);
                }
                _hash = h;
            }
            return _hash.Value;
        }

        public override bool Equals(object obj)
        {
            Signature rhs = (Signature)obj;
            return this.Sig.SequenceEqual(rhs.Sig);
        }
    }
}
