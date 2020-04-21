using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Windows.Media.Imaging.WriteableBitmapExtensions;
using Point = System.Drawing.Point;


namespace Game.Entities
{
    class Beetle : Obstacle
    {
        public Beetle(Player U, int speed) : base(U, speed)
        {
            //Initial position
            Position = new Point(1440, 420); //Magic numbers for start pos.

            //Custom Initial velocity?
            
        }

        public override void LoadAnimations()
        {
            CurrentAnimation = HelperClasses.EntityAnimations.Beetle;
        }

        public override void CollisionEvents()
        {
            User.dead = true;
        }
    }
}
