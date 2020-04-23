using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Point = System.Drawing.Point;

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


        private static WriteableBitmap GetTextBitmap(string text, double fontSize, Color color, double opacity)
        {
            TextBlock txt = new TextBlock();
            txt.Text = text;
            txt.FontSize = fontSize;
            txt.Foreground = new SolidColorBrush(color);
            txt.Opacity = opacity;

            

            WriteableBitmap bitmap = new WriteableBitmap((int)txt.ActualWidth, (int)txt.ActualHeight);
            bitmap.Render(txt, null);
            bitmap.Invalidate();

            return bitmap;
        }

    }
}
