using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Game.HelperClasses
{
    public static class BackgroundAssets
    {
        public static string Start_Screen = "../../VisualAssets/Backgrounds/Start Screen.jpg";
        public static string Running_Background = "../../VisualAssets/Backgrounds/Blank_Background.png";
        public static string Clouds = "../../VisualAssets/Backgrounds/Clouds.png";
        public static string Foreground = "../../VisualAssets/Backgrounds/Foreground.png";
        public static string Store = "";


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

        //The Y axis value of the floor
        public static float Floor = 470;
        public static Vector2 startPos = new Vector2(1440/8, Floor);


    }
}
