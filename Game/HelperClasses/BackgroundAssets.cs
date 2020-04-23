using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Brushes = System.Drawing.Brushes;
using Point = System.Drawing.Point;
using Size = System.Windows.Size;

namespace Game.HelperClasses
{
    public static class BackgroundAssets
    {
        public static string Start_Screen = "../../VisualAssets/Backgrounds/Start Screen.jpg";
        public static string Running_Background = "../../VisualAssets/Backgrounds/Blank_Background.png";
        public static string Clouds = "../../VisualAssets/Backgrounds/Clouds.png";
        public static string Foreground = "../../VisualAssets/Backgrounds/Foreground.png";
        public static string Store = "../../VisualAssets/Backgrounds/Store1.png";
        public static string High_Scores = "../../VisualAssets/Backgrounds/HighScores.png";
        public static string GameOver = "../../VisualAssets/Backgrounds/GameOver.png";


        public static readonly List<string> OctocatRed = new List<string>
        {
            ""
        };

        public static readonly List<string> OctocatBlue = new List<string>
        {
            ""
        };

        public static readonly List<string> OctocatGreen = new List<string>
        {
            ""
        };


        private static void writeTextToBitmap(WriteableBitmap bm, string text, Point point)
        {
            Font font = new Font("Times New Roman", 34);

            Bitmap bmap;
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create((BitmapSource)bm));
                enc.Save(outStream);
                bmap = new System.Drawing.Bitmap(outStream);
            }

            using (Graphics g = Graphics.FromImage(bmap))
            {
                g.DrawString(text, font, Brushes.Black, point);
                IntPtr hBmap = bmap.GetHbitmap();

                try
                {
                    BitmapSource Bsource = Imaging.CreateBitmapSourceFromHBitmap(hBmap, IntPtr.Zero,
                        Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
                    WriteableBitmap NewBmap = new WriteableBitmap(Bsource);

                    bm.Blit(new System.Windows.Point(point.X, point.Y), NewBmap, new Rect(new Size((double)NewBmap.PixelWidth,
                        (double)NewBmap.PixelHeight)), Colors.White, WriteableBitmapExtensions.BlendMode.Alpha);
                }
            }

            
        }

    }
}
