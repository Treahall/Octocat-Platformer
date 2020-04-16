using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.HelperClasses
{
    class EntityAnimations
    {
        public static string OctocatRun = "../../VisualAssets/Entities/Player/Octocat Running!.png";

        public static string OctocatJump = "../../VisualAssets/Entities/Player/Octocat Jumping!.png";

        public static string OctocatFalling = "../../VisualAssets/Entities/Player/Octocat Falling 2.png";

        public static string OctocatDuck = "../../VisualAssets/Entities/Player/Octocat Ducking!.png";

        public static readonly List<string> Beetle = new List<string>
        {
            "../../VisualAssets/Entities/Obstacles/Bug Pose 1.png",
            "../../VisualAssets/Entities/Obstacles/Bug Pose 2.png",
            "../../VisualAssets/Entities/Obstacles/Bug Pose 3.png",
            "../../VisualAssets/Entities/Obstacles/Bug Pose 4.png"
        };

        public static readonly List<string> BrokenWindow = new List<string>
        {
            ""
        };

        public static readonly List<string> Slug = new List<string>
        {
            ""
        };
    }
}
