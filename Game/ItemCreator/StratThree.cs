using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ItemCreatorFile
{
    class StratThree : ItemStrategies
    {
        public StratThree(Player U, int speed) : base(U, speed)
        {

        }
        public override Item Spawn()
        {
            int num = rand.Next(4);
            ItemType = (ItemEnum)num;

            //returns the object needed
            return Create(ItemType);
        }
    }
}
