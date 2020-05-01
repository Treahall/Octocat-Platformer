using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.ItemCreatorFile
{
    class Magnet : Item
    {
        public Magnet(Player U, int speed) : base(U, speed)
        {

        }
        public override void CollisionEvents()
        {
            PickedUp = true;
            User.ItemsOwned[1] += 1;
        }

        public override void LoadAnimations()
        {
            CurrentAnimation = HelperClasses.ItemAnimations.Magnet;
        }
    }
}
