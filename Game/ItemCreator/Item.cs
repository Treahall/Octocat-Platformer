using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using Game.HelperClasses;

namespace Game.ItemCreatorFile
{
    abstract class Item : Obstacle
    {
        public Item(Player U, int speed) : base(U, speed)
        {
            Position = new Point(1440, EntityAnimations.Floor - GetSpriteSize().Height);
            PickedUp = false;
        }

        public bool PickedUp;

        public override abstract void CollisionEvents();

        public override abstract void LoadAnimations();

    }
}
