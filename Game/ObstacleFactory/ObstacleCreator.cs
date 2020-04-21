using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using System.Windows.Threading;


namespace Game.ObstacleFactory
{
    enum OTypes
    {
        Slug,
        Beetle,
        BrokenWindow
    }
    class ObstacleCreator
    {
        Player User;
        OTypes Type;
        ObstacleFactory OFactory;
        Random rand;

        public ObstacleCreator(Player U)
        {
            rand = new Random();
            User = U;

            //Gives a value to avoid null errors.
            OFactory = new SlugFactory(U);
        }
//=============================================================================================
        //Returns the obstacle that corresponds with T.
        Obstacle Create(OTypes T)
        {
            switch (T)
            {
                case OTypes.Slug:
                    OFactory = new SlugFactory(User);
                    break;
                case OTypes.Beetle:
                    OFactory = new BeetleFactory(User);
                    break;
                case OTypes.BrokenWindow:
                    OFactory = new WindowFactory(User);
                    break;
                default:
                    break;
            }
            return OFactory.Create();
        }

        //Feeds a random OType to Create() resulting in a random obstacle.
        Obstacle getRandom()
        {
            //gets a random number in range of the enum OTypes.
            int num = rand.Next(Enum.GetNames(typeof(OTypes)).Length);
            Type = (OTypes)num;

            //returns the object needed
            return Create(Type);
        }
    }
}
