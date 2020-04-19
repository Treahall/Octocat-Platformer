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
        Obstacle beetle;
        public BeetleFactory(Random r) : base(r)
        {
            beetle = new Beetle();
        }

        Obstacle create()
        {
            return beetle;
        }

    }
}
