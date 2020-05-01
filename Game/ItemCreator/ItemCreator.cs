using Game.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.ItemCreatorFile
{
    
    class ItemCreator
    {
        ItemStrategies Strategy;
        Player User;
        int Speed;
        public ItemCreator(Player U, int speed)
        {
            User = U;
            Speed = speed;
        }
        public Item SpawnRandom(Levels level)
        {
            switch (level)
            {
                case Levels.one:
                    Strategy = new StratOne(User, Speed);
                    break;
                case Levels.two:
                    Strategy = new StratTwo(User, Speed);
                    break;
                case Levels.three:
                    Strategy = new StratThree(User, Speed);
                    break;
                case Levels.four:
                    Strategy = new StratFour(User, Speed);
                    break;
                default:
                    Strategy = new StratOne(User, Speed);
                    break;
            }

            return Strategy.Spawn();
        }
    }
}
