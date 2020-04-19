using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using System.Windows.Threading;

namespace Game.ObstacleFactory
{
    class ObstacleFactory
    {
        Obstacle obstacle;
        public ObstacleFactory(Random r)
        {
            int rand = r.Next();
            /*if (rand % 3 == 2)
            {*/
                BeetleFactory beetleFactory = new BeetleFactory(r);
                obstacle = beetleFactory.create();
            /*}
            else if (rand % 3 == 1)
            {
                SlugFactory slugFactory = new SlugFactory(r);
                obstacle = slugFactory.create();
            }
            else
            {
                WindowFactory windowFactory = new WindowFactory(r);
                obstacle = windowFactory.create();
            }*/
        }

        public Obstacle create()
        {
            return obstacle;
        }
    }
}
