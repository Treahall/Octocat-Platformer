using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ItemCreatorFile
{
    enum ItemEnum
    {
        Coffee,
        EnergyDrink,
        Magnet,
        Shield,
        NyanCat
    }
    abstract class ItemStrategies
    {
        Player User;
        int Speed;
        public Random rand;
        public ItemEnum ItemType;
        public ItemStrategies(Player U, int speed)
        {
            User = U;
            Speed = speed;
            rand = new Random();
        }

        public Item Create(ItemEnum I)
        {
            Item item = new Coffee(User, Speed);
            switch (I)
            {
                case ItemEnum.Coffee:
                    item = new Coffee(User, Speed);
                    break;
                case ItemEnum.EnergyDrink:
                    item = new EnergyDrink(User, Speed);
                    break;
                case ItemEnum.Magnet:
                    item = new Magnet(User, Speed);
                    break;
                case ItemEnum.Shield:
                    item = new Shield(User, Speed);
                    break;
                case ItemEnum.NyanCat:
                    item = new NyanCat(User, Speed);
                    break;
                default:
                    break;
            }

            return item;

        }
        public abstract Item Spawn();
    }
}
