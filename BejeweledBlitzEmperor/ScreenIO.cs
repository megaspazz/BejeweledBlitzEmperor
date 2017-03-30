using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public static int BOX_SIZE = 40;
        public static int BOARD_DIM = 8;

        public static int[] CLR_WHITE = { 255, 255, 255 };
        public static int[] CLR_FLASH_CORNER = { 57, 21, 80 };

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
            return WindowWrapper.ScreenCapture(GetBoardRectangle());
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

                // WTF GG I GOT THIS WRONG THE WHOLE TIME!
                //return (px[0] << 16) | (px[1] << 8) | px[0];
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
                                    return new Point(x, y);
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
