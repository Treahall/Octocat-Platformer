using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Game.HelperClasses
{
    public static class BackgroundAssets
    {
        //TO DO: figure out floor position and background position and size
        /*public static Size BackgroundSize = new Size(787, 600);
          public static Point FloorPos = new Point(0, 600 - 98);
          public static Point BackgroundPos = new Point(0, 0);*/

        public static string Blank_Background = "../../VisualAssets/Backgrounds/Blank_Background.png";
        public static string Clouds = "../../VisualAssets/Backgrounds/Clouds.png";
        public static string Foreground = "../../VisualAssets/Backgrounds/Foreground.png";

        public static List<string> Background = new List<string>
        {
            ""
        };

        public static readonly List<string> MainMenu = new List<string>
        {
            ""
        };

        public static readonly List<string> Store = new List<string>
        {
            ""
        };

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
        public static Point Floor = new Point(0, 600 - 98);


    }
}
