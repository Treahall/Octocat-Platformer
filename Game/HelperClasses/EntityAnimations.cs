using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = System.Drawing.Point;

namespace Game.HelperClasses
{
    class EntityAnimations
    {
        //The Y axis value of the floor.
        public static int Floor = 470;
        public static Point PlayerStartPos = new Point(180, Floor);

        public static readonly List<string> OctocatJump = new List<string>
        {
            "../../VisualAssets/Entities/Player/Octocat Jumping!.png"
        };

        public static readonly List<string> OctocatFalling = new List<string>
        {
            "../../VisualAssets/Entities/Player/Octocat Falling!.png"
        };

        public static readonly List<string> OctocatDuck = new List<string>
        {
            "../../VisualAssets/Entities/Player/Octocat Duck 1.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 1.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 1.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 2.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 2.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 3.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 4.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 3.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 2.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 2.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 1.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 1.png",
            "../../VisualAssets/Entities/Player/Octocat Duck 1.png"
        };

        public static readonly List<string> OctocatRun = new List<string>
        {
            "../../VisualAssets/Entities/Player/Octocat Running!.png",
            "../../VisualAssets/Entities/Player/Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/Octocat Running!.png",
            "../../VisualAssets/Entities/Player/Octocat Legs Forward.png",
            "../../VisualAssets/Entities/Player/Octocat Running!.png"
        };

        public static readonly List<string> Beetle = new List<string>
        {
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 1.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 2.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 3.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 4.png"
        };

        public static readonly List<string> BrokenWindow = new List<string>
        {
            "../../VisualAssets/Entities/Obstacles/BrokenWindow/Larger broken window.png"
        };

        public static readonly List<string> Slug = new List<string>
        {
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 1.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 2.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 3.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 4.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 5.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 6.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 7.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 8.png"
        };
    }
}
