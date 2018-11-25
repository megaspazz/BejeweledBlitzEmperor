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
        public static Point PT_BOARD = new Point(-1695, 294);
        public static Point OFF_BOARD = new Point(308, 150);

        public static Point OFF_PAUSE = new Point(922, 72);
        public static Point OFF_RESUME = new Point(483, 463);

        public static Size SZ_GAME = new Size(960, 640);

        public static int BOX_SIZE = 40;
        public static int BOARD_DIM = 8;

        public static int[] CLR_WHITE = { 255, 255, 255 };
        public static int[] CLR_FLASH_CORNER = { 50, 0, 77 };

        // The type of Bot to use for the game itself
        private static GameBot _bot = new RandomBot();

        // States in order of execution
        private static ScreenState[] _STATES =
        {
            // New Rank screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(303, 135), new int[] { 42, 116, 201 }),
                    new PixelCheck(new Point(647, 135), new int[] { 42, 24, 67 }),
                    new PixelCheck(new Point(657, 138), new int[] { 46, 123, 212 })
                ),
                delegate()
                {
                    // Continue button
                    ScreenIO.ReturnClickRelativeToGame(594, 431);
                }
            ),

            // Gem Explorers screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(297, 15), new int[] { 255, 255, 255 }),
                    new PixelCheck(new Point(448, 30), new int[] { 30, 199, 246 }),
                    new PixelCheck(new Point(681, 26), new int[] { 1, 101, 171 })
                ),
                delegate()
                {
                    // Back button
                    ScreenIO.ReturnClickRelativeToGame(339, 595);
                }
            ),
            
            // Events screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(431, 55), new int[] { 229, 140, 31 }),
                    new PixelCheck(new Point(545, 60), new int[] { 206, 118, 7 }),
                    new PixelCheck(new Point(479, 22), new int[] { 38, 6, 57 }),
                    new PixelCheck(new Point(467, 60), new int[] { 78, 12, 116 })
                ),
                delegate()
                {
                    // Back button
                    ScreenIO.ReturnClickRelativeToGame(675, 14);
                }
            ),

            // Bring Back the Competition screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(173, 69), new int[] { 255, 249, 87 }),
                    new PixelCheck(new Point(176, 72), new int[] { 214, 215, 231 }),
                    new PixelCheck(new Point(785, 513), new int[] { 92, 92, 168 }),
                    new PixelCheck(new Point(787, 518), new int[] { 192, 145, 31 })
                ),
                delegate()
                {
                    // Back button
                    ScreenIO.ReturnClickRelativeToGame(780, 67);
                }
            ),

            // Blitz Champions screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(184, 131), new int[] { 223, 176, 251 }),
                    new PixelCheck(new Point(417, 109), new int[] { 218, 113, 0 }),
                    new PixelCheck(new Point(792, 169), new int[] { 189, 30, 183 })
                ),
                delegate()
                {
                    // Leaderboard button
                    ScreenIO.ReturnClickRelativeToGame(314, 625);
                }
            ),

            // Weekly Leaderboard screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(215, 113), new int[] { 255, 255, 86 }),
                    new PixelCheck(new Point(511, 92), new int[] { 216, 114, 0 }),
                    new PixelCheck(new Point(748, 162), new int[] { 229, 46, 223 })
                ),
                delegate()
                {
                    // Play button
                    ScreenIO.ReturnClickRelativeToGame(474, 502);
                }
            ),

            // Rare Gem screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(254, 116), new int[] { 241, 238, 255}),
                    new PixelCheck(new Point(708, 533), new int[] { 44, 7, 98})
                ),
                delegate() {
                    // No Thanks button
                    ScreenIO.ReturnClickRelativeToGame(392, 495);
                }
            ),

            // End game screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(294, 245), new int[] { 253, 247, 253}),
                    new PixelCheck(new Point(640, 585), new int[] { 140, 82, 145 })
                ),
                delegate()
                {
                    // Play Again button
                    ScreenIO.ReturnClickRelativeToGame(471, 581);
                    Thread.Sleep(1000);
                }
            ),

            // Main screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(257, 113), new int[] { 164, 121, 101 }),
                    new PixelCheck(new Point(703, 490), new int[] { 248, 221, 22 })
                ),
                delegate()
                {
                    // Play Now button 
                    ScreenIO.ReturnClickRelativeToGame(471, 512);

                    // Play a game
                    //_bot.RunTimed(80000);
                }
            ),

            // Game Paused screen
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(229, 78), new int[] { 241, 238, 255 }),
                    new PixelCheck(new Point(471, 123), new int[] { 22, 240, 244 }),
                    new PixelCheck(new Point(720, 123), new int[] { 52, 71, 119 })
                ),
                delegate()
                {
                    // Resume button 
                    ScreenIO.ReturnClickRelativeToGame(ScreenIO.OFF_RESUME);
                }
            ),

            // Awesome Game overlay screen
            // Should be before the In-game screen in the state order
            new ScreenState(
                new AndCheck(
                    new PixelCheck(new Point(524, 219), new int[] { 144, 10, 213 }),
                    new PixelCheck(new Point(483, 233), new int[] { 4, 31, 0 }),
                    new PixelCheck(new Point(469, 282), new int[] { 255, 36, 110 }),
                    new PixelCheck(new Point(466, 251), new int[] { 255, 186, 23 })
                ),
                delegate()
                {
                    // No Thanks button to close Awesome Game overlay
                    // May require delays to close the popup properly
                    Thread.Sleep(2500);
                    ScreenIO.ReturnClickRelativeToGame(471, 392);
                    Thread.Sleep(2500);
                }
            ),

            // In-game screen
            // Should be after the Awesome Game popup screen in the state order
            new ScreenState(
                new OrCheck(
                    new AndCheck(
                        new PixelCheck(new Point(304, 109), new int[] { 255, 254, 66 }),
                        new PixelCheck(new Point(636, 513), new int[] { 241, 235, 66 })
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

            // +----------------------------+
            // |  OLD UNUSED STATES BELOW!  |
            // +----------------------------+
            
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
                    new PixelCheck(new Point(235, 139), new int[] { 255, 232, 72 }),
                    new PixelCheck(new Point(338, 147), new int[] { 255, 227, 78 }),
                    new PixelCheck(new Point(433, 141), new int[] { 255, 238, 65 })
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
            )
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
                return _STATES;
            }
            set
            {
                _STATES = value;
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
            ClickRelativeToGame(pt.X, pt.Y);
        }

        public static void ClickRelativeToGame(int x, int y)
        {
            Point tl = GetGameTopLeft();
            InputWrapper.LeftClick(tl.X + x, tl.Y + y);
        }

        public static void ReturnClickRelativeToGame(Point pt)
        {
            ReturnClickRelativeToGame(pt.X, pt.Y);
        }

        public static void ReturnClickRelativeToGame(int x, int y)
        {
            Point orig = Cursor.Position;
            ScreenIO.ClickRelativeToGame(x, y);
            Cursor.Position = orig;
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

        public bool CompareWithinTolerance(Signature rhs, int tolerance, int maxMismatches)
        {
            if (this.Sig.Length != rhs.Sig.Length)
            {
                throw new ArgumentException("Signature lengths don't match.");
            }

            int mismatches = 0;
            for (int i = 0; i < this.Sig.Length; ++i)
            {
                int[] lhsPx = IntToRGB(this.Sig[i]);
                int[] rhsPx = IntToRGB(rhs.Sig[i]);
                for (int j = 0; j < lhsPx.Length; ++j)
                {
                    if (Math.Abs(lhsPx[j] - rhsPx[j]) > tolerance)
                    {
                        ++mismatches;
                        if (mismatches > maxMismatches)
                        {
                            return false;
                        }
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
