using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.ItemCreatorFile
{
    class EnergyDrink : Item
    {
        public EnergyDrink(Player U, int speed) : base(U, speed)
        {

        }
        public override void CollisionEvents()
        {
            PickedUp = true;
            User.ItemsOwned[3] += 3;

        }

        public override void LoadAnimations()
        {
            CurrentAnimation = HelperClasses.ItemAnimations.EnergyDrink;
        }
    }
}
