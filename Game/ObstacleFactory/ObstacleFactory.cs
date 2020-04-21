using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Entities;
using System.Windows.Threading;

namespace Game.ObstacleFactory
{
    abstract class ObstacleFactory
    {
        //Used for collision events with the user.
        protected Player User;

        //Enforces the parameter that is stored into user.
        public ObstacleFactory(Player U)
        {
            User = U;
        }
        //Subclasses create specified obstacle.
        public abstract Obstacle Create();
    }
}
