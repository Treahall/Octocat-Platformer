using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ItemCreatorFile
{
    class StratOne : ItemStrategies
    {
        public StratOne(Player U, int speed) : base(U, speed)
        {

        }
        public override Item Spawn()
        {
            int num = rand.Next(2);
            ItemType = (ItemEnum)num;

            //returns the object needed
            return Create(ItemType);
        }
    }
}
