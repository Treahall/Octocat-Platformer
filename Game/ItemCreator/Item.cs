using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.ItemCreatorFile
{
    abstract class Item : Obstacle
    {
        public Item(Player U, int speed) : base(U, speed)
        {

        }

        public bool PickedUp;

        public override abstract void CollisionEvents();

        public override abstract void LoadAnimations();

        public void Update()
        {
            PickedUp = false;
        }
    }
}
