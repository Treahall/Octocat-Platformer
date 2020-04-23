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

        }

        public override void LoadAnimations()
        {
            CurrentAnimation = HelperClasses.ItemAnimations.EnergyDrink;
        }
    }
}
