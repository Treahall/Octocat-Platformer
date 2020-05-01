using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.HelperClasses;
using Point = System.Drawing.Point;

namespace Game.Entities
{
    class Slug : Obstacle
    {
        public Slug(Player U, int speed) : base(U, speed)
        {
            //Initial position
            Position = new Point(1440, EntityAnimations.Floor - GetSpriteSize().Height); //Magic numbers for start pos.
        }

        public override void LoadAnimations()
        {
            CurrentAnimation = EntityAnimations.Slug;
        }

        public override void CollisionEvents()
        {
            User.dead = true;
        }
    }
}
