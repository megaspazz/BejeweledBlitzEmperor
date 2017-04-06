using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;
using Cursor = System.Windows.Forms.Cursor;

using MessageBox = System.Windows.MessageBox;

using System.Threading;
using System.IO;

namespace BejeweledBlitzEmperor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetBoard_Click(object sender, RoutedEventArgs e)
        {
            Bitmap bmp = ScreenIO.GetBoardBitmap();
            bmp.Save(@"board.bmp");

            GemBoard board = ScreenIO.GetBoard();
        }

        private void btnGetBoardFromPause_Click(object sender, RoutedEventArgs e)
        {
            ScreenIO.ClickRelativeToBoard(ScreenIO.OFF_RESUME);
            Thread.Sleep(500);

            Bitmap bmp = ScreenIO.GetBoardBitmap();
            bmp.Save(@"board.bmp");

            GemBoard board = ScreenIO.GetBoard();

            ScreenIO.ClickRelativeToBoard(ScreenIO.OFF_MENU);

            Process.Start(@"board.bmp");
        }
        
        private void btnSpeedTest_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch sw = new Stopwatch();

            sw.Restart();
            Bitmap bmp = ScreenIO.GetBoardBitmap();
            sw.Stop();
            Console.WriteLine("big SS = {0} ms, bigPx = {1}", sw.ElapsedMilliseconds, bmp.Width * bmp.Height);
            
            int smPx = 0;
            sw.Restart();
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    foreach (Point offset in ScreenIO.PTS_READ)
                    {
                        Bitmap test = WindowWrapper.ScreenCapture(new Rectangle(ScreenIO.PT_BOARD.X + i * 40 + 20 + offset.X, ScreenIO.PT_BOARD.Y + j * 40 + 20 + offset.Y, 1, 1));
                        smPx += test.Width * test.Height;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("small SS = {0} ms, smPx = {1}", sw.ElapsedMilliseconds, smPx);

            int medPx = 0;
            sw.Restart();
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    Bitmap tmp = WindowWrapper.ScreenCapture(new Rectangle(ScreenIO.PT_BOARD.X + i * 40 + 20 - 5, ScreenIO.PT_BOARD.Y + j * 40 + 20 - 4, 10, 9));
                    medPx += tmp.Width * tmp.Height;
                }
            }
            sw.Stop();
            Console.WriteLine("med SS = {0} ms, medPx = {1}", sw.ElapsedMilliseconds, medPx);
        }

        private void btnRecordSquare_Click(object sender, RoutedEventArgs e)
        {
            string[] result = InputBox.Show("gridX", "gridY", "duration [ms]", "gem color", "gem type");
            if (result != null)
            {
                int gridX, gridY, duration;
                if (int.TryParse(result[0], out gridX) && int.TryParse(result[1], out gridY))
                {
                    int.TryParse(result[2], out duration);
                    HashSet<Signature> sigs = new HashSet<Signature>();
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    do
                    {
                        using (Bitmap bmp = ScreenIO.GetBoxBitmap(gridX, gridY))
                        {
                            using (Bitmap24 bmp24 = Bitmap24.FromImage(bmp))
                            {
                                sigs.Add(ScreenIO.GetSignature(bmp24, 0, 0));
                            }
                        }
                    } while (sw.ElapsedMilliseconds < duration);

                    StringBuilder sb = new StringBuilder();
                    foreach (Signature sig in sigs)
                    {
                        sb.AppendFormat("AddSignature(new int[] {{ {0} }}, Gem.Get(GemColor.{1}, GemType.{2}));\r\n", string.Join(", ", sig.Sig), result[3], result[4]);
                    }
                    Console.Write(sb.ToString());
                }
            }
        }

        private void btnRecordSquareFromPause_Click(object sender, RoutedEventArgs e)
        {
            string[] result = InputBox.Show("gridX", "gridY", "duration [ms]", "gem color", "gem type");
            if (result != null)
            {
                int gridX, gridY, duration;
                if (int.TryParse(result[0], out gridX) && int.TryParse(result[1], out gridY))
                {
                    ScreenIO.ClickRelativeToBoard(ScreenIO.OFF_RESUME);
                    Thread.Sleep(500);

                    int.TryParse(result[2], out duration);
                    HashSet<Signature> sigs = new HashSet<Signature>();
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    do
                    {
                        using (Bitmap bmp = ScreenIO.GetBoxBitmap(gridX, gridY))
                        {
                            using (Bitmap24 bmp24 = Bitmap24.FromImage(bmp))
                            {
                                sigs.Add(ScreenIO.GetSignature(bmp24, 0, 0));
                            }
                        }
                    } while (sw.ElapsedMilliseconds < duration);

                    ScreenIO.ClickRelativeToBoard(ScreenIO.OFF_MENU);

                    StringBuilder sb = new StringBuilder();
                    foreach (Signature sig in sigs)
                    {
                        sb.AppendFormat("AddSignature(new int[] {{ {0} }}, GemColor.{1}, GemType.{2});\r\n", string.Join(", ", sig.Sig), result[3], result[4]);
                    }
                    Console.Write(sb.ToString());
                    File.WriteAllText(@"record.txt", sb.ToString());
                    Process.Start(@"record.txt");
                }
            }
        }

        private void btnGetMoves_Click(object sender, RoutedEventArgs e)
        {
            using (Bitmap bmp = ScreenIO.GetBoardBitmap())
            {
                bmp.Save(@"board.bmp");
            }

            GemBoard board = ScreenIO.GetBoard();
            Move[] moves = board.GetMoves();
        }

        private static readonly Random RNG = new Random();
        private void btnSimulateOneMove_Click(object sender, RoutedEventArgs e)
        {
            GemBoard board = ScreenIO.GetBoard();
            Move[] moves = board.GetMoves();

            if (moves.Length > 0)
            {
                Point prev = System.Windows.Forms.Cursor.Position;
                ScreenIO.MakeMove(moves[RNG.Next(moves.Length)]);
                System.Windows.Forms.Cursor.Position = prev;
            }
        }

        private GameBot _bot = new RandomBot();
        private void btnRunTimedAsync_Click(object sender, RoutedEventArgs e)
        {
            if (_bot.Running)
            {
                MessageBox.Show("Error!  The bot is still running.  Please stop it or wait for it to finish.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            string[] result = InputBox.Show("time [ms]");
            if (result != null)
            {
                int time;
                if (int.TryParse(result[0], out time))
                {
                    _bot.RunTimedAsync(time);
                }
            }
        }

        private void btnStopAsync_Click(object sender, RoutedEventArgs e)
        {
            _bot.StopAsync();
        }

        private void btnGetHandleAndRect_Click(object sender, RoutedEventArgs e)
        {
            IntPtr handle = WindowWrapper.GetHandleFromCursor();
            string name = WindowWrapper.GetText(handle);
            Rectangle rect = WindowWrapper.GetClientArea(handle);
            this.btnGetHandleAndRect.Content = string.Format("Handle: {0}, Name: {1}, Rect: {2}", handle, name, rect);
        }

        private void btnAutoDetectGamePos_Click(object sender, RoutedEventArgs e)
        {
            if (ScreenIO.AutoSetBoardPoint())
            {
                // Note that even though this may succeed, it may fail if it is able to detect the top corner pixel color somewhere else, like if there was another instance of the game open.
                Point pt = ScreenIO.GetGameTopLeft();
                string msg = string.Format("The position of the flash game has been automatically set at ({0}, {1}).", pt.X, pt.Y);
                MessageBox.Show(msg, "Auto Detect", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Unable to automatically detect the position of the flash game.  Please make sure that the game has fully loaded and that the entire flash game is visible on your screen.", "Auto Detect", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnGetScreenCheck_Click(object sender, RoutedEventArgs e)
        {
            Point tl = ScreenIO.GetGameTopLeft();
            Point pt = System.Windows.Forms.Cursor.Position;
            using (Bitmap bmp = ScreenIO.GetGameBitmap())
            {
                using (Bitmap24 bmp24 = Bitmap24.FromImage(bmp))
                {
                    bmp24.Lock();
                    int x = pt.X - tl.X;
                    int y = pt.Y - tl.Y;
                    int[] px = bmp24.GetPixel(x, y);
                    Console.WriteLine("new PixelCheck(new Point({0}, {1}), new int[] {{ {2}, {3}, {4} }})", x, y, px[0], px[1], px[2]);
                }
            }
        }

        private void btnGetScreenCheckImage_Click(object sender, RoutedEventArgs e)
        {
            string[] result = InputBox.Show("image file name", "top left X", "top left Y", "point X", "point Y");
            if (result == null)
            {
                return;
            }

            if (!File.Exists(result[0]))
            {
                MessageBox.Show("Specified image file does not exist.", "Auto Detect", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            int tlX, tlY, ptX, ptY;
            if (!int.TryParse(result[1], out tlX) || !int.TryParse(result[2], out tlY) || !int.TryParse(result[3], out ptX) || !int.TryParse(result[4], out ptY))
            {
                MessageBox.Show("Error parsing coordinates!", "Auto Detect", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            using (Bitmap bmp = new Bitmap(result[0]))
            {
                using (Bitmap24 bmp24 = Bitmap24.FromImage(bmp))
                {
                    bmp24.Lock();
                    int x = ptX - tlX;
                    int y = ptY - tlY;
                    int[] px = bmp24.GetPixel(ptX, ptY);
                    Console.WriteLine("new PixelCheck(new Point({0}, {1}), new int[] {{ {2}, {3}, {4} }})", x, y, px[0], px[1], px[2]);
                }
            }
        }

        private void btnGetGameScreenPoint_Click(object sender, RoutedEventArgs e)
        {
            Point tl = ScreenIO.GetGameTopLeft();
            Point pt = System.Windows.Forms.Cursor.Position;
            MessageBox.Show(string.Format("Relative to top-left of flash game window:\n\n({0}, {1})", pt.X - tl.X, pt.Y - tl.Y), "Game Screen Point");
        }

        private void btnExecuteAllStates_Click(object sender, RoutedEventArgs e)
        {
            ScreenIO.ExecuteAllStatesAsync();
        }

        private Bot _driver = new FirstStateDriverBot();
        private void btnRunForeverAsync_Click(object sender, RoutedEventArgs e)
        {
            if (_driver.Running)
            {
                MessageBox.Show("Error!  The driver is still running.  Please stop it or wait for it to finish.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            _driver.RunTimedAsync(int.MaxValue);
        }

        private void btnStopForeverAsync_Click(object sender, RoutedEventArgs e)
        {
            _driver.StopAsync();
        }
    }
}
