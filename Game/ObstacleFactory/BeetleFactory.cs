using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;

namespace Game.ObstacleFactory
{
    class BeetleFactory : ObstacleFactory
    {
        public BeetleFactory()
        {

        }

        Obstacle create()
        {
            Obstacle beetle = new Beetle();
            return beetle;
        }

    }
}
