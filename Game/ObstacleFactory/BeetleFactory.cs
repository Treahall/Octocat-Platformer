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
        public BeetleFactory(Player U) : base(U) { }

        //Creates a new beetle
        public override Obstacle Create()
        {
            return new Beetle(User);
        }

    }
}
