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
        public static int Floor = 777;
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
            "../../VisualAssets/Entities/Player/Octocat Running!.png",
            "../../VisualAssets/Entities/Player/Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/Octocat Running!.png",
            "../../VisualAssets/Entities/Player/Octocat Legs Forward.png",
            "../../VisualAssets/Entities/Player/Octocat Legs Forward.png",
            "../../VisualAssets/Entities/Player/Octocat Running!.png"
        };

        public static readonly List<string> Beetle = new List<string>
        {
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 1.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 1.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 2.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 2.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 3.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 3.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 4.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 4.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 4.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 3.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 3.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 2.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 2.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 1.png",
            "../../VisualAssets/Entities/Obstacles/Bug/Bug Pose 1.png"
        };

        public static readonly List<string> BrokenWindow = new List<string>
        {
            "../../VisualAssets/Entities/Obstacles/BrokenWindow/Larger broken window.png"
        };

        public static readonly List<string> Slug = new List<string>
        {
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 1.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 1.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 2.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 2.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 3.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 3.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 4.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 4.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 5.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 5.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 6.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 6.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 7.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 7.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 8.png",
            "../../VisualAssets/Entities/Obstacles/Snail/Snail 8.png"
        };

        public static readonly List<string> MagnetRun = new List<string>
        {
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Legs Middle.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Legs Middle.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Legs Middle.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Legs Front.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Legs Front.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Legs Middle.png"
        };

        public static readonly List<string> MagnetDuck = new List<string>
        {
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck2.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck2.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck3.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck4.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck3.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck2.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck2.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Duck1.png"
        };

        public static readonly List<string> MagnetJump = new List<string>
        {
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Jump.png"
        };

        public static readonly List<string> MagnetFall = new List<string>
        {
            "../../VisualAssets/Entities/Player/PlayerWithItems/Magnet/Magnet Octocat Fall.png"
        };

        public static readonly List<string> ShieldRun = new List<string>
        {
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Legs Middle.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Legs Middle.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Legs Backward.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Legs Middle.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Legs Forward.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Legs Forward.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Legs Middle.png"
        };

        public static readonly List<string> ShieldDuck = new List<string>
        {
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck2.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck2.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck3.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck4.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck3.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck2.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck2.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck1.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield/Shield Octocat Duck1.png"
        };

        public static readonly List<string> ShieldJump = new List<string>
        {
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield Octocat Jump.png"
        };

        public static readonly List<string> ShieldFall = new List<string>
        {
            "../../VisualAssets/Entities/Player/PlayerWithItems/Shield Octocat Fall.png"
        };

        public static readonly List<string> NyanRun = new List<string>
        {
            "../../VisualAssets/Entities/Player/PlayerWithItems/Octocat Nyan Cat.png",
            "../../VisualAssets/Entities/Player/PlayerWithItems/Octocat Nyan Cat2.png"
        };
    }
}
