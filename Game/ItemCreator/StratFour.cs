using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ItemCreatorFile
{
    class StratFour : ItemStrategies
    {
        public StratFour(Player U, int speed) : base(U, speed)
        {

        }
        public override Item Spawn()
        {
            int num = rand.Next(5);
            ItemType = (ItemEnum)num;

            //returns the object needed
            return Create(ItemType);
        }
    }
}
